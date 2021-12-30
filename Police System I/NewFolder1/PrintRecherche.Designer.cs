
namespace Police_System_I.NewFolder1
{
    partial class PrintRecherche
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintRecherche));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.btnPicture = new Guna.UI.WinForms.GunaButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnInfo = new Guna.UI.WinForms.GunaButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.comboNom = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtNumOff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BaseColor = System.Drawing.Color.White;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(382, 59);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(157, 152);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.AnimationHoverSpeed = 0.07F;
            this.btnPicture.AnimationSpeed = 0.03F;
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnPicture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPicture.FocusedColor = System.Drawing.Color.Empty;
            this.btnPicture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicture.ForeColor = System.Drawing.Color.White;
            this.btnPicture.Image = null;
            this.btnPicture.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPicture.Location = new System.Drawing.Point(400, 223);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnPicture.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnPicture.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnPicture.OnHoverImage = null;
            this.btnPicture.OnPressedColor = System.Drawing.Color.Black;
            this.btnPicture.Radius = 20;
            this.btnPicture.Size = new System.Drawing.Size(119, 42);
            this.btnPicture.TabIndex = 1;
            this.btnPicture.Text = "Image";
            this.btnPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPicture.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(547, 277);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(49, 18);
            this.bunifuCustomLabel7.TabIndex = 68;
            this.bunifuCustomLabel7.Text = "Ville :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(139, 277);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(74, 18);
            this.bunifuCustomLabel2.TabIndex = 65;
            this.bunifuCustomLabel2.Text = "Le nom  :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(139, 344);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 18);
            this.bunifuCustomLabel1.TabIndex = 64;
            this.bunifuCustomLabel1.Text = "Le prénom :";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(547, 344);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(120, 18);
            this.bunifuCustomLabel6.TabIndex = 67;
            this.bunifuCustomLabel6.Text = "Type de Crime:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(139, 412);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(54, 18);
            this.bunifuCustomLabel5.TabIndex = 66;
            this.bunifuCustomLabel5.Text = "Taille :";
            // 
            // btnInfo
            // 
            this.btnInfo.AnimationHoverSpeed = 0.07F;
            this.btnInfo.AnimationSpeed = 0.03F;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInfo.FocusedColor = System.Drawing.Color.Empty;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = null;
            this.btnInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInfo.Location = new System.Drawing.Point(383, 494);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnInfo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnInfo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.btnInfo.OnHoverImage = null;
            this.btnInfo.OnPressedColor = System.Drawing.Color.Black;
            this.btnInfo.Radius = 20;
            this.btnInfo.Size = new System.Drawing.Size(157, 42);
            this.btnInfo.TabIndex = 69;
            this.btnInfo.Text = "Ajouter ";
            this.btnInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(547, 412);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(104, 18);
            this.bunifuCustomLabel4.TabIndex = 71;
            this.bunifuCustomLabel4.Text = "Num Officier:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gunaLabel1.Location = new System.Drawing.Point(241, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(442, 21);
            this.gunaLabel1.TabIndex = 72;
            this.gunaLabel1.Text = "Imprimer les informations de la personne recherchée  :";
            // 
            // comboNom
            // 
            this.comboNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNom.FormattingEnabled = true;
            this.comboNom.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique"});
            this.comboNom.Location = new System.Drawing.Point(142, 300);
            this.comboNom.Name = "comboNom";
            this.comboNom.Size = new System.Drawing.Size(247, 26);
            this.comboNom.TabIndex = 74;
            this.comboNom.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique"});
            this.comboBox1.Location = new System.Drawing.Point(142, 368);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 26);
            this.comboBox1.TabIndex = 82;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique"});
            this.comboBox3.Location = new System.Drawing.Point(142, 435);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(247, 26);
            this.comboBox3.TabIndex = 83;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique"});
            this.comboBox4.Location = new System.Drawing.Point(550, 300);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(247, 26);
            this.comboBox4.TabIndex = 84;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique"});
            this.txtType.Location = new System.Drawing.Point(550, 368);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(247, 26);
            this.txtType.TabIndex = 85;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged_1);
            // 
            // txtNumOff
            // 
            this.txtNumOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOff.FormattingEnabled = true;
            this.txtNumOff.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique"});
            this.txtNumOff.Location = new System.Drawing.Point(550, 435);
            this.txtNumOff.Name = "txtNumOff";
            this.txtNumOff.Size = new System.Drawing.Size(247, 26);
            this.txtNumOff.TabIndex = 86;
            // 
            // PrintRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNumOff);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboNom);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pictureBox);
            this.Name = "PrintRecherche";
            this.Size = new System.Drawing.Size(940, 558);
            this.Load += new System.EventHandler(this.PrintRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnPicture;
        private Guna.UI.WinForms.GunaPictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Guna.UI.WinForms.GunaButton btnInfo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox comboNom;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox txtNumOff;
    }
}
