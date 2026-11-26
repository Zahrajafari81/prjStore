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
    public partial class FrmEmployee : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        private void EmpityTextBox()
        {
            ID.Clear();
            IDmelli.Clear();
            Fname.Clear();
            Lname.Clear();
            NumberHouse.Clear();
            Number.Clear();
            Duty.Clear();
            Address.Clear();
        }
        private bool CheckEmpityTextBox(params TextBox[] a)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i].Text == "")
                {
                    errorProvider1.SetError(a[i], "بایستگی پر گردد");
                    a[i].BackColor = Color.LightGoldenrodYellow;
                    a[i].Focus();
                    return false;
                }
                a[i].BackColor = Color.White;
                errorProvider1.Clear();
            }
            return true;
        }

        BLEmployee objclassemplooye = new BLEmployee();
       

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objclassemplooye.Search();
            radGridView1.DataSource = dt;
        }

        private void btnsave1_Click(object sender, EventArgs e)
        {
            if (CheckEmpityTextBox(ID, IDmelli, Fname, Lname, NumberHouse, Number, Duty, Address))

            {
                string message, radiobutton;
                if (radMale.Checked == true)
                {
                    radiobutton = radMale.Text;
                }
                else
                {
                    radiobutton = radFamle.Text;
                }
                objclassemplooye.Insert(ID.Text, IDmelli.Text, Fname.Text, Lname.Text, NumberHouse.Text, Number.Text, Duty.Text, radiobutton, Address.Text, out message);
                MessageBox.Show(message);
                FrmEmployee_Load(null, null);
                if (message == "عملیات ثبت با موفقیت انجام شد")
                {
                    EmpityTextBox();
                }
            }
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            string message,radiobutton;
            if (radMale.Checked == true)
            {
                radiobutton = radMale.Text;
            }
            else
            {
                radiobutton = radFamle.Text;
            }
            objclassemplooye.Update(ID.Text, IDmelli.Text, Fname.Text, Lname.Text, NumberHouse.Text, Number.Text, Duty.Text, radiobutton, Address.Text, out message);
            MessageBox.Show(message);
            if(message == "عملیات ویرایش با موفقیت انجام شد")
            {
                EmpityTextBox();
                ID.Enabled = true;
            }
            FrmEmployee_Load(sender, e);
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ID.Enabled = false;
            ID.Text = radGridView1.CurrentRow.Cells["ID"].Value.ToString();
            IDmelli.Text = radGridView1.CurrentRow.Cells["CodeMeli"].Value.ToString();
            Fname.Text = radGridView1.CurrentRow.Cells["Fname"].Value.ToString();
            Lname.Text = radGridView1.CurrentRow.Cells["Lname"].Value.ToString();
            NumberHouse.Text = radGridView1.CurrentRow.Cells["NumberTelHouse"].Value.ToString();
            Number.Text = radGridView1.CurrentRow.Cells["NumberTelHamrah"].Value.ToString();
            Duty.Text = radGridView1.CurrentRow.Cells["Masoleate"].Value.ToString();
            if (radGridView1.CurrentRow.Cells["sex"].Value.ToString() == "آقا")
                radMale.Checked = true;
            else
                radFamle.Checked = true;
                Address.Text = radGridView1.CurrentRow.Cells["Address"].Value.ToString();
          //  bool isopen = Application.OpenForms.Cast<Form>().Any(form => form.Name == "FrmNewUser");
             //   FrmNewUser frm = new FrmNewUser(radGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
           
                string message;
                if (MessageBox.Show("آیا مطمئن به حذف هستید", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    objclassemplooye.Delete(radGridView1.CurrentRow.Cells["ID"].Value.ToString(),out message);
                    MessageBox.Show(message);
                    FrmEmployee_Load(sender, e);
                }
        }

        private void txtSearchFname_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objclassemplooye.Search(txtSearchFname.Text.Trim());
            radGridView1.DataSource = dt;
        }

        private void btnserch1_Click(object sender, EventArgs e)
        {
            GrpSearchInfo.Visible = true;
        }
    }
}