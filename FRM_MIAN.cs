using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace porject.PL
{

    public partial class FRM_MIAN : Form
    {
        User currentUser;

        public List<category> categories = new List<category>();

        public List<Book> books = new List<Book>();

        public List<Borrow> borrows = new List<Borrow>();

        public FRM_MIAN(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        //لحظه الفتح

        private void FRM_MIAN_Load_1(object sender, EventArgs e)
        {
            Lb_Title.Text = "الرئيسية";
            if (currentUser.Role == UserRole.Admin)
            {
                P_MAIN.Visible = false;
                panelbook.Visible = false;
                panel_category.Visible = false;
                panel_books.Visible = false;
                panelAdminborrow.Visible = false;
                paneluserborrow.Visible = false;
                btnBorrowMenu.Visible = false;
                paneluser.Visible = false;
                P_HOME.Visible = true;
                panel1.Visible = true;
                panel6.Visible = true;
                panel5.Visible = true;
                buttonhome.Visible = true;
                book.Visible = true;
                btncategory.Visible = true;
                buttonadminborrow.Visible = true;


                dgvBook.Columns.Clear();
                dgvBook.Columns.Add("الاسم", "اسم الكتاب");
                dgvBook.Columns.Add("المؤالف", "المؤالف");
                dgvBook.Columns.Add("الصنف", "الصنف");
                dgvBook.Columns.Add("Status", "الحالة");
                dgvborrows.Columns.Clear();
                dgvborrows.Columns.Add("الاسم", "اسم الطالب");
                dgvborrows.Columns.Add("الاسم", "اسم الكتاب");
                dgvborrows.Columns.Add("التاريخ", "التاريخ");

                LoadBooksFromFile();
                LoadBooksToGrid();
                LoadCategories();
                LoadBorrowsFromFile();
                UpdateDashboard();
            }
            else
            {
                P_HOME.Visible = true;
                P_MAIN.Visible = false;
                panelbook.Visible = false;
                panel_category.Visible = false;
                panel_books.Visible = false;
                panelAdminborrow.Visible = false;
                paneluserborrow.Visible = false;
                panel1.Visible = false;
                panel6.Visible = false;
                panel5.Visible = false;
                buttonhome.Visible = false;
                book.Visible = false;
                btncategory.Visible = false;
                buttonadminborrow.Visible = false;
                P_MB.Visible = false;
                paneluser.Visible = true;
                welcom.Visible = true;
                btnBorrowMenu.Visible= true;

                Lb_Title.Text = "";

                LoadBooksFromFile();
                LoadCombo();
            }
        }
       


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void P_TB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (P_MB.Size.Width != 200)
            {
                P_MB.Width = 200;
                buttonhome.RightToLeft = RightToLeft.No;
                book.RightToLeft = RightToLeft.No;
                buttonadminborrow.RightToLeft = RightToLeft.No;
                btnBorrowMenu.RightToLeft = RightToLeft.No;
                btncategory.RightToLeft = RightToLeft.No;
                label2.Visible = true;
                pictureBox7.Visible = true;
                pictureBox9.Visible = false;
            }
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (P_MB.Size.Width == 200)
            {
                P_MB.Width = 50;
                buttonhome.RightToLeft = RightToLeft.Yes;
                book.RightToLeft = RightToLeft.Yes;
                buttonadminborrow.RightToLeft = RightToLeft.Yes;
                btnBorrowMenu.RightToLeft = RightToLeft.Yes;
                btncategory.RightToLeft = RightToLeft.Yes;
                label2.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = true;

            }
        }




        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void P_MB_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
            P_MB.ClientRectangle,
            Color.FromArgb(30, 42, 71),
            Color.FromArgb(36, 58, 94),
            LinearGradientMode.Vertical);
            P_MB.BackgroundImage = null;
            P_MB.BackColor = Color.Transparent;
            e.Graphics.FillRectangle(brush, P_MB.ClientRectangle);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        Button activeButton;

        private void SetActiveButton(Button btn)
        {
            if (activeButton != null)
                activeButton.BackColor = Color.Transparent;

            activeButton = btn;
            activeButton.BackColor = Color.DimGray;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void buttonadminborrow_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveButton((Button)sender);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //botton Category
        private void button7_Click_1(object sender, EventArgs e)
        {
            Lb_Title.Text = "الاصناف";
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            panelbook.Visible = false;
            panel_category.Visible = true;
            panel_books.Visible = false;
            panelAdminborrow.Visible = false;
            paneluserborrow.Visible = false;
            dgvCategories.Columns.Clear();
            dgvCategories.Columns.Add("اسم الصنف", "اسم الصنف");
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            LoadCategories();
        }
        //load
        private void LoadCategories()
        {
            dgvCategories.Rows.Clear();

            if (dgvCategories.Columns.Count == 0)
            {
                dgvCategories.Columns.Add("Name", "Category");
            }

            categories.Clear();

            if (File.Exists("categories.txt"))
            {
                foreach (var line in File.ReadAllLines("categories.txt"))
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    dgvCategories.Rows.Add(line);

                    categories.Add(new category { Name = line });
                }
            }
        }
        
        //save

        public void SaveAllCategories()
        {
            using (StreamWriter sw = new StreamWriter("categories.txt"))
            {
                foreach (DataGridViewRow row in dgvCategories.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sw.WriteLine(row.Cells[0].Value.ToString());
                    }
                }
            }
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            FRM_ADDCAT f1 = new FRM_ADDCAT(this);
            f1.ShowDialog();
            UpdateDashboard();
        }
        public void AddCategory(string name)
        {
            category c = new category();
            c.Name = name;
            categories.Add(c);
            File.AppendAllText("categories.txt", c.Name + "\n");
            dgvCategories.Rows.Add(name);
        }

        //edit
        public void UpdateCategory(string oldName, string newName)
        {
            for (int i = 0; i < dgvCategories.Rows.Count; i++)
            {
                if (!dgvCategories.Rows[i].IsNewRow)
                {
                    if (dgvCategories.Rows[i].Cells[0].Value.ToString() == oldName)
                    {
                        dgvCategories.Rows[i].Cells[0].Value = newName;
                        break;
                    }
                }
            }
            SaveAllCategories();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string name = dgvCategories.CurrentRow.Cells[0].Value.ToString();
            FRM_EDIT f1 = new FRM_EDIT(this, name);
            f1.ShowDialog();
            UpdateDashboard();
        }

        private void buttondeletcategort_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow != null)
            {
                dgvCategories.Rows.Remove(dgvCategories.CurrentRow);
                SaveAllCategories();
                UpdateDashboard();
            }
        }

        private void book_Click(object sender, EventArgs e)
        {
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                paneluser.Visible = false;
                panelbook.Visible = true;
                panel_category.Visible = false;
                panel_books.Visible = true;
                panelAdminborrow.Visible = false;
                paneluserborrow.Visible = false;
                Lb_Title.Text = "الكتب";
                dgvBook.Columns.Clear();
                dgvBook.Columns.Add("الاسم", "اسم الكتاب");
                dgvBook.Columns.Add("المؤالف", "المؤالف");
                dgvBook.Columns.Add("الصنف", "الصنف");
                dgvBook.Columns.Add("Status", "الحالة");
                dgvBook.RowHeadersVisible = false;
                dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBook.MultiSelect = false;
                LoadBooksFromFile();
                LoadBooksToGrid();
            }
        }
        private void buttonaddbook_Click(object sender, EventArgs e)
        {
            FRM_ADDBOOK f = new FRM_ADDBOOK(this);
            f.ShowDialog();

        }



        //add book
        public void AddBook(string name, string author, string category)
        {
            LoadCategories();
            Book b = new Book();
            b.Name = name;
            b.Author = author;
            b.Category = category;

            books.Add(b);

            int rowindex = dgvBook.Rows.Add(b.Name, b.Author, b.Category);
            dgvBook.Rows[rowindex].Tag = b;
            File.AppendAllText("books.txt", $"{name},{author},{category}\n");
            LoadBooksFromFile();
            LoadBooksToGrid();
            UpdateDashboard();
        }

        private void buttoneditbook1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBook.CurrentRow == null)
                {
                    MessageBox.Show("من فضلك اختر كتاب");
                    return;
                }
                Book b = books.FirstOrDefault(x => x.Name == dgvBook.CurrentRow.Cells[0].Value.ToString());
                FRM_EDITBOOK frm = new FRM_EDITBOOK(this, b);
                frm.ShowDialog();
                LoadBooksFromFile();
                LoadBooksToGrid();
                UpdateDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void SaveBooksToFile()
        {
            File.WriteAllText("books.txt", "");

            foreach (var b in books)
            {
                File.AppendAllText("books.txt", $"{b.Name},{b.Author},{b.Category},{b.IsBorrowed}\n");
            }
        }


        public void LoadBooksFromFile()
        {
            books.Clear();

            if (File.Exists("books.txt"))
            {
                string[] lines = File.ReadAllLines("books.txt");

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] data = line.Split(',');

                    if (data.Length < 3) continue;

                    Book b = new Book()
                    {
                        Name = data[0],
                        Author = data[1],
                        Category = data[2],
                        IsBorrowed = data.Length > 3 && bool.Parse(data[3])
                    };

                    books.Add(b);
                }
            }
        }

        public void LoadBooksToGrid()
        {
            dgvBook.Rows.Clear();
            if (dgvBook.Columns.Count == 0)
            {
                dgvBook.Columns.Add("Name", "اسم الكتاب");
                dgvBook.Columns.Add("Author", "المؤلف");
                dgvBook.Columns.Add("Category", "الصنف");
                dgvBook.Columns.Add("Status", "الحالة");
            }
                foreach (var b in books)
                {
                    string status = b.IsBorrowed ? "مستعار" : "متاح";
                int rowIndex = dgvBook.Rows.Add(b.Name, b.Author, b.Category, status);

                if (b.IsBorrowed)
                {
                    dgvBook.Rows[rowIndex].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    dgvBook.Rows[rowIndex].Cells[3].Style.ForeColor = Color.Green;
                }
            }
        }

        //delet book
        private void buttondeletbook_Click(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow != null)
            {
                int index = dgvBook.CurrentRow.Index;

                books.RemoveAt(index);
                SaveBooksToFile();
                LoadBooksFromFile();
                LoadBooksToGrid();
                dgvBook.Refresh();
                UpdateDashboard();
            }
        }


        //method save borrow

        void SaveBorrowsToFile()
        {
            StreamWriter sw = new StreamWriter("borrows.txt");

            foreach (var b in borrows)
            {
                sw.WriteLine($"{b.UserName}|{b.BookName}|{b.Id}|{b.Phone}|{b.BorrowDate}");
            }

            sw.Close();
        }

        //method load borrow

        void LoadBorrowsFromFile()
        {
            borrows.Clear();

            if (!File.Exists("borrows.txt"))
                return;

            string[] lines = File.ReadAllLines("borrows.txt");

            foreach (var line in lines)
            {
                string[] data = line.Split('|');

                Borrow b = new Borrow()
                {
                    UserName = data[0],
                    BookName = data[1],
                    Id = (data[2]),
                    Phone =(data[3]),
                    BorrowDate = DateTime.Parse(data[4])
                };

                borrows.Add(b);
                dgvborrows.Rows.Add(b.UserName, b.BookName, b.Id , b.Phone , b.BorrowDate);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbbookborrow.SelectedItem == null)
            {
                MessageBox.Show("اختار كتاب الأول");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnameb.Text))
            {
                MessageBox.Show("ادخل اسمك");
                return; 
            }
            Book selectedBook = (Book)cmbbookborrow.SelectedItem;
            if (!selectedBook.IsBorrowed)
            {
                selectedBook.IsBorrowed = true;
                Borrow b = new Borrow()
                {
                    UserName = txtnameb.Text,
                    BookName = selectedBook.Name,
                    Id = txtid.Text,
                    Phone = txtphone.Text,
                    BorrowDate = DateTime.Now
                };
                borrows.Add(b);
                SaveBooksToFile();
                SaveBorrowsToFile();
                LoadCombo();
                MessageBox.Show("تمت الاستعارة");
                UpdateDashboard();
            }
            else 
            {
                MessageBox.Show("الكتاب مستعار بالفعل"); 
            }
        }

        private void btnBorrowMenu_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            panelbook.Visible = false;
            panel_category.Visible = false;
            panel_books.Visible = false;
            panelAdminborrow.Visible = false;
            paneluserborrow.Visible = true;
            paneluserborrowbtns.Visible = true;
            Lb_Title.Text = "استعارة كتاب";
            LoadBooksFromFile();
            LoadCombo();
        }

        void LoadCombo()
        {
            cmbbookborrow.DataSource = null;
            cmbbookborrow.DataSource = books.Where(b => !b.IsBorrowed).ToList();
            cmbbookborrow.DisplayMember = "Name";
        
        }

        private void buttonadminborrow_Click_1(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            panelbook.Visible = false;
            panel_category.Visible = false;
            panel_books.Visible = false;
            panelAdminborrow.Visible = true;
            paneluserborrow.Visible = false;
            paneluserborrowbtns.Visible = false;
            panelreset.Visible = true;
            Lb_Title.Text = "الاستعارات";
            dgvborrows.Columns.Clear();
            dgvborrows.Columns.Add("الاسم", "اسم الطالب");
            dgvborrows.Columns.Add("الاسم", "اسم الكتاب");
            dgvborrows.Columns.Add("الرقم القومي", "الرقم القومي");
            dgvborrows.Columns.Add("رقم الهاتف", "رقم الهاتف");
            dgvborrows.Columns.Add("التاريخ", "التاريخ");
            dgvborrows.RowHeadersVisible = false;
            dgvborrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvborrows.MultiSelect = false;
            LoadBorrowsFromFile();

        }



        //UpdateDashboard

        void UpdateDashboard()
        {
            labeltotalbooks.Text = books.Count.ToString();
            labeltatalcategories.Text = categories.Count.ToString();
            labeltotalborrows.Text = borrows.Count.ToString();
            labelAvailableBooks.Text = (books.Count - borrows.Count).ToString();
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            Lb_Title.Text = "الرئيسية";
            UpdateDashboard();
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            panelbook.Visible = false;
            panel_category.Visible = false;
            panel_books.Visible = false;
            panelAdminborrow.Visible = false;
            paneluserborrow.Visible = false;
            paneluserborrowbtns.Visible = false;
            panelreset.Visible = false;
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            if (dgvborrows.CurrentRow == null)
            {
                MessageBox.Show("اختار استعارة الأول");
                return;
            }

            string userName = dgvborrows.CurrentRow.Cells[0].Value.ToString();
            string bookName = dgvborrows.CurrentRow.Cells[1].Value.ToString();
            string Id = dgvborrows.CurrentRow.Cells[2].Value.ToString();
            string Phone = dgvborrows.CurrentRow.Cells[3].Value.ToString();
            DateTime borrowDate = Convert.ToDateTime(dgvborrows.CurrentRow.Cells[4].Value);

            // نجيب الاستعارة بالثلاث بيانات
            var borrow = borrows.FirstOrDefault(b =>
                b.UserName == userName &&
                b.BookName == bookName &&
                b.Id == Id &&
                b.Phone == Phone &&
                b.BorrowDate == borrowDate);

            if (borrow != null)
            {
                // نرجع الكتاب
                var book = books.FirstOrDefault(b => b.Name == bookName);

                if (book != null)
                {
                    book.IsBorrowed = false;
                    SaveBooksToFile();
                    LoadCombo();
                }

                // نحذف الاستعارة
                borrows.Remove(borrow);

                SaveBorrowsToFile();
                UpdateDashboard();

                // تحديث الجدول
                dgvborrows.Rows.Remove(dgvborrows.CurrentRow);

                MessageBox.Show("تم استرجاع الكتاب بنجاح");
            
        }

    }

    }
    }





    //enum
    public enum UserRole
    {
        Admin, User
    }


    public class Person
    {
    public string Username { get; set; }
    }

    //class user
    public class User : Person
    {
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }

    //data login

    static class datalogin
    {
        public static List<User> Users = new List<User>()
        {
            new User{ Username = "admin" ,Password= "123" , Role =UserRole.Admin},
            new User{ Username="user" , Password= "123" , Role= UserRole.User }

        };
    }





    //class category
    public class category
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    //class book

    public class Book
    {
        private string name;
        private string author;
        private string category;

        public bool IsBorrowed { get; set; } = false;

        public override string ToString()
        {
            return Name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

    }

    //class borrow book
    public class Borrow
    {
        public string UserName { get; set; }
        public string BookName { get; set; }
        public string Id { get; set; }
        public string Phone { get; set; }
        public DateTime BorrowDate { get; set; }
    }



