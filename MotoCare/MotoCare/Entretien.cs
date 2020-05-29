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
        private string _idMaintenance;
        private string _description;
        private string _freqKm;
        private string _kmDerniereMaintenance;
        private DateTime _dateDerniereMaintenance;
        private bool _fait;
        private string _idVehicule;

        public string IdMaintenance { get => _idMaintenance; set => _idMaintenance = value; }
        public string Description { get => _description; set => _description = value; }
        public string FreqKm { get => _freqKm; set => _freqKm = value; }
        public string KmDerniereMaintenance { get => _kmDerniereMaintenance; set => _kmDerniereMaintenance = value; }
        public DateTime DateDerniereMaintenance { get => _dateDerniereMaintenance; set => _dateDerniereMaintenance = value; }
        public bool Fait { get => _fait; set => _fait = value; }
        public string IdVehicule { get => _idVehicule; set => _idVehicule = value; }
        public Entretien(string idMaintenance, string description, string frequKm, string kmDerniereMaintenance, string dateDerniereMaintenance, string fait, string idVehicule)
        {
            IdMaintenance = idMaintenance;
            Description = description;
            FreqKm = frequKm;
            KmDerniereMaintenance = kmDerniereMaintenance;
            DateDerniereMaintenance = new DateTime(Convert.ToInt32(dateDerniereMaintenance.Substring(6, 4)), Convert.ToInt32(dateDerniereMaintenance.Substring(3, 2)), Convert.ToInt32(dateDerniereMaintenance.Substring(0, 2))); ;
            if (fait == "1")
                Fait = true;
            else
                Fait = false;
            IdVehicule = idVehicule;
        }
    }
}
