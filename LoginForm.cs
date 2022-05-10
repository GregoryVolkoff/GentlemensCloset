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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (roleComboBox.SelectedIndex > -1)
                {
                    if (roleComboBox.SelectedItem.ToString() == "ADMIN")
                    {
                        if (usernameTextBox.Text == "Admin" && passwordTextBox.Text == "Admin123")
                        {
                            CategoryForm category = new CategoryForm();
                            category.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Si eres Admin, introduce nombre de usuario y contraseña correctos", "Id incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                       
                    }
                }
                else
                {
                    MessageBox.Show("Elige un rol", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
