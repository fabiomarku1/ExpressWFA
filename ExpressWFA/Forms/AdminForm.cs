using System;
using System.Drawing;
using System.Windows.Forms;
using ExpressWFA.Services;
using ExpressWFA.Shared.Utility;

namespace ExpressWFA.Forms
{
    public partial class AdminForm : Form
    {
        private readonly UserService _userService; 
        public AdminForm( )
        {
            InitializeComponent();
           _userService=new UserService();
           loadInitialData();
        }

        private async void refreshData()
        {
            var list = await _userService.GetUsers();
            dataGrid.DataSource = list;
        }
        private async void loadInitialData()
        {
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "FSHIJ";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.DefaultCellStyle.BackColor = Color.Red;
            deleteButton.DefaultCellStyle.ForeColor = Color.Red;

            StartLoading();
            var list = await _userService.GetUsers();
            StopLoading();


            dataGrid.DataSource = list;
            dataGrid.ReadOnly = true;
            dataGrid.Columns.Add(deleteButton);
            dataGrid.Columns["Id"].Visible = false;

            var userFirstLAst = string.Concat(JwtHelper.GetClaim("FirstName"), " ", JwtHelper.GetClaim("LastName"));

            userFirstLast.Text = userFirstLAst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var register = new RegisterForm();
            register.ShowDialog();
            refreshData();
        }

        private void logout(object sender, EventArgs e)
        {
            this.Hide();

            AppSession.AccessToken = null;
            AppSession.RefreshToken = null;

            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private async void openEditUser(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGrid.Rows[e.RowIndex];
                int userId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var userForm = new EditUserForm(userId);
                userForm.ShowDialog();
                refreshData();
            }
        }

        private async void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var userId = (int)dataGrid.Rows[e.RowIndex].Cells["Id"].Value;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await _userService.DeleteUser(userId);
               //     dataGrid.Rows.RemoveAt(e.RowIndex);
                }
                refreshData();
            }
        }
        private void StartLoading()
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Visible = true;
        }

        private void StopLoading()
        {
            progressBar.Visible = false;
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var searchPatter=searchText.Text;

            try
            {
                var result = await _userService.GetUserByPattern(searchPatter);
                dataGrid.DataSource = result;
                resetTableButton.Visible = true;
                StopLoading();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                StopLoading();
            }
        }

        private void resetTableButton_Click(object sender, EventArgs e)
        {
            resetTableButton.Visible = false;
            searchText.Text="";
            refreshData();

        }
    }
}
