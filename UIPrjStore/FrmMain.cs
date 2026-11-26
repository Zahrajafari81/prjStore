using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLprjStore;


namespace UIPrjStore
{
    public partial class FrmMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        blLogin blLogin = new blLogin();
        public FrmMain(string name, string access)
        {
            InitializeComponent();
            DataTable dt = blLogin.Gender(name);
            DataRow dr = dt.Rows[0];
            string Gender = dr["Sex"].ToString();
            string fullName = dr["Fname"]+ " " + dr["Lname"];
            if (Gender == "خانم")
                lblMessage.Text = "سرکار خانم " + fullName + " " + "خوش آمدید";
            else if (Gender == "آقا")
                lblMessage.Text = "جناب آقای " + fullName + " " + "خوش آمدید";
            
            if (access == "بخش فروش")
                {
                    ItemWareHouse.Visible = false;
                    ItemSave.Visible = false;
                }
                else if (access == "بخش ثبت")
                {
                    ItemSelling.Visible = false;
                    ItemWareHouse.Visible = false;
                }
                else if (access == "بخش انباردار")
                {
                    ItemSave.Visible = false;
                    ItemSelling.Visible = false;
                }
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            radDateTimePicker1.Text = DateTime.Now.Day.ToString("yyyy/mm/dd");
            radDateTimePicker1.Value = DateTime.Today;
            radDateTimePicker1.BackColor = Color.LightBlue;
        }
        private void MetroItemUser_Click(object sender, EventArgs e)
        {
            FrmNewUser frm = new FrmNewUser();
            frm.ShowDialog();
        }

        private void MetroItemProducts_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
        }

        private void MetroItemEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            frm.ShowDialog();
        }

        private void MISellingFoodProducts_Click(object sender, EventArgs e)
        {
            frmSelling frm = new frmSelling();
            frm.ShowDialog();
        }
    }
}
