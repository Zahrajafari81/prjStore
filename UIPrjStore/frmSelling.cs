using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BLprjStore;

namespace UIPrjStore
{
    public partial class frmSelling : DevComponents.DotNetBar.Metro.MetroForm
    {
    
        public frmSelling()
        {
            InitializeComponent();
            timer1.Enabled = true;
            DateTime ODateTime = DateTime.Now;
            PersianCalendar Obj = new PersianCalendar();
            LblDate.Text = Obj.GetYear(ODateTime).ToString("0000") + "/" + Obj.GetMonth(ODateTime).ToString("00") + "/" + Obj.GetDayOfMonth(ODateTime).ToString("00");
            
        }

        BLSellingProduct objSellingP = new BLSellingProduct();
        
        private void ClearTextBox()
        {
            TxtNameProduct.Clear();
            TxtNumber.Clear();
            TxtTypeProduct.Clear();
            TxtUnit.Clear();
            TxtPrice.Clear();
            TxtDarsadTakhfif.Clear();
            TxtLNameEmployee.Clear();
            TxtFNameEmployee.Clear();
            TxtNumberProduct.Clear();
        }
        private bool CheckEmpityTextbox(params TextBox[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Text == "")
                {
                    errorProvider1.SetError(a[i], "بایستی پر یا انتخاب گردد");
                    a[i].Focus();
                    a[i].BackColor = Color.LightBlue;
                    return false;
                }
                else
                {
                    errorProvider1.Clear();
                }
                a[i].BackColor = Color.White;
            }
            return true;
        }
        private bool Kamkardan()
        {
            DataTable dt = new DataTable();
            bool resutl = true;
            for (int i = 0; i < radGridView.Rows.Count; i++)
            {
              dt= objSellingP.SearchNumberProduct(radGridView.Rows[i].Cells["IDProduct"].Value);
              string name=radGridView.Rows[i].Cells["Name"].Value.ToString();
              DataRow dr = dt.Rows[0];
              int numberP = Convert.ToInt32(dr[0]);
              int number = Convert.ToInt32(radGridView.Rows[i].Cells["Number"].Value);
              int UpdateNumber = numberP - number;
                if (UpdateNumber >= 0)
                {
                    objSellingP.Update(radGridView.Rows[i].Cells["IDProduct"].Value, UpdateNumber);
                }
                else
                {
                    MessageBox.Show("محصول  " + name +"موجودی کافی ندارد");
                    resutl = false;
                    break;
                }
            }
            return resutl;
        }
        private void frmSelling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStoreDataSet.TblSelling' table. You can move, or remove it, as needed.
            this.tblSellingTableAdapter.Fill(this.dbStoreDataSet.TblSelling);
            DataTable dt = new DataTable();
            dt= objSellingP.searchMaxID();
            DataRow dr = dt.Rows[0];
            int c = Convert.ToInt32(dr[0]);
            c++;
            TxtIDFactor.Text = c.ToString();
        }
        private void OrderAll()
        {
            int rowCount = radGridView.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                int number = Convert.ToInt32(radGridView.Rows[i].Cells["Number"].Value);
                int price = Convert.ToInt32(radGridView.Rows[i].Cells["Price"].Value);
                double darsadTakfif = Convert.ToInt32(radGridView.Rows[i].Cells["DarsadeTakhfif"].Value);
                double totalprice = (price * number);
                darsadTakfif /= 100;
                radGridView.Rows[i].Cells["FinalPrice"].Value = (totalprice - (price * darsadTakfif));
            }
            rowCount--;
            TxtFinalPrice.Text = radGridView.Rows[rowCount].Cells["FinalPrice"].Value.ToString();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (CheckEmpityTextbox(TxtIDFactor, TxtNameProduct, TxtTypeProduct ,TxtNumber,TxtUnit, TxtPrice, TxtFNameEmployee, TxtLNameEmployee, TxtDarsadTakhfif))
            {
                radGridView.Rows.Add(Convert.ToInt32(TxtIDFactor.Text), Convert.ToInt32(TxtNumberProduct.Text), TxtNameProduct.Text, TxtTypeProduct.Text, TxtNumber.Text, TxtUnit.Text, TxtDarsadTakhfif.Text, TxtPrice.Text.Replace(",", ""), TxtFinalPrice.Text, TxtFNameEmployee.Text, TxtLNameEmployee.Text,LblTime.Text,LblDate.Text);
                OrderAll();
                ClearTextBox();
            }
            BtnSave.Enabled = true;
            BtnRemove.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnAttachInfoProduct_Click(object sender, EventArgs e)
        {
            frmInfoProduct frm = new frmInfoProduct();
            frm.ShowDialog();
            TxtNumberProduct.Text = frm.IdProduct;
            TxtNameProduct.Text = frm.Name;
            TxtNumber.WatermarkText = "تعداد باقی مانده= " + frm.Number;
            TxtTypeProduct.Text = frm.TypeProduct;
            TxtPrice.Text = frm.price;
            TxtUnit.Text = frm.Unit;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string message;
           if (MessageBox.Show("آیا مطمئن به ثبت اطلاعات هستید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                for(int i=0; i<radGridView.Rows.Count;i++)
                {
                    object IDFactor = radGridView.Rows[i].Cells["IDFactor"].Value;
                    object IDProduct= radGridView.Rows[i].Cells["IDProduct"].Value;
                    object NameProduct = radGridView.Rows[i].Cells["Name"].Value;
                    object ProductType = radGridView.Rows[i].Cells["ProductType"].Value;
                    object Number = radGridView.Rows[i].Cells["Number"].Value;
                    object Unit = radGridView.Rows[i].Cells["Unit"].Value;
                    object Price = radGridView.Rows[i].Cells["Price"].Value;
                    object DarsadeTakhfif = radGridView.Rows[i].Cells["DarsadeTakhfif"].Value;
                    object FinalPrice = radGridView.Rows[i].Cells["FinalPrice"].Value;
                    object FNameEmployee = radGridView.Rows[i].Cells["FNameEmployee"].Value;
                    object LNameEmployee = radGridView.Rows[i].Cells["LNameEmployee"].Value;
                    object Date = radGridView.Rows[i].Cells["Time"].Value;
                    object Time = radGridView.Rows[i].Cells["Date"].Value;
                    if (Kamkardan() == true)
                    {
                        objSellingP.Insert(IDFactor, IDProduct, NameProduct, ProductType, Number, Unit, Price, DarsadeTakhfif, FinalPrice, FNameEmployee, LNameEmployee, Time, Date, out message);
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات به دلیل موجود نبودن کالا ثبت نشد");
                        break;
                    }
                    if(i==radGridView.Rows.Count-1)
                    {
                        
                        btnEdit.Enabled = false;
                        BtnSave.Enabled = false;
                        BtnRemove.Enabled = false;
                        BtnPrint.Enabled = true;
                        BtnShowFactor.Enabled = true;
                        MessageBox.Show(message);
                        frmSelling_Load(sender, e);
                        break;
                    }
                }

                ClearTextBox();
                TxtFinalPrice.Clear();
            }

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                radGridView.Rows.RemoveAt(radGridView.CurrentRow.Index);
            }
            if (radGridView.Rows.Count == 0)
            {
                BtnRemove.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }
        private void frmSelling_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void radGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (radGridView.Rows.Count > 0)
            {
                TxtIDFactor.Text = radGridView.CurrentRow.Cells["IDFactor"].Value.ToString();
                TxtNameProduct.Text = radGridView.CurrentRow.Cells["Name"].Value.ToString();
                TxtNumber.Text = radGridView.CurrentRow.Cells["Number"].Value.ToString();
                TxtPrice.Text = radGridView.CurrentRow.Cells["Price"].Value.ToString();
                TxtLNameEmployee.Text = radGridView.CurrentRow.Cells["LNameEmployee"].Value.ToString();
                TxtFNameEmployee.Text = radGridView.CurrentRow.Cells["FNameEmployee"].Value.ToString();
                TxtNumberProduct.Text = radGridView.CurrentRow.Cells["IDProduct"].Value.ToString();
                TxtUnit.Text = radGridView.CurrentRow.Cells["Unit"].Value.ToString();
                TxtDarsadTakhfif.Text = radGridView.CurrentRow.Cells["DarsadeTakhfif"].Value.ToString();
                TxtFinalPrice.Text = radGridView.CurrentRow.Cells["FinalPrice"].Value.ToString();
                TxtTypeProduct.Text = radGridView.CurrentRow.Cells["ProductType"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmpityTextbox(TxtIDFactor, TxtNameProduct, TxtTypeProduct ,TxtNumber,TxtUnit, TxtPrice, TxtFNameEmployee, TxtLNameEmployee, TxtDarsadTakhfif))
            {
                radGridView.CurrentRow.Cells["IDFactor"].Value= TxtIDFactor.Text;
                radGridView.CurrentRow.Cells["Name"].Value = TxtNameProduct.Text;
                radGridView.CurrentRow.Cells["Number"].Value = TxtNumber.Text;
                radGridView.CurrentRow.Cells["Price"].Value = TxtPrice.Text;
                radGridView.CurrentRow.Cells["LNameEmployee"].Value = TxtLNameEmployee.Text;
                radGridView.CurrentRow.Cells["FNameEmployee"].Value = TxtFNameEmployee.Text;
                radGridView.CurrentRow.Cells["IDProduct"].Value= TxtNumberProduct.Text;
                radGridView.CurrentRow.Cells["Unit"].Value = TxtUnit.Text;
                radGridView.CurrentRow.Cells["DarsadeTakhfif"].Value = TxtDarsadTakhfif.Text; 
                radGridView.CurrentRow.Cells["FinalPrice"].Value = TxtFinalPrice.Text;
                radGridView.CurrentRow.Cells["ProductType"].Value = TxtTypeProduct.Text;
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد");
                ClearTextBox();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            int idfactor = Convert.ToInt32(TxtIDFactor.Text);
            idfactor--;
            //frmReport frm = new frmReport(idfactor);
            //frm.ShowDialog();
        }
        private void BtnShowFactor_Click(object sender, EventArgs e)
        {
            //int IDFactor = Convert.ToInt32(TxtIDFactor.Text);
            //IDFactor--;
            int FinalPrice = 0;
            for (int i = 0; i < radGridView.Rows.Count; i++)
            {
                string NameProduct = radGridView.Rows[i].Cells["Name"].Value.ToString();
                string ProductType = radGridView.Rows[i].Cells["ProductType"].Value.ToString();
                int Number = Convert.ToInt32(radGridView.Rows[i].Cells["Number"].Value);
                string Unit = radGridView.Rows[i].Cells["Unit"].Value.ToString();
                int Price = Convert.ToInt32(radGridView.Rows[i].Cells["Price"].Value);
                FinalPrice+= Convert.ToInt32(radGridView.Rows[i].Cells["FinalPrice"].Value);
                //dataSet13.DataTable1.AddDataTable1Row(NameProduct, ProductType, Number, Unit, Price, FinalPrice);
            }

            //stiReport1.RegData(dataSet13.DataTable1);
            //stiReport1.Dictionary.Variables["date"].Value = LblDate.Text;
            //stiReport1.Compile();
            //stiReport1.Show();
            radGridView.Rows.Clear();
        }
    }
}