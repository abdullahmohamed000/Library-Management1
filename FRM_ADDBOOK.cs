using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace porject.PL
{
    public partial class FRM_ADDBOOK : Form
    {

        public FRM_MIAN parentForm;

        public FRM_ADDBOOK(FRM_MIAN form)
        {
            InitializeComponent();
            parentForm = form;
            Loadcategories();
        }

        private void Loadcategories()
        {
            cmbocategory.Items.Clear();

                if (File.Exists("categories.txt"))
                {
                    var lines = File.ReadAllLines("categories.txt");

                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                        cmbocategory.Items.Add(line);
                        }
                    }
                }
            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtnamebook.Text;
                string author = textnameathor.Text;
                string category = cmbocategory.Text;

                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(author) ||
                    string.IsNullOrWhiteSpace(category))
                {
                    MessageBox.Show("من فضلك املأ جميع الحقول");
                    return;
                }

                parentForm.AddBook(name, author, category);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADDBOOK_Load(object sender, EventArgs e)
        {
        }
    }
}
