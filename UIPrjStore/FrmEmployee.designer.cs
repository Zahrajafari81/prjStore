namespace UIPrjStore
{
    partial class FrmEmployee
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFamle = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gender = new Telerik.WinControls.UI.RadDropDownList();
            this.btnserch1 = new DevComponents.DotNetBar.ButtonX();
            this.btndelete1 = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate1 = new DevComponents.DotNetBar.ButtonX();
            this.btnsave1 = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activities = new System.Windows.Forms.GroupBox();
            this.GrpSearchInfo = new System.Windows.Forms.GroupBox();
            this.txtSearchFname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Duty = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.NumberHouse = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.IDmelli = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ID = new System.Windows.Forms.TextBox();
            this.information = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).BeginInit();
            this.activities.SuspendLayout();
            this.GrpSearchInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.information.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radMale.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radMale.ForeColor = System.Drawing.Color.Black;
            this.radMale.Location = new System.Drawing.Point(627, 196);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(49, 34);
            this.radMale.TabIndex = 18;
            this.radMale.Text = "آقا";
            this.radMale.UseVisualStyleBackColor = false;
            // 
            // radFamle
            // 
            this.radFamle.AutoSize = true;
            this.radFamle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFamle.Checked = true;
            this.radFamle.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radFamle.ForeColor = System.Drawing.Color.Black;
            this.radFamle.Location = new System.Drawing.Point(538, 194);
            this.radFamle.Name = "radFamle";
            this.radFamle.Size = new System.Drawing.Size(59, 34);
            this.radFamle.TabIndex = 18;
            this.radFamle.TabStop = true;
            this.radFamle.Text = "خانم";
            this.radFamle.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(741, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "جنسیت";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(746, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "آدرس";
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Address.ForeColor = System.Drawing.Color.Black;
            this.Address.Location = new System.Drawing.Point(295, 240);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(418, 56);
            this.Address.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(741, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "وظیفه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(741, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "شماره تماس";
            // 
            // Gender
            // 
            this.Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Gender.DropDownAnimationEnabled = true;
            this.Gender.DropDownHeight = 993;
            this.Gender.ForeColor = System.Drawing.Color.Black;
            this.Gender.ItemHeight = 173;
            radListDataItem1.Text = "زن";
            radListDataItem2.Selected = true;
            radListDataItem2.Text = "مرد";
            this.Gender.Items.Add(radListDataItem1);
            this.Gender.Items.Add(radListDataItem2);
            this.Gender.Location = new System.Drawing.Point(1868, 1885);
            this.Gender.Margin = new System.Windows.Forms.Padding(30);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(2594, 20);
            this.Gender.TabIndex = 12;
            this.Gender.Text = "مرد";
            // 
            // btnserch1
            // 
            this.btnserch1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnserch1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnserch1.Location = new System.Drawing.Point(794, 37);
            this.btnserch1.Name = "btnserch1";
            this.btnserch1.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnserch1.Size = new System.Drawing.Size(97, 71);
            this.btnserch1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnserch1.Symbol = "";
            this.btnserch1.TabIndex = 3;
            this.btnserch1.Tooltip = "جستجو";
            this.btnserch1.Click += new System.EventHandler(this.btnserch1_Click);
            // 
            // btndelete1
            // 
            this.btndelete1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndelete1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndelete1.Location = new System.Drawing.Point(919, 37);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btndelete1.Size = new System.Drawing.Size(97, 71);
            this.btndelete1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndelete1.Symbol = "";
            this.btndelete1.TabIndex = 2;
            this.btndelete1.Tooltip = "حذف";
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // btnupdate1
            // 
            this.btnupdate1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnupdate1.Location = new System.Drawing.Point(1033, 37);
            this.btnupdate1.Name = "btnupdate1";
            this.btnupdate1.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnupdate1.Size = new System.Drawing.Size(97, 71);
            this.btnupdate1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate1.Symbol = "";
            this.btnupdate1.TabIndex = 1;
            this.btnupdate1.Tooltip = "ویرایش";
            this.btnupdate1.Click += new System.EventHandler(this.btnupdate1_Click);
            // 
            // btnsave1
            // 
            this.btnsave1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave1.Location = new System.Drawing.Point(1147, 37);
            this.btnsave1.Name = "btnsave1";
            this.btnsave1.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnsave1.Size = new System.Drawing.Size(97, 71);
            this.btnsave1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave1.Symbol = "";
            this.btnsave1.TabIndex = 0;
            this.btnsave1.Tooltip = "ثبت";
            this.btnsave1.Click += new System.EventHandler(this.btnsave1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(741, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "تلفن ثابت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1141, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1198, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1176, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "کدملی";
            // 
            // activities
            // 
            this.activities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activities.Controls.Add(this.GrpSearchInfo);
            this.activities.Controls.Add(this.btnserch1);
            this.activities.Controls.Add(this.btndelete1);
            this.activities.Controls.Add(this.btnupdate1);
            this.activities.Controls.Add(this.btnsave1);
            this.activities.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activities.ForeColor = System.Drawing.Color.Black;
            this.activities.Location = new System.Drawing.Point(14, 611);
            this.activities.Name = "activities";
            this.activities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.activities.Size = new System.Drawing.Size(1287, 137);
            this.activities.TabIndex = 4;
            this.activities.TabStop = false;
            this.activities.Text = "عملیات";
            // 
            // GrpSearchInfo
            // 
            this.GrpSearchInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrpSearchInfo.Controls.Add(this.txtSearchFname);
            this.GrpSearchInfo.Controls.Add(this.label10);
            this.GrpSearchInfo.ForeColor = System.Drawing.Color.Black;
            this.GrpSearchInfo.Location = new System.Drawing.Point(57, 25);
            this.GrpSearchInfo.Name = "GrpSearchInfo";
            this.GrpSearchInfo.Size = new System.Drawing.Size(656, 97);
            this.GrpSearchInfo.TabIndex = 4;
            this.GrpSearchInfo.TabStop = false;
            this.GrpSearchInfo.Text = "جستجو بر حسب نام";
            this.GrpSearchInfo.Visible = false;
            // 
            // txtSearchFname
            // 
            this.txtSearchFname.BackColor = System.Drawing.Color.White;
            this.txtSearchFname.ForeColor = System.Drawing.Color.Black;
            this.txtSearchFname.Location = new System.Drawing.Point(313, 32);
            this.txtSearchFname.Name = "txtSearchFname";
            this.txtSearchFname.Size = new System.Drawing.Size(273, 37);
            this.txtSearchFname.TabIndex = 2;
            this.txtSearchFname.TextChanged += new System.EventHandler(this.txtSearchFname_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(613, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1158, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "کدپرسنلی";
            // 
            // Duty
            // 
            this.Duty.BackColor = System.Drawing.Color.White;
            this.Duty.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Duty.ForeColor = System.Drawing.Color.Black;
            this.Duty.Location = new System.Drawing.Point(440, 147);
            this.Duty.Name = "Duty";
            this.Duty.Size = new System.Drawing.Size(273, 37);
            this.Duty.TabIndex = 6;
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.White;
            this.Number.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Number.ForeColor = System.Drawing.Color.Black;
            this.Number.Location = new System.Drawing.Point(440, 98);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(273, 37);
            this.Number.TabIndex = 5;
            // 
            // NumberHouse
            // 
            this.NumberHouse.BackColor = System.Drawing.Color.White;
            this.NumberHouse.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberHouse.ForeColor = System.Drawing.Color.Black;
            this.NumberHouse.Location = new System.Drawing.Point(440, 47);
            this.NumberHouse.Name = "NumberHouse";
            this.NumberHouse.Size = new System.Drawing.Size(273, 37);
            this.NumberHouse.TabIndex = 4;
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.White;
            this.Lname.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lname.ForeColor = System.Drawing.Color.Black;
            this.Lname.Location = new System.Drawing.Point(847, 215);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(273, 37);
            this.Lname.TabIndex = 3;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.White;
            this.Fname.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Fname.ForeColor = System.Drawing.Color.Black;
            this.Fname.Location = new System.Drawing.Point(847, 159);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(273, 37);
            this.Fname.TabIndex = 2;
            // 
            // IDmelli
            // 
            this.IDmelli.BackColor = System.Drawing.Color.White;
            this.IDmelli.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IDmelli.ForeColor = System.Drawing.Color.Black;
            this.IDmelli.Location = new System.Drawing.Point(847, 110);
            this.IDmelli.Name = "IDmelli";
            this.IDmelli.Size = new System.Drawing.Size(273, 37);
            this.IDmelli.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.Location = new System.Drawing.Point(847, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(273, 37);
            this.ID.TabIndex = 0;
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.information.Controls.Add(this.radMale);
            this.information.Controls.Add(this.radFamle);
            this.information.Controls.Add(this.label9);
            this.information.Controls.Add(this.label8);
            this.information.Controls.Add(this.Address);
            this.information.Controls.Add(this.label7);
            this.information.Controls.Add(this.label6);
            this.information.Controls.Add(this.Gender);
            this.information.Controls.Add(this.label5);
            this.information.Controls.Add(this.label4);
            this.information.Controls.Add(this.label3);
            this.information.Controls.Add(this.label2);
            this.information.Controls.Add(this.label1);
            this.information.Controls.Add(this.Duty);
            this.information.Controls.Add(this.Number);
            this.information.Controls.Add(this.NumberHouse);
            this.information.Controls.Add(this.Lname);
            this.information.Controls.Add(this.Fname);
            this.information.Controls.Add(this.IDmelli);
            this.information.Controls.Add(this.ID);
            this.information.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.information.ForeColor = System.Drawing.Color.Black;
            this.information.Location = new System.Drawing.Point(14, 282);
            this.information.Name = "information";
            this.information.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.information.Size = new System.Drawing.Size(1285, 314);
            this.information.TabIndex = 3;
            this.information.TabStop = false;
            this.information.Text = "ثبت اطلاعات";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.radGridView1);
            this.groupBox1.Font = new System.Drawing.Font("B Zar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1287, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نمایش اطلاعات";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radGridView1.ColumnChooserSortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("B Tir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(3, 33);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(6);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowColumnResize = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.FieldName = "IDFactor";
            gridViewTextBoxColumn1.HeaderText = "کد پرسنلی";
            gridViewTextBoxColumn1.Name = "IDFactor";
            gridViewTextBoxColumn1.RowSpan = 25;
            gridViewTextBoxColumn1.Width = 102;
            gridViewTextBoxColumn2.FieldName = "CodeMeli";
            gridViewTextBoxColumn2.HeaderText = "کد ملی";
            gridViewTextBoxColumn2.Name = "CodeMeli";
            gridViewTextBoxColumn2.Width = 115;
            gridViewTextBoxColumn3.FieldName = "FName";
            gridViewTextBoxColumn3.HeaderText = "نام";
            gridViewTextBoxColumn3.Name = "FName";
            gridViewTextBoxColumn3.Width = 74;
            gridViewTextBoxColumn4.FieldName = "LName";
            gridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn4.Name = "LName";
            gridViewTextBoxColumn4.Width = 158;
            gridViewTextBoxColumn5.FieldName = "NumberTelHouse";
            gridViewTextBoxColumn5.HeaderText = "شماره تلفن ثابت";
            gridViewTextBoxColumn5.Name = "NumberTelHouse";
            gridViewTextBoxColumn5.Width = 165;
            gridViewTextBoxColumn6.FieldName = "NumberTelHamrah";
            gridViewTextBoxColumn6.HeaderText = "شماره تلفن همراه";
            gridViewTextBoxColumn6.Name = "NumberTelHamrah";
            gridViewTextBoxColumn6.Width = 165;
            gridViewTextBoxColumn7.FieldName = "Masoleate";
            gridViewTextBoxColumn7.HeaderText = "مسئولیت";
            gridViewTextBoxColumn7.Name = "Masoleate";
            gridViewTextBoxColumn7.Width = 165;
            gridViewTextBoxColumn8.FieldName = "sex";
            gridViewTextBoxColumn8.HeaderText = "جنسیت";
            gridViewTextBoxColumn8.Name = "sex";
            gridViewTextBoxColumn8.Width = 82;
            gridViewTextBoxColumn9.FieldName = "Address";
            gridViewTextBoxColumn9.HeaderText = "آدرس";
            gridViewTextBoxColumn9.Name = "Address";
            gridViewTextBoxColumn9.Width = 206;
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
            this.radGridView1.Size = new System.Drawing.Size(1281, 228);
            this.radGridView1.TabIndex = 5;
            this.radGridView1.ThemeName = "Fluent";
            this.radGridView1.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellDoubleClick);
            // 
            // FrmEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1310, 772);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.activities);
            this.Controls.Add(this.information);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت اطلاعات کارمندان";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).EndInit();
            this.activities.ResumeLayout(false);
            this.GrpSearchInfo.ResumeLayout(false);
            this.GrpSearchInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.information.ResumeLayout(false);
            this.information.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFamle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadDropDownList Gender;
        private DevComponents.DotNetBar.ButtonX btnserch1;
        private DevComponents.DotNetBar.ButtonX btndelete1;
        private DevComponents.DotNetBar.ButtonX btnupdate1;
        private DevComponents.DotNetBar.ButtonX btnsave1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox activities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Duty;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox NumberHouse;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox IDmelli;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox information;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.GroupBox GrpSearchInfo;
        private System.Windows.Forms.TextBox txtSearchFname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}