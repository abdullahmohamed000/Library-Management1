using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace porject.PL
{
    public partial class FRM_ADDCAT : Form
    {
        public FRM_ADDCAT()
        {
            
            InitializeComponent();
        }

        private void FRM_ADDCAT_Load(object sender, EventArgs e)
        {

        }
        public void SetRoundedPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtcategory.Text.Trim();

                if (name == "")
                {
                    MessageBox.Show("اكتب اسم الصنف");
                    return;
                }
                parentForm.AddCategory(name);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private FRM_MIAN parentForm;

        public FRM_ADDCAT(FRM_MIAN form)
        {
            InitializeComponent();
            parentForm = form;
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
