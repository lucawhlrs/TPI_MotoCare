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
    public partial class frmMain : Form
    {
        //Création de l'objet BD
        BD bd = new BD();
        public frmMain()
        {
            InitializeComponent();
            List<Vehicule> vehicules = new List<Vehicule>();
            //bd.maConnexion.Open();
            //vehicules = bd.LireVehicules();
            //bd.maConnexion.Close();

            foreach (Vehicule v in vehicules)
            {
                cbxVehicules.Items.Add(v.Nom);
            }
        }

        private void cbxVehicules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterVehicule_Click(object sender, EventArgs e)
        {
            FrmAjoutVehicule frmAjoutVehicule = new FrmAjoutVehicule();
            if (frmAjoutVehicule.ShowDialog() == DialogResult.OK)
            {
                bd.maConnexion.Open();
                bd.CreerVehicule(frmAjoutVehicule.Nom, frmAjoutVehicule.Description, frmAjoutVehicule.KmInitial, frmAjoutVehicule.KmReel, frmAjoutVehicule.PhotoEnBytes);
                bd.maConnexion.Close();
            }
        }
    }
}
