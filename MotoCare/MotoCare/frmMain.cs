﻿using System;
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

        List<PointInteret> pointsInterets = new List<PointInteret>();
        List<Vehicule> vehicules;
        Vehicule vehiculeSelectionne;
        //Initialisation des valeur pour les marqueurs
        string nomPointInteret = string.Empty;
        string visitePointInteret = string.Empty;
        string descriptionPointInteret = string.Empty;

        //Initialisation de la couche de la carte
        GMapOverlay overlayMarkers = new GMapOverlay("OverlayMarkers");
        
        public frmMain()
        {
            InitializeComponent();
            vehicules = new List<Vehicule>();
            
            UpdateVehiculesAndCbxVehicules();
            bd.maConnexion.Open();
            pointsInterets = bd.LirePointsInterets();
            bd.maConnexion.Close();
            tpTrajets.SuspendLayout();
            tpCarnet.SuspendLayout();
            tpGestion.SuspendLayout();
            AffichagePointsInterets();
        }
        public void AffichagePointsInterets()
        {
            foreach (PointInteret pointInteret in pointsInterets)
            {
                PointLatLng location = new PointLatLng(Convert.ToDouble(pointInteret.Lat), Convert.ToDouble(pointInteret.Lng));
                AjouterMarqueurCarte(location, overlayMarkers, GMarkerGoogleType.green_dot, pointInteret);
            }
            //Clear la couche
            gmcCarte.Overlays.Clear();

            //Ajoute la couche
            gmcCarte.Overlays.Add(overlayMarkers);
        }
        private void AjouterMarqueurCarte(PointLatLng latLng, GMapOverlay overlayMarkers, GMarkerGoogleType style, PointInteret pointInteret)
        {
            GMapMarker marqueur = new GMarkerGoogle(latLng, style);

            string infos = string.Empty;

            infos = "Nom: " + pointInteret.Nom + "\r\n";
            infos += "Lieu visité: " + pointInteret.Visite + "\r\n";
            infos += "Description: " + pointInteret.Description + "\r\n";

            marqueur.ToolTipText = infos;

            //Ajouter le marker à la couche
            overlayMarkers.Markers.Add(marqueur);
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
        public void UpdateTrajetContent()
        {
            int totalKmTrajets = 0;
            bd.maConnexion.Open();
            dtgvTrajets.Rows.Clear();
            foreach (Trajet trajet in bd.LireTrajets(vehiculeSelectionne.IdVehicule))
            {
                dtgvTrajets.Rows.Add(trajet.Depart, trajet.Arrivee, trajet.Distance, trajet.Date);
                totalKmTrajets += Convert.ToInt32(trajet.Distance);
            }
            bd.maConnexion.Close();

            //Tri les données par ordre de date
            dtgvTrajets.Sort(colDate, ListSortDirection.Ascending);
            //Calcule les km réel en fonction des trajets et du kilométrage lors de l'achat
            int kmReel = totalKmTrajets + Convert.ToInt32(vehiculeSelectionne.KmInitial);
            tbxKmReel.Text = kmReel.ToString();
            vehiculeSelectionne.KmReel = kmReel.ToString();
            //Mettre à jour dans la bdd le kmReel
            bd.maConnexion.Open();
            bd.MettreAJourVehicule(kmReel.ToString(), vehiculeSelectionne);
            bd.maConnexion.Close();
        }
        public void UpdateCarnetContent()
        {
            bd.maConnexion.Open();
            dtgvCarnetEntretiens.Rows.Clear();
            
            foreach (Entretien entretien in bd.LireEntretiens(vehiculeSelectionne.IdVehicule))
            {
                //Pour calculer dans combien de km aura lieux la maintenance (soit c'est la première et c'est du coup kmPremiereMaintenance soit il faut la calculer
                int prochaineMaitenance = 0;
                if (entretien.KmPremiereMaintenance == "0")
                {
                    //C'est une répétition d'un entretien
                    prochaineMaitenance = Convert.ToInt32(entretien.KmDerniereMaintenance) + Convert.ToInt32(entretien.FreqKm) - Convert.ToInt32(vehiculeSelectionne.KmReel);
                    dtgvCarnetEntretiens.Rows.Add(entretien.IdMaintenance, entretien.Fait, entretien.Description, entretien.DateDerniereMaintenance, entretien.KmDerniereMaintenance, entretien.FreqKm, prochaineMaitenance.ToString());
                }
                else
                {
                    //C'est le tout premier entretien
                    prochaineMaitenance = Convert.ToInt32(entretien.KmPremiereMaintenance) - Convert.ToInt32(vehiculeSelectionne.KmReel);
                    dtgvCarnetEntretiens.Rows.Add(entretien.IdMaintenance, entretien.Fait, entretien.Description, "", "", entretien.FreqKm, prochaineMaitenance.ToString());
                }
            }
            bd.maConnexion.Close();

            //Détails d'affichage
            foreach (DataGridViewRow row in dtgvCarnetEntretiens.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colFait"].Value))
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.Cells["colProchaineMaintenance"].Value = "--";
                }
                else
                {
                    if (Convert.ToInt32(row.Cells["colProchaineMaintenance"].Value) <= 0)
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    else if (Convert.ToInt32(row.Cells["colProchaineMaintenance"].Value) <= 100)
                        row.DefaultCellStyle.ForeColor = Color.Orange;
                }
            }
            dtgvCarnetEntretiens.Sort(colProchaineMaintenance, ListSortDirection.Ascending);
            //dtgvCarnetEntretiens.DataSource = bd.LireEntretiens(vehiculeSelectionne.IdVehicule);
        }
        public void UpdateGestionEntretiensContent()
        {
            bd.maConnexion.Open();
            dtgvGestionEntretiens.Rows.Clear();

            foreach (Entretien entretien in bd.LireEntretiens(vehiculeSelectionne.IdVehicule))
            {
                if (entretien.KmPremiereMaintenance == "0")
                    dtgvGestionEntretiens.Rows.Add(entretien.IdMaintenance, entretien.Fait, entretien.Description, Convert.ToInt32(entretien.KmDerniereMaintenance) + Convert.ToInt32(entretien.FreqKm), entretien.FreqKm);
                else
                    dtgvGestionEntretiens.Rows.Add(entretien.IdMaintenance, entretien.Fait, entretien.Description, Convert.ToInt32(entretien.KmPremiereMaintenance), entretien.FreqKm);
            }
            bd.maConnexion.Close();
            dtgvGestionEntretiens.Sort(colKmLorsEntretienGestion, ListSortDirection.Ascending);
            //dtgvCarnetEntretiens.DataSource = bd.LireEntretiens(vehiculeSelectionne.IdVehicule);
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

                    UpdateTrajetContent();
                    UpdateCarnetContent();
                    UpdateGestionEntretiensContent();
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
                bd.SupprimerTrajetsVehicule(vehiculeSelectionne.IdVehicule);
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

                UpdateTrajetContent();
                UpdateCarnetContent();
                UpdateGestionEntretiensContent();
            }
        }
        private void dtgvTrajets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = (DataGridView)sender;

            if (dtgvTrajets.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int ligne = dtgvTrajets.Rows[e.RowIndex].Index;
                string depart = dtgvTrajets.Rows[ligne].Cells["colDepart"].Value.ToString();
                string arrivee = dtgvTrajets.Rows[ligne].Cells["colArrivee"].Value.ToString();
                string distance = dtgvTrajets.Rows[ligne].Cells["colDistance"].Value.ToString();
                string date = dtgvTrajets.Rows[ligne].Cells["colDate"].Value.ToString();

                bd.maConnexion.Open();
                string idTrajet = bd.ObtenirIdTrajetAvecReste(depart, arrivee, distance, date, vehiculeSelectionne.IdVehicule);

                if (dtgvTrajets.Columns[e.ColumnIndex].Name == "colModifier")
                {
                    FrmModifierTrajet frmModifierTrajet = new FrmModifierTrajet(depart, arrivee, distance, date);
                    if (frmModifierTrajet.ShowDialog() == DialogResult.OK)
                    {
                        bd.MettreAJourTrajet(frmModifierTrajet.Depart, frmModifierTrajet.Arrivee, frmModifierTrajet.Distance, frmModifierTrajet.Date, vehiculeSelectionne.IdVehicule, idTrajet);
                    }
                }
                else if (dtgvTrajets.Columns[e.ColumnIndex].Name == "colSupprimer")
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer ce trajet ?", "Supprimer trajet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //bd.SupprimerTrajet(depart, arrivee, distance, date, vehiculeSelectionne.IdVehicule);
                        bd.SupprimerTrajet(idTrajet);
                    }
                }
                bd.maConnexion.Close();
                UpdateTrajetContent();
                UpdateCarnetContent();
                UpdateGestionEntretiensContent();
            }
        }

        private void dtgvCarnetEntretiens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = (DataGridView)sender;
            if (dtgvCarnetEntretiens.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && !Convert.ToBoolean(dtgvCarnetEntretiens.Rows[dtgvCarnetEntretiens.Rows[e.RowIndex].Index].Cells["colFait"].Value))
            {
                int ligne = dtgvCarnetEntretiens.Rows[e.RowIndex].Index;
                string description = dtgvCarnetEntretiens.Rows[ligne].Cells["colDescription"].Value.ToString();
                string freqKm = dtgvCarnetEntretiens.Rows[ligne].Cells["colFrequence"].Value.ToString();
                string kmDerniereMaintenance = dtgvCarnetEntretiens.Rows[ligne].Cells["colKmDerniereMaintenance"].Value.ToString();
                string dateDerniereMaintenance = dtgvCarnetEntretiens.Rows[ligne].Cells["colDateDerniereMaintenance"].Value.ToString();
                string faitActuel = string.Empty;
                string faitApresClique = string.Empty;
                if (Convert.ToBoolean(dtgvCarnetEntretiens.Rows[ligne].Cells["colFait"].Value))
                {
                    faitActuel = "1";
                    faitApresClique = "0";
                }
                else
                {
                    faitActuel = "0";
                    faitApresClique = "1";
                }
                //Date et kmDerniereMaintenance une fois avoir coché la checkbox (donc après avoir effectué la maintenance)
                string dateMtn = DateTime.Now.ToString();
                DateTime dateActuelle = new DateTime(Convert.ToInt32(dateMtn.Substring(6, 4)), Convert.ToInt32(dateMtn.Substring(3, 2)), Convert.ToInt32(dateMtn.Substring(0, 2)));
                string kmNouvelleMaintenance = vehiculeSelectionne.KmReel;

                bd.maConnexion.Open();
                //string idMaintenance = bd.ObtenirIdEntretienAvecReste(description, freqKm, kmDerniereMaintenance, dateDerniereMaintenance, faitActuel, vehiculeSelectionne.IdVehicule);
                string idMaintenance = dtgvCarnetEntretiens.Rows[ligne].Cells["colIdEntretien"].Value.ToString();
                bd.MettreAJourEntretien(idMaintenance, faitApresClique);
                bd.CreerEntretien(description, freqKm, "-", kmNouvelleMaintenance, dateActuelle.ToString(), "0", vehiculeSelectionne.IdVehicule);
                bd.maConnexion.Close();
                UpdateCarnetContent();
                UpdateGestionEntretiensContent();
            }
        }

        private void btnAjoutEntretien_Click(object sender, EventArgs e)
        {
            string dateMtn = DateTime.Now.ToString();
            DateTime dateActuelle = new DateTime(Convert.ToInt32(dateMtn.Substring(6, 4)), Convert.ToInt32(dateMtn.Substring(3, 2)), Convert.ToInt32(dateMtn.Substring(0, 2)));

            FrmAjoutEntretien frmAjoutEntretien = new FrmAjoutEntretien();
            if (frmAjoutEntretien.ShowDialog() == DialogResult.OK)
            {
                bd.maConnexion.Open();
                bd.CreerEntretien(frmAjoutEntretien.Description, frmAjoutEntretien.FreqKm, frmAjoutEntretien.KmPremierEntretien, "", "", "0", vehiculeSelectionne.IdVehicule);
                bd.maConnexion.Close();

                UpdateCarnetContent();
                UpdateGestionEntretiensContent();
            }
        }

        private void dtgvGestionEntretiens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvGestionEntretiens.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int ligne = dtgvGestionEntretiens.Rows[e.RowIndex].Index;
                string description = dtgvGestionEntretiens.Rows[ligne].Cells["colDescriptionGestion"].Value.ToString();
                string freqKm = dtgvGestionEntretiens.Rows[ligne].Cells["colFreqKmGestion"].Value.ToString();
                string kmDerniereMaintenance = (Convert.ToInt32(dtgvGestionEntretiens.Rows[ligne].Cells["colKmLorsEntretienGestion"].Value) - Convert.ToInt32(dtgvGestionEntretiens.Rows[ligne].Cells["colFreqKmGestion"].Value)).ToString();

                bd.maConnexion.Open();
                //string idEntretien = bd.ObtenirIdEntretienAvecReste(description, freqKm, kmDerniereMaintenance, vehiculeSelectionne.IdVehicule);
                string idEntretien = dtgvGestionEntretiens.Rows[ligne].Cells["colIdEntretienGestion"].Value.ToString();
                if (dtgvGestionEntretiens.Columns[e.ColumnIndex].Name == "colModifierGestion")
                {
                    if (!bd.EstDejaFait(idEntretien))
                    {
                        FrmModifierEntretien frmModifierEntretien = new FrmModifierEntretien(description, freqKm);
                        if (frmModifierEntretien.ShowDialog() == DialogResult.OK)
                        {
                            bd.MettreAJourEntretien(frmModifierEntretien.Description, frmModifierEntretien.FreqKm, idEntretien);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous ne pouvez pas modifier un entretien déjà effectué.", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else if (dtgvGestionEntretiens.Columns[e.ColumnIndex].Name == "colSupprimerGestion")
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cet entretien ?", "Supprimer entretien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bd.SupprimerEntretien(idEntretien);
                    }
                }
                bd.maConnexion.Close();
                UpdateTrajetContent();
                UpdateCarnetContent();
                UpdateGestionEntretiensContent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterPointInteret_Click(object sender, EventArgs e)
        {
            nomPointInteret = tbxNomPointInteret.Text;
            visitePointInteret = cbxVisitePointInteret.SelectedItem.ToString();
            descriptionPointInteret = tbxDescriptionPointInteret.Text;
        }

        private void gmcCarte_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            if (nomPointInteret != string.Empty || visitePointInteret != string.Empty || descriptionPointInteret != string.Empty)
            {
                PointInteret nouveauPointInteret = new PointInteret(pointClick.Lat.ToString().Replace(',', '.'), pointClick.Lng.ToString().Replace(',', '.'), nomPointInteret, visitePointInteret, descriptionPointInteret);
                pointsInterets.Add(nouveauPointInteret);
                AjouterMarqueurCarte(pointClick, overlayMarkers, GMarkerGoogleType.green_dot, nouveauPointInteret);

                //Ajout à la BDD
                bd.maConnexion.Open();
                bd.CreerPointInteret(nouveauPointInteret);
                bd.maConnexion.Close();

                //Reset des valeurs
                visitePointInteret = string.Empty;
                descriptionPointInteret = string.Empty;

                cbxVisitePointInteret.SelectedIndex = 0;
                tbxDescriptionPointInteret.Text = "";

                //Clear la couche
                gmcCarte.Overlays.Clear();
                //Ajoute la couche
                gmcCarte.Overlays.Add(overlayMarkers);
            }
        }
    }
}
