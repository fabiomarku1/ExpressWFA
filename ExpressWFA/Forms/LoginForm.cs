using System;
using System.Windows.Forms;
using ExpressWFA.Models;
using ExpressWFA.Services;
using ExpressWFA.Shared.Utility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpressWFA.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authenticationService;
        public LoginForm()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new LoginUserDTO
                {
                    UserName = username.Text,
                    Password = password.Text,
                };

                StartLoading();
                var isLogged = await _authenticationService.Login(request);

                var role = JwtHelper.GetClaim("role");

                if (isLogged && role.Contains("User")) //user
                {
                    var userForm = new UserForm();
                    this.Hide();
                    userForm.ShowDialog();

                }
                else if (isLogged && role.Contains("Admin")) //admin
                {
                    var adminForm = new AdminForm();
                    this.Hide();
                    adminForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }

                StopLoading();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StopLoading();

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
    }
}
