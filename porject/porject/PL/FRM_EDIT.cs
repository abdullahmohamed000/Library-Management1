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
    public partial class FRM_EDIT : Form
    {
        private FRM_MIAN parentForm;
        private string oldName;
        public FRM_EDIT(FRM_MIAN parentForm, string oldName)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.oldName = oldName;

            txtcategory.Text = oldName;
        }

        private void Lb_Title_Click(object sender, EventArgs e)
        {

        }

        private void FRM_EDIT_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = txtcategory.Text.Trim();
                if (newName == "")
                {
                    MessageBox.Show("اكتب اسم الصنف");
                    return;
                }
                parentForm.UpdateCategory(oldName, newName);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
