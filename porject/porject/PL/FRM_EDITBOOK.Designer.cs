namespace porject.PL
{
    partial class FRM_EDITBOOK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbocategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textnameathor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnamebook = new System.Windows.Forms.TextBox();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.btneditbook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::porject.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbocategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textnameathor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnamebook);
            this.groupBox1.Controls.Add(this.Lb_Title);
            this.groupBox1.Location = new System.Drawing.Point(23, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 508);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات التعديل";
            // 
            // cmbocategory
            // 
            this.cmbocategory.FormattingEnabled = true;
            this.cmbocategory.Location = new System.Drawing.Point(21, 418);
            this.cmbocategory.Name = "cmbocategory";
            this.cmbocategory.Size = new System.Drawing.Size(557, 35);
            this.cmbocategory.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "صنف الكتاب";
            // 
            // textnameathor
            // 
            this.textnameathor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textnameathor.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnameathor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textnameathor.Location = new System.Drawing.Point(27, 233);
            this.textnameathor.Name = "textnameathor";
            this.textnameathor.Size = new System.Drawing.Size(545, 63);
            this.textnameathor.TabIndex = 6;
            this.textnameathor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المؤالف";
            // 
            // txtnamebook
            // 
            this.txtnamebook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnamebook.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamebook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtnamebook.Location = new System.Drawing.Point(27, 90);
            this.txtnamebook.Name = "txtnamebook";
            this.txtnamebook.Size = new System.Drawing.Size(545, 63);
            this.txtnamebook.TabIndex = 4;
            this.txtnamebook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(201, 30);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(196, 57);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "اسم الكتاب";
            // 
            // btneditbook
            // 
            this.btneditbook.BackColor = System.Drawing.Color.White;
            this.btneditbook.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditbook.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btneditbook.Location = new System.Drawing.Point(90, 564);
            this.btneditbook.Name = "btneditbook";
            this.btneditbook.Size = new System.Drawing.Size(451, 73);
            this.btneditbook.TabIndex = 8;
            this.btneditbook.Text = "تعديل";
            this.btneditbook.UseVisualStyleBackColor = false;
            this.btneditbook.Click += new System.EventHandler(this.btneditbook_Click);
            // 
            // FRM_EDITBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btneditbook);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_EDITBOOK";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EDITBOOK";
            this.Load += new System.EventHandler(this.FRM_EDITBOOK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbocategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnameathor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnamebook;
        private System.Windows.Forms.Label Lb_Title;
        public System.Windows.Forms.Button btneditbook;
    }
}