using System;
using System.Windows.Forms;
using ExpressWFA.Models;
using ExpressWFA.Services;
using ExpressWFA.Shared.Types;

namespace ExpressWFA.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;
        public RegisterForm()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // validate inputs
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
                    MartialStatus =(MartialStatus)martialStatusList.SelectedItem,
                    Username = username.Text,
                    Password = password.Text
                };

                await _userService.CreateUser(user);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  //suppress 
            }
        }

        private void FieldsChanged(object sender, EventArgs e)
        {
            button1.Enabled = AreAllFieldsCompleted();
        }

        private bool AreAllFieldsCompleted()
        {
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
