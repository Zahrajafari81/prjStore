namespace UIPrjStore
{
    partial class frmInfoBooth
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView
            // 
            this.radGridView.Location = new System.Drawing.Point(11, 21);
            this.radGridView.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            // 
            // 
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn3.FieldName = "BoothNumber";
            gridViewTextBoxColumn3.HeaderText = "شماره غرفه";
            gridViewTextBoxColumn3.Name = "BoothNumber";
            gridViewTextBoxColumn3.Width = 390;
            gridViewTextBoxColumn4.FieldName = "BoothName";
            gridViewTextBoxColumn4.HeaderText = "نام غرفه";
            gridViewTextBoxColumn4.Name = "BoothName";
            gridViewTextBoxColumn4.Width = 390;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGridView.MasterTemplate.EnableGrouping = false;
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView.Name = "radGridView";
            this.radGridView.ReadOnly = true;
            this.radGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView.Size = new System.Drawing.Size(1064, 437);
            this.radGridView.TabIndex = 1;
            this.radGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radGridView_MouseClick);
            // 
            // frmInfoBooth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1111, 498);
            this.Controls.Add(this.radGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmInfoBooth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش اطلاعات غرفه";
            this.Load += new System.EventHandler(this.frmInfoBooth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView;
    }
}