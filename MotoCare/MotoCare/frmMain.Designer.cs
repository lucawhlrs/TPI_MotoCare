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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpTrajets = new System.Windows.Forms.TabPage();
            this.btnAjouterTrajet = new System.Windows.Forms.Button();
            this.dtgvTrajets = new System.Windows.Forms.DataGridView();
            this.tpCarnet = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.menuStrip1.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.tpTrajets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrajets)).BeginInit();
            this.tpCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpInterets.SuspendLayout();
            this.gbVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
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
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(201, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 46);
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
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
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
            this.tpCarnet.Controls.Add(this.dataGridView2);
            this.tpCarnet.Location = new System.Drawing.Point(4, 22);
            this.tpCarnet.Name = "tpCarnet";
            this.tpCarnet.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpCarnet.Size = new System.Drawing.Size(925, 366);
            this.tpCarnet.TabIndex = 1;
            this.tpCarnet.Text = "Carnet d\'Entretiens";
            this.tpCarnet.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.Size = new System.Drawing.Size(919, 360);
            this.dataGridView2.TabIndex = 1;
            // 
            // tpGestion
            // 
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
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDate.FillWeight = 41.69231F;
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 12;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colModifier
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            this.colModifier.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSupprimer.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSupprimer.FillWeight = 228.4264F;
            this.colSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSupprimer.HeaderText = "Supprimer";
            this.colSupprimer.MinimumWidth = 12;
            this.colSupprimer.Name = "colSupprimer";
            this.colSupprimer.ReadOnly = true;
            this.colSupprimer.Text = "Test de texte";
            this.colSupprimer.Width = 70;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 648);
            this.Controls.Add(this.gbVehicule);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "Moto Care";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcMenu.ResumeLayout(false);
            this.tpTrajets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrajets)).EndInit();
            this.tpCarnet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpInterets.ResumeLayout(false);
            this.gbVehicule.ResumeLayout(false);
            this.gbVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpTrajets;
        private System.Windows.Forms.TabPage tpCarnet;
        private System.Windows.Forms.TabPage tpGestion;
        private System.Windows.Forms.TabPage tpInterets;
        private System.Windows.Forms.DataGridView dtgvTrajets;
        private System.Windows.Forms.GroupBox gbVehicule;
        private System.Windows.Forms.ComboBox cbxVehicules;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}

