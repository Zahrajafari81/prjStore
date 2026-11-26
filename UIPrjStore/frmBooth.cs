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
    public partial class frmBooth : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmBooth()
        {
            InitializeComponent();
        }
        BLBooth objBooth = new BLBooth();
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
         private void Clear()
        {
            TxtBoothNumber.Clear();
            TxtBoothName.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string message;
            if(CheckEmpityTextBox(TxtBoothNumber, TxtBoothName))
            {
                objBooth.Insert(TxtBoothNumber.Text, TxtBoothName.Text, out message);
                MessageBox.Show(message);
                Clear();
                frmBooth_Load(sender, e);
            }
            
        }

        private void frmBooth_Load(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            dt = objBooth.Search();
            radGridView.DataSource = dt;
        }
        private void radGridView_MouseClick(object sender, MouseEventArgs e)
        {
            TxtBoothNumber.Text = radGridView.CurrentRow.Cells["BoothNumber"].Value.ToString();
            TxtBoothName.Text = radGridView.CurrentRow.Cells["BoothName"].Value.ToString();
            TxtBoothNumber.Enabled = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string message;
            if(CheckEmpityTextBox(TxtBoothNumber,TxtBoothNumber))
            {
                objBooth.Update(TxtBoothNumber.Text, TxtBoothName.Text, out message);
                MessageBox.Show(message);
                Clear();
                frmBooth_Load(sender, e);
                TxtBoothNumber.Enabled = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string message;
            if (MessageBox.Show("آیا مطمئن به حذف هستید", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                objBooth.Delete(radGridView.CurrentRow.Cells["BoothNumber"].Value.ToString(), out message);
                MessageBox.Show(message);
                frmBooth_Load(sender, e);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GrpSearch.Visible= true;
        }

        private void TxtSearchNameBooth_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objBooth.Search(TxtSearchNameBooth.Text.Trim());
            radGridView.DataSource = dt;
        }
    }
}
