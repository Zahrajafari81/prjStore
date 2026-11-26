namespace UIPrjStore
{
    partial class frmBooth
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtSearchNameBooth = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LblSearchNameBooth = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new DevComponents.DotNetBar.ButtonX();
            this.BtnDelete = new DevComponents.DotNetBar.ButtonX();
            this.BtnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.TxtBoothName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtBoothNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblNameBooth = new DevComponents.DotNetBar.LabelX();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.GrpSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtSearchNameBooth
            // 
            this.TxtSearchNameBooth.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtSearchNameBooth.Border.Class = "TextBoxBorder";
            this.TxtSearchNameBooth.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtSearchNameBooth.DisabledBackColor = System.Drawing.Color.White;
            this.TxtSearchNameBooth.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchNameBooth.Location = new System.Drawing.Point(22, 25);
            this.TxtSearchNameBooth.Name = "TxtSearchNameBooth";
            this.TxtSearchNameBooth.PreventEnterBeep = true;
            this.TxtSearchNameBooth.Size = new System.Drawing.Size(235, 29);
            this.TxtSearchNameBooth.TabIndex = 1;
            this.TxtSearchNameBooth.TextChanged += new System.EventHandler(this.TxtSearchNameBooth_TextChanged);
            // 
            // LblSearchNameBooth
            // 
            // 
            // 
            // 
            this.LblSearchNameBooth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblSearchNameBooth.Location = new System.Drawing.Point(263, 25);
            this.LblSearchNameBooth.Name = "LblSearchNameBooth";
            this.LblSearchNameBooth.Size = new System.Drawing.Size(75, 23);
            this.LblSearchNameBooth.TabIndex = 0;
            this.LblSearchNameBooth.Text = "نام غرفه";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GrpSearch);
            this.groupBox3.Controls.Add(this.BtnSearch);
            this.groupBox3.Controls.Add(this.BtnDelete);
            this.groupBox3.Controls.Add(this.BtnUpdate);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(27, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(771, 126);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "نوع عملیات";
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.TxtSearchNameBooth);
            this.GrpSearch.Controls.Add(this.LblSearchNameBooth);
            this.GrpSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSearch.Location = new System.Drawing.Point(22, 30);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrpSearch.Size = new System.Drawing.Size(363, 75);
            this.GrpSearch.TabIndex = 4;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Visible = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSearch.Location = new System.Drawing.Point(400, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnSearch.Size = new System.Drawing.Size(80, 67);
            this.BtnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSearch.Symbol = "";
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Tooltip = "جستجو";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnDelete.Location = new System.Drawing.Point(486, 38);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnDelete.Size = new System.Drawing.Size(81, 67);
            this.BtnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnDelete.Symbol = "";
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Tooltip = "حذف";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnUpdate.Location = new System.Drawing.Point(573, 38);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnUpdate.Size = new System.Drawing.Size(79, 67);
            this.BtnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnUpdate.Symbol = "";
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Tooltip = "ویرایش";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Location = new System.Drawing.Point(658, 38);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnSave.Size = new System.Drawing.Size(79, 67);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.Symbol = "";
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Tooltip = "ثبت";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(655, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(109, 42);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "شماره غرفه";
            // 
            // TxtBoothName
            // 
            this.TxtBoothName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtBoothName.Border.Class = "TextBoxBorder";
            this.TxtBoothName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtBoothName.DisabledBackColor = System.Drawing.Color.White;
            this.TxtBoothName.ForeColor = System.Drawing.Color.Black;
            this.TxtBoothName.Location = new System.Drawing.Point(37, 45);
            this.TxtBoothName.Name = "TxtBoothName";
            this.TxtBoothName.PreventEnterBeep = true;
            this.TxtBoothName.Size = new System.Drawing.Size(226, 41);
            this.TxtBoothName.TabIndex = 3;
            // 
            // TxtBoothNumber
            // 
            this.TxtBoothNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtBoothNumber.Border.Class = "TextBoxBorder";
            this.TxtBoothNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtBoothNumber.DisabledBackColor = System.Drawing.Color.White;
            this.TxtBoothNumber.ForeColor = System.Drawing.Color.Black;
            this.TxtBoothNumber.Location = new System.Drawing.Point(400, 44);
            this.TxtBoothNumber.Name = "TxtBoothNumber";
            this.TxtBoothNumber.PreventEnterBeep = true;
            this.TxtBoothNumber.Size = new System.Drawing.Size(235, 41);
            this.TxtBoothNumber.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBoothName);
            this.groupBox2.Controls.Add(this.TxtBoothNumber);
            this.groupBox2.Controls.Add(this.LblNameBooth);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(27, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(770, 115);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وارد کردن اطلاعات";
            // 
            // LblNameBooth
            // 
            // 
            // 
            // 
            this.LblNameBooth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblNameBooth.Location = new System.Drawing.Point(269, 45);
            this.LblNameBooth.Name = "LblNameBooth";
            this.LblNameBooth.Size = new System.Drawing.Size(94, 41);
            this.LblNameBooth.TabIndex = 1;
            this.LblNameBooth.Text = "نام غرفه";
            // 
            // radGridView
            // 
            this.radGridView.Location = new System.Drawing.Point(22, 45);
            this.radGridView.Margin = new System.Windows.Forms.Padding(8);
            // 
            // 
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.FieldName = "BoothNumber";
            gridViewTextBoxColumn1.HeaderText = "شماره غرفه";
            gridViewTextBoxColumn1.Name = "BoothNumber";
            gridViewTextBoxColumn1.Width = 250;
            gridViewTextBoxColumn2.FieldName = "BoothName";
            gridViewTextBoxColumn2.HeaderText = "نام غرفه";
            gridViewTextBoxColumn2.Name = "BoothName";
            gridViewTextBoxColumn2.Width = 250;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.radGridView.MasterTemplate.EnableGrouping = false;
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView.Name = "radGridView";
            this.radGridView.Padding = new System.Windows.Forms.Padding(1);
            this.radGridView.ReadOnly = true;
            this.radGridView.Size = new System.Drawing.Size(726, 202);
            this.radGridView.TabIndex = 0;
            this.radGridView.ThemeName = "Fluent";
            this.radGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radGridView_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGridView);
            this.groupBox1.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(771, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نمایش اطلاعات";
            // 
            // frmBooth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(809, 540);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "غرفه";
            this.Load += new System.EventHandler(this.frmBooth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.GrpSearch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GrpSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSearchNameBooth;
        private DevComponents.DotNetBar.LabelX LblSearchNameBooth;
        private DevComponents.DotNetBar.ButtonX BtnSearch;
        private DevComponents.DotNetBar.ButtonX BtnDelete;
        private DevComponents.DotNetBar.ButtonX BtnUpdate;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtBoothName;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtBoothNumber;
        private DevComponents.DotNetBar.LabelX LblNameBooth;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView radGridView;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}