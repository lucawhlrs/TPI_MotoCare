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
 *  Fichier     :   Trajet.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    /// <summary>
    /// Trajet est une classe qui mémorise certaines informations sur des trajets.
    /// -Départ
    /// -Arrivée
    /// -Distance
    /// -Date
    /// -L'id du véhicule qui a effectué le trajet
    /// </summary>
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
