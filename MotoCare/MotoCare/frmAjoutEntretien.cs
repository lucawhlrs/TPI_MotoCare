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
        private string _freqKm;

        public string Description { get => tbxDescription.Text; set => _description = value; }
        public string FreqKm { get => tbxFreqKm.Text; set => _freqKm = value; }
        public FrmAjoutEntretien()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Description == "" || FreqKm == "")
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
