using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GentlemensCloset
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearLabel_MouseEnter(object sender, EventArgs e)
        {
            clearLabel.ForeColor = Color.Red;
        }

        private void clearLabel_MouseLeave(object sender, EventArgs e)
        {
            clearLabel.ForeColor = Color.RoyalBlue;
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
