using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.Internals;

namespace MotoCare
{
    public partial class frmMain : Form
    {
        //Création de l'objet BD
        BD bd = new BD();

        List<Vehicule> vehicules;
        Vehicule vehiculeSelectionne;
        //Initialisation de la couche de la carte
        GMapOverlay overlayMarkers = new GMapOverlay("OverlayMarkers");
        
        public frmMain()
        {
            InitializeComponent();
            vehicules = new List<Vehicule>();
            UpdateVehiculesAndCbxVehicules();
            tpTrajets.SuspendLayout();
            tpCarnet.SuspendLayout();
            tpGestion.SuspendLayout();
        }
        public void UpdateVehiculesAndCbxVehicules()
        {
            bd.maConnexion.Open();
            vehicules = bd.LireVehicules();
            bd.maConnexion.Close();

            cbxVehicules.Items.Clear();
            
            if (vehicules.Count >= 1)
            {
                foreach (Vehicule v in vehicules)
                {
                    cbxVehicules.Items.Add(v.Nom);
                }
                cbxVehicules.Enabled = true;
                btnSupprimerVehicule.Enabled = true;
                btnModifierVehicule.Enabled = true;

                if (tcMenu.TabCount == 1)
                {
                    tcMenu.TabPages.Insert(0, tpTrajets);
                    tcMenu.TabPages.Insert(1, tpCarnet);
                    tcMenu.TabPages.Insert(2, tpGestion);
                }
            }
            else
            {
                //Quand aucun véhicule n'est sélectionné on désactive presque tout les controls sauf le bouton ajouter et les points d'intérêts
                cbxVehicules.Items.Add("Aucun véhicule, veuillez en créer");
                cbxVehicules.Enabled = false;
                btnModifierVehicule.Enabled = false;
                btnSupprimerVehicule.Enabled = false;
                tcMenu.TabPages.Remove(tpTrajets);
                tcMenu.TabPages.Remove(tpCarnet);
                tcMenu.TabPages.Remove(tpGestion);
                tbxDescription.Text = "";
                tbxKmInitial.Text = "";
                tbxKmReel.Text = "";
                pcbPhoto.Image = null;
            }
            cbxVehicules.SelectedIndex = 0;
        }
        private void cbxVehicules_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Indique quel vehicule est sélectionné et met à jour les champs en fonction du véhicule
            foreach (Vehicule vehicule in vehicules)
            {
                if (vehicule.Nom == cbxVehicules.SelectedItem.ToString())
                {
                    vehiculeSelectionne = vehicule;
                    tbxDescription.Text = vehicule.Description;
                    pcbPhoto.Image = vehicule.Photo;
                    tbxKmInitial.Text = vehicule.KmInitial;
                    tbxKmReel.Text = vehicule.KmReel;

                    bd.maConnexion.Open();
                    dtgvTrajets.Rows.Clear();
                    foreach (Trajet trajet in bd.LireTrajets(vehiculeSelectionne.IdVehicule))
                    {
                        dtgvTrajets.Rows.Add(trajet.Depart, trajet.Arrivee, trajet.Distance, trajet.Date);
                    }
                    bd.maConnexion.Close();
                }
            }
        }
        private void gmcCarte_Load(object sender, EventArgs e)
        {
            //Indique quelle carte afficher
            gmcCarte.MapProvider = GoogleMapProvider.Instance;
            //Zoom au niveau de la souris
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //Enlever la croix rouge
            gmcCarte.ShowCenter = false;
            //La ou débute la map
            gmcCarte.Position = new PointLatLng(46.2, 6.1667);

            //Ajouter la couche à la map
            gmcCarte.Overlays.Add(overlayMarkers);
        }
        private void btnAjouterVehicule_Click(object sender, EventArgs e)
        {
            FrmAjoutVehicule frmAjoutVehicule = new FrmAjoutVehicule();
            if (frmAjoutVehicule.ShowDialog() == DialogResult.OK)
            {
                bd.maConnexion.Open();
                bd.CreerVehicule(frmAjoutVehicule.Nom, frmAjoutVehicule.Description, frmAjoutVehicule.KmInitial, frmAjoutVehicule.KmReel, frmAjoutVehicule.PhotoEnBytes);
                bd.maConnexion.Close();
                UpdateVehiculesAndCbxVehicules();
            }
        }
        private void btnSupprimerVehicule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer définitivement ce véhicule ?", "Supprimer véhicule", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bd.maConnexion.Open();
                bd.SupprimerVehicule(vehiculeSelectionne);
                bd.maConnexion.Close();
                UpdateVehiculesAndCbxVehicules();
            }
        }

        private void btnModifierVehicule_Click(object sender, EventArgs e)
        {
            FrmModifierVehicule frmModifierVehicule = new FrmModifierVehicule(vehiculeSelectionne);
            if (frmModifierVehicule.ShowDialog() == DialogResult.OK)
            {
                bd.maConnexion.Open();
                bd.MettreAJourVehicule(vehiculeSelectionne.IdVehicule, frmModifierVehicule.Nom, frmModifierVehicule.Description, frmModifierVehicule.KmInitial, frmModifierVehicule.KmReel, frmModifierVehicule.PhotoEnBytes);
                bd.maConnexion.Close();
                UpdateVehiculesAndCbxVehicules();
            }
        }

        private void btnAjouterTrajet_Click(object sender, EventArgs e)
        {
            FrmAjoutTrajet frmAjoutTrajet = new FrmAjoutTrajet();
            if (frmAjoutTrajet.ShowDialog() == DialogResult.OK)
            {
                bd.maConnexion.Open();
                bd.CreerTrajet(vehiculeSelectionne.IdVehicule, frmAjoutTrajet.Depart, frmAjoutTrajet.Arrivee, frmAjoutTrajet.Distance, frmAjoutTrajet.Date);
                bd.maConnexion.Close();
            }
        }
    }
}
