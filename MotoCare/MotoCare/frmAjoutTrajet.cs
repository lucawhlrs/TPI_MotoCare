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
    public partial class FrmAjoutTrajet : Form
    {
        private string _depart;
        private string _arrivee;
        private string _distance;
        private string _date;
        public string Depart { get => tbxDepart.Text; set => _depart = value; }
        public string Arrivee { get => tbxArrivee.Text; set => _arrivee = value; }
        public string Distance { get => nudDistance.Value.ToString(); set => _distance = value; }
        public string Date { get => dtpDate.Value.ToString(); set => _date = value; }

        public FrmAjoutTrajet()
        {
            InitializeComponent();
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
