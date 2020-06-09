namespace MotoCare
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpTrajets = new System.Windows.Forms.TabPage();
            this.btnAjouterTrajet = new System.Windows.Forms.Button();
            this.dtgvTrajets = new System.Windows.Forms.DataGridView();
            this.tpCarnet = new System.Windows.Forms.TabPage();
            this.dtgvCarnetEntretiens = new System.Windows.Forms.DataGridView();
            this.tpGestion = new System.Windows.Forms.TabPage();
            this.dtgvGestionEntretiens = new System.Windows.Forms.DataGridView();
            this.colIdEntretienGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaitGestion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDescriptionGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKmLorsEntretienGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreqKmGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifierGestion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSupprimerGestion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAjoutEntretien = new System.Windows.Forms.Button();
            this.tpInterets = new System.Windows.Forms.TabPage();
            this.lblNomPointInteret = new System.Windows.Forms.Label();
            this.tbxNomPointInteret = new System.Windows.Forms.TextBox();
            this.cbxVisitePointInteret = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAjouterPointInteret = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDescriptionPointInteret = new System.Windows.Forms.TextBox();
            this.gmcCarte = new GMap.NET.WindowsForms.GMapControl();
            this.gbVehicule = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxKmReel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKmInitial = new System.Windows.Forms.TextBox();
            this.btnModifierVehicule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimerVehicule = new System.Windows.Forms.Button();
            this.btnAjouterVehicule = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            this.cbxVehicules = new System.Windows.Forms.ComboBox();
            this.lblErreurAjoutPointInteret = new System.Windows.Forms.Label();
            this.colDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIdEntretien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFait = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateDerniereMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKmDerniereMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProchaineMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMenu.SuspendLayout();
            this.tpTrajets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrajets)).BeginInit();
            this.tpCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarnetEntretiens)).BeginInit();
            this.tpGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionEntretiens)).BeginInit();
            this.tpInterets.SuspendLayout();
            this.gbVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpTrajets);
            this.tcMenu.Controls.Add(this.tpCarnet);
            this.tcMenu.Controls.Add(this.tpGestion);
            this.tcMenu.Controls.Add(this.tpInterets);
            this.tcMenu.Location = new System.Drawing.Point(4, 225);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(933, 393);
            this.tcMenu.TabIndex = 1;
            // 
            // tpTrajets
            // 
            this.tpTrajets.Controls.Add(this.btnAjouterTrajet);
            this.tpTrajets.Controls.Add(this.dtgvTrajets);
            this.tpTrajets.Location = new System.Drawing.Point(4, 22);
            this.tpTrajets.Name = "tpTrajets";
            this.tpTrajets.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpTrajets.Size = new System.Drawing.Size(925, 367);
            this.tpTrajets.TabIndex = 0;
            this.tpTrajets.Text = "Saisie des trajets";
            this.tpTrajets.UseVisualStyleBackColor = true;
            // 
            // btnAjouterTrajet
            // 
            this.btnAjouterTrajet.Location = new System.Drawing.Point(7, 4);
            this.btnAjouterTrajet.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterTrajet.Name = "btnAjouterTrajet";
            this.btnAjouterTrajet.Size = new System.Drawing.Size(914, 28);
            this.btnAjouterTrajet.TabIndex = 1;
            this.btnAjouterTrajet.Text = "Ajouter un nouveau trajet";
            this.btnAjouterTrajet.UseVisualStyleBackColor = true;
            this.btnAjouterTrajet.Click += new System.EventHandler(this.btnAjouterTrajet_Click);
            // 
            // dtgvTrajets
            // 
            this.dtgvTrajets.AllowUserToAddRows = false;
            this.dtgvTrajets.AllowUserToDeleteRows = false;
            this.dtgvTrajets.AllowUserToResizeRows = false;
            this.dtgvTrajets.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvTrajets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTrajets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepart,
            this.colArrivee,
            this.colDistance,
            this.colDate,
            this.colModifier,
            this.colSupprimer});
            this.dtgvTrajets.Location = new System.Drawing.Point(3, 36);
            this.dtgvTrajets.Name = "dtgvTrajets";
            this.dtgvTrajets.ReadOnly = true;
            this.dtgvTrajets.RowHeadersVisible = false;
            this.dtgvTrajets.RowHeadersWidth = 102;
            this.dtgvTrajets.Size = new System.Drawing.Size(920, 328);
            this.dtgvTrajets.TabIndex = 0;
            this.dtgvTrajets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTrajets_CellContentClick);
            // 
            // tpCarnet
            // 
            this.tpCarnet.Controls.Add(this.dtgvCarnetEntretiens);
            this.tpCarnet.Location = new System.Drawing.Point(4, 22);
            this.tpCarnet.Name = "tpCarnet";
            this.tpCarnet.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpCarnet.Size = new System.Drawing.Size(925, 367);
            this.tpCarnet.TabIndex = 1;
            this.tpCarnet.Text = "Carnet d\'Entretiens";
            this.tpCarnet.UseVisualStyleBackColor = true;
            // 
            // dtgvCarnetEntretiens
            // 
            this.dtgvCarnetEntretiens.AllowUserToAddRows = false;
            this.dtgvCarnetEntretiens.AllowUserToDeleteRows = false;
            this.dtgvCarnetEntretiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarnetEntretiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdEntretien,
            this.colFait,
            this.colDescription,
            this.colDateDerniereMaintenance,
            this.colKmDerniereMaintenance,
            this.colFrequence,
            this.colProchaineMaintenance});
            this.dtgvCarnetEntretiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCarnetEntretiens.Location = new System.Drawing.Point(3, 3);
            this.dtgvCarnetEntretiens.Name = "dtgvCarnetEntretiens";
            this.dtgvCarnetEntretiens.ReadOnly = true;
            this.dtgvCarnetEntretiens.RowHeadersVisible = false;
            this.dtgvCarnetEntretiens.RowHeadersWidth = 102;
            this.dtgvCarnetEntretiens.Size = new System.Drawing.Size(919, 361);
            this.dtgvCarnetEntretiens.TabIndex = 1;
            this.dtgvCarnetEntretiens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCarnetEntretiens_CellContentClick);
            // 
            // tpGestion
            // 
            this.tpGestion.Controls.Add(this.dtgvGestionEntretiens);
            this.tpGestion.Controls.Add(this.btnAjoutEntretien);
            this.tpGestion.Location = new System.Drawing.Point(4, 22);
            this.tpGestion.Name = "tpGestion";
            this.tpGestion.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpGestion.Size = new System.Drawing.Size(925, 367);
            this.tpGestion.TabIndex = 2;
            this.tpGestion.Text = "Gestion des Entretiens";
            this.tpGestion.UseVisualStyleBackColor = true;
            // 
            // dtgvGestionEntretiens
            // 
            this.dtgvGestionEntretiens.AllowUserToAddRows = false;
            this.dtgvGestionEntretiens.AllowUserToDeleteRows = false;
            this.dtgvGestionEntretiens.AllowUserToResizeRows = false;
            this.dtgvGestionEntretiens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvGestionEntretiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionEntretiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdEntretienGestion,
            this.colFaitGestion,
            this.colDescriptionGestion,
            this.colKmLorsEntretienGestion,
            this.colFreqKmGestion,
            this.colModifierGestion,
            this.colSupprimerGestion});
            this.dtgvGestionEntretiens.Location = new System.Drawing.Point(1, 35);
            this.dtgvGestionEntretiens.Name = "dtgvGestionEntretiens";
            this.dtgvGestionEntretiens.ReadOnly = true;
            this.dtgvGestionEntretiens.RowHeadersVisible = false;
            this.dtgvGestionEntretiens.RowHeadersWidth = 102;
            this.dtgvGestionEntretiens.Size = new System.Drawing.Size(920, 328);
            this.dtgvGestionEntretiens.TabIndex = 3;
            this.dtgvGestionEntretiens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGestionEntretiens_CellContentClick);
            // 
            // colIdEntretienGestion
            // 
            this.colIdEntretienGestion.HeaderText = "Id";
            this.colIdEntretienGestion.MinimumWidth = 12;
            this.colIdEntretienGestion.Name = "colIdEntretienGestion";
            this.colIdEntretienGestion.ReadOnly = true;
            this.colIdEntretienGestion.Visible = false;
            this.colIdEntretienGestion.Width = 250;
            // 
            // colFaitGestion
            // 
            this.colFaitGestion.HeaderText = "Effectué";
            this.colFaitGestion.MinimumWidth = 12;
            this.colFaitGestion.Name = "colFaitGestion";
            this.colFaitGestion.ReadOnly = true;
            this.colFaitGestion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFaitGestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFaitGestion.Width = 50;
            // 
            // colDescriptionGestion
            // 
            this.colDescriptionGestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescriptionGestion.HeaderText = "Description";
            this.colDescriptionGestion.MinimumWidth = 12;
            this.colDescriptionGestion.Name = "colDescriptionGestion";
            this.colDescriptionGestion.ReadOnly = true;
            // 
            // colKmLorsEntretienGestion
            // 
            this.colKmLorsEntretienGestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKmLorsEntretienGestion.HeaderText = "Km lors de l\'entretien";
            this.colKmLorsEntretienGestion.MinimumWidth = 12;
            this.colKmLorsEntretienGestion.Name = "colKmLorsEntretienGestion";
            this.colKmLorsEntretienGestion.ReadOnly = true;
            // 
            // colFreqKmGestion
            // 
            this.colFreqKmGestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFreqKmGestion.HeaderText = "Fréquence";
            this.colFreqKmGestion.MinimumWidth = 12;
            this.colFreqKmGestion.Name = "colFreqKmGestion";
            this.colFreqKmGestion.ReadOnly = true;
            // 
            // colModifierGestion
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            this.colModifierGestion.DefaultCellStyle = dataGridViewCellStyle6;
            this.colModifierGestion.FillWeight = 204.8044F;
            this.colModifierGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colModifierGestion.HeaderText = "Modifier";
            this.colModifierGestion.MinimumWidth = 12;
            this.colModifierGestion.Name = "colModifierGestion";
            this.colModifierGestion.ReadOnly = true;
            this.colModifierGestion.Text = "Modif.";
            this.colModifierGestion.Width = 70;
            // 
            // colSupprimerGestion
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSupprimerGestion.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSupprimerGestion.FillWeight = 228.4264F;
            this.colSupprimerGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSupprimerGestion.HeaderText = "Supprimer";
            this.colSupprimerGestion.MinimumWidth = 12;
            this.colSupprimerGestion.Name = "colSupprimerGestion";
            this.colSupprimerGestion.ReadOnly = true;
            this.colSupprimerGestion.Text = "Test de texte";
            this.colSupprimerGestion.Width = 70;
            // 
            // btnAjoutEntretien
            // 
            this.btnAjoutEntretien.Location = new System.Drawing.Point(5, 4);
            this.btnAjoutEntretien.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjoutEntretien.Name = "btnAjoutEntretien";
            this.btnAjoutEntretien.Size = new System.Drawing.Size(914, 28);
            this.btnAjoutEntretien.TabIndex = 2;
            this.btnAjoutEntretien.Text = "Ajouter un nouvel Entretien";
            this.btnAjoutEntretien.UseVisualStyleBackColor = true;
            this.btnAjoutEntretien.Click += new System.EventHandler(this.btnAjoutEntretien_Click);
            // 
            // tpInterets
            // 
            this.tpInterets.Controls.Add(this.lblErreurAjoutPointInteret);
            this.tpInterets.Controls.Add(this.lblNomPointInteret);
            this.tpInterets.Controls.Add(this.tbxNomPointInteret);
            this.tpInterets.Controls.Add(this.cbxVisitePointInteret);
            this.tpInterets.Controls.Add(this.label8);
            this.tpInterets.Controls.Add(this.btnAjouterPointInteret);
            this.tpInterets.Controls.Add(this.label7);
            this.tpInterets.Controls.Add(this.label6);
            this.tpInterets.Controls.Add(this.label5);
            this.tpInterets.Controls.Add(this.tbxDescriptionPointInteret);
            this.tpInterets.Controls.Add(this.gmcCarte);
            this.tpInterets.Location = new System.Drawing.Point(4, 22);
            this.tpInterets.Name = "tpInterets";
            this.tpInterets.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpInterets.Size = new System.Drawing.Size(925, 367);
            this.tpInterets.TabIndex = 3;
            this.tpInterets.Text = "Points d\'intérêts";
            this.tpInterets.UseVisualStyleBackColor = true;
            // 
            // lblNomPointInteret
            // 
            this.lblNomPointInteret.AutoSize = true;
            this.lblNomPointInteret.Location = new System.Drawing.Point(615, 64);
            this.lblNomPointInteret.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNomPointInteret.Name = "lblNomPointInteret";
            this.lblNomPointInteret.Size = new System.Drawing.Size(32, 13);
            this.lblNomPointInteret.TabIndex = 33;
            this.lblNomPointInteret.Text = "Nom:";
            // 
            // tbxNomPointInteret
            // 
            this.tbxNomPointInteret.Location = new System.Drawing.Point(752, 61);
            this.tbxNomPointInteret.Name = "tbxNomPointInteret";
            this.tbxNomPointInteret.Size = new System.Drawing.Size(154, 20);
            this.tbxNomPointInteret.TabIndex = 32;
            // 
            // cbxVisitePointInteret
            // 
            this.cbxVisitePointInteret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVisitePointInteret.FormattingEnabled = true;
            this.cbxVisitePointInteret.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.cbxVisitePointInteret.Location = new System.Drawing.Point(752, 87);
            this.cbxVisitePointInteret.Name = "cbxVisitePointInteret";
            this.cbxVisitePointInteret.Size = new System.Drawing.Size(154, 21);
            this.cbxVisitePointInteret.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(615, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 26);
            this.label8.TabIndex = 30;
            this.label8.Text = "Après avoir cliqué sur \"Ajouter\", sélectionner\r\nl\'endroit du restaurant sur la ca" +
    "rte pour l\'ajouter.";
            // 
            // btnAjouterPointInteret
            // 
            this.btnAjouterPointInteret.Location = new System.Drawing.Point(752, 225);
            this.btnAjouterPointInteret.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterPointInteret.Name = "btnAjouterPointInteret";
            this.btnAjouterPointInteret.Size = new System.Drawing.Size(154, 28);
            this.btnAjouterPointInteret.TabIndex = 29;
            this.btnAjouterPointInteret.Text = "Ajouter";
            this.btnAjouterPointInteret.UseVisualStyleBackColor = true;
            this.btnAjouterPointInteret.Click += new System.EventHandler(this.btnAjouterPointInteret_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(614, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ajouter un point d\'intérêt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Lieu déjà visité ?";
            // 
            // tbxDescriptionPointInteret
            // 
            this.tbxDescriptionPointInteret.Location = new System.Drawing.Point(752, 112);
            this.tbxDescriptionPointInteret.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxDescriptionPointInteret.Multiline = true;
            this.tbxDescriptionPointInteret.Name = "tbxDescriptionPointInteret";
            this.tbxDescriptionPointInteret.Size = new System.Drawing.Size(154, 101);
            this.tbxDescriptionPointInteret.TabIndex = 21;
            // 
            // gmcCarte
            // 
            this.gmcCarte.Bearing = 0F;
            this.gmcCarte.CanDragMap = true;
            this.gmcCarte.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmcCarte.GrayScaleMode = false;
            this.gmcCarte.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmcCarte.LevelsKeepInMemory = 5;
            this.gmcCarte.Location = new System.Drawing.Point(4, 4);
            this.gmcCarte.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gmcCarte.MarkersEnabled = true;
            this.gmcCarte.MaxZoom = 18;
            this.gmcCarte.MinZoom = 2;
            this.gmcCarte.MouseWheelZoomEnabled = true;
            this.gmcCarte.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmcCarte.Name = "gmcCarte";
            this.gmcCarte.NegativeMode = false;
            this.gmcCarte.PolygonsEnabled = true;
            this.gmcCarte.RetryLoadTile = 0;
            this.gmcCarte.RoutesEnabled = true;
            this.gmcCarte.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmcCarte.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmcCarte.ShowTileGridLines = false;
            this.gmcCarte.Size = new System.Drawing.Size(591, 364);
            this.gmcCarte.TabIndex = 0;
            this.gmcCarte.Zoom = 10D;
            this.gmcCarte.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.gmcCarte_OnMapClick);
            this.gmcCarte.Load += new System.EventHandler(this.gmcCarte_Load);
            // 
            // gbVehicule
            // 
            this.gbVehicule.Controls.Add(this.label4);
            this.gbVehicule.Controls.Add(this.tbxKmReel);
            this.gbVehicule.Controls.Add(this.label3);
            this.gbVehicule.Controls.Add(this.tbxKmInitial);
            this.gbVehicule.Controls.Add(this.btnModifierVehicule);
            this.gbVehicule.Controls.Add(this.label2);
            this.gbVehicule.Controls.Add(this.label1);
            this.gbVehicule.Controls.Add(this.btnSupprimerVehicule);
            this.gbVehicule.Controls.Add(this.btnAjouterVehicule);
            this.gbVehicule.Controls.Add(this.tbxDescription);
            this.gbVehicule.Controls.Add(this.pcbPhoto);
            this.gbVehicule.Controls.Add(this.cbxVehicules);
            this.gbVehicule.Location = new System.Drawing.Point(4, 11);
            this.gbVehicule.Name = "gbVehicule";
            this.gbVehicule.Size = new System.Drawing.Size(929, 202);
            this.gbVehicule.TabIndex = 2;
            this.gbVehicule.TabStop = false;
            this.gbVehicule.Text = "Véhicules";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre de kilomètres actuel:";
            // 
            // tbxKmReel
            // 
            this.tbxKmReel.Location = new System.Drawing.Point(242, 81);
            this.tbxKmReel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxKmReel.Name = "tbxKmReel";
            this.tbxKmReel.ReadOnly = true;
            this.tbxKmReel.Size = new System.Drawing.Size(224, 20);
            this.tbxKmReel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre de kilomètres lors de l\'achat:";
            // 
            // tbxKmInitial
            // 
            this.tbxKmInitial.Location = new System.Drawing.Point(242, 36);
            this.tbxKmInitial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxKmInitial.Name = "tbxKmInitial";
            this.tbxKmInitial.ReadOnly = true;
            this.tbxKmInitial.Size = new System.Drawing.Size(224, 20);
            this.tbxKmInitial.TabIndex = 8;
            // 
            // btnModifierVehicule
            // 
            this.btnModifierVehicule.Enabled = false;
            this.btnModifierVehicule.Location = new System.Drawing.Point(756, 17);
            this.btnModifierVehicule.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnModifierVehicule.Name = "btnModifierVehicule";
            this.btnModifierVehicule.Size = new System.Drawing.Size(169, 51);
            this.btnModifierVehicule.TabIndex = 7;
            this.btnModifierVehicule.Text = "Modifier ce véhicule";
            this.btnModifierVehicule.UseVisualStyleBackColor = true;
            this.btnModifierVehicule.Click += new System.EventHandler(this.btnModifierVehicule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selectionnez un véhicule:";
            // 
            // btnSupprimerVehicule
            // 
            this.btnSupprimerVehicule.Enabled = false;
            this.btnSupprimerVehicule.Location = new System.Drawing.Point(756, 80);
            this.btnSupprimerVehicule.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSupprimerVehicule.Name = "btnSupprimerVehicule";
            this.btnSupprimerVehicule.Size = new System.Drawing.Size(169, 51);
            this.btnSupprimerVehicule.TabIndex = 4;
            this.btnSupprimerVehicule.Text = "Supprimer ce véhicule";
            this.btnSupprimerVehicule.UseVisualStyleBackColor = true;
            this.btnSupprimerVehicule.Click += new System.EventHandler(this.btnSupprimerVehicule_Click);
            // 
            // btnAjouterVehicule
            // 
            this.btnAjouterVehicule.Location = new System.Drawing.Point(756, 147);
            this.btnAjouterVehicule.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterVehicule.Name = "btnAjouterVehicule";
            this.btnAjouterVehicule.Size = new System.Drawing.Size(169, 51);
            this.btnAjouterVehicule.TabIndex = 3;
            this.btnAjouterVehicule.Text = "Ajouter un nouveau véhicule";
            this.btnAjouterVehicule.UseVisualStyleBackColor = true;
            this.btnAjouterVehicule.Click += new System.EventHandler(this.btnAjouterVehicule_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(4, 77);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(224, 121);
            this.tbxDescription.TabIndex = 2;
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.Location = new System.Drawing.Point(482, 17);
            this.pcbPhoto.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(240, 181);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPhoto.TabIndex = 1;
            this.pcbPhoto.TabStop = false;
            // 
            // cbxVehicules
            // 
            this.cbxVehicules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVehicules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehicules.FormattingEnabled = true;
            this.cbxVehicules.Location = new System.Drawing.Point(6, 34);
            this.cbxVehicules.Name = "cbxVehicules";
            this.cbxVehicules.Size = new System.Drawing.Size(222, 24);
            this.cbxVehicules.TabIndex = 0;
            this.cbxVehicules.SelectedIndexChanged += new System.EventHandler(this.cbxVehicules_SelectedIndexChanged);
            // 
            // lblErreurAjoutPointInteret
            // 
            this.lblErreurAjoutPointInteret.AutoSize = true;
            this.lblErreurAjoutPointInteret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurAjoutPointInteret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErreurAjoutPointInteret.Location = new System.Drawing.Point(615, 39);
            this.lblErreurAjoutPointInteret.Name = "lblErreurAjoutPointInteret";
            this.lblErreurAjoutPointInteret.Size = new System.Drawing.Size(0, 16);
            this.lblErreurAjoutPointInteret.TabIndex = 65;
            // 
            // colDepart
            // 
            this.colDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepart.FillWeight = 41.69231F;
            this.colDepart.HeaderText = "Départ";
            this.colDepart.MinimumWidth = 12;
            this.colDepart.Name = "colDepart";
            this.colDepart.ReadOnly = true;
            // 
            // colArrivee
            // 
            this.colArrivee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArrivee.FillWeight = 41.69231F;
            this.colArrivee.HeaderText = "Arrivée";
            this.colArrivee.MinimumWidth = 12;
            this.colArrivee.Name = "colArrivee";
            this.colArrivee.ReadOnly = true;
            // 
            // colDistance
            // 
            this.colDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDistance.FillWeight = 41.69231F;
            this.colDistance.HeaderText = "Distance(Km)";
            this.colDistance.MinimumWidth = 12;
            this.colDistance.Name = "colDistance";
            this.colDistance.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDate.FillWeight = 41.69231F;
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 12;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colModifier
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            this.colModifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.colModifier.FillWeight = 204.8044F;
            this.colModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colModifier.HeaderText = "Modifier";
            this.colModifier.MinimumWidth = 12;
            this.colModifier.Name = "colModifier";
            this.colModifier.ReadOnly = true;
            this.colModifier.Text = "Modif.";
            this.colModifier.Width = 70;
            // 
            // colSupprimer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSupprimer.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSupprimer.FillWeight = 228.4264F;
            this.colSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSupprimer.HeaderText = "Supprimer";
            this.colSupprimer.MinimumWidth = 12;
            this.colSupprimer.Name = "colSupprimer";
            this.colSupprimer.ReadOnly = true;
            this.colSupprimer.Text = "Test de texte";
            this.colSupprimer.Width = 70;
            // 
            // colIdEntretien
            // 
            this.colIdEntretien.HeaderText = "Id";
            this.colIdEntretien.MinimumWidth = 12;
            this.colIdEntretien.Name = "colIdEntretien";
            this.colIdEntretien.ReadOnly = true;
            this.colIdEntretien.Visible = false;
            this.colIdEntretien.Width = 250;
            // 
            // colFait
            // 
            this.colFait.HeaderText = "Effectué";
            this.colFait.MinimumWidth = 12;
            this.colFait.Name = "colFait";
            this.colFait.ReadOnly = true;
            this.colFait.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFait.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFait.Width = 50;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 12;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colDateDerniereMaintenance
            // 
            this.colDateDerniereMaintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.colDateDerniereMaintenance.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDateDerniereMaintenance.HeaderText = "Date Dernière Maintenance";
            this.colDateDerniereMaintenance.MinimumWidth = 12;
            this.colDateDerniereMaintenance.Name = "colDateDerniereMaintenance";
            this.colDateDerniereMaintenance.ReadOnly = true;
            this.colDateDerniereMaintenance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colKmDerniereMaintenance
            // 
            this.colKmDerniereMaintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKmDerniereMaintenance.HeaderText = "Km Dernière Maintenance";
            this.colKmDerniereMaintenance.MinimumWidth = 12;
            this.colKmDerniereMaintenance.Name = "colKmDerniereMaintenance";
            this.colKmDerniereMaintenance.ReadOnly = true;
            // 
            // colFrequence
            // 
            this.colFrequence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFrequence.HeaderText = "Fréquence";
            this.colFrequence.MinimumWidth = 12;
            this.colFrequence.Name = "colFrequence";
            this.colFrequence.ReadOnly = true;
            // 
            // colProchaineMaintenance
            // 
            this.colProchaineMaintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.colProchaineMaintenance.DefaultCellStyle = dataGridViewCellStyle5;
            this.colProchaineMaintenance.HeaderText = "Prochaine Maintenance dans (km):";
            this.colProchaineMaintenance.MinimumWidth = 12;
            this.colProchaineMaintenance.Name = "colProchaineMaintenance";
            this.colProchaineMaintenance.ReadOnly = true;
            this.colProchaineMaintenance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 619);
            this.Controls.Add(this.gbVehicule);
            this.Controls.Add(this.tcMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Moto Care";
            this.tcMenu.ResumeLayout(false);
            this.tpTrajets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrajets)).EndInit();
            this.tpCarnet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarnetEntretiens)).EndInit();
            this.tpGestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionEntretiens)).EndInit();
            this.tpInterets.ResumeLayout(false);
            this.tpInterets.PerformLayout();
            this.gbVehicule.ResumeLayout(false);
            this.gbVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpTrajets;
        private System.Windows.Forms.TabPage tpCarnet;
        private System.Windows.Forms.TabPage tpGestion;
        private System.Windows.Forms.TabPage tpInterets;
        private System.Windows.Forms.DataGridView dtgvTrajets;
        private System.Windows.Forms.GroupBox gbVehicule;
        private System.Windows.Forms.ComboBox cbxVehicules;
        private System.Windows.Forms.DataGridView dtgvCarnetEntretiens;
        private GMap.NET.WindowsForms.GMapControl gmcCarte;
        private System.Windows.Forms.PictureBox pcbPhoto;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnModifierVehicule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimerVehicule;
        private System.Windows.Forms.Button btnAjouterVehicule;
        private System.Windows.Forms.Button btnAjouterTrajet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxKmReel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxKmInitial;
        private System.Windows.Forms.DataGridView dtgvGestionEntretiens;
        private System.Windows.Forms.Button btnAjoutEntretien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEntretienGestion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFaitGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescriptionGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKmLorsEntretienGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreqKmGestion;
        private System.Windows.Forms.DataGridViewButtonColumn colModifierGestion;
        private System.Windows.Forms.DataGridViewButtonColumn colSupprimerGestion;
        private System.Windows.Forms.ComboBox cbxVisitePointInteret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAjouterPointInteret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDescriptionPointInteret;
        private System.Windows.Forms.Label lblNomPointInteret;
        private System.Windows.Forms.TextBox tbxNomPointInteret;
        private System.Windows.Forms.Label lblErreurAjoutPointInteret;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewButtonColumn colModifier;
        private System.Windows.Forms.DataGridViewButtonColumn colSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEntretien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFait;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateDerniereMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKmDerniereMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProchaineMaintenance;
    }
}

