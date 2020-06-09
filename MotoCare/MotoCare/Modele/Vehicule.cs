/*
 *  Auteur      :   Luca Wohlers
 *  Professeur  :   Mme. Anne Terrier
 *  Experts     :   M. Borys Folomietow et M. Alain Fontanini
 *  Date        :   08 Juin 2020
 *  Projet      :   Moto Care
 *  Version     :   1.0
 *  Description :   Moto Care est une application développé dans le cadre
 *                  d'un travail pratique individuel (TPI) que les élèves d'informatique
 *                  doivent effectuer à la fin de leur CFC.
 *                  Cette application consiste à gérer des entretiens et trajets en fonction 
 *                  de véhicules. On peut aussi voir et ajouter des points d'intérêts sur une carte.
 *  Fichier     :   Vehicule.cs
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    /// <summary>
    /// Vehicule est une classe qui mémorise certaines information sur le véhicule.
    /// -L'id du véhicule
    /// -Nom
    /// -Description
    /// -Kilométrage initial lors de l'achat du véhicule
    /// -Kilométrage réel donc actuel du véhicule
    /// -Image du véhicule
    /// </summary>
    public class Vehicule
    {
        //Champs
        private string _idVehicule;
        private string _nom;
        private string _description;
        private string _kmInitial;
        private string _kmReel;
        private Image _photo;

        //Propriétés
        public string IdVehicule { get => _idVehicule; set => _idVehicule = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public string KmInitial { get => _kmInitial; set => _kmInitial = value; }
        public string KmReel { get => _kmReel; set => _kmReel = value; }
        public Image Photo { get => _photo; set => _photo = value; }

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
    }
}
