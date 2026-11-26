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
    public partial class frmInfoEmployee : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmInfoEmployee()
        {
            InitializeComponent();
        }
       
        BLEmployee objclassemplooye = new BLEmployee();
        public string id { get; set; }
        public string name { get; set; }

        private void frmInfoEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objclassemplooye.Search();
            radGridView1.DataSource = dt;
        }
        
        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            id = radGridView1.CurrentRow.Cells["ID"].Value.ToString();
            name = radGridView1.CurrentRow.Cells["FName"].Value + " " + radGridView1.CurrentRow.Cells["LName"].Value;
            this.Close();
        }






    }
}
