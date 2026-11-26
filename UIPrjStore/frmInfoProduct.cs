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
    public partial class frmInfoProduct : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmInfoProduct()
        {
            InitializeComponent();
        }
        BLProduct1 objProduct = new BLProduct1();
        private void frmInfoProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objProduct.searchAllInfo();
            radGridView.DataSource = dt;
            radGridView.TableElement.RowHeight = 140;
        }
        public string IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string TypeProduct { get; set; }
        public string Number { get; set; }

        public string Unit { get; set; }

        public string price { get; set; }

        private void radGridView_MouseClick(object sender, MouseEventArgs e)
        {
            IdProduct = radGridView.CurrentRow.Cells["Barcode"].Value.ToString();
            Name = radGridView.CurrentRow.Cells["ProductName"].Value.ToString();
            TypeProduct = radGridView.CurrentRow.Cells["BoothName"].Value.ToString();
            Number = radGridView.CurrentRow.Cells["Number"].Value.ToString();
            Unit = radGridView.CurrentRow.Cells["Unit"].Value.ToString();
            price = radGridView.CurrentRow.Cells["Price"].Value.ToString();
            this.Close();
        }
    }
}
