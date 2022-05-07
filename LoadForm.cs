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
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }
        private void LoadForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startTimer = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startTimer += 2;
            loadingProgressBar.Value = startTimer;
            if (loadingProgressBar.Value == 100)
            {
                loadingProgressBar.Value = 0;
                timer1.Stop();
                FormLogin loginForm = new FormLogin();
                this.Hide();
                loginForm.Show();
            }
        }

        
    }
}
