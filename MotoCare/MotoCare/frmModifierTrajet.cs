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
 *  Fichier     :   frmModifierTrajet.cs
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
    public partial class FrmModifierTrajet : Form
    {
        private string _depart;
        private string _arrivee;
        private string _distance;
        private string _date;
        public string Depart { get => tbxDepart.Text; set => _depart = value; }
        public string Arrivee { get => tbxArrivee.Text; set => _arrivee = value; }
        public string Distance { get => nudDistance.Value.ToString(); set => _distance = value; }
        public string Date { get => dtpDate.Value.ToString(); set => _date = value; }

        public FrmModifierTrajet(string depart, string arrivee, string distance, string date)
        {
            InitializeComponent();
            tbxDepart.Text = depart;
            tbxArrivee.Text = arrivee;
            nudDistance.Value = Convert.ToDecimal(distance);
            dtpDate.Value = new DateTime(Convert.ToInt32(date.Substring(6, 4)), Convert.ToInt32(date.Substring(3, 2)), Convert.ToInt32(date.Substring(0, 2))); ;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Depart == "" || Arrivee == "" || Date == "")
            {
                lblErreurAjoutTrajet.Text = "Veuillez renseigner tous les champs.";
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
