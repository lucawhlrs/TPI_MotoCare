namespace MotoCare
{
    partial class FrmAjoutTrajet
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.tbxDepart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbxArrivee = new System.Windows.Forms.TextBox();
            this.lblErreurAjoutTrajet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date lors du trajet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ajout d\'un trajet";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(261, 205);
            this.btnValider.Margin = new System.Windows.Forms.Padding(1);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(56, 23);
            this.btnValider.TabIndex = 39;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 205);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 23);
            this.btnAnnuler.TabIndex = 40;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // nudDistance
            // 
            this.nudDistance.Location = new System.Drawing.Point(117, 122);
            this.nudDistance.Margin = new System.Windows.Forms.Padding(1);
            this.nudDistance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(200, 20);
            this.nudDistance.TabIndex = 35;
            // 
            // tbxDepart
            // 
            this.tbxDepart.Location = new System.Drawing.Point(117, 57);
            this.tbxDepart.Margin = new System.Windows.Forms.Padding(1);
            this.tbxDepart.Name = "tbxDepart";
            this.tbxDepart.Size = new System.Drawing.Size(200, 20);
            this.tbxDepart.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Distance parcourue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Arrivée:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Départ:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(117, 153);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 42;
            this.dtpDate.Value = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            // 
            // tbxArrivee
            // 
            this.tbxArrivee.Location = new System.Drawing.Point(117, 90);
            this.tbxArrivee.Margin = new System.Windows.Forms.Padding(1);
            this.tbxArrivee.Name = "tbxArrivee";
            this.tbxArrivee.Size = new System.Drawing.Size(200, 20);
            this.tbxArrivee.TabIndex = 43;
            // 
            // lblErreurAjoutTrajet
            // 
            this.lblErreurAjoutTrajet.AutoSize = true;
            this.lblErreurAjoutTrajet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurAjoutTrajet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErreurAjoutTrajet.Location = new System.Drawing.Point(12, 35);
            this.lblErreurAjoutTrajet.Name = "lblErreurAjoutTrajet";
            this.lblErreurAjoutTrajet.Size = new System.Drawing.Size(0, 16);
            this.lblErreurAjoutTrajet.TabIndex = 44;
            // 
            // FrmAjoutTrajet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 238);
            this.Controls.Add(this.lblErreurAjoutTrajet);
            this.Controls.Add(this.tbxArrivee);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.tbxDepart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutTrajet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout d\'un trajet";
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.TextBox tbxDepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbxArrivee;
        private System.Windows.Forms.Label lblErreurAjoutTrajet;
    }
}