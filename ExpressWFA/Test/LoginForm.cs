using Microsoft.Extensions.DependencyInjection;
using Soft.Services.Contracts;
using Soft.Shared.DTO;
using Soft.Shared.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;

        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var request = new LoginUserDTO
            {
                UserName = username.Text, Password = password.Text,
            };

            var isLogged = await _userService.Login(request);

            var roleId = AppSession.GetClaim("RoleId")?.Value;

            if (isLogged && roleId.Contains("1"))//user
            {
                var userForm=new UserForm();

                this.Hide();

                userForm.ShowDialog();

            }
            else if (isLogged && roleId.Contains("2"))//admin
            {
                var adminForm = Program.ServiceProvider.GetRequiredService<AdminForm>();
                this.Hide();
                adminForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid credentials!");

            }
        }
    }
}
