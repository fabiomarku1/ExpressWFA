using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soft.Entities.Models;
using Soft.Repository.Contracts;
using Soft.Services.Contracts;
using Soft.Shared.DTO;
using Soft.Shared.Utility;

namespace Soft.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IUserService _userService;
        public RegisterForm(IUserRepository userRepository, IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!AreAllFieldsCompleted())
                {
                    MessageBox.Show("Please complete all required fields.");
                    return;
                }

                string gender = null;
                if (maleRadio.Checked)
                {
                    gender = maleRadio.Text;
                }
                else if (femaleRadio.Checked)
                {
                    gender = femaleRadio.Text;
                }

                var user = new CreateUserDTO
                {
                    FirstName = firstNameBox.Text,
                    LastName = lastNameBox.Text,
                    Birthday = dirthdayPicker.Value,
                    Birthplace = birthPlaceBox.Text,
                    Gender = gender,
                    IsEmployed = isEmployedCheck.Checked,
                    PhoneNumber = phoneBox.Text,
                    MartialStatus = GetMartialStatus(),
                    Username = username.Text,
                    Password = password.Text
                };

                await _userService.CreateUser(user);

                var loggedForm = new UserForm();

                this.Hide();
                loggedForm.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private MartialStatus GetMartialStatus()
        {
            var status = martialStatusList.Text;

            if (status.ToLower().Contains("martuar"))
            {
                return MartialStatus.Married;
            }
            else if (status.ToLower().Contains("ndare"))
            {
                return MartialStatus.Divorced;
            }
            else if (status.ToLower().Contains("ve"))
            {
                return MartialStatus.Widow;
            }
            else if (status.ToLower().Contains("beqare"))
            {
                return MartialStatus.Single;
            }
            else
            {
                return 0;
            }

        }


        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is neither a number nor a control key (e.g., Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Suppress the keypress
            }
        }

        private void FieldsChanged(object sender, EventArgs e)
        {
            button1.Enabled = AreAllFieldsCompleted();
        }

        private bool AreAllFieldsCompleted()
        {
            // Check TextBox controls
            if (string.IsNullOrWhiteSpace(firstNameBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameBox.Text) ||
                string.IsNullOrWhiteSpace(phoneBox.Text) ||
                string.IsNullOrWhiteSpace(birthPlaceBox.Text) ||
                string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(password.Text))
            {
                return false;
            }

            if (!maleRadio.Checked && !femaleRadio.Checked)
            {
                return false;
            }

            if (martialStatusList.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {
            phoneBox.KeyPress += PhoneBox_KeyPress;
        }
    }
}
