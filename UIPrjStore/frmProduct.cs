using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using System.IO;
using BLprjStore;



namespace UIPrjStore
{
    public partial class frmProduct : MetroForm
    {
        public frmProduct()
        {
            InitializeComponent();
          //  this.AutoScaleMode = AutoScaleMode.None;
          //  this.Width = (int)(this.Width / this.CurrentAutoScaleDimensions.Width * 10);
         //   this.Height = (int)(this.Height / this.CurrentAutoScaleDimensions.Height * 10);

        }
        BLProduct objProduct = new BLProduct();
        BLProduct1 objPorduct1 = new BLProduct1();
        
        private bool CheckEmpityTextBox(params TextBox[] a )
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i].Text == "")
                {
                    errorProvider1.SetError(a[i], "بایستی پر گردد");
                    a[i].BackColor = Color.LightBlue;
                    a[i].Focus();
                    return false;
                }
                a[i].BackColor = Color.White;
                errorProvider1.Clear();
            }
            return true;
        }
        private void ClearTextBox()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtNumber.Clear();
            txtTarikhtolid.Clear();
            txtTarikhEngheza.Clear();
            txtGaranty.Clear();
            cmbUnit.SelectedIndex = 0;
            txtBarcode.Enabled = true;
            txtBoothNumber.Clear();
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            cmbUnit.SelectedIndex = 0;
            float defaultWidth = 1200;
            float defaultHeight = 900;

            using (Graphics g = this.CreateGraphics())
            {
                float dpiScale = g.DpiX / 96f;
                this.Width = (int)(defaultWidth * dpiScale);
                this.Height = (int)(defaultHeight * dpiScale);
            }
            //تنظیم موقعیت فرم
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            //DataTable dt = new DataTable();
            //dt.Columns.Add("id", typeof(int));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Major", typeof(string));
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["id"] };
            //dt.Rows.Add("1", "علیرضا رضایی", "مهندسی کامپیوتر");
            //dt.Rows.Add("2", "رضا محمدی", "مهندسی کامپیوتر");
            //dt.Rows.Add("3", "سعید رضایی", "مهندسی مکانیک");
            //dataGridView1.DataSource = dt;


            //DataSet dataSet = new DataSet();
            //DataTable studentsTable = new DataTable("Students");

            //studentsTable.Columns.Add("ID", typeof(int));
            //studentsTable.Columns.Add("Name", typeof(string));

            //studentsTable.Rows.Add(1, "Ali");
            //studentsTable.Rows.Add(2, "Reza");

            //dataSet.Tables.Add(studentsTable);

            //dataGridView1.DataSource = dataSet.Tables["Students"];

            DataTable dt = new DataTable();
            dt = objPorduct1.searchAllInfo();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Barcode"].HeaderText = "بارکد محصول";
            dataGridView1.Columns["Barcode"].Width = 180;
            
            dataGridView1.Columns["ProductName"].HeaderText = "نام محصول";
            dataGridView1.Columns["ProductName"].Width = 200;

            dataGridView1.Columns["Unit"].HeaderText = "واحد";
            dataGridView1.Columns["Unit"].Width = 100;

            dataGridView1.Columns["Price"].HeaderText = "قیمت";
            dataGridView1.Columns["Price"].Width = 100;

            dataGridView1.Columns["Number"].HeaderText = "تعداد محصول";
            dataGridView1.Columns["Number"].Width = 200;


            dataGridView1.Columns["TarikhTolid"].HeaderText = "تاریخ تولید";
            dataGridView1.Columns["TarikhTolid"].Width = 80;

            dataGridView1.Columns["TarikhEngheza"].HeaderText = "تاریخ انقضاء";
            dataGridView1.Columns["TarikhEngheza"].Width = 90;

            dataGridView1.Columns["Garanty"].HeaderText = "گارانتی";
            dataGridView1.Columns["Garanty"].Width = 80;

            dataGridView1.Columns["Image"].HeaderText = "تصویر";
            dataGridView1.Columns["Image"].Width = 90;

            dataGridView1.Columns["BoothNumber_fk"].HeaderText = "شماره غرفه";
            dataGridView1.Columns["BoothNumber_fk"].Width = 90;

            dataGridView1.Columns["BoothName"].HeaderText = "نام غرفه";
            dataGridView1.Columns["BoothName"].Width = 90;

            for (int i=0;i<dataGridView1.Rows.Count;i+=2)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
      
            }

            for(int i=0; i<dataGridView1.Rows.Count;i++)
            {
                dataGridView1.Rows[i].Height = 140;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //UI
            //BL
            //DAL
            if (CheckEmpityTextBox(txtBarcode, txtName, txtTarikhtolid, txtTarikhEngheza , txtTarikhEngheza, txtGaranty, txtNumber,txtBoothNumber))
            {
                string message;
                MemoryStream Ms = new MemoryStream();
                Bitmap bmp = (Bitmap)pictureBox1.Image;
                bmp.Save(Ms, pictureBox1.Image.RawFormat);
                byte[] a = Ms.GetBuffer();
                objPorduct1.InsertProduct(txtBarcode.Text, txtName.Text, cmbUnit.Text, txtPrice.Text, txtNumber.Text, txtTarikhtolid.Text, txtTarikhEngheza.Text, txtGaranty.Text,a, txtBoothNumber.Text,out message);
                MessageBox.Show(message);
                frmProduct_Load(sender,e);
                ClearTextBox();
            }
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcode.Enabled = false;
            txtBarcode.Text = dataGridView1.CurrentRow.Cells["Barcode"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            MemoryStream Ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells["Image"].Value);
            pictureBox1.Image = Image.FromStream(Ms);
            cmbUnit.Text = dataGridView1.CurrentRow.Cells["Unit"].Value.ToString();
            txtPrice.Text= dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            txtNumber.Text= dataGridView1.CurrentRow.Cells["Number"].Value.ToString();
            txtTarikhtolid.Text= dataGridView1.CurrentRow.Cells["TarikhTolid"].Value.ToString();
            txtTarikhEngheza.Text = dataGridView1.CurrentRow.Cells["TarikhEngheza"].Value.ToString();
            txtGaranty.Text= dataGridView1.CurrentRow.Cells["Garanty"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmpityTextBox(txtBarcode, txtName, txtTarikhtolid, txtTarikhEngheza, txtTarikhEngheza, txtGaranty, txtNumber,txtBoothNumber))
            {
                string message;
                MemoryStream Ms = new MemoryStream();
                Bitmap bmp = (Bitmap)pictureBox1.Image;
                bmp.Save(Ms, pictureBox1.Image.RawFormat);
                byte[] a = Ms.GetBuffer();
                objPorduct1.UpdateProduct1(txtBarcode.Text, txtName.Text, cmbUnit.Text, txtPrice.Text, txtNumber.Text, txtTarikhtolid.Text, txtTarikhEngheza.Text, txtGaranty.Text,a,txtBoothNumber.Text, out message);
                MessageBox.Show(message);
                frmProduct_Load(sender, e);
                ClearTextBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string message;
            if (MessageBox.Show("آیا مطمئن به حذف هستید", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                objPorduct1.DeleteInfo(dataGridView1.CurrentRow.Cells["Barcode"].Value, out message);
                MessageBox.Show(message);
                frmProduct_Load(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpSearchInfoName.Visible = true;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objPorduct1.SearchGoogle(txtSearchName.Text.Trim());
            dataGridView1.DataSource = dt;

            for (int i = 0; i < dataGridView1.Rows.Count; i += 2)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;

            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 40;
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "image File (*.jpg)|*.jpg| image File (*.Png)|*.Png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا قصد اسکن بارکد محصولات را دارید؟","سوال",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                frmScanner frm = new frmScanner();
                frm.ShowDialog();
                txtBarcode.Text = frm.barcode;
            }
        }

        private void btnAttchBoothNumber_Click(object sender, EventArgs e)
        {
            frmInfoBooth frm = new frmInfoBooth();
            frm.ShowDialog();
            txtBoothNumber.Text = frm.BoothNumber;
        }
    }
}
