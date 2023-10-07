using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpressWFA.Models;
using ExpressWFA.Services;
using ExpressWFA.Shared.Types;

namespace ExpressWFA.Forms
{
    public partial class EditUserForm : Form
    {
        private readonly UserService _userService;
        private readonly int _userId;
        public EditUserForm(int userId)
        {
            _userService = new UserService();
            LoadDetails(userId);
            InitializeComponent();
            _userId = userId;

        }

        private async Task LoadDetails(int userId)
        {
            var details = await _userService.GetUserDetails(userId);

            firstNameBox.Text=details.FirstName;
            lastNameBox.Text=details.LastName;
            dirthdayPicker.Value = details.Birthday;
            isEmployedCheck.Checked = details.IsEmployed.Value;
            birthPlaceBox.Text=details.Birthplace;
            martialStatusList.SelectedIndex = martialStatusList.Items.IndexOf(details.MartialStatus);
            phoneBox.Text = details.PhoneNumber;
            maleRadio.Checked = details.Gender.ToLower().Equals("male") ? true : false;
            femaleRadio.Checked = details.Gender.ToLower().Contains("f") ? true : false;

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

                var body = new UpdateUserDTO
                {
                    FirstName = firstNameBox.Text,
                    LastName = lastNameBox.Text,
                    Birthday = dirthdayPicker.Value,
                    Birthplace = birthPlaceBox.Text,
                    Gender = gender,
                    IsEmployed = isEmployedCheck.Checked,
                    PhoneNumber = phoneBox.Text,
                    MartialStatus = (MartialStatus)martialStatusList.SelectedItem,
                };

                await _userService.UpdateUser(_userId, body);
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
                e.Handled = true;
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
                string.IsNullOrWhiteSpace(birthPlaceBox.Text) )
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
