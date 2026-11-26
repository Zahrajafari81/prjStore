namespace UIPrjStore
{
    partial class frmInfoProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView
            // 
            this.radGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView.ForeColor = System.Drawing.Color.Black;
            this.radGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView.Location = new System.Drawing.Point(0, 0);
            this.radGridView.Margin = new System.Windows.Forms.Padding(94, 94, 94, 94);
            // 
            // 
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            this.radGridView.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Barcode";
            gridViewTextBoxColumn1.HeaderText = "کد محصول";
            gridViewTextBoxColumn1.Name = "Barcode";
            gridViewTextBoxColumn1.RowSpan = 40;
            gridViewTextBoxColumn1.Width = 381;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ProductName";
            gridViewTextBoxColumn2.HeaderText = "نام محصول";
            gridViewTextBoxColumn2.Name = "ProductName";
            gridViewTextBoxColumn2.RowSpan = 40;
            gridViewTextBoxColumn2.Width = 460;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.FieldName = "Image";
            gridViewImageColumn1.HeaderText = "تصویر";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gridViewImageColumn1.Name = "Image";
            gridViewImageColumn1.RowSpan = 500;
            gridViewImageColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewImageColumn1.Width = 762;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Number";
            gridViewTextBoxColumn3.HeaderText = "تعداد";
            gridViewTextBoxColumn3.Name = "Number";
            gridViewTextBoxColumn3.RowSpan = 40;
            gridViewTextBoxColumn3.Width = 381;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Unit";
            gridViewTextBoxColumn4.HeaderText = "واحد";
            gridViewTextBoxColumn4.Name = "Unit";
            gridViewTextBoxColumn4.RowSpan = 40;
            gridViewTextBoxColumn4.Width = 550;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Price";
            gridViewTextBoxColumn5.HeaderText = "قیمت";
            gridViewTextBoxColumn5.Name = "Price";
            gridViewTextBoxColumn5.RowSpan = 40;
            gridViewTextBoxColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn5.Width = 439;
            gridViewTextBoxColumn6.FieldName = "BoothNumber";
            gridViewTextBoxColumn6.HeaderText = "شماره غرفه";
            gridViewTextBoxColumn6.Name = "BoothNumber";
            gridViewTextBoxColumn6.Width = 451;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "BoothName";
            gridViewTextBoxColumn7.HeaderText = "نام غرفه";
            gridViewTextBoxColumn7.Name = "BoothName";
            gridViewTextBoxColumn7.RowSpan = 40;
            gridViewTextBoxColumn7.Width = 544;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "DateofBirth";
            gridViewTextBoxColumn8.HeaderText = "تاریخ تولید";
            gridViewTextBoxColumn8.Name = "DateofBirth";
            gridViewTextBoxColumn8.RowSpan = 40;
            gridViewTextBoxColumn8.Width = 465;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "ExpirstionDate";
            gridViewTextBoxColumn9.HeaderText = "تاریخ انقضا";
            gridViewTextBoxColumn9.Name = "ExpirstionDate";
            gridViewTextBoxColumn9.RowSpan = 40;
            gridViewTextBoxColumn9.Width = 550;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Garanty";
            gridViewTextBoxColumn10.HeaderText = "گارانتی";
            gridViewTextBoxColumn10.Name = "Garanty";
            gridViewTextBoxColumn10.RowSpan = 40;
            gridViewTextBoxColumn10.Width = 810;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "NameSherkateSazandeh";
            gridViewTextBoxColumn11.HeaderText = "نام کارخانه سازنده";
            gridViewTextBoxColumn11.Name = "NameSherkateSazandeh";
            gridViewTextBoxColumn11.RowSpan = 40;
            gridViewTextBoxColumn11.Width = 850;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewImageColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            sortDescriptor1.PropertyName = "Price";
            this.radGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView.Name = "radGridView";
            this.radGridView.ReadOnly = true;
            this.radGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView.ShowGroupPanel = false;
            this.radGridView.Size = new System.Drawing.Size(1461, 681);
            this.radGridView.TabIndex = 2;
            this.radGridView.ThemeName = "Breeze";
            this.radGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radGridView_MouseClick);
            // 
            // frmInfoProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 681);
            this.Controls.Add(this.radGridView);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInfoProduct";
            this.Text = "نمایش اطلاعات محصول";
            this.Load += new System.EventHandler(this.frmInfoProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
    }
}