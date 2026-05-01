using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porject.PL
{
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void loginbotton_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            User currentUser = datalogin.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (currentUser != null)
            {
                FRM_MIAN home = new FRM_MIAN(currentUser);
                home.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed ❌");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
