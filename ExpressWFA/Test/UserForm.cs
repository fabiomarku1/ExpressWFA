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
using Soft.Shared.Utility;

namespace Soft.Forms
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
            var userFirstLAst =string.Concat(AppSession.GetClaim("FirstName")?.Value," ",AppSession.GetClaim("LastName")?.Value);

            userFirstLast.Text = userFirstLAst;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppSession.JwtToken = null;
            AppSession.Claims = null;

            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();
            this.Close();
        }
    }
}
