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
    public partial class frmInfoBooth : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmInfoBooth()
        {
            InitializeComponent();
        }
        BLBooth objBooth = new BLBooth();
       
        public string BoothNumber { get; set; }
      
        private void radGridView_MouseClick(object sender, MouseEventArgs e)
        {
            BoothNumber = radGridView.CurrentRow.Cells["BoothNumber"].Value.ToString();
            this.Close();
        }
        private void frmInfoBooth_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objBooth.Search();
            radGridView.DataSource = dt;
        }
    }
}
