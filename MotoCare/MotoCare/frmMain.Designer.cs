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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpTrajets = new System.Windows.Forms.TabPage();
            this.btnAjouterTrajet = new System.Windows.Forms.Button();
            this.dtgvTrajets = new System.Windows.Forms.DataGridView();
            this.tpCarnet = new System.Windows.Forms.TabPage();
            this.dtgvCarnetEntretiens = new System.Windows.Forms.DataGridView();
            this.tpGestion = new System.Windows.Forms.TabPage();
            this.tpInterets = new System.Windows.Forms.TabPage();
            this.gmcCarte = new GMap.NET.WindowsForms.GMapControl();
            this.gbVehicule = new System.Windows.Forms.GroupBox();
            this.btnModifierVehicule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimerVehicule = new System.Windows.Forms.Button();
            this.btnAjouterVehicule = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            this.cbxVehicules = new System.Windows.Forms.ComboBox();
            this.tbxKmInitial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxKmReel = new System.Windows.Forms.TextBox();
            this.colDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAjoutEntretien = new System.Windows.Forms.Button();
            this.dtgvGestionEntretiens = new System.Windows.Forms.DataGridView();
            this.colDescriptionGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKmLorsEntretienGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreqKmGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifierGestion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSupprimerGestion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colFait = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateDerniereMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKmDerniereMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProchaineMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.tpTrajets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrajets)).BeginInit();
            this.tpCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarnetEntretiens)).BeginInit();
            this.tpGestion.SuspendLayout();
            this.tpInterets.SuspendLayout();
            this.gbVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionEntretiens)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpTrajets);
            this.tcMenu.Controls.Add(this.tpCarnet);
            this.tcMenu.Controls.Add(this.tpGestion);
            this.tcMenu.Controls.Add(this.tpInterets);
            this.tcMenu.Location = new System.Drawing.Point(4, 252);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(933, 392);
            this.tcMenu.TabIndex = 1;
            // 
            // tpTrajets
            // 
            this.tpTrajets.Controls.Add(this.btnAjouterTrajet);
            this.tpTrajets.Controls.Add(this.dtgvTrajets);
            this.tpTrajets.Location = new System.Drawing.Point(4, 22);
            this.tpTrajets.Name = "tpTrajets";
            this.tpTrajets.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpTrajets.Size = new System.Drawing.Size(925, 366);
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
            this.tpCarnet.Size = new System.Drawing.Size(925, 366);
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
            this.dtgvCarnetEntretiens.Size = new System.Drawing.Size(919, 360);
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
            this.tpGestion.Size = new System.Drawing.Size(925, 366);
            this.tpGestion.TabIndex = 2;
            this.tpGestion.Text = "Gestion des Entretiens";
            this.tpGestion.UseVisualStyleBackColor = true;
            // 
            // tpInterets
            // 
            this.tpInterets.Controls.Add(this.gmcCarte);
            this.tpInterets.Location = new System.Drawing.Point(4, 22);
            this.tpInterets.Name = "tpInterets";
            this.tpInterets.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpInterets.Size = new System.Drawing.Size(925, 366);
            this.tpInterets.TabIndex = 3;
            this.tpInterets.Text = "Points d\'intérêts";
            this.tpInterets.UseVisualStyleBackColor = true;
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
            this.gmcCarte.Size = new System.Drawing.Size(519, 359);
            this.gmcCarte.TabIndex = 0;
            this.gmcCarte.Zoom = 0D;
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
            this.gbVehicule.Location = new System.Drawing.Point(4, 35);
            this.gbVehicule.Name = "gbVehicule";
            this.gbVehicule.Size = new System.Drawing.Size(929, 202);
            this.gbVehicule.TabIndex = 2;
            this.gbVehicule.TabStop = false;
            this.gbVehicule.Text = "Véhicules";
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
            // tbxKmInitial
            // 
            this.tbxKmInitial.Location = new System.Drawing.Point(242, 36);
            this.tbxKmInitial.Margin = new System.Windows.Forms.Padding(1);
            this.tbxKmInitial.Name = "tbxKmInitial";
            this.tbxKmInitial.ReadOnly = true;
            this.tbxKmInitial.Size = new System.Drawing.Size(224, 20);
            this.tbxKmInitial.TabIndex = 8;
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
            this.tbxKmReel.Margin = new System.Windows.Forms.Padding(1);
            this.tbxKmReel.Name = "tbxKmReel";
            this.tbxKmReel.ReadOnly = true;
            this.tbxKmReel.Size = new System.Drawing.Size(224, 20);
            this.tbxKmReel.TabIndex = 10;
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
            dataGridViewCellStyle8.Format = "D";
            dataGridViewCellStyle8.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDate.FillWeight = 41.69231F;
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 12;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colModifier
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DodgerBlue;
            this.colModifier.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSupprimer.DefaultCellStyle = dataGridViewCellStyle10;
            this.colSupprimer.FillWeight = 228.4264F;
            this.colSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSupprimer.HeaderText = "Supprimer";
            this.colSupprimer.MinimumWidth = 12;
            this.colSupprimer.Name = "colSupprimer";
            this.colSupprimer.ReadOnly = true;
            this.colSupprimer.Text = "Test de texte";
            this.colSupprimer.Width = 70;
            // 
            // btnAjoutEntretien
            // 
            this.btnAjoutEntretien.Location = new System.Drawing.Point(5, 4);
            this.btnAjoutEntretien.Margin = new System.Windows.Forms.Padding(1);
            this.btnAjoutEntretien.Name = "btnAjoutEntretien";
            this.btnAjoutEntretien.Size = new System.Drawing.Size(914, 28);
            this.btnAjoutEntretien.TabIndex = 2;
            this.btnAjoutEntretien.Text = "Ajouter un nouvel Entretien";
            this.btnAjoutEntretien.UseVisualStyleBackColor = true;
            this.btnAjoutEntretien.Click += new System.EventHandler(this.btnAjoutEntretien_Click);
            // 
            // dtgvGestionEntretiens
            // 
            this.dtgvGestionEntretiens.AllowUserToAddRows = false;
            this.dtgvGestionEntretiens.AllowUserToDeleteRows = false;
            this.dtgvGestionEntretiens.AllowUserToResizeRows = false;
            this.dtgvGestionEntretiens.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvGestionEntretiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGestionEntretiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            // colDescriptionGestion
            // 
            this.colDescriptionGestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescriptionGestion.HeaderText = "Description";
            this.colDescriptionGestion.Name = "colDescriptionGestion";
            this.colDescriptionGestion.ReadOnly = true;
            // 
            // colKmLorsEntretienGestion
            // 
            this.colKmLorsEntretienGestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKmLorsEntretienGestion.HeaderText = "Km lors de l\'entretien";
            this.colKmLorsEntretienGestion.Name = "colKmLorsEntretienGestion";
            this.colKmLorsEntretienGestion.ReadOnly = true;
            // 
            // colFreqKmGestion
            // 
            this.colFreqKmGestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFreqKmGestion.HeaderText = "Fréquence";
            this.colFreqKmGestion.Name = "colFreqKmGestion";
            this.colFreqKmGestion.ReadOnly = true;
            // 
            // colModifierGestion
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            this.colModifierGestion.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSupprimerGestion.DefaultCellStyle = dataGridViewCellStyle12;
            this.colSupprimerGestion.FillWeight = 228.4264F;
            this.colSupprimerGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSupprimerGestion.HeaderText = "Supprimer";
            this.colSupprimerGestion.MinimumWidth = 12;
            this.colSupprimerGestion.Name = "colSupprimerGestion";
            this.colSupprimerGestion.ReadOnly = true;
            this.colSupprimerGestion.Text = "Test de texte";
            this.colSupprimerGestion.Width = 70;
            // 
            // colFait
            // 
            this.colFait.HeaderText = "Effectué";
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
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colDateDerniereMaintenance
            // 
            this.colDateDerniereMaintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Format = "D";
            dataGridViewCellStyle13.NullValue = null;
            this.colDateDerniereMaintenance.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDateDerniereMaintenance.HeaderText = "Date Dernière Maintenance";
            this.colDateDerniereMaintenance.Name = "colDateDerniereMaintenance";
            this.colDateDerniereMaintenance.ReadOnly = true;
            // 
            // colKmDerniereMaintenance
            // 
            this.colKmDerniereMaintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKmDerniereMaintenance.HeaderText = "Km Dernière Maintenance";
            this.colKmDerniereMaintenance.Name = "colKmDerniereMaintenance";
            this.colKmDerniereMaintenance.ReadOnly = true;
            // 
            // colFrequence
            // 
            this.colFrequence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFrequence.HeaderText = "Fréquence";
            this.colFrequence.Name = "colFrequence";
            this.colFrequence.ReadOnly = true;
            // 
            // colProchaineMaintenance
            // 
            this.colProchaineMaintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProchaineMaintenance.DefaultCellStyle = dataGridViewCellStyle14;
            this.colProchaineMaintenance.HeaderText = "Prochaine Maintenance dans (km):";
            this.colProchaineMaintenance.Name = "colProchaineMaintenance";
            this.colProchaineMaintenance.ReadOnly = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 648);
            this.Controls.Add(this.gbVehicule);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Moto Care";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcMenu.ResumeLayout(false);
            this.tpTrajets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrajets)).EndInit();
            this.tpCarnet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarnetEntretiens)).EndInit();
            this.tpGestion.ResumeLayout(false);
            this.tpInterets.ResumeLayout(false);
            this.gbVehicule.ResumeLayout(false);
            this.gbVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGestionEntretiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewButtonColumn colModifier;
        private System.Windows.Forms.DataGridViewButtonColumn colSupprimer;
        private System.Windows.Forms.DataGridView dtgvGestionEntretiens;
        private System.Windows.Forms.Button btnAjoutEntretien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescriptionGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKmLorsEntretienGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreqKmGestion;
        private System.Windows.Forms.DataGridViewButtonColumn colModifierGestion;
        private System.Windows.Forms.DataGridViewButtonColumn colSupprimerGestion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFait;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateDerniereMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKmDerniereMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProchaineMaintenance;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

