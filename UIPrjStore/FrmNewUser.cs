using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLPrjSturee;

namespace UIPrjStore
{
    public partial class FrmNewUser : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }
        //public FrmNewUser(string name,string id)
        //{
        //    InitializeComponent();
        //    TxtUserName.Text = name;
        //    txtPersonnelCode.Text = id;
        //}
        //public FrmNewUser(string PersonalCode)
        //{
        //    InitializeComponent();
        //    txtPersonnelCode.Text = PersonalCode;
        //}
        BLNewUser objBLNewUser = new BLNewUser();
        private bool CheckEmpityTextBox(params TextBox[] a)
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
        private void EmpityTextBox()
        {
            txtPersonnelCode.Clear();
            TxtUserName.Clear();
            TxtPassword.Clear();
            radDropAccess.SelectedIndex = 0;
        }
        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStureDataSet1.TblLogin' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dbStureDataSet.TblLogin' table. You can move, or remove it, as needed.
            GrpSearch.Visible = false;
            DataTable dt = new DataTable();
            dt = objBLNewUser.search();
            radGridView1.DataSource = dt;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmpityTextBox(TxtUserName, TxtPassword))
            {
                string message;
                objBLNewUser.insert(TxtUserName.Text, TxtPassword.Text, radDropAccess.Text, txtPersonnelCode.Text, out message);
                MessageBox.Show(message);
                if (message == "عملیات ثبت با موفقیت انجام شد")
                {
                    FrmNewUser_Load(sender, e);
                    TxtUserName.Enabled = true;
                  
                }
                EmpityTextBox();
            }
        }
      
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (CheckEmpityTextBox(txtPersonnelCode, TxtUserName, TxtPassword))
            {

                string message;
                objBLNewUser.update(TxtUserName.Text, TxtPassword.Text, radDropAccess.Text, txtPersonnelCode.Text, out message);
                MessageBox.Show(message);
                FrmNewUser_Load(sender, e);
                TxtUserName.Enabled = true;
                EmpityTextBox();
            }
              
        }
        private void BtnClean_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا مطمئن به حذف هستید", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (objBLNewUser.Delete(radGridView1.CurrentRow.Cells["UserName"].Value.ToString()) == true)
                    {
                        MessageBox.Show("با موفقیت عملیات حذف انجام شد");
                        FrmNewUser_Load(sender, e);
                        EmpityTextBox();
                    }
                    else
                    {
                        MessageBox.Show("عملیات حذف با شکست مواجه شد");
                    }
                }
            }
            catch
            {
                MessageBox.Show("خطا");
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GrpSearch.Visible = true;
            
        }

        private void TxtSearchUserName_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objBLNewUser.search(TxtSearchUserName.Text);
            radGridView1.DataSource = dt;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {

            frmInfoEmployee frm = new frmInfoEmployee();
            frm.ShowDialog();

            if (MessageBox.Show("آیا قصد دارید نام کاربری جدید تعریف کنید؟", "سوال", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtPersonnelCode.Text = frm.id;
            }
            else
            {
                TxtUserName.Text = frm.name;
                txtPersonnelCode.Text = frm.id;
            }
        }

        private void radGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtUserName.Enabled = false;
            txtPersonnelCode.Text = radGridView1.CurrentRow.Cells["ID"].Value.ToString();
            TxtUserName.Text = radGridView1.CurrentRow.Cells["UserName"].Value.ToString();
            TxtPassword.Text = radGridView1.CurrentRow.Cells["Password"].Value.ToString();
            radDropAccess.Text = radGridView1.CurrentRow.Cells["Access"].Value.ToString();
        }
    }
}
