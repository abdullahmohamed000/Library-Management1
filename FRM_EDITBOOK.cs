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

namespace porject.PL
{
    public partial class FRM_EDITBOOK : Form
    {
        public FRM_MIAN parentForm;
        public Book book;


        public FRM_EDITBOOK(FRM_MIAN form, Book b)
        {
            InitializeComponent();
            parentForm = form;
            book = b;
            LoadData();
        }



        //LOADDATA

        private void LoadData()
        {
            try
            {
                txtnamebook.Text = book.Name;
                textnameathor.Text = book.Author;

                cmbocategory.Items.Clear();

                foreach (var c in parentForm.categories)
                {
                    if (c != null)
                        cmbocategory.Items.Add(c.Name);
                }

                cmbocategory.Text = book.Category;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }


        private void FRM_EDITBOOK_Load(object sender, EventArgs e)
        {

        }

        private void btneditbook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtnamebook.Text))
                {
                    MessageBox.Show("اسم الكتاب مطلوب");
                    return; 
                }
                // تعديل البيانات     
                book.Name = txtnamebook.Text;
                book.Author = textnameathor.Text;
                book.Category = cmbocategory.Text;
                // حفظ + تحديث 
                parentForm.SaveBooksToFile();
                parentForm.LoadBooksFromFile();
                parentForm.LoadBooksToGrid();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Save Error: " + ex.Message); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
