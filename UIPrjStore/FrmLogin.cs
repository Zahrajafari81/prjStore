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
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public FrmLogin(string name)
        {
            InitializeComponent();
        }

        blLogin objLogin = new blLogin();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید، می خواهید خارج شوید؟", "سوال", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            DataTable dt = objLogin.Login(TxtUserName.Text, TxtPassword.Text);
            if(dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                FrmMain frm = new FrmMain(dr["UserName"].ToString(), dr["Access"].ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه وارد شده است","اخطار",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
