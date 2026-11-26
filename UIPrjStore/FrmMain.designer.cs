namespace UIPrjStore
{
    partial class FrmMain
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
            this.lblMessage = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.analogueClock1 = new GHNet.Windows.Forms.AnalogueClock();
            this.MISellingFoodProducts = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ItemSelling = new DevComponents.DotNetBar.ItemContainer();
            this.MIStockInTrade = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MIInventory = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MIEnterProducts = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ItemWareHouse = new DevComponents.DotNetBar.ItemContainer();
            this.MINewSaveBooth = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MICompanyNameContracts = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroItemDefineDriver = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroItemEmployee = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroItemUser = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroItemProducts = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.ItemSave = new DevComponents.DotNetBar.ItemContainer();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.LblMessage2 = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radTimeSpanPicker1 = new Telerik.WinControls.UI.RadTimeSpanPicker();
            this.radTimePicker1 = new Telerik.WinControls.UI.RadTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analogueClock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimeSpanPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            // 
            // 
            // 
            this.lblMessage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(441, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(367, 23);
            this.lblMessage.TabIndex = 11;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radDateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.radDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker1.Location = new System.Drawing.Point(643, 73);
            this.radDateTimePicker1.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radDateTimePicker1.RootElement.ControlBounds = new System.Drawing.Rectangle(557, 64, 164, 20);
            this.radDateTimePicker1.RootElement.StretchVertically = true;
            this.radDateTimePicker1.Size = new System.Drawing.Size(302, 34);
            this.radDateTimePicker1.TabIndex = 2;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "2015/02/12";
            this.radDateTimePicker1.ThemeName = "TelerikMetroBlue";
            this.radDateTimePicker1.Value = new System.DateTime(2015, 2, 12, 8, 7, 24, 374);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radTimePicker1);
            this.groupBox1.Controls.Add(this.radTimeSpanPicker1);
            this.groupBox1.Controls.Add(this.radDateTimePicker2);
            this.groupBox1.Controls.Add(this.analogueClock1);
            this.groupBox1.Controls.Add(this.radDateTimePicker1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(39, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1002, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // analogueClock1
            // 
            this.analogueClock1.Location = new System.Drawing.Point(85, 21);
            this.analogueClock1.Name = "analogueClock1";
            this.analogueClock1.Size = new System.Drawing.Size(185, 142);
            this.analogueClock1.StyleImage = global::UIPrjStore.Properties.Resources.AC_Trad__135_135px_1;
            this.analogueClock1.TabIndex = 3;
            // 
            // MISellingFoodProducts
            // 
            this.MISellingFoodProducts.Name = "MISellingFoodProducts";
            this.MISellingFoodProducts.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F10);
            this.MISellingFoodProducts.SymbolColor = System.Drawing.Color.Empty;
            this.MISellingFoodProducts.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MISellingFoodProducts.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MISellingFoodProducts.TitleText = "محصولات ";
            this.MISellingFoodProducts.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MISellingFoodProducts.Tooltip = "F10";
            this.MISellingFoodProducts.Click += new System.EventHandler(this.MISellingFoodProducts_Click);
            // 
            // ItemSelling
            // 
            // 
            // 
            // 
            this.ItemSelling.BackgroundStyle.BackColor = System.Drawing.Color.Khaki;
            this.ItemSelling.BackgroundStyle.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.ItemSelling.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemSelling.FixedSize = new System.Drawing.Size(350, 0);
            this.ItemSelling.MultiLine = true;
            this.ItemSelling.Name = "ItemSelling";
            this.ItemSelling.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MISellingFoodProducts});
            // 
            // 
            // 
            this.ItemSelling.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ItemSelling.TitleStyle.Class = "MetroTileGroupTitle";
            this.ItemSelling.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemSelling.TitleStyle.MarginLeft = 70;
            this.ItemSelling.TitleText = "بخش فروش";
            // 
            // MIStockInTrade
            // 
            this.MIStockInTrade.Name = "MIStockInTrade";
            this.MIStockInTrade.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            this.MIStockInTrade.SymbolColor = System.Drawing.Color.Empty;
            this.MIStockInTrade.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MIStockInTrade.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MIStockInTrade.TitleText = "موجودی فروشگاه";
            this.MIStockInTrade.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MIStockInTrade.Tooltip = "F9";
            // 
            // MIInventory
            // 
            this.MIInventory.Name = "MIInventory";
            this.MIInventory.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8);
            this.MIInventory.SymbolColor = System.Drawing.Color.Empty;
            this.MIInventory.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MIInventory.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MIInventory.TitleText = "موجودی انبار";
            this.MIInventory.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MIInventory.Tooltip = "F8";
            // 
            // MIEnterProducts
            // 
            this.MIEnterProducts.Name = "MIEnterProducts";
            this.MIEnterProducts.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7);
            this.MIEnterProducts.SymbolColor = System.Drawing.Color.Empty;
            this.MIEnterProducts.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MIEnterProducts.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MIEnterProducts.TitleText = "محصولات رسیده به انبار";
            this.MIEnterProducts.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MIEnterProducts.Tooltip = "F7";
            // 
            // ItemWareHouse
            // 
            // 
            // 
            // 
            this.ItemWareHouse.BackgroundStyle.BackColor = System.Drawing.Color.Khaki;
            this.ItemWareHouse.BackgroundStyle.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.ItemWareHouse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemWareHouse.MultiLine = true;
            this.ItemWareHouse.Name = "ItemWareHouse";
            this.ItemWareHouse.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MIEnterProducts,
            this.MIInventory,
            this.MIStockInTrade});
            // 
            // 
            // 
            this.ItemWareHouse.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ItemWareHouse.TitleStyle.Class = "MetroTileGroupTitle";
            this.ItemWareHouse.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemWareHouse.TitleStyle.MarginLeft = 50;
            this.ItemWareHouse.TitleText = "بخش انبار داری و موجودی";
            // 
            // MINewSaveBooth
            // 
            this.MINewSaveBooth.Name = "MINewSaveBooth";
            this.MINewSaveBooth.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F6);
            this.MINewSaveBooth.SymbolColor = System.Drawing.Color.Empty;
            this.MINewSaveBooth.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MINewSaveBooth.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MINewSaveBooth.TitleText = "غرفه جدید";
            this.MINewSaveBooth.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MINewSaveBooth.Tooltip = "F6";
            // 
            // MICompanyNameContracts
            // 
            this.MICompanyNameContracts.Name = "MICompanyNameContracts";
            this.MICompanyNameContracts.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.MICompanyNameContracts.SymbolColor = System.Drawing.Color.Empty;
            this.MICompanyNameContracts.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MICompanyNameContracts.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MICompanyNameContracts.TitleText = "شرکت طرف قرار داد";
            this.MICompanyNameContracts.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MICompanyNameContracts.Tooltip = "F5";
            // 
            // MetroItemDefineDriver
            // 
            this.MetroItemDefineDriver.Name = "MetroItemDefineDriver";
            this.MetroItemDefineDriver.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.MetroItemDefineDriver.SymbolColor = System.Drawing.Color.Empty;
            this.MetroItemDefineDriver.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MetroItemDefineDriver.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroItemDefineDriver.TitleText = "اطلاعات راننده";
            this.MetroItemDefineDriver.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroItemDefineDriver.Tooltip = "F4";
            // 
            // MetroItemEmployee
            // 
            this.MetroItemEmployee.Name = "MetroItemEmployee";
            this.MetroItemEmployee.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.MetroItemEmployee.SymbolColor = System.Drawing.Color.Empty;
            this.MetroItemEmployee.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MetroItemEmployee.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroItemEmployee.TitleText = "کارمندان";
            this.MetroItemEmployee.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroItemEmployee.Tooltip = "F3";
            this.MetroItemEmployee.Click += new System.EventHandler(this.MetroItemEmployee_Click);
            // 
            // MetroItemUser
            // 
            this.MetroItemUser.Name = "MetroItemUser";
            this.MetroItemUser.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.MetroItemUser.SymbolColor = System.Drawing.Color.Empty;
            this.MetroItemUser.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MetroItemUser.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroItemUser.TitleText = "کاربر جدید";
            this.MetroItemUser.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroItemUser.Tooltip = "F2";
            this.MetroItemUser.Click += new System.EventHandler(this.MetroItemUser_Click);
            // 
            // MetroItemProducts
            // 
            this.MetroItemProducts.Name = "MetroItemProducts";
            this.MetroItemProducts.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.MetroItemProducts.SymbolColor = System.Drawing.Color.Empty;
            this.MetroItemProducts.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.MetroItemProducts.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroItemProducts.TitleText = "محصولات";
            this.MetroItemProducts.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroItemProducts.Tooltip = "F1";
            this.MetroItemProducts.Click += new System.EventHandler(this.MetroItemProducts_Click);
            // 
            // ItemSave
            // 
            // 
            // 
            // 
            this.ItemSave.BackgroundStyle.BackColor = System.Drawing.Color.Khaki;
            this.ItemSave.BackgroundStyle.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.ItemSave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemSave.MultiLine = true;
            this.ItemSave.Name = "ItemSave";
            this.ItemSave.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MetroItemProducts,
            this.MetroItemUser,
            this.MetroItemEmployee,
            this.MetroItemDefineDriver,
            this.MICompanyNameContracts,
            this.MINewSaveBooth});
            // 
            // 
            // 
            this.ItemSave.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ItemSave.TitleStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dot;
            this.ItemSave.TitleStyle.BorderBottomColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItemSave.TitleStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Dot;
            this.ItemSave.TitleStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Dot;
            this.ItemSave.TitleStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Dot;
            this.ItemSave.TitleStyle.Class = "MetroTileGroupTitle";
            this.ItemSave.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemSave.TitleStyle.MarginLeft = 350;
            this.ItemSave.TitleText = "ثبت";
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.ForeColor = System.Drawing.Color.BurlyWood;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ItemSave,
            this.ItemWareHouse,
            this.ItemSelling});
            this.metroTilePanel1.Location = new System.Drawing.Point(39, 254);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.ReserveLeftSpace = false;
            this.metroTilePanel1.Size = new System.Drawing.Size(1002, 382);
            this.metroTilePanel1.TabIndex = 8;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // LblMessage2
            // 
            // 
            // 
            // 
            this.LblMessage2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblMessage2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LblMessage2.Location = new System.Drawing.Point(419, 13);
            this.LblMessage2.Name = "LblMessage2";
            this.LblMessage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblMessage2.Size = new System.Drawing.Size(284, 23);
            this.LblMessage2.TabIndex = 9;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.CalendarSize = new System.Drawing.Size(290, 320);
            this.radDateTimePicker2.Location = new System.Drawing.Point(319, 73);
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            this.radDateTimePicker2.Size = new System.Drawing.Size(277, 24);
            this.radDateTimePicker2.TabIndex = 4;
            this.radDateTimePicker2.TabStop = false;
            this.radDateTimePicker2.Text = "Saturday, May 17, 2025";
            this.radDateTimePicker2.Value = new System.DateTime(2025, 5, 17, 12, 44, 20, 634);
            // 
            // radTimeSpanPicker1
            // 
            this.radTimeSpanPicker1.Location = new System.Drawing.Point(301, 139);
            this.radTimeSpanPicker1.Name = "radTimeSpanPicker1";
            this.radTimeSpanPicker1.Size = new System.Drawing.Size(271, 24);
            this.radTimeSpanPicker1.TabIndex = 5;
            this.radTimeSpanPicker1.TabStop = false;
            // 
            // radTimePicker1
            // 
            this.radTimePicker1.Location = new System.Drawing.Point(659, 125);
            this.radTimePicker1.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.radTimePicker1.MinValue = new System.DateTime(((long)(0)));
            this.radTimePicker1.Name = "radTimePicker1";
            this.radTimePicker1.Size = new System.Drawing.Size(228, 24);
            this.radTimePicker1.TabIndex = 6;
            this.radTimePicker1.TabStop = false;
            this.radTimePicker1.Value = new System.DateTime(2025, 5, 17, 12, 46, 4, 418);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1069, 654);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTilePanel1);
            this.Controls.Add(this.LblMessage2);
            this.DoubleBuffered = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منوی اصلی";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analogueClock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimeSpanPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblMessage;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Metro.MetroTileItem MISellingFoodProducts;
        private DevComponents.DotNetBar.ItemContainer ItemSelling;
        private DevComponents.DotNetBar.Metro.MetroTileItem MIStockInTrade;
        private DevComponents.DotNetBar.Metro.MetroTileItem MIInventory;
        private DevComponents.DotNetBar.Metro.MetroTileItem MIEnterProducts;
        private DevComponents.DotNetBar.ItemContainer ItemWareHouse;
        private DevComponents.DotNetBar.Metro.MetroTileItem MINewSaveBooth;
        private DevComponents.DotNetBar.Metro.MetroTileItem MICompanyNameContracts;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroItemDefineDriver;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroItemEmployee;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroItemUser;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroItemProducts;
        private DevComponents.DotNetBar.ItemContainer ItemSave;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.LabelX LblMessage2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private GHNet.Windows.Forms.AnalogueClock analogueClock1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;
        private Telerik.WinControls.UI.RadTimePicker radTimePicker1;
        private Telerik.WinControls.UI.RadTimeSpanPicker radTimeSpanPicker1;
    }
}