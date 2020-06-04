namespace MotoCare
{
    partial class FrmAjoutEntretien
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
            this.lblErreurAjoutTrajet = new System.Windows.Forms.Label();
            this.tbxFreqKm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKmPremierEntretien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErreurAjoutTrajet
            // 
            this.lblErreurAjoutTrajet.AutoSize = true;
            this.lblErreurAjoutTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurAjoutTrajet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErreurAjoutTrajet.Location = new System.Drawing.Point(15, 35);
            this.lblErreurAjoutTrajet.Name = "lblErreurAjoutTrajet";
            this.lblErreurAjoutTrajet.Size = new System.Drawing.Size(0, 16);
            this.lblErreurAjoutTrajet.TabIndex = 56;
            // 
            // tbxFreqKm
            // 
            this.tbxFreqKm.Location = new System.Drawing.Point(162, 189);
            this.tbxFreqKm.Margin = new System.Windows.Forms.Padding(1);
            this.tbxFreqKm.Name = "tbxFreqKm";
            this.tbxFreqKm.Size = new System.Drawing.Size(200, 20);
            this.tbxFreqKm.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ajout d\'un entretien";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(329, 242);
            this.btnValider.Margin = new System.Windows.Forms.Padding(1);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 23);
            this.btnValider.TabIndex = 49;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 242);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 23);
            this.btnAnnuler.TabIndex = 50;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(162, 57);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(1);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size = new System.Drawing.Size(200, 79);
            this.tbxDescription.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "La fréquence à laquelle \r\neffectuer l\'entretien:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Description:";
            // 
            // tbxKmPremierEntretien
            // 
            this.tbxKmPremierEntretien.Location = new System.Drawing.Point(162, 147);
            this.tbxKmPremierEntretien.Margin = new System.Windows.Forms.Padding(1);
            this.tbxKmPremierEntretien.Name = "tbxKmPremierEntretien";
            this.tbxKmPremierEntretien.Size = new System.Drawing.Size(200, 20);
            this.tbxKmPremierEntretien.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Le premier entretien se fera à :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Km";
            // 
            // FrmAjoutEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 275);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKmPremierEntretien);
            this.Controls.Add(this.lblErreurAjoutTrajet);
            this.Controls.Add(this.tbxFreqKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutEntretien";
            this.Text = "frmAjoutEntretien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreurAjoutTrajet;
        private System.Windows.Forms.TextBox tbxFreqKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKmPremierEntretien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}