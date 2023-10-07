using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Soft.Services.Contracts;
using Soft.Shared.Utility;

namespace Soft.Forms
{
    public partial class AdminForm : Form
    {
        private readonly IUserService _userService;
        public AdminForm(IUserService userService)
        {
            InitializeComponent();
            this._userService = userService;
            loadData();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userFirstLast_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void loadData()
        {
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "FSHIJ";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.DefaultCellStyle.BackColor = Color.Red;
            deleteButton.DefaultCellStyle.ForeColor  = Color.Red;

            var list = await _userService.GetUsers();
            dataGrid.DataSource = list;
            dataGrid.Columns.Add(deleteButton);
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.CellClick += dataGrid_CellClick;

            var userFirstLAst = string.Concat(AppSession.GetClaim("FirstName")?.Value, " ", AppSession.GetClaim("LastName")?.Value);

            userFirstLast.Text = userFirstLAst;
        }

        private async void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var userId = (int)dataGrid.Rows[e.RowIndex].Cells["Id"].Value;
                    await _userService.DeleteUser(userId);  

                   

                    loadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var register = Program.ServiceProvider.GetRequiredService<RegisterForm>();
           // this.Hide();
            register.ShowDialog();
            loadData();
        }

        private void logout(object sender, EventArgs e)
        {        
            this.Hide();

            AppSession.JwtToken = null;
            AppSession.Claims = null;

            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();
        }
    }
}
