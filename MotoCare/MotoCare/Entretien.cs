using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    public class Entretien
    {
        private string _description;
        private string _freqKm;
        private string _kmPremiereMaintenance;
        private string _kmDerniereMaintenance;
        private DateTime _dateDerniereMaintenance;
        private bool _fait;
        private string _idVehicule;

        public string Description { get => _description; set => _description = value; }
        public string FreqKm { get => _freqKm; set => _freqKm = value; }
        public string KmPremiereMaintenance { get => _kmPremiereMaintenance; set => _kmPremiereMaintenance = value; }
        public string KmDerniereMaintenance { get => _kmDerniereMaintenance; set => _kmDerniereMaintenance = value; }
        public DateTime DateDerniereMaintenance { get => _dateDerniereMaintenance; set => _dateDerniereMaintenance = value; }
        public bool Fait { get => _fait; set => _fait = value; }
        public string IdVehicule { get => _idVehicule; set => _idVehicule = value; }

        public Entretien(string description, string freqKm, string kmPremiereMaintenance, string kmDerniereMaintenance, string dateDerniereMaintenance, string fait, string idVehicule)
        {
            Description = description;
            FreqKm = freqKm;
            if (kmPremiereMaintenance == "0")
            {
                DateDerniereMaintenance = new DateTime(Convert.ToInt32(dateDerniereMaintenance.Substring(6, 4)), Convert.ToInt32(dateDerniereMaintenance.Substring(3, 2)), Convert.ToInt32(dateDerniereMaintenance.Substring(0, 2))); ;
            }
            else
            {
                DateDerniereMaintenance = new DateTime();
            }
            KmPremiereMaintenance = kmPremiereMaintenance;
            KmDerniereMaintenance = kmDerniereMaintenance;
            if (fait == "1")
                Fait = true;
            else
                Fait = false;
            IdVehicule = idVehicule;
        }
    }
}
