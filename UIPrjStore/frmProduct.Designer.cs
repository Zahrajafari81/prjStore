namespace UIPrjStore
{
    partial class frmProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.office2013DarkTheme1 = new Telerik.WinControls.Themes.Office2013DarkTheme();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.GrpEnter = new System.Windows.Forms.GroupBox();
            this.btnScanner = new DevComponents.DotNetBar.ButtonX();
            this.btnAttach = new DevComponents.DotNetBar.ButtonX();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTarikhEngheza = new System.Windows.Forms.TextBox();
            this.txtTarikhtolid = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtGaranty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.grpSearchInfoName = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoothNumber = new System.Windows.Forms.TextBox();
            this.btnAttchBoothNumber = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrpEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpOperation.SuspendLayout();
            this.grpSearchInfoName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1502, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نمایش اطلاعات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(19, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // GrpEnter
            // 
            this.GrpEnter.Controls.Add(this.btnAttchBoothNumber);
            this.GrpEnter.Controls.Add(this.btnScanner);
            this.GrpEnter.Controls.Add(this.btnAttach);
            this.GrpEnter.Controls.Add(this.label9);
            this.GrpEnter.Controls.Add(this.pictureBox1);
            this.GrpEnter.Controls.Add(this.txtTarikhEngheza);
            this.GrpEnter.Controls.Add(this.txtTarikhtolid);
            this.GrpEnter.Controls.Add(this.cmbUnit);
            this.GrpEnter.Controls.Add(this.txtBoothNumber);
            this.GrpEnter.Controls.Add(this.txtNumber);
            this.GrpEnter.Controls.Add(this.textBox7);
            this.GrpEnter.Controls.Add(this.txtGaranty);
            this.GrpEnter.Controls.Add(this.txtPrice);
            this.GrpEnter.Controls.Add(this.txtName);
            this.GrpEnter.Controls.Add(this.txtBarcode);
            this.GrpEnter.Controls.Add(this.label11);
            this.GrpEnter.Controls.Add(this.label3);
            this.GrpEnter.Controls.Add(this.label7);
            this.GrpEnter.Controls.Add(this.label8);
            this.GrpEnter.Controls.Add(this.label5);
            this.GrpEnter.Controls.Add(this.label2);
            this.GrpEnter.Controls.Add(this.label6);
            this.GrpEnter.Controls.Add(this.label4);
            this.GrpEnter.Controls.Add(this.label1);
            this.GrpEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GrpEnter.Location = new System.Drawing.Point(23, 369);
            this.GrpEnter.Name = "GrpEnter";
            this.GrpEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrpEnter.Size = new System.Drawing.Size(1502, 481);
            this.GrpEnter.TabIndex = 1;
            this.GrpEnter.TabStop = false;
            // 
            // btnScanner
            // 
            this.btnScanner.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnScanner.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnScanner.Location = new System.Drawing.Point(855, 37);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnScanner.Size = new System.Drawing.Size(83, 68);
            this.btnScanner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnScanner.Symbol = "";
            this.btnScanner.TabIndex = 13;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAttach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAttach.Location = new System.Drawing.Point(829, 346);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAttach.Size = new System.Drawing.Size(82, 75);
            this.btnAttach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAttach.Symbol = "";
            this.btnAttach.TabIndex = 12;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(1387, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "تصویر";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::UIPrjStore.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(960, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtTarikhEngheza
            // 
            this.txtTarikhEngheza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTarikhEngheza.Location = new System.Drawing.Point(175, 124);
            this.txtTarikhEngheza.Name = "txtTarikhEngheza";
            this.txtTarikhEngheza.Size = new System.Drawing.Size(347, 34);
            this.txtTarikhEngheza.TabIndex = 9;
            // 
            // txtTarikhtolid
            // 
            this.txtTarikhtolid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTarikhtolid.Location = new System.Drawing.Point(175, 54);
            this.txtTarikhtolid.Name = "txtTarikhtolid";
            this.txtTarikhtolid.Size = new System.Drawing.Size(347, 34);
            this.txtTarikhtolid.TabIndex = 9;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "کیلوگرم",
            "گرم",
            "عدد",
            "بسته",
            "باکس"});
            this.cmbUnit.Location = new System.Drawing.Point(171, 334);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(351, 37);
            this.cmbUnit.TabIndex = 8;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumber.Location = new System.Drawing.Point(171, 259);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(351, 34);
            this.txtNumber.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(-465, 421);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(351, 38);
            this.textBox7.TabIndex = 1;
            // 
            // txtGaranty
            // 
            this.txtGaranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtGaranty.Location = new System.Drawing.Point(171, 191);
            this.txtGaranty.Name = "txtGaranty";
            this.txtGaranty.Size = new System.Drawing.Size(351, 34);
            this.txtGaranty.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrice.Location = new System.Drawing.Point(960, 219);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(351, 34);
            this.txtPrice.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(960, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBarcode.Location = new System.Drawing.Point(960, 48);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(351, 34);
            this.txtBarcode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1364, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام محصول";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(635, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "تعداد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(610, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "گارانتی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(584, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاریخ انقضا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1414, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "قیمت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(631, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "واحد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(590, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "تاریخ تولید";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1344, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "بارکد محصول";
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.grpSearchInfoName);
            this.grpOperation.Controls.Add(this.btnSearch);
            this.grpOperation.Controls.Add(this.btnDelete);
            this.grpOperation.Controls.Add(this.btnUpdate);
            this.grpOperation.Controls.Add(this.btnSave);
            this.grpOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpOperation.Location = new System.Drawing.Point(23, 857);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpOperation.Size = new System.Drawing.Size(1502, 124);
            this.grpOperation.TabIndex = 2;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "نوع عملیات";
            // 
            // grpSearchInfoName
            // 
            this.grpSearchInfoName.Controls.Add(this.txtSearchName);
            this.grpSearchInfoName.Controls.Add(this.label10);
            this.grpSearchInfoName.Location = new System.Drawing.Point(19, 23);
            this.grpSearchInfoName.Name = "grpSearchInfoName";
            this.grpSearchInfoName.Size = new System.Drawing.Size(712, 85);
            this.grpSearchInfoName.TabIndex = 1;
            this.grpSearchInfoName.TabStop = false;
            this.grpSearchInfoName.Visible = false;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(94, 37);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(351, 41);
            this.txtSearchName.TabIndex = 3;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 36);
            this.label10.TabIndex = 2;
            this.label10.Text = "نام محصول";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(811, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnSearch.Size = new System.Drawing.Size(100, 85);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.Symbol = "";
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Tooltip = "جستجو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(960, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnDelete.Size = new System.Drawing.Size(101, 85);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Tooltip = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(1119, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnUpdate.Size = new System.Drawing.Size(101, 85);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.Symbol = "";
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Tooltip = "ویرایش";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(1292, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnSave.Size = new System.Drawing.Size(102, 87);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 0;
            this.btnSave.Tooltip = "ثبت";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(610, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "شماره غرفه";
            // 
            // txtBoothNumber
            // 
            this.txtBoothNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBoothNumber.Location = new System.Drawing.Point(171, 415);
            this.txtBoothNumber.Name = "txtBoothNumber";
            this.txtBoothNumber.Size = new System.Drawing.Size(351, 34);
            this.txtBoothNumber.TabIndex = 1;
            // 
            // btnAttchBoothNumber
            // 
            this.btnAttchBoothNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAttchBoothNumber.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAttchBoothNumber.Location = new System.Drawing.Point(63, 389);
            this.btnAttchBoothNumber.Name = "btnAttchBoothNumber";
            this.btnAttchBoothNumber.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAttchBoothNumber.Size = new System.Drawing.Size(91, 75);
            this.btnAttchBoothNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAttchBoothNumber.Symbol = "";
            this.btnAttchBoothNumber.TabIndex = 14;
            this.btnAttchBoothNumber.Click += new System.EventHandler(this.btnAttchBoothNumber_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 1012);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.GrpEnter);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "`";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrpEnter.ResumeLayout(false);
            this.GrpEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpOperation.ResumeLayout(false);
            this.grpSearchInfoName.ResumeLayout(false);
            this.grpSearchInfoName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Telerik.WinControls.Themes.Office2013DarkTheme office2013DarkTheme1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.GroupBox GrpEnter;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtGaranty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.GroupBox grpSearchInfoName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private System.Windows.Forms.ComboBox cmbUnit;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.TextBox txtTarikhEngheza;
        private System.Windows.Forms.TextBox txtTarikhtolid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnAttach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private DevComponents.DotNetBar.ButtonX btnScanner;
        private DevComponents.DotNetBar.ButtonX btnAttchBoothNumber;
        private System.Windows.Forms.TextBox txtBoothNumber;
        private System.Windows.Forms.Label label11;
    }
}

