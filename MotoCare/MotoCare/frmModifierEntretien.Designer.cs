namespace MotoCare
{
    partial class FrmModifierEntretien
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
            this.SuspendLayout();
            // 
            // lblErreurAjoutTrajet
            // 
            this.lblErreurAjoutTrajet.AutoSize = true;
            this.lblErreurAjoutTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurAjoutTrajet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErreurAjoutTrajet.Location = new System.Drawing.Point(15, 36);
            this.lblErreurAjoutTrajet.Name = "lblErreurAjoutTrajet";
            this.lblErreurAjoutTrajet.Size = new System.Drawing.Size(0, 16);
            this.lblErreurAjoutTrajet.TabIndex = 64;
            // 
            // tbxFreqKm
            // 
            this.tbxFreqKm.Location = new System.Drawing.Point(153, 153);
            this.tbxFreqKm.Margin = new System.Windows.Forms.Padding(1);
            this.tbxFreqKm.Name = "tbxFreqKm";
            this.tbxFreqKm.Size = new System.Drawing.Size(200, 20);
            this.tbxFreqKm.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Modifier un entretien";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(297, 201);
            this.btnValider.Margin = new System.Windows.Forms.Padding(1);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 23);
            this.btnValider.TabIndex = 59;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 201);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 23);
            this.btnAnnuler.TabIndex = 60;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(153, 58);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(1);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size = new System.Drawing.Size(200, 79);
            this.tbxDescription.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "La fréquence en km à \r\nlaquelle effectuer l\'entretien:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Description:";
            // 
            // FrmModifierEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 234);
            this.Controls.Add(this.lblErreurAjoutTrajet);
            this.Controls.Add(this.tbxFreqKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmModifierEntretien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmModifierEntretien";
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
    }
}