namespace MotoCare
{
    partial class FrmAjoutVehicule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.nudInitial = new System.Windows.Forms.NumericUpDown();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.nudReel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErreurAjoutVehicule = new System.Windows.Forms.Label();
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom (marque,model):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nb. de Km lors de l\'achat:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Photo:";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(157, 58);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(160, 20);
            this.tbxNom.TabIndex = 1;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(157, 91);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size = new System.Drawing.Size(160, 61);
            this.tbxDescription.TabIndex = 2;
            // 
            // nudInitial
            // 
            this.nudInitial.Location = new System.Drawing.Point(157, 158);
            this.nudInitial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.nudInitial.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudInitial.Name = "nudInitial";
            this.nudInitial.Size = new System.Drawing.Size(160, 20);
            this.nudInitial.TabIndex = 3;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 355);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(261, 355);
            this.btnValider.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ajout d\'un véhicule";
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(157, 220);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(160, 25);
            this.btnPhoto.TabIndex = 5;
            this.btnPhoto.Text = "Ajouter une photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // nudReel
            // 
            this.nudReel.Location = new System.Drawing.Point(157, 187);
            this.nudReel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.nudReel.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudReel.Name = "nudReel";
            this.nudReel.Size = new System.Drawing.Size(160, 20);
            this.nudReel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nb. de Km actuels:";
            // 
            // lblErreurAjoutVehicule
            // 
            this.lblErreurAjoutVehicule.AutoSize = true;
            this.lblErreurAjoutVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurAjoutVehicule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErreurAjoutVehicule.Location = new System.Drawing.Point(7, 38);
            this.lblErreurAjoutVehicule.Name = "lblErreurAjoutVehicule";
            this.lblErreurAjoutVehicule.Size = new System.Drawing.Size(0, 16);
            this.lblErreurAjoutVehicule.TabIndex = 12;
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.Location = new System.Drawing.Point(157, 249);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(160, 97);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPhoto.TabIndex = 28;
            this.pcbPhoto.TabStop = false;
            // 
            // FrmAjoutVehicule
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 388);
            this.Controls.Add(this.pcbPhoto);
            this.Controls.Add(this.lblErreurAjoutVehicule);
            this.Controls.Add(this.nudReel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.nudInitial);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmAjoutVehicule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un véhicule";
            ((System.ComponentModel.ISupportInitialize)(this.nudInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.NumericUpDown nudInitial;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.NumericUpDown nudReel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErreurAjoutVehicule;
        private System.Windows.Forms.PictureBox pcbPhoto;
    }
}