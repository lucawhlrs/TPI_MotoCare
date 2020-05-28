using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    public class Trajet
    {
        //Champs
        private string _depart;
        private string _arrivee;
        private string _distance;
        private DateTime _date;
        private string _idVehicule;
        //Propriétés
        public string Depart { get => _depart; set => _depart = value; }
        public string Arrivee { get => _arrivee; set => _arrivee = value; }
        public string Distance { get => _distance; set => _distance = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string IdVehicule { get => _idVehicule; set => _idVehicule = value; }

        //Constructeur
        public Trajet(string depart, string arrivee, string distance, string date, string idVehicule)
        {
            Depart = depart;
            Arrivee = arrivee;
            Distance = distance;
            Date = new DateTime(Convert.ToInt32(date.Substring(6, 4)), Convert.ToInt32(date.Substring(3, 2)), Convert.ToInt32(date.Substring(0, 2)));
            IdVehicule = idVehicule;
        }
    }
}
