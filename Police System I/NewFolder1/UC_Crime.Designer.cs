
namespace Police_System_I.NewFolder1
{
    partial class UC_Crime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Crime));
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGridViewCrime = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.ComboBox();
            this.txtDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtLieu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNumOff = new System.Windows.Forms.ComboBox();
            this.txtNumCri = new System.Windows.Forms.ComboBox();
            this.btnMiseajour = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSupprimer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAjouter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCrime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(636, 115);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(112, 18);
            this.bunifuCustomLabel7.TabIndex = 60;
            this.bunifuCustomLabel7.Text = "Num Criminel:";
            // 
            // DataGridViewCrime
            // 
            this.DataGridViewCrime.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewCrime.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewCrime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewCrime.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridViewCrime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewCrime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCrime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewCrime.ColumnHeadersHeight = 25;
            this.DataGridViewCrime.DoubleBuffered = true;
            this.DataGridViewCrime.EnableHeadersVisualStyles = false;
            this.DataGridViewCrime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.DataGridViewCrime.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.DataGridViewCrime.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.DataGridViewCrime.Location = new System.Drawing.Point(22, 235);
            this.DataGridViewCrime.Name = "DataGridViewCrime";
            this.DataGridViewCrime.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewCrime.Size = new System.Drawing.Size(833, 273);
            this.DataGridViewCrime.TabIndex = 52;
            this.DataGridViewCrime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCrime_CellClick);
            this.DataGridViewCrime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCrime_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(444, 115);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(104, 18);
            this.bunifuCustomLabel6.TabIndex = 51;
            this.bunifuCustomLabel6.Text = "Num Officier:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(444, 44);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(51, 18);
            this.bunifuCustomLabel5.TabIndex = 49;
            this.bunifuCustomLabel5.Text = "Type :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(237, 115);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(121, 18);
            this.bunifuCustomLabel4.TabIndex = 47;
            this.bunifuCustomLabel4.Text = "Nom detective:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(238, 44);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(51, 18);
            this.bunifuCustomLabel3.TabIndex = 45;
            this.bunifuCustomLabel3.Text = "Date :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 115);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(120, 18);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Text = "Num detective:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(44, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 18);
            this.bunifuCustomLabel1.TabIndex = 41;
            this.bunifuCustomLabel1.Text = "Le lieu :";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(636, 44);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(65, 18);
            this.bunifuCustomLabel8.TabIndex = 62;
            this.bunifuCustomLabel8.Text = "Details :";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique"});
            this.txtType.Location = new System.Drawing.Point(447, 67);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(152, 24);
            this.txtType.TabIndex = 63;
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.FormattingEnabled = true;
            this.txtDetails.Items.AddRange(new object[] {
            "Coups et Blessures",
            "La menace",
            "Fraude",
            "Agression",
            "Porter une arme",
            "Le tuer",
            "Accusation",
            "Arme sans Licence",
            "Corruption",
            "Cambriolage",
            "Incendie criminel",
            "Homicide",
            "Le Vol",
            "Possession de drogue",
            "Homicide involontaire",
            "Falsification",
            "Abus sur mineur",
            "Enlèvement"});
            this.txtDetails.Location = new System.Drawing.Point(639, 68);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(148, 24);
            this.txtDetails.TabIndex = 64;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDate.BorderRadius = 1;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.FormatCustom = null;
            this.txtDate.Location = new System.Drawing.Point(240, 66);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(171, 28);
            this.txtDate.TabIndex = 65;
            this.txtDate.Value = new System.DateTime(2021, 12, 3, 12, 20, 20, 983);
            // 
            // txtLieu
            // 
            this.txtLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLieu.BorderColorFocused = System.Drawing.Color.White;
            this.txtLieu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.txtLieu.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtLieu.BorderThickness = 2;
            this.txtLieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLieu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLieu.isPassword = false;
            this.txtLieu.Location = new System.Drawing.Point(45, 66);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(161, 28);
            this.txtLieu.TabIndex = 69;
            this.txtLieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLieu.OnValueChanged += new System.EventHandler(this.txtLieu_OnValueChanged);
            // 
            // txtNum
            // 
            this.txtNum.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.txtNum.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNum.BorderThickness = 2;
            this.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNum.isPassword = false;
            this.txtNum.Location = new System.Drawing.Point(47, 137);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(161, 27);
            this.txtNum.TabIndex = 70;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNom
            // 
            this.txtNom.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.txtNom.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNom.BorderThickness = 2;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom.isPassword = false;
            this.txtNom.Location = new System.Drawing.Point(240, 137);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(171, 27);
            this.txtNom.TabIndex = 71;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNumOff
            // 
            this.txtNumOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOff.FormattingEnabled = true;
            this.txtNumOff.Items.AddRange(new object[] {
            "Sociaux",
            "Économique",
            "Psychologique",
            "Politique",
            "Cybercriminalité",
            "crimes rudimentaires",
            "crimes contre la propriété",
            "crimes statutaires",
            "crimes financiers et autres",
            "délits liés à l\'alcool"});
            this.txtNumOff.Location = new System.Drawing.Point(447, 140);
            this.txtNumOff.Name = "txtNumOff";
            this.txtNumOff.Size = new System.Drawing.Size(152, 24);
            this.txtNumOff.TabIndex = 72;
            // 
            // txtNumCri
            // 
            this.txtNumCri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCri.FormattingEnabled = true;
            this.txtNumCri.Items.AddRange(new object[] {
            "Coups et Blessures",
            "La menace",
            "Fraude",
            "Agression",
            "Porter une arme",
            "Le tuer",
            "Accusation",
            "Arme sans Licence",
            "Corruption",
            "Cambriolage",
            "Incendie criminel",
            "Homicide",
            "Le Vol",
            "Possession de drogue",
            "Homicide involontaire",
            "Falsification",
            "Abus sur mineur",
            "Enlèvement"});
            this.txtNumCri.Location = new System.Drawing.Point(639, 140);
            this.txtNumCri.Name = "txtNumCri";
            this.txtNumCri.Size = new System.Drawing.Size(148, 24);
            this.txtNumCri.TabIndex = 73;
            // 
            // btnMiseajour
            // 
            this.btnMiseajour.ActiveBorderThickness = 1;
            this.btnMiseajour.ActiveCornerRadius = 20;
            this.btnMiseajour.ActiveFillColor = System.Drawing.Color.HotPink;
            this.btnMiseajour.ActiveForecolor = System.Drawing.Color.White;
            this.btnMiseajour.ActiveLineColor = System.Drawing.Color.HotPink;
            this.btnMiseajour.BackColor = System.Drawing.Color.White;
            this.btnMiseajour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMiseajour.BackgroundImage")));
            this.btnMiseajour.ButtonText = "Mise à jour";
            this.btnMiseajour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiseajour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiseajour.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMiseajour.IdleBorderThickness = 1;
            this.btnMiseajour.IdleCornerRadius = 20;
            this.btnMiseajour.IdleFillColor = System.Drawing.Color.White;
            this.btnMiseajour.IdleForecolor = System.Drawing.Color.HotPink;
            this.btnMiseajour.IdleLineColor = System.Drawing.Color.HotPink;
            this.btnMiseajour.Location = new System.Drawing.Point(450, 179);
            this.btnMiseajour.Margin = new System.Windows.Forms.Padding(5);
            this.btnMiseajour.Name = "btnMiseajour";
            this.btnMiseajour.Size = new System.Drawing.Size(132, 43);
            this.btnMiseajour.TabIndex = 80;
            this.btnMiseajour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMiseajour.Click += new System.EventHandler(this.btnMiseajour_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ActiveBorderThickness = 1;
            this.btnSupprimer.ActiveCornerRadius = 20;
            this.btnSupprimer.ActiveFillColor = System.Drawing.Color.Red;
            this.btnSupprimer.ActiveForecolor = System.Drawing.Color.White;
            this.btnSupprimer.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSupprimer.BackColor = System.Drawing.Color.White;
            this.btnSupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.BackgroundImage")));
            this.btnSupprimer.ButtonText = "Supprimer";
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSupprimer.IdleBorderThickness = 1;
            this.btnSupprimer.IdleCornerRadius = 20;
            this.btnSupprimer.IdleFillColor = System.Drawing.Color.White;
            this.btnSupprimer.IdleForecolor = System.Drawing.Color.Red;
            this.btnSupprimer.IdleLineColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(262, 179);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(132, 43);
            this.btnSupprimer.TabIndex = 79;
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.ActiveBorderThickness = 1;
            this.btnAjouter.ActiveCornerRadius = 20;
            this.btnAjouter.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.btnAjouter.ActiveForecolor = System.Drawing.Color.White;
            this.btnAjouter.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.btnAjouter.BackColor = System.Drawing.Color.White;
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.ButtonText = "Ajouter";
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAjouter.IdleBorderThickness = 1;
            this.btnAjouter.IdleCornerRadius = 20;
            this.btnAjouter.IdleFillColor = System.Drawing.Color.White;
            this.btnAjouter.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.btnAjouter.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.btnAjouter.Location = new System.Drawing.Point(79, 179);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(132, 43);
            this.btnAjouter.TabIndex = 78;
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtClear
            // 
            this.txtClear.ActiveBorderThickness = 1;
            this.txtClear.ActiveCornerRadius = 20;
            this.txtClear.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.txtClear.ActiveForecolor = System.Drawing.Color.White;
            this.txtClear.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.txtClear.BackColor = System.Drawing.Color.White;
            this.txtClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtClear.BackgroundImage")));
            this.txtClear.ButtonText = "dégager";
            this.txtClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtClear.IdleBorderThickness = 1;
            this.txtClear.IdleCornerRadius = 20;
            this.txtClear.IdleFillColor = System.Drawing.Color.White;
            this.txtClear.IdleForecolor = System.Drawing.Color.MediumSeaGreen;
            this.txtClear.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.txtClear.Location = new System.Drawing.Point(639, 179);
            this.txtClear.Margin = new System.Windows.Forms.Padding(5);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(132, 43);
            this.txtClear.TabIndex = 81;
            this.txtClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(569, 514);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 40);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 102;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(323, 522);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 23);
            this.txtSearch.TabIndex = 101;
            // 
            // UC_Crime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.btnMiseajour);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumCri);
            this.Controls.Add(this.txtNumOff);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.DataGridViewCrime);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "UC_Crime";
            this.Size = new System.Drawing.Size(877, 558);
            this.Load += new System.EventHandler(this.UC_Crime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCrime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridViewCrime;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox txtDetails;
        private System.Windows.Forms.ComboBox txtType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuDatepicker txtDate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLieu;
        private System.Windows.Forms.ComboBox txtNumCri;
        private System.Windows.Forms.ComboBox txtNumOff;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNom;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNum;
        private Bunifu.Framework.UI.BunifuThinButton2 txtClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMiseajour;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSupprimer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAjouter;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
