
namespace Police_System_I
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.combo = new System.Windows.Forms.ComboBox();
            this.CheckOn = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(361, 201);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 25);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Nom d\'Utilisateur";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 492);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 317);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPass.Location = new System.Drawing.Point(361, 267);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(213, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Mot de passe";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(308, 258);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(312, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 1);
            this.panel4.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(309, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(312, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 1);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(411, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 8);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(335, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "présentez-vous";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.SystemColors.HighlightText;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Quitter";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(468, 371);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(132, 47);
            this.bunifuThinButton22.TabIndex = 29;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Connexion";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.HighlightText;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(310, 371);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(133, 47);
            this.bunifuThinButton21.TabIndex = 28;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.Color.White;
            this.combo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "Admin",
            "Officier"});
            this.combo.Location = new System.Drawing.Point(309, 134);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(292, 29);
            this.combo.TabIndex = 0;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            this.combo.Enter += new System.EventHandler(this.combo_Enter);
            // 
            // CheckOn
            // 
            this.CheckOn.BackColor = System.Drawing.Color.PowderBlue;
            this.CheckOn.ChechedOffColor = System.Drawing.Color.PowderBlue;
            this.CheckOn.Checked = false;
            this.CheckOn.CheckedOnColor = System.Drawing.Color.PowderBlue;
            this.CheckOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.CheckOn.Location = new System.Drawing.Point(316, 327);
            this.CheckOn.Name = "CheckOn";
            this.CheckOn.Size = new System.Drawing.Size(20, 20);
            this.CheckOn.TabIndex = 30;
            this.CheckOn.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(343, 329);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(143, 17);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Afficher mot de pase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(688, 447);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CheckOn);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.ComboBox combo;
        private Bunifu.Framework.UI.BunifuCheckbox CheckOn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

