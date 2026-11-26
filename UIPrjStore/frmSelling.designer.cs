namespace UIPrjStore
{
    partial class frmSelling
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelling));
            this.TxtLNameEmployee = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LablFNameEmployee = new DevComponents.DotNetBar.LabelX();
            this.TxtFNameEmployee = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LblNameEmployee = new DevComponents.DotNetBar.LabelX();
            this.BtnOk = new DevComponents.DotNetBar.ButtonX();
            this.LblNumber = new DevComponents.DotNetBar.LabelX();
            this.BtnRemove = new DevComponents.DotNetBar.ButtonX();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.LblDate = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.LblTime = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.TxtTypeProduct = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAttachInfoProduct = new DevComponents.DotNetBar.ButtonX();
            this.TxtNumberProduct = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TxtNameProduct = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtIDFactor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BtnShowFactor = new DevComponents.DotNetBar.ButtonX();
            this.BtnPrint = new DevComponents.DotNetBar.ButtonX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.TxtFinalPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDarsadTakhfif = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LblFinalPrice = new DevComponents.DotNetBar.LabelX();
            this.LblPrice = new DevComponents.DotNetBar.LabelX();
            this.LblDarsadTakhfif = new DevComponents.DotNetBar.LabelX();
            this.LblUnit = new DevComponents.DotNetBar.LabelX();
            this.LblTypeProduct = new DevComponents.DotNetBar.LabelX();
            this.LblNameProduct = new DevComponents.DotNetBar.LabelX();
            this.LblIDFactor = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.dsSellingProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.stiReportDataSource1 = new Stimulsoft.Report.Design.StiReportDataSource("tblSellingBindingSource", this.tblSellingBindingSource);
            this.tblSellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbStoreDataSet = new UIPrjStore.DbStoreDataSet();
            this.tblSellingTableAdapter = new UIPrjStore.DbStoreDataSetTableAdapters.TblSellingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSellingProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLNameEmployee
            // 
            this.TxtLNameEmployee.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtLNameEmployee.Border.Class = "TextBoxBorder";
            this.TxtLNameEmployee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtLNameEmployee.DisabledBackColor = System.Drawing.Color.White;
            this.TxtLNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.TxtLNameEmployee.Location = new System.Drawing.Point(86, 50);
            this.TxtLNameEmployee.Name = "TxtLNameEmployee";
            this.TxtLNameEmployee.PreventEnterBeep = true;
            this.TxtLNameEmployee.Size = new System.Drawing.Size(183, 29);
            this.TxtLNameEmployee.TabIndex = 27;
            // 
            // LablFNameEmployee
            // 
            this.LablFNameEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LablFNameEmployee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LablFNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.LablFNameEmployee.Location = new System.Drawing.Point(301, 50);
            this.LablFNameEmployee.Name = "LablFNameEmployee";
            this.LablFNameEmployee.Size = new System.Drawing.Size(133, 23);
            this.LablFNameEmployee.TabIndex = 28;
            this.LablFNameEmployee.Text = "نام خانوادگی کارمند";
            // 
            // TxtFNameEmployee
            // 
            this.TxtFNameEmployee.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtFNameEmployee.Border.Class = "TextBoxBorder";
            this.TxtFNameEmployee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFNameEmployee.DisabledBackColor = System.Drawing.Color.White;
            this.TxtFNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.TxtFNameEmployee.Location = new System.Drawing.Point(504, 212);
            this.TxtFNameEmployee.Name = "TxtFNameEmployee";
            this.TxtFNameEmployee.PreventEnterBeep = true;
            this.TxtFNameEmployee.Size = new System.Drawing.Size(192, 29);
            this.TxtFNameEmployee.TabIndex = 26;
            // 
            // LblNameEmployee
            // 
            this.LblNameEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblNameEmployee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.LblNameEmployee.Location = new System.Drawing.Point(695, 218);
            this.LblNameEmployee.Name = "LblNameEmployee";
            this.LblNameEmployee.Size = new System.Drawing.Size(139, 23);
            this.LblNameEmployee.TabIndex = 25;
            this.LblNameEmployee.Text = "نام کارمند ثبت کننده";
            // 
            // BtnOk
            // 
            this.BtnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnOk.Location = new System.Drawing.Point(440, 218);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnOk.Size = new System.Drawing.Size(58, 64);
            this.BtnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnOk.Symbol = "";
            this.BtnOk.TabIndex = 24;
            this.BtnOk.Tooltip = "تایید";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblNumber
            // 
            this.LblNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblNumber.ForeColor = System.Drawing.Color.Black;
            this.LblNumber.Location = new System.Drawing.Point(728, 46);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(75, 23);
            this.LblNumber.TabIndex = 4;
            this.LblNumber.Text = "تعداد";
            // 
            // BtnRemove
            // 
            this.BtnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(133, 218);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnRemove.Size = new System.Drawing.Size(58, 56);
            this.BtnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnRemove.Symbol = "";
            this.BtnRemove.TabIndex = 29;
            this.BtnRemove.Tooltip = "پاک کردن اطلاعات وارد شده ";
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(8132, 69);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(60, 60, 60, 60);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(62, 22);
            this.radLabel2.TabIndex = 13;
            this.radLabel2.Text = "تاریخ ثبت";
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.Black;
            this.LblDate.Location = new System.Drawing.Point(426, 1);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(129, 23);
            this.LblDate.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(15315, 908);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(60, 60, 60, 60);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(33, 22);
            this.radLabel1.TabIndex = 14;
            this.radLabel1.Text = "زمان";
            // 
            // LblTime
            // 
            this.LblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.Black;
            this.LblTime.Location = new System.Drawing.Point(641, 1);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(125, 23);
            this.LblTime.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.TxtTypeProduct);
            this.groupBox2.Controls.Add(this.TxtNumber);
            this.groupBox2.Controls.Add(this.btnAttachInfoProduct);
            this.groupBox2.Controls.Add(this.TxtNumberProduct);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.TxtNameProduct);
            this.groupBox2.Controls.Add(this.TxtIDFactor);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.BtnRemove);
            this.groupBox2.Controls.Add(this.TxtLNameEmployee);
            this.groupBox2.Controls.Add(this.LablFNameEmployee);
            this.groupBox2.Controls.Add(this.TxtFNameEmployee);
            this.groupBox2.Controls.Add(this.LblNameEmployee);
            this.groupBox2.Controls.Add(this.BtnOk);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.BtnShowFactor);
            this.groupBox2.Controls.Add(this.BtnPrint);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.TxtFinalPrice);
            this.groupBox2.Controls.Add(this.TxtDarsadTakhfif);
            this.groupBox2.Controls.Add(this.TxtPrice);
            this.groupBox2.Controls.Add(this.TxtUnit);
            this.groupBox2.Controls.Add(this.LblFinalPrice);
            this.groupBox2.Controls.Add(this.LblPrice);
            this.groupBox2.Controls.Add(this.LblDarsadTakhfif);
            this.groupBox2.Controls.Add(this.LblUnit);
            this.groupBox2.Controls.Add(this.LblNumber);
            this.groupBox2.Controls.Add(this.LblTypeProduct);
            this.groupBox2.Controls.Add(this.LblNameProduct);
            this.groupBox2.Controls.Add(this.LblIDFactor);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1195, 305);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وارد کردن اطلاعات";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(361, 218);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnEdit.Size = new System.Drawing.Size(61, 64);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.Symbol = "";
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Tooltip = "ویرایش ";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TxtTypeProduct
            // 
            this.TxtTypeProduct.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtTypeProduct.Border.Class = "TextBoxBorder";
            this.TxtTypeProduct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtTypeProduct.DisabledBackColor = System.Drawing.Color.White;
            this.TxtTypeProduct.Enabled = false;
            this.TxtTypeProduct.ForeColor = System.Drawing.Color.Black;
            this.TxtTypeProduct.Location = new System.Drawing.Point(859, 212);
            this.TxtTypeProduct.Name = "TxtTypeProduct";
            this.TxtTypeProduct.PreventEnterBeep = true;
            this.TxtTypeProduct.Size = new System.Drawing.Size(220, 29);
            this.TxtTypeProduct.TabIndex = 41;
            // 
            // TxtNumber
            // 
            this.TxtNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtNumber.Border.Class = "TextBoxBorder";
            this.TxtNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNumber.DisabledBackColor = System.Drawing.Color.White;
            this.TxtNumber.ForeColor = System.Drawing.Color.Black;
            this.TxtNumber.Location = new System.Drawing.Point(504, 44);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.PreventEnterBeep = true;
            this.TxtNumber.Size = new System.Drawing.Size(192, 29);
            this.TxtNumber.TabIndex = 40;
            // 
            // btnAttachInfoProduct
            // 
            this.btnAttachInfoProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAttachInfoProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAttachInfoProduct.Location = new System.Drawing.Point(842, 139);
            this.btnAttachInfoProduct.Name = "btnAttachInfoProduct";
            this.btnAttachInfoProduct.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAttachInfoProduct.Size = new System.Drawing.Size(52, 54);
            this.btnAttachInfoProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAttachInfoProduct.Symbol = "";
            this.btnAttachInfoProduct.TabIndex = 39;
            this.btnAttachInfoProduct.Tooltip = "دسترسی به اطلاعات محصول";
            this.btnAttachInfoProduct.Click += new System.EventHandler(this.btnAttachInfoProduct_Click);
            // 
            // TxtNumberProduct
            // 
            this.TxtNumberProduct.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtNumberProduct.Border.Class = "TextBoxBorder";
            this.TxtNumberProduct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNumberProduct.DisabledBackColor = System.Drawing.Color.White;
            this.TxtNumberProduct.Enabled = false;
            this.TxtNumberProduct.ForeColor = System.Drawing.Color.Black;
            this.TxtNumberProduct.Location = new System.Drawing.Point(910, 159);
            this.TxtNumberProduct.Name = "TxtNumberProduct";
            this.TxtNumberProduct.PreventEnterBeep = true;
            this.TxtNumberProduct.Size = new System.Drawing.Size(166, 29);
            this.TxtNumberProduct.TabIndex = 38;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(1079, 156);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "شماره محصول";
            // 
            // TxtNameProduct
            // 
            this.TxtNameProduct.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtNameProduct.Border.Class = "TextBoxBorder";
            this.TxtNameProduct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNameProduct.DisabledBackColor = System.Drawing.Color.White;
            this.TxtNameProduct.Enabled = false;
            this.TxtNameProduct.ForeColor = System.Drawing.Color.Black;
            this.TxtNameProduct.Location = new System.Drawing.Point(859, 108);
            this.TxtNameProduct.Name = "TxtNameProduct";
            this.TxtNameProduct.PreventEnterBeep = true;
            this.TxtNameProduct.Size = new System.Drawing.Size(220, 29);
            this.TxtNameProduct.TabIndex = 34;
            // 
            // TxtIDFactor
            // 
            this.TxtIDFactor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtIDFactor.Border.Class = "TextBoxBorder";
            this.TxtIDFactor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtIDFactor.DisabledBackColor = System.Drawing.Color.White;
            this.TxtIDFactor.Enabled = false;
            this.TxtIDFactor.ForeColor = System.Drawing.Color.Black;
            this.TxtIDFactor.Location = new System.Drawing.Point(859, 54);
            this.TxtIDFactor.Name = "TxtIDFactor";
            this.TxtIDFactor.PreventEnterBeep = true;
            this.TxtIDFactor.Size = new System.Drawing.Size(220, 29);
            this.TxtIDFactor.TabIndex = 33;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(1079, 215);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(103, 23);
            this.labelX3.TabIndex = 32;
            this.labelX3.Text = "نوع محصول";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(1078, 103);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(107, 30);
            this.labelX4.TabIndex = 31;
            this.labelX4.Text = "نام محصول";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(1101, 53);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(84, 23);
            this.labelX5.TabIndex = 30;
            this.labelX5.Text = "شماره فاکتور";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(1354, 153);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 23);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "شماره محصول";
            // 
            // BtnShowFactor
            // 
            this.BtnShowFactor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnShowFactor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnShowFactor.Enabled = false;
            this.BtnShowFactor.Location = new System.Drawing.Point(62, 218);
            this.BtnShowFactor.Name = "BtnShowFactor";
            this.BtnShowFactor.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnShowFactor.Size = new System.Drawing.Size(56, 55);
            this.BtnShowFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnShowFactor.Symbol = "";
            this.BtnShowFactor.TabIndex = 21;
            this.BtnShowFactor.Tooltip = "نمایش گزارش ";
            this.BtnShowFactor.Click += new System.EventHandler(this.BtnShowFactor_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnPrint.Enabled = false;
            this.BtnPrint.Location = new System.Drawing.Point(208, 214);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnPrint.Size = new System.Drawing.Size(64, 67);
            this.BtnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnPrint.Symbol = "";
            this.BtnPrint.TabIndex = 18;
            this.BtnPrint.Tooltip = "صدور فاکتور بر حسب شماره فاکتور";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(285, 217);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnSave.Size = new System.Drawing.Size(58, 64);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.Symbol = "";
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Tooltip = "ثبت";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtFinalPrice
            // 
            this.TxtFinalPrice.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtFinalPrice.Border.Class = "TextBoxBorder";
            this.TxtFinalPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtFinalPrice.DisabledBackColor = System.Drawing.Color.White;
            this.TxtFinalPrice.Enabled = false;
            this.TxtFinalPrice.ForeColor = System.Drawing.Color.Black;
            this.TxtFinalPrice.Location = new System.Drawing.Point(90, 159);
            this.TxtFinalPrice.Name = "TxtFinalPrice";
            this.TxtFinalPrice.PreventEnterBeep = true;
            this.TxtFinalPrice.Size = new System.Drawing.Size(177, 29);
            this.TxtFinalPrice.TabIndex = 16;
            // 
            // TxtDarsadTakhfif
            // 
            this.TxtDarsadTakhfif.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtDarsadTakhfif.Border.Class = "TextBoxBorder";
            this.TxtDarsadTakhfif.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDarsadTakhfif.DisabledBackColor = System.Drawing.Color.White;
            this.TxtDarsadTakhfif.ForeColor = System.Drawing.Color.Black;
            this.TxtDarsadTakhfif.Location = new System.Drawing.Point(90, 103);
            this.TxtDarsadTakhfif.Name = "TxtDarsadTakhfif";
            this.TxtDarsadTakhfif.PreventEnterBeep = true;
            this.TxtDarsadTakhfif.Size = new System.Drawing.Size(177, 29);
            this.TxtDarsadTakhfif.TabIndex = 15;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtPrice.Border.Class = "TextBoxBorder";
            this.TxtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtPrice.DisabledBackColor = System.Drawing.Color.White;
            this.TxtPrice.Enabled = false;
            this.TxtPrice.ForeColor = System.Drawing.Color.Black;
            this.TxtPrice.Location = new System.Drawing.Point(504, 156);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PreventEnterBeep = true;
            this.TxtPrice.Size = new System.Drawing.Size(192, 29);
            this.TxtPrice.TabIndex = 14;
            // 
            // TxtUnit
            // 
            this.TxtUnit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtUnit.Border.Class = "TextBoxBorder";
            this.TxtUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtUnit.DisabledBackColor = System.Drawing.Color.White;
            this.TxtUnit.Enabled = false;
            this.TxtUnit.ForeColor = System.Drawing.Color.Black;
            this.TxtUnit.Location = new System.Drawing.Point(504, 103);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.PreventEnterBeep = true;
            this.TxtUnit.Size = new System.Drawing.Size(192, 29);
            this.TxtUnit.TabIndex = 13;
            // 
            // LblFinalPrice
            // 
            this.LblFinalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblFinalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblFinalPrice.ForeColor = System.Drawing.Color.Black;
            this.LblFinalPrice.Location = new System.Drawing.Point(329, 162);
            this.LblFinalPrice.Name = "LblFinalPrice";
            this.LblFinalPrice.Size = new System.Drawing.Size(91, 23);
            this.LblFinalPrice.TabIndex = 8;
            this.LblFinalPrice.Text = "قیمت نهایی";
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblPrice.ForeColor = System.Drawing.Color.Black;
            this.LblPrice.Location = new System.Drawing.Point(728, 159);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(75, 23);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "قیمت";
            // 
            // LblDarsadTakhfif
            // 
            this.LblDarsadTakhfif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblDarsadTakhfif.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblDarsadTakhfif.ForeColor = System.Drawing.Color.Black;
            this.LblDarsadTakhfif.Location = new System.Drawing.Point(303, 101);
            this.LblDarsadTakhfif.Name = "LblDarsadTakhfif";
            this.LblDarsadTakhfif.Size = new System.Drawing.Size(119, 23);
            this.LblDarsadTakhfif.TabIndex = 6;
            this.LblDarsadTakhfif.Text = "درصد تخفیف";
            // 
            // LblUnit
            // 
            this.LblUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblUnit.ForeColor = System.Drawing.Color.Black;
            this.LblUnit.Location = new System.Drawing.Point(728, 103);
            this.LblUnit.Name = "LblUnit";
            this.LblUnit.Size = new System.Drawing.Size(75, 23);
            this.LblUnit.TabIndex = 5;
            this.LblUnit.Text = "واحد";
            // 
            // LblTypeProduct
            // 
            this.LblTypeProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblTypeProduct.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblTypeProduct.ForeColor = System.Drawing.Color.Black;
            this.LblTypeProduct.Location = new System.Drawing.Point(1354, 212);
            this.LblTypeProduct.Name = "LblTypeProduct";
            this.LblTypeProduct.Size = new System.Drawing.Size(103, 23);
            this.LblTypeProduct.TabIndex = 3;
            this.LblTypeProduct.Text = "نوع محصول";
            // 
            // LblNameProduct
            // 
            this.LblNameProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblNameProduct.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblNameProduct.ForeColor = System.Drawing.Color.Black;
            this.LblNameProduct.Location = new System.Drawing.Point(1353, 100);
            this.LblNameProduct.Name = "LblNameProduct";
            this.LblNameProduct.Size = new System.Drawing.Size(107, 30);
            this.LblNameProduct.TabIndex = 1;
            this.LblNameProduct.Text = "نام محصول";
            // 
            // LblIDFactor
            // 
            this.LblIDFactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblIDFactor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblIDFactor.ForeColor = System.Drawing.Color.Black;
            this.LblIDFactor.Location = new System.Drawing.Point(1331, 50);
            this.LblIDFactor.Name = "LblIDFactor";
            this.LblIDFactor.Size = new System.Drawing.Size(129, 23);
            this.LblIDFactor.TabIndex = 0;
            this.LblIDFactor.Text = "شماره فاکتور";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radGridView);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-272, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1467, 360);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radGridView
            // 
            this.radGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView.ForeColor = System.Drawing.Color.Black;
            this.radGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView.Location = new System.Drawing.Point(324, 56);
            this.radGridView.Margin = new System.Windows.Forms.Padding(60, 60, 60, 60);
            // 
            // 
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            this.radGridView.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.DataType = typeof(int);
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "IDFactor";
            gridViewTextBoxColumn1.HeaderText = "شماره فاکتور";
            gridViewTextBoxColumn1.Name = "IDFactor";
            gridViewTextBoxColumn1.Width = 595;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "IDProduct";
            gridViewTextBoxColumn2.HeaderText = "شماره محصول";
            gridViewTextBoxColumn2.Name = "IDProduct";
            gridViewTextBoxColumn2.Width = 1190;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "NameProducts";
            gridViewTextBoxColumn3.HeaderText = "نام محصول";
            gridViewTextBoxColumn3.Name = "NameProducts";
            gridViewTextBoxColumn3.Width = 1488;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ProductType";
            gridViewTextBoxColumn4.HeaderText = "نوع محصول";
            gridViewTextBoxColumn4.Name = "ProductType";
            gridViewTextBoxColumn4.Width = 1488;
            gridViewTextBoxColumn5.DataType = typeof(int);
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Number";
            gridViewTextBoxColumn5.HeaderText = "تعداد";
            gridViewTextBoxColumn5.Name = "Number";
            gridViewTextBoxColumn5.Width = 1488;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Unit";
            gridViewTextBoxColumn6.HeaderText = "واحد";
            gridViewTextBoxColumn6.Name = "Unit";
            gridViewTextBoxColumn6.Width = 1452;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "DarsadeTakhfif";
            gridViewTextBoxColumn7.HeaderText = "در صد تخفیف";
            gridViewTextBoxColumn7.Name = "DarsadeTakhfif";
            gridViewTextBoxColumn7.Width = 1524;
            gridViewTextBoxColumn8.DataType = typeof(int);
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Price";
            gridViewTextBoxColumn8.HeaderText = "قیمت";
            gridViewTextBoxColumn8.Name = "Price";
            gridViewTextBoxColumn8.Width = 1525;
            gridViewTextBoxColumn9.DataType = typeof(int);
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "FinalPrice";
            gridViewTextBoxColumn9.HeaderText = "قیمت نهایی";
            gridViewTextBoxColumn9.Name = "FinalPrice";
            gridViewTextBoxColumn9.Width = 1190;
            gridViewTextBoxColumn10.FieldName = "FNameEmployee";
            gridViewTextBoxColumn10.HeaderText = "نام کارمند";
            gridViewTextBoxColumn10.Name = "FNameEmployee";
            gridViewTextBoxColumn10.Width = 1430;
            gridViewTextBoxColumn11.FieldName = "LNameEmployee";
            gridViewTextBoxColumn11.HeaderText = "نام خانوادگی کارمند";
            gridViewTextBoxColumn11.Name = "LNameEmployee";
            gridViewTextBoxColumn11.Width = 1190;
            gridViewTextBoxColumn12.FieldName = "Time";
            gridViewTextBoxColumn12.HeaderText = "ساعت";
            gridViewTextBoxColumn12.Name = "Time";
            gridViewTextBoxColumn12.Width = 476;
            gridViewTextBoxColumn13.FieldName = "Date";
            gridViewTextBoxColumn13.HeaderText = "تاریخ";
            gridViewTextBoxColumn13.Name = "Date";
            gridViewTextBoxColumn13.Width = 476;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.radGridView.MasterTemplate.EnableGrouping = false;
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView.Name = "radGridView";
            this.radGridView.ReadOnly = true;
            this.radGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView.Size = new System.Drawing.Size(1546, 360);
            this.radGridView.TabIndex = 4;
            this.radGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radGridView_MouseClick);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.HttpHeadersContainer = null;
            this.stiReport1.Key = "5a4b9b7f72264b06ba9e7c7fcbbf6b00";
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.stiReport1.ReportGuid = "daedd3de7926426988e6f2827205811f";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.tblSellingBindingSource;
            this.stiReportDataSource1.Name = "tblSellingBindingSource";
            // 
            // tblSellingBindingSource
            // 
            this.tblSellingBindingSource.DataMember = "TblSelling";
            this.tblSellingBindingSource.DataSource = this.dbStoreDataSet;
            // 
            // dbStoreDataSet
            // 
            this.dbStoreDataSet.DataSetName = "DbStoreDataSet";
            this.dbStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSellingTableAdapter
            // 
            this.tblSellingTableAdapter.ClearBeforeFill = true;
            // 
            // frmSelling
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1216, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بخش فروش";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelling_FormClosed);
            this.Load += new System.EventHandler(this.frmSelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSellingProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dsSellingProductsBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtLNameEmployee;
        private DevComponents.DotNetBar.LabelX LablFNameEmployee;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtFNameEmployee;
        private DevComponents.DotNetBar.LabelX LblNameEmployee;
        private DevComponents.DotNetBar.ButtonX BtnOk;
        private DevComponents.DotNetBar.LabelX LblNumber;
        private DevComponents.DotNetBar.ButtonX BtnRemove;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private DevComponents.DotNetBar.LabelX LblDate;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private DevComponents.DotNetBar.LabelX LblTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BtnShowFactor;
        private DevComponents.DotNetBar.ButtonX BtnPrint;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtFinalPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDarsadTakhfif;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtUnit;
        private DevComponents.DotNetBar.LabelX LblFinalPrice;
        private DevComponents.DotNetBar.LabelX LblPrice;
        private DevComponents.DotNetBar.LabelX LblDarsadTakhfif;
        private DevComponents.DotNetBar.LabelX LblUnit;
        private DevComponents.DotNetBar.LabelX LblTypeProduct;
        private DevComponents.DotNetBar.LabelX LblNameProduct;
        private DevComponents.DotNetBar.LabelX LblIDFactor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView radGridView;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNumberProduct;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNameProduct;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtIDFactor;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnAttachInfoProduct;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtTypeProduct;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private System.Windows.Forms.BindingSource dataSet12BindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Stimulsoft.Report.StiReport stiReport1;
        private DbStoreDataSet dbStoreDataSet;
        private System.Windows.Forms.BindingSource tblSellingBindingSource;
        private DbStoreDataSetTableAdapters.TblSellingTableAdapter tblSellingTableAdapter;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
    }
}