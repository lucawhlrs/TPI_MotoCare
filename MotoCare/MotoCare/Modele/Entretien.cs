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
 *  Fichier     :   Entretien.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    /// <summary>
    /// Entretien est une classe qui mémorise quelques informations sur des entretiens/maintenances.
    /// -L'id de l'entretien
    /// -Description
    /// -Frequence en km des prochaines maintenances
    /// -Kilométrage lors de la première maintenance
    /// -Kilométrage de la dernière même maintenance effectuée
    /// -Fait ou pas encore
    /// -L'id du véhicule auquel la maintenance doit ou a été faite
    /// </summary>
    public class Entretien
    {
        //Champs
        private string _idMaintenance;
        private string _description;
        private string _freqKm;
        private string _kmPremiereMaintenance;
        private string _kmDerniereMaintenance;
        private DateTime _dateDerniereMaintenance;
        private bool _fait;
        private string _idVehicule;

        //Propriétés
        public string Description { get => _description; set => _description = value; }
        public string FreqKm { get => _freqKm; set => _freqKm = value; }
        public string KmPremiereMaintenance { get => _kmPremiereMaintenance; set => _kmPremiereMaintenance = value; }
        public string KmDerniereMaintenance { get => _kmDerniereMaintenance; set => _kmDerniereMaintenance = value; }
        public DateTime DateDerniereMaintenance { get => _dateDerniereMaintenance; set => _dateDerniereMaintenance = value; }
        public bool Fait { get => _fait; set => _fait = value; }
        public string IdVehicule { get => _idVehicule; set => _idVehicule = value; }
        public string IdMaintenance { get => _idMaintenance; set => _idMaintenance = value; }

        //Constructeur
        /// <summary>
        /// Crée un nouvel Entretien/Maintenance
        /// </summary>
        /// <param name="idMaintenance">l'id de la maintenance</param>
        /// <param name="description">Une description de la maintenance</param>
        /// <param name="freqKm">A quel fréquence elle devra être effectuée à nouveau</param>
        /// <param name="kmPremiereMaintenance">A quel kilométrage du véhicule faudra faire la première maintenance</param>
        /// <param name="kmDerniereMaintenance">Le kilométrage du véhicule lors de la dernière même maintenance</param>
        /// <param name="dateDerniereMaintenance">La date de la dernière maintenance pour celles qui se répètent</param>
        /// <param name="fait">Indique si la maintenance a été effectué. ("0" --> Non, "1" --> Oui)</param>
        /// <param name="idVehicule">Indique pour quel véhicule appartient cette maintenance</param>
        public Entretien(string idMaintenance, string description, string freqKm, string kmPremiereMaintenance, string kmDerniereMaintenance, string dateDerniereMaintenance, string fait, string idVehicule)
        {
            IdMaintenance = idMaintenance;
            Description = description;
            FreqKm = freqKm;
            KmPremiereMaintenance = kmPremiereMaintenance;
            KmDerniereMaintenance = kmDerniereMaintenance;

            //S'il s'agit d'une maintenance qui se répète elle possède une date de dernier entretien sinon non
            if (kmPremiereMaintenance == "0")
                DateDerniereMaintenance = new DateTime(Convert.ToInt32(dateDerniereMaintenance.Substring(6, 4)), Convert.ToInt32(dateDerniereMaintenance.Substring(3, 2)), Convert.ToInt32(dateDerniereMaintenance.Substring(0, 2)));
            else
                DateDerniereMaintenance = new DateTime();
            
            //Si la maintenance a déjà été faite on met Fait à true sinon à false
            if (fait == "1")
                Fait = true;
            else
                Fait = false;

            IdVehicule = idVehicule;
        }
    }
}
