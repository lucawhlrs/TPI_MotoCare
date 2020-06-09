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
 *  Fichier     :   frmModifierVehicule.cs
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
    public partial class FrmModifierVehicule : Form
    {
        //Déclaration de bd pour pouvoir faire un appel à la classe BD et pouvoir convertir l'image en tableau d'octet
        BD bd = new BD();
        Image image;

        private string _nom;
        private string _description;
        private string _kmInitial;
        private string _kmReel;
        private byte[] _photoEnBytes;

        public string Nom { get => tbxNom.Text; set => _nom = value; }
        public string Description { get => tbxDescription.Text; set => _description = value; }
        public string KmInitial { get => nudInitial.Value.ToString(); set => _kmInitial = value; }
        public string KmReel { get => _kmReel; set => _kmReel = value; }//Ne change pas
        public byte[] PhotoEnBytes { get => _photoEnBytes; set => _photoEnBytes = value; }

        public FrmModifierVehicule(Vehicule vehicule)
        {
            InitializeComponent();
            tbxNom.Text = vehicule.Nom;
            tbxDescription.Text = vehicule.Description;
            nudInitial.Value = Convert.ToDecimal(vehicule.KmInitial);
            KmReel = vehicule.KmReel;
            pcbPhoto.Image = vehicule.Photo;

            image = vehicule.Photo;
            PhotoEnBytes = bd.ImageToBytesArray(image);
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();

            ofdImage.InitialDirectory = "C:\\Desktop\"";
            ofdImage.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            ofdImage.FilterIndex = 2;
            ofdImage.RestoreDirectory = true;
            ofdImage.Multiselect = true;

            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                //Permet la sélection d'une image png ou jpg seulement
                if (ofdImage.SafeFileName.Substring(ofdImage.SafeFileName.Length - 3, 3) == "png" ||
                    ofdImage.SafeFileName.Substring(ofdImage.SafeFileName.Length - 3, 3) == "jpg")
                {
                    image = Image.FromFile(ofdImage.FileName);
                    PhotoEnBytes = bd.ImageToBytesArray(image);

                    pcbPhoto.Image = image;
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une image .png ou .jpg", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Nom == "" || Description == "" || PhotoEnBytes == null)
            {
                lblErreurAjoutVehicule.Text = "Veuillez renseigner tous les champs";
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
