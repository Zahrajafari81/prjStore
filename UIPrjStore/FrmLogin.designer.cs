namespace UIPrjStore
{
    partial class FrmLogin
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
            this.BtnClose = new DevComponents.DotNetBar.ButtonX();
            this.BtnEnter = new DevComponents.DotNetBar.ButtonX();
            this.TxtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LblPassword = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnClose.Location = new System.Drawing.Point(61, 159);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.BtnClose.Size = new System.Drawing.Size(99, 76);
            this.BtnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnClose.Symbol = "";
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Tooltip = "خروج";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnEnter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnEnter.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.BtnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnter.Location = new System.Drawing.Point(183, 159);
            this.BtnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.BtnEnter.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftF2);
            this.BtnEnter.Size = new System.Drawing.Size(103, 76);
            this.BtnEnter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnEnter.Symbol = "";
            this.BtnEnter.TabIndex = 10;
            this.BtnEnter.Tooltip = "ورود";
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
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
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.Location = new System.Drawing.Point(388, 226);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PreventEnterBeep = true;
            this.TxtPassword.Size = new System.Drawing.Size(313, 30);
            this.TxtPassword.TabIndex = 9;
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
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtUserName.ForeColor = System.Drawing.Color.Black;
            this.TxtUserName.Location = new System.Drawing.Point(388, 140);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PreventEnterBeep = true;
            this.TxtUserName.Size = new System.Drawing.Size(313, 30);
            this.TxtUserName.TabIndex = 8;
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblPassword.ForeColor = System.Drawing.Color.Black;
            this.LblPassword.Location = new System.Drawing.Point(761, 226);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPassword.Size = new System.Drawing.Size(100, 28);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "رمز عبور";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(761, 140);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(100, 28);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "نام کاربری";
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(942, 413);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه ی ورود کاربر";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BtnClose;
        private DevComponents.DotNetBar.ButtonX BtnEnter;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtUserName;
        private DevComponents.DotNetBar.LabelX LblPassword;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}