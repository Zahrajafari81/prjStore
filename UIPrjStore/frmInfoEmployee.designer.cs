namespace UIPrjStore
{
    partial class frmInfoEmployee
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radGridView1.ColumnChooserSortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            this.radGridView1.Font = new System.Drawing.Font("B Tir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(19, 19);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(10);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowColumnResize = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "کد پرسنلی";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.RowSpan = 25;
            gridViewTextBoxColumn1.Width = 160;
            gridViewTextBoxColumn2.FieldName = "CodeMeli";
            gridViewTextBoxColumn2.HeaderText = "کد ملی";
            gridViewTextBoxColumn2.Name = "CodeMeli";
            gridViewTextBoxColumn2.Width = 180;
            gridViewTextBoxColumn3.FieldName = "FName";
            gridViewTextBoxColumn3.HeaderText = "نام";
            gridViewTextBoxColumn3.Name = "FName";
            gridViewTextBoxColumn3.Width = 115;
            gridViewTextBoxColumn4.FieldName = "LName";
            gridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn4.Name = "LName";
            gridViewTextBoxColumn4.Width = 248;
            gridViewTextBoxColumn5.FieldName = "NumberTelHouse";
            gridViewTextBoxColumn5.HeaderText = "شماره تلفن ثابت";
            gridViewTextBoxColumn5.Name = "NumberTelHouse";
            gridViewTextBoxColumn5.Width = 258;
            gridViewTextBoxColumn6.FieldName = "NumberTelHamrah";
            gridViewTextBoxColumn6.HeaderText = "شماره تلفن همراه";
            gridViewTextBoxColumn6.Name = "NumberTelHamrah";
            gridViewTextBoxColumn6.Width = 258;
            gridViewTextBoxColumn7.FieldName = "Masoleate";
            gridViewTextBoxColumn7.HeaderText = "مسئولیت";
            gridViewTextBoxColumn7.Name = "Masoleate";
            gridViewTextBoxColumn7.Width = 258;
            gridViewTextBoxColumn8.FieldName = "sex";
            gridViewTextBoxColumn8.HeaderText = "جنسیت";
            gridViewTextBoxColumn8.Name = "sex";
            gridViewTextBoxColumn8.Width = 128;
            gridViewTextBoxColumn9.FieldName = "Address";
            gridViewTextBoxColumn9.HeaderText = "آدرس";
            gridViewTextBoxColumn9.Name = "Address";
            gridViewTextBoxColumn9.Width = 322;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.radGridView1.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGridView1.RootElement.AutoSize = true;
            this.radGridView1.Size = new System.Drawing.Size(1140, 505);
            this.radGridView1.TabIndex = 6;
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            // 
            // frmInfoEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1178, 560);
            this.Controls.Add(this.radGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmInfoEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش اطلاعات کارمندان";
            this.Load += new System.EventHandler(this.frmInfoEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadGridView radGridView1;
    }
}