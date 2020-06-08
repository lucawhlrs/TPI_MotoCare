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
 *  Fichier     :   BD.cs
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoCare
{
    /// <summary>
    /// BD est une classe qui permet d'effectuer beaucoup de requêtes envers la base de données motoCare.sqlite
    /// Comme par exemple:
    /// -Lire tous les véhicules
    /// -Créer un véhicule
    /// -Modifier un véhicule
    /// -Supprimer un véhicule
    /// -Créer un trajet
    /// -etc.
    /// </summary>
    public class BD
    {
        const string CHAINE_CONNEXION = "Data Source=motoCare.sqlite;Version=3;";
        public SQLiteConnection maConnexion = new SQLiteConnection(CHAINE_CONNEXION);
        string sql = string.Empty;

        public BD()
        {

        }
        /// <summary>
        /// Converti un tableau d'octet en une Image
        /// </summary>
        /// <param name="imageBytes"></param>
        /// <returns>Une Image</returns>
        public Image ByteArrayToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        /// <summary>
        /// Obtient un tableau d'octet à partir de données binaires
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Le tableau d'octet</returns>
        static byte[] GetBytes(SQLiteDataReader reader)
        {
            const int CHUNK_SIZE = 2 * 1024;
            byte[] buffer = new byte[CHUNK_SIZE];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                if (reader.IsDBNull(0))
                {
                    return null;
                }
                else
                {
                    while ((bytesRead = reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length)) > 0)
                    {
                        stream.Write(buffer, 0, (int)bytesRead);
                        fieldOffset += bytesRead;
                    }
                    return stream.ToArray();
                }
                
            }
        }
        /// <summary>
        /// Convertit une image en tableau d'octet
        /// </summary>
        /// <param name="image"></param>
        /// <returns>Un tableau d'octet</returns>
        public byte[] ImageToBytesArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        /// <summary>
        /// Obtient la photo du véhicule grâce à l'id du véhicule
        /// </summary>
        /// <param name="idVehicule"></param>
        /// <returns>Une Image</returns>
        public Image ObtenirPhotoGraceIdVehicule(string idVehicule)
        {
            Image photo = null;

            string query = string.Format("SELECT photo FROM vehicule WHERE idVehicule = '{0}';", idVehicule);
            SQLiteCommand command = new SQLiteCommand(query, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                //Convertit en tableau d'octet les données binaires obtenus à partir de la requête SQL
                byte[] buffer = GetBytes(dtReader);
                //Convertit le tableau d'octet temporairement obtenu en Image
                photo = ByteArrayToImage(buffer);
            }

            return photo;
        }
        /// <summary>
        /// Obtient une liste d'objet Vehicule parmit tous les véhicules de la base de données
        /// </summary>
        /// <returns>Une liste d'objet Vehicule de tous les véhicules</returns>
        public List<Vehicule> LireVehicules()
        {
            List<Vehicule> vehicules = new List<Vehicule>();
            sql = "SELECT idVehicule, nom, description, kmInitial, kmReel, photo FROM vehicule";
            SQLiteCommand command = new SQLiteCommand(sql, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                vehicules.Add(new Vehicule(
                    dtReader["idVehicule"].ToString(),
                    dtReader["nom"].ToString(),
                    dtReader["description"].ToString(),
                    dtReader["kmInitial"].ToString(),
                    dtReader["kmReel"].ToString(),
                    ObtenirPhotoGraceIdVehicule(dtReader["idVehicule"].ToString())
                    ));
            }
            return vehicules;
        }
        /// <summary>
        /// Ajoute un véhicule à la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="description"></param>
        /// <param name="kmInitial"></param>
        /// <param name="kmReel"></param>
        /// <param name="photoEnByte"></param>
        public void CreerVehicule(string nom, string description, string kmInitial, string kmReel, byte[] photoEnByte)
        {
            //Remplacer les ' par des double '' pour éviter les erreurs avec le SQL
            string query = string.Format("INSERT INTO vehicule (nom, description, kmInitial, kmReel, photo) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}', @photo);", nom.Replace("'", "''"), description.Replace("'", "''"), kmInitial, kmReel);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            //Ajoute à un nouveau paramètre de type binaire la photo en octet
            sQLiteCommand.Parameters.Add("@photo", DbType.Binary, 20).Value = photoEnByte;
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Supprime le véhicule fournit
        /// </summary>
        /// <param name="vehicule">Vehicule que à supprimer</param>
        public void SupprimerVehicule(Vehicule vehicule)
        {
            string query = string.Format("DELETE FROM vehicule WHERE idVehicule = '{0}';", vehicule.IdVehicule);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Met à jour le véhicule dans la base de données
        /// </summary>
        /// <param name="idVehicule">Pour savoir quel véhicule mettre à jour</param>
        /// <param name="nom">Nouveau nom</param>
        /// <param name="description">Nouvelle description</param>
        /// <param name="kmInitial">Nouveau kmInitial</param>
        /// <param name="kmReel">Nouveau kmReel</param>
        /// <param name="photoEnByte">Nouvelle photo en tableau d'octet</param>
        public void MettreAJourVehicule(string idVehicule, string nom, string description, string kmInitial, string kmReel, byte[] photoEnByte)
        {
            //Remplacer les ' par des double '' pour éviter les erreurs avec le SQL
            string query = string.Format("UPDATE vehicule SET nom = '{0}', description = '{1}', kmInitial = '{2}', kmReel = '{3}', photo = @photo " +
                "WHERE idVehicule = '{4}'", nom.Replace("'", "''"), description.Replace("'", "''"), kmInitial, kmReel, idVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.Parameters.Add("@photo", DbType.Binary, 20).Value = photoEnByte;
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Met à jour le kmReel d'un véhicule
        /// </summary>
        /// <param name="kmReel"></param>
        /// <param name="vehicule"></param>
        public void MettreAJourVehicule(string kmReel, Vehicule vehicule)
        {
            string query = string.Format("UPDATE vehicule SET kmReel = '{0}' WHERE idVehicule = '{1}';", kmReel, vehicule.IdVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Crée un nouveau trajet
        /// </summary>
        /// <param name="idVehicule">l'id du véhicule avec lequel le trajet a été effectué</param>
        /// <param name="depart"></param>
        /// <param name="arrivee"></param>
        /// <param name="distance"></param>
        /// <param name="date"></param>
        public void CreerTrajet(string idVehicule, string depart, string arrivee,string distance, string date)
        {
            //Remplacer les ' par des double '' pour éviter les erreurs avec le SQL
            string query = string.Format("INSERT INTO trajet (depart, arrivee, distance, date, idVehicule)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", depart.Replace("'", "''"), arrivee.Replace("'", "''"), distance, date, idVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Obtient tous les trajets effectué par le véhicule en question
        /// </summary>
        /// <param name="idVehicule"></param>
        /// <returns>Une liste d'objet Trajet</returns>
        public List<Trajet> LireTrajets(string idVehicule)
        {
            List<Trajet> trajets = new List<Trajet>();
            string select = string.Format("SELECT depart, arrivee, distance, date, idVehicule FROM trajet WHERE idVehicule = '{0}';", idVehicule);
            SQLiteCommand command = new SQLiteCommand(select, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                trajets.Add(new Trajet(
                    dtReader["depart"].ToString(),
                    dtReader["arrivee"].ToString(),
                    dtReader["distance"].ToString(),
                    dtReader["date"].ToString(),
                    dtReader["idVehicule"].ToString()
                    ));
            }
            return trajets;
        }
        /// <summary>
        /// Supprime le trajet avec l'id indiqué en paramètre
        /// </summary>
        /// <param name="idTrajet">id du trajet à supprimer</param>
        public void SupprimerTrajet(string idTrajet)
        {
            string query = string.Format("DELETE FROM trajet WHERE idTrajet = '{0}';", idTrajet);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Supprime tous les trajet du véhicule indiqué en paramètre
        /// </summary>
        /// <param name="idVehicule">id du véhicule dont faut supprimer tous les trajets</param>
        public void SupprimerTrajetsVehicule(string idVehicule)
        {
            string query = string.Format("DELETE FROM trajet WHERE idVehicule = '{0}';", idVehicule);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Met à jour le trajet correspondant à l'id indiqué
        /// </summary>
        /// <param name="depart"></param>
        /// <param name="arrivee"></param>
        /// <param name="distance"></param>
        /// <param name="date"></param>
        /// <param name="idVehicule"></param>
        /// <param name="idTrajet">id du trajet à modifier</param>
        public void MettreAJourTrajet(string depart, string arrivee, string distance, string date, string idVehicule, string idTrajet)
        {
            //Remplacer les ' par des double '' pour éviter les erreurs avec le SQL
            string query = string.Format("UPDATE trajet SET depart = '{0}', arrivee = '{1}', distance = '{2}', date = '{3}', idVehicule = '{4}' " +
                "WHERE idTrajet = '{5}'", depart.Replace("'", "''"), arrivee.Replace("'", "''"), distance, date, idVehicule, idTrajet);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Obtient l'id du trajet dans la base de données en fonction des paramètres indiqués
        /// </summary>
        /// <param name="depart"></param>
        /// <param name="arrivee"></param>
        /// <param name="distance"></param>
        /// <param name="date"></param>
        /// <param name="idVehicule"></param>
        /// <returns>l'id du trajet</returns>
        public string ObtenirIdTrajetAvecReste(string depart, string arrivee, string distance, string date, string idVehicule)
        {
            string idTrajet = string.Empty;

            string select = string.Format("SELECT idTrajet FROM trajet WHERE depart = '{0}' AND arrivee = '{1}' AND distance = '{2}' AND date = '{3}' AND idVehicule = '{4}' LIMIT 1;", depart, arrivee, distance, date, idVehicule);
            SQLiteCommand command = new SQLiteCommand(select, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();
            while (dtReader.Read())
            {
                idTrajet = dtReader["idTrajet"].ToString();
            }

            return idTrajet;
        }
        /// <summary>
        /// Lit tous les entretiens de l'id du véhicule indiqué en paramètre
        /// </summary>
        /// <param name="idVehicule"></param>
        /// <returns>Une liste d'objet Entretien</returns>
        public List<Entretien> LireEntretiens(string idVehicule)
        {
            List<Entretien> entretiens = new List<Entretien>();
            string select = string.Format("SELECT idMaintenance, description, freqKm, kmPremiereMaintenance, kmDerniereMaintenance, dateDerniereMaintenance, fait, idVehicule " +
                "FROM maintenance WHERE idVehicule = '{0}'" +
                "ORDER BY kmDerniereMaintenance ASC;", idVehicule);
            SQLiteCommand command = new SQLiteCommand(select, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                entretiens.Add(new Entretien(
                    dtReader["idMaintenance"].ToString(),
                    dtReader["description"].ToString(),
                    dtReader["freqKm"].ToString(),
                    dtReader["kmPremiereMaintenance"].ToString(),
                    dtReader["kmDerniereMaintenance"].ToString(),
                    dtReader["dateDerniereMaintenance"].ToString(),
                    dtReader["fait"].ToString(),
                    dtReader["idVehicule"].ToString()
                    ));
            }
            return entretiens;
        }
        /// <summary>
        /// Met à jour dans la base de données le champ fait. Pour savoir si l'entretien a été fait ou pas encore.
        /// </summary>
        /// <param name="idMaintenance">l'id de l'entretien à modifier</param>
        /// <param name="fait">"0" s'il n'est pas fait. "1" s'il est fait.</param>
        public void MettreAJourEntretien(string idMaintenance, string fait)
        {
            string query = string.Format("UPDATE maintenance SET fait = '{0}' " +
                "WHERE idMaintenance = '{1}'", fait, idMaintenance);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Crée un nouvel entretien en fonction des paramètres fournis
        /// </summary>
        /// <param name="description">Description de l'entretien</param>
        /// <param name="freqKm">Fréquence à laquelle effectuer l'entretien</param>
        /// <param name="kmPremiereMaintenance">Kilométrage du véhicule lors du premier entretien. "-" s'il se répète, que ce n'est pas le premier.</param>
        /// <param name="kmDerniereMaintenance">Kilométrage de la dernière maintenance effectué du même type</param>
        /// <param name="dateDerniereMaintenance">Date lors de la dernière maintenance effectué du même type</param>
        /// <param name="fait">"0" si elle n'est pas effectué. "1" si elle déjà faite</param>
        /// <param name="idVehicule">L'id du véhicule sur lequel effectuer la maintenance</param>
        public void CreerEntretien(string description, string freqKm, string kmPremiereMaintenance, string kmDerniereMaintenance, string dateDerniereMaintenance, string fait, string idVehicule)
        {
            //Remplacer les ' par des double '' pour éviter les erreurs avec le SQL
            string query = string.Format("INSERT INTO maintenance (description, freqKm, kmPremiereMaintenance, kmDerniereMaintenance, dateDerniereMaintenance, fait, idVehicule)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", description.Replace("'", "''"), freqKm, kmPremiereMaintenance, kmDerniereMaintenance, dateDerniereMaintenance, fait, idVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Supprime l'entretien indiqué
        /// </summary>
        /// <param name="idEntretien"></param>
        public void SupprimerEntretien(string idEntretien)
        {
            string query = string.Format("DELETE FROM maintenance WHERE idMaintenance = '{0}';", idEntretien);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Supprime tous les entretiens d'un véhicule
        /// </summary>
        /// <param name="idVehicule"></param>
        public void SupprimerEntretiensVehicule(string idVehicule)
        {
            string query = string.Format("DELETE FROM maintenance WHERE idVehicule = '{0}';", idVehicule);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Met à jour un entretien avec de nouvelles valeurs
        /// </summary>
        /// <param name="description"></param>
        /// <param name="freqKm"></param>
        /// <param name="idMaintenance">l'entretien à mettre à jour</param>
        public void MettreAJourEntretien(string description, string freqKm, string idMaintenance)
        {
            string query = string.Format("UPDATE maintenance SET description = '{0}', freqKm = '{1}' " +
                "WHERE idMaintenance = '{2}'", description, freqKm, idMaintenance);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// Indique en fonction de l'id de l'entretien s'il a déjà été effectué ou non
        /// </summary>
        /// <param name="idEntretien"></param>
        /// <returns>True s'il à déjà été fait. False si pas encore</returns>
        public bool EstDejaFait(string idEntretien)
        {
            bool estDejaFait = false;

            string select = string.Format("SELECT fait FROM maintenance WHERE idMaintenance = '{0}';", idEntretien);

            SQLiteCommand command = new SQLiteCommand(select, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();
            while (dtReader.Read())
            {
                estDejaFait = Convert.ToBoolean(dtReader["fait"]);
            }

            return estDejaFait;
        }
        /// <summary>
        /// Obtient tous les points d'intérêts de la base de données
        /// </summary>
        /// <returns>Une liste d'objet PointInteret</returns>
        public List<PointInteret> LirePointsInterets()
        {
            List<PointInteret> pointsInterets = new List<PointInteret>();
            sql = "SELECT lat, lng, nom, visite, description FROM pointInteret";
            SQLiteCommand command = new SQLiteCommand(sql, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                pointsInterets.Add(new PointInteret(
                    dtReader["lat"].ToString(),
                    dtReader["lng"].ToString(),
                    dtReader["nom"].ToString(),
                    dtReader["visite"].ToString(),
                    dtReader["description"].ToString()
                    ));
            }
            return pointsInterets;
        }
        /// <summary>
        /// Crée un point d'intérêt dans la base de données
        /// </summary>
        /// <param name="pointInteret"></param>
        public void CreerPointInteret(PointInteret pointInteret)
        {
            //Remplacer les ' par des double '' pour éviter les erreurs avec le SQL
            string query = string.Format("INSERT INTO pointInteret (lat, lng, nom, visite, description) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", pointInteret.Lat, pointInteret.Lng, pointInteret.Nom.Replace("'", "''"), pointInteret.Visite ,pointInteret.Description.Replace("'", "''"));

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
    }
}
