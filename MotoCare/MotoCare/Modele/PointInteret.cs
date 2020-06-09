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
 *  Fichier     :   PointInteret.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    /// <summary>
    /// PointInteret est une classe qui mémorise quelques informations sur des marqueur d'une map.
    /// -Latitude
    /// -Longitude
    /// -Nom du marqueur
    /// -Si déjà visité
    /// -Description
    /// </summary>
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
