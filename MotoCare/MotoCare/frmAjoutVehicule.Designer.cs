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
            this.button1 = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.nudReel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom (marque,model):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nb. de Km lors de l\'achat:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Photo:";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(411, 115);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(428, 38);
            this.tbxNom.TabIndex = 4;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(411, 186);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(428, 141);
            this.tbxDescription.TabIndex = 5;
            // 
            // nudInitial
            // 
            this.nudInitial.Location = new System.Drawing.Point(411, 351);
            this.nudInitial.Name = "nudInitial";
            this.nudInitial.Size = new System.Drawing.Size(428, 38);
            this.nudInitial.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValider.Location = new System.Drawing.Point(689, 608);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(150, 56);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ajout d\'un véhicule";
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(411, 497);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(428, 59);
            this.btnPhoto.TabIndex = 10;
            this.btnPhoto.Text = "Ajouter une photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // nudReel
            // 
            this.nudReel.Location = new System.Drawing.Point(411, 419);
            this.nudReel.Name = "nudReel";
            this.nudReel.Size = new System.Drawing.Size(428, 38);
            this.nudReel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nb. de Km actuels:";
            // 
            // FrmAjoutVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 676);
            this.Controls.Add(this.nudReel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudInitial);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAjoutVehicule";
            this.Text = "Ajouter un véhicule";
            ((System.ComponentModel.ISupportInitialize)(this.nudInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReel)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.NumericUpDown nudReel;
        private System.Windows.Forms.Label label6;
    }
}