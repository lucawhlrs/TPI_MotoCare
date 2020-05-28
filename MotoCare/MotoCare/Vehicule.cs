using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    public class Vehicule
    {
        //Champs
        private string _idVehicule;
        private string _nom;
        private string _description;
        private string _kmInitial;
        private string _kmReel;
        private Image _photo;
        private byte[] _photoEnBytes;

        //Propriétés
        public string IdVehicule { get => _idVehicule; set => _idVehicule = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public string KmInitial { get => _kmInitial; set => _kmInitial = value; }
        public string KmReel { get => _kmReel; set => _kmReel = value; }
        public Image Photo { get => _photo; set => _photo = value; }
        public byte[] PhotoEnBytes { get => _photoEnBytes; set => _photoEnBytes = value; }

        //Constructeur
        public Vehicule(string idVehicule, string nom, string description, string kmInitial, string kmReel, Image photo)
        {
            IdVehicule = idVehicule;
            Nom = nom;
            Description = description;
            KmInitial = kmInitial;
            KmReel = kmReel;
            Photo = photo;
        }
        public Vehicule(string idVehicule, string nom, string description, string kmInitial, string kmReel, Image photo, byte[] photoEnBytes)
        {
            IdVehicule = idVehicule;
            Nom = nom;
            Description = description;
            KmInitial = kmInitial;
            KmReel = kmReel;
            Photo = photo;
            PhotoEnBytes = photoEnBytes;
        }
    }
}
