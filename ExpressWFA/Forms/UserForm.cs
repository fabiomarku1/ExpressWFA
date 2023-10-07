using System;
using System.Windows.Forms;
using ExpressWFA.Shared.Utility;

namespace ExpressWFA.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            var userFirstLAst =string.Concat(JwtHelper.GetClaim("FirstName")," ",JwtHelper.GetClaim("LastName"));

            userFirstLast.Text = userFirstLAst;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppSession.AccessToken = null;
            AppSession.RefreshToken = null;

            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
