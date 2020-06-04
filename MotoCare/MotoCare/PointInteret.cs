using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    public class PointInteret
    {
        //Champs
        private string _lat;
        private string _lng;
        private string _nom;
        private string _visite;
        private string _description;
        //Propriétés
        public string Lat { get => _lat; set => _lat = value; }
        public string Lng { get => _lng; set => _lng = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Visite { get => _visite; set => _visite = value; }
        public string Description { get => _description; set => _description = value; }

        //Constructeur
        public PointInteret(string lat, string lng, string nom, string visite, string description)
        {
            Lat = lat;
            Lng = lng;
            Nom = nom;
            Visite = visite;
            Description = description;
        }
    }
}
