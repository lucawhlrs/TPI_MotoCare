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
        //A faire: un héritage avec une classe parent. A affecter aussi frmAjoutVehicule
        BD bd = new BD();

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

        Image image;

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
                image = Image.FromFile(ofdImage.FileName);
                PhotoEnBytes = bd.ImageToBytesArray(image);

                pcbPhoto.Image = image;
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
