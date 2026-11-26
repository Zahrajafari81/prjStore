namespace UIPrjStore
{
    partial class FrmNewUser
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.TxtSearchUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.BtnSearch = new DevComponents.DotNetBar.ButtonX();
            this.BtnClean = new DevComponents.DotNetBar.ButtonX();
            this.BtnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDropAccess = new Telerik.WinControls.UI.RadDropDownList();
            this.btnAttach = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPersonnelCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LblAccess = new DevComponents.DotNetBar.LabelX();
            this.LblPassword = new DevComponents.DotNetBar.LabelX();
            this.LblUserName = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.tblLoginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.GrpSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropAccess)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.GrpSearch);
            this.groupBox3.Controls.Add(this.BtnSearch);
            this.groupBox3.Controls.Add(this.BtnClean);
            this.groupBox3.Controls.Add(this.BtnUpdate);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(897, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // GrpSearch
            // 
            this.GrpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrpSearch.Controls.Add(this.TxtSearchUserName);
            this.GrpSearch.Controls.Add(this.labelX4);
            this.GrpSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSearch.ForeColor = System.Drawing.Color.Black;
            this.GrpSearch.Location = new System.Drawing.Point(59, 21);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(373, 64);
            this.GrpSearch.TabIndex = 11;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Visible = false;
            // 
            // TxtSearchUserName
            // 
            this.TxtSearchUserName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtSearchUserName.Border.Class = "TextBoxBorder";
            this.TxtSearchUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtSearchUserName.DisabledBackColor = System.Drawing.Color.White;
            this.TxtSearchUserName.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchUserName.Location = new System.Drawing.Point(21, 22);
            this.TxtSearchUserName.Name = "TxtSearchUserName";
            this.TxtSearchUserName.PreventEnterBeep = true;
            this.TxtSearchUserName.Size = new System.Drawing.Size(239, 27);
            this.TxtSearchUserName.TabIndex = 15;
            this.TxtSearchUserName.TextChanged += new System.EventHandler(this.TxtSearchUserName_TextChanged);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(284, 22);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "نام کاربری";
            // 
            // BtnSearch
            // 
            this.BtnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSearch.Location = new System.Drawing.Point(529, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnSearch.Size = new System.Drawing.Size(68, 65);
            this.BtnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSearch.Symbol = "";
            this.BtnSearch.TabIndex = 13;
            this.BtnSearch.Tooltip = "جستجو";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnClean.Location = new System.Drawing.Point(619, 21);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnClean.Size = new System.Drawing.Size(72, 65);
            this.BtnClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnClean.Symbol = "";
            this.BtnClean.TabIndex = 12;
            this.BtnClean.Tooltip = "پاک کردن متن";
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnUpdate.Location = new System.Drawing.Point(716, 21);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnUpdate.Size = new System.Drawing.Size(65, 65);
            this.BtnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnUpdate.Symbol = "";
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Tooltip = "ویرایش";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Location = new System.Drawing.Point(808, 20);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnSave.Size = new System.Drawing.Size(70, 65);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.Symbol = "";
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Tooltip = "ثبت";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.radDropAccess);
            this.groupBox2.Controls.Add(this.btnAttach);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.txtPersonnelCode);
            this.groupBox2.Controls.Add(this.TxtPassword);
            this.groupBox2.Controls.Add(this.TxtUserName);
            this.groupBox2.Controls.Add(this.LblAccess);
            this.groupBox2.Controls.Add(this.LblPassword);
            this.groupBox2.Controls.Add(this.LblUserName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(891, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وارد کردن اطلاعات";
            // 
            // radDropAccess
            // 
            this.radDropAccess.DropDownAnimationEnabled = true;
            this.radDropAccess.DropDownHeight = 166;
            this.radDropAccess.ItemHeight = 29;
            radListDataItem5.Selected = true;
            radListDataItem5.Text = "بخش فروش";
            radListDataItem6.Text = "بخش ثبت";
            radListDataItem7.Text = "بخش انبارداری";
            radListDataItem8.Text = "ادمین ویژه";
            this.radDropAccess.Items.Add(radListDataItem5);
            this.radDropAccess.Items.Add(radListDataItem6);
            this.radDropAccess.Items.Add(radListDataItem7);
            this.radDropAccess.Items.Add(radListDataItem8);
            this.radDropAccess.Location = new System.Drawing.Point(51, 105);
            this.radDropAccess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radDropAccess.Name = "radDropAccess";
            this.radDropAccess.Size = new System.Drawing.Size(240, 32);
            this.radDropAccess.TabIndex = 11;
            this.radDropAccess.Text = "بخش فروش";
            // 
            // btnAttach
            // 
            this.btnAttach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAttach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAttach.Location = new System.Drawing.Point(475, 40);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAttach.Size = new System.Drawing.Size(60, 56);
            this.btnAttach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAttach.Symbol = "";
            this.btnAttach.TabIndex = 10;
            this.btnAttach.Tooltip = "ضمیمه اطلاعات";
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(765, 49);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "کد پرسنلی";
            // 
            // txtPersonnelCode
            // 
            this.txtPersonnelCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPersonnelCode.Border.Class = "TextBoxBorder";
            this.txtPersonnelCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPersonnelCode.DisabledBackColor = System.Drawing.Color.White;
            this.txtPersonnelCode.Enabled = false;
            this.txtPersonnelCode.ForeColor = System.Drawing.Color.Black;
            this.txtPersonnelCode.Location = new System.Drawing.Point(550, 49);
            this.txtPersonnelCode.Name = "txtPersonnelCode";
            this.txtPersonnelCode.PreventEnterBeep = true;
            this.txtPersonnelCode.Size = new System.Drawing.Size(209, 29);
            this.txtPersonnelCode.TabIndex = 7;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtPassword.Border.Class = "TextBoxBorder";
            this.TxtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.Location = new System.Drawing.Point(59, 49);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PreventEnterBeep = true;
            this.TxtPassword.Size = new System.Drawing.Size(232, 29);
            this.TxtPassword.TabIndex = 7;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtUserName.Border.Class = "TextBoxBorder";
            this.TxtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtUserName.DisabledBackColor = System.Drawing.Color.White;
            this.TxtUserName.ForeColor = System.Drawing.Color.Black;
            this.TxtUserName.Location = new System.Drawing.Point(550, 108);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PreventEnterBeep = true;
            this.TxtUserName.Size = new System.Drawing.Size(209, 29);
            this.TxtUserName.TabIndex = 6;
            // 
            // LblAccess
            // 
            this.LblAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblAccess.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblAccess.ForeColor = System.Drawing.Color.Black;
            this.LblAccess.Location = new System.Drawing.Point(329, 108);
            this.LblAccess.Name = "LblAccess";
            this.LblAccess.Size = new System.Drawing.Size(103, 23);
            this.LblAccess.TabIndex = 5;
            this.LblAccess.Text = "سطح دسترسی";
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblPassword.ForeColor = System.Drawing.Color.Black;
            this.LblPassword.Location = new System.Drawing.Point(357, 49);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(75, 23);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "کلمه عبور";
            // 
            // LblUserName
            // 
            this.LblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblUserName.ForeColor = System.Drawing.Color.Black;
            this.LblUserName.Location = new System.Drawing.Point(804, 108);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(75, 23);
            this.LblUserName.TabIndex = 3;
            this.LblUserName.Text = "نام کاربری";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(891, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نمایش اطلاعات";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(34, 45);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn5.FieldName = "PersonnelCode";
            gridViewTextBoxColumn5.HeaderText = "کدپرسنلی";
            gridViewTextBoxColumn5.Name = "ID";
            gridViewTextBoxColumn5.Width = 575;
            gridViewTextBoxColumn6.FieldName = "UserName";
            gridViewTextBoxColumn6.HeaderText = "نام کاربری";
            gridViewTextBoxColumn6.Name = "UserName";
            gridViewTextBoxColumn6.Width = 575;
            gridViewTextBoxColumn7.FieldName = "Password";
            gridViewTextBoxColumn7.HeaderText = "کلمه ی عبور";
            gridViewTextBoxColumn7.Name = "Password";
            gridViewTextBoxColumn7.Width = 575;
            gridViewTextBoxColumn8.FieldName = "Access";
            gridViewTextBoxColumn8.HeaderText = "سطح دسترسی";
            gridViewTextBoxColumn8.Name = "Access";
            gridViewTextBoxColumn8.Width = 312;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(824, 197);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.radGridView1_MouseDoubleClick);
            // 
            // tblLoginBindingSource1
            // 
            this.tblLoginBindingSource1.DataMember = "TblLogin";
            // 
            // tblLoginBindingSource
            // 
            this.tblLoginBindingSource.DataMember = "TblLogin";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmNewUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(918, 627);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف کاربر جدید";
            this.Load += new System.EventHandler(this.FrmNewUser_Load);
            this.groupBox3.ResumeLayout(false);
            this.GrpSearch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropAccess)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GrpSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSearchUserName;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX BtnSearch;
        private DevComponents.DotNetBar.ButtonX BtnClean;
        private DevComponents.DotNetBar.ButtonX BtnUpdate;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtUserName;
        private DevComponents.DotNetBar.LabelX LblAccess;
        private DevComponents.DotNetBar.LabelX LblPassword;
        private DevComponents.DotNetBar.LabelX LblUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tblLoginBindingSource;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource tblLoginBindingSource1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPersonnelCode;
        private DevComponents.DotNetBar.ButtonX btnAttach;
        private Telerik.WinControls.UI.RadDropDownList radDropAccess;
    }
}