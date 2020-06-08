/*
 *  Auteur      :   Luca Wohlers
 *  Professeur  :   Mme. Anne Terrier
 *  Experts     :   M. Borys Folomietow et M. Alain Fontanini
 *  Date        :   08 Juin 2020
 *  Projet      :   Moto Care
 *  Version     :   1.0
 *  Description :   Moto Care est une application développé dans le cadre
 *                  d'un travail pratique individuel (TPI) que les élèves d'informatique
 *                  doivent effectuer à la fin de leur CFC.
 *                  Cette application consiste à gérer des entretiens et trajets en fonction 
 *                  de véhicules. On peut aussi voir et ajouter des points d'intérêts sur une carte.
 *  Fichier     :   frmAjoutEntretien.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoCare
{
    public partial class FrmAjoutEntretien : Form
    {
        private string _description;
        private string _kmPremierEntretien;
        private string _freqKm;

        public string Description { get => tbxDescription.Text; set => _description = value; }
        public string KmPremierEntretien { get => nudKmPremierEntretien.Value.ToString(); set => _kmPremierEntretien = value; }
        public string FreqKm { get => nudFreqKm.Value.ToString(); set => _freqKm = value; }

        public FrmAjoutEntretien()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Description == "" || KmPremierEntretien == "" || FreqKm == "")
            {
                lblErreurAjoutTrajet.Text = "Veuillez renseigner tous les champs";
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
