﻿using System;
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
    public class BD
    {
        const string CHAINE_CONNEXION = "Data Source=motoCare.sqlite;Version=3;";
        public SQLiteConnection maConnexion = new SQLiteConnection(CHAINE_CONNEXION);
        string sql = string.Empty;

        public BD()
        {

        }
        public Image ByteArrayToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
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
        public byte[] ImageToBytesArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public Image ObtenirPhotoGraceIdVehicule(string idVehicule)
        {
            Image photo = null;

            string query = string.Format("SELECT photo FROM vehicule WHERE idVehicule = '{0}';", idVehicule);
            SQLiteCommand command = new SQLiteCommand(query, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                byte[] buffer = GetBytes(dtReader);
                photo = ByteArrayToImage(buffer);
            }

            return photo;
        }
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
        public void CreerVehicule(string nom, string description, string kmInitial, string kmReel, byte[] photoEnByte)
        {
            string query = string.Format("INSERT INTO vehicule (nom, description, kmInitial, kmReel, photo) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}', @photo);", nom, description, kmInitial, kmReel);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.Parameters.Add("@photo", DbType.Binary, 20).Value = photoEnByte;
            sQLiteCommand.ExecuteNonQuery();
        }
        public void SupprimerVehicule(Vehicule vehicule)
        {
            string query = string.Format("DELETE FROM vehicule WHERE idVehicule = '{0}';", vehicule.IdVehicule);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        public void MettreAJourVehicule(string idVehicule, string nom, string description, string kmInitial, string kmReel, byte[] photoEnByte)
        {
            string query = string.Format("UPDATE vehicule SET nom = '{0}', description = '{1}', kmInitial = '{2}', kmReel = '{3}', photo = @photo " +
                "WHERE idVehicule = '{4}'", nom, description, kmInitial, kmReel, idVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.Parameters.Add("@photo", DbType.Binary, 20).Value = photoEnByte;
            sQLiteCommand.ExecuteNonQuery();
        }
        public void MettreAJourVehicule(string kmReel, Vehicule vehicule)
        {
            string query = string.Format("UPDATE vehicule SET kmReel = '{0}' WHERE idVehicule = '{1}';", kmReel, vehicule.IdVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }


        public void CreerTrajet(string idVehicule, string depart, string arrivee,string distance, string date)
        {
            string query = string.Format("INSERT INTO trajet (depart, arrivee, distance, date, idVehicule)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", depart, arrivee, distance, date, idVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
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
        public void SupprimerTrajet(string depart, string arrivee, string distance, string date, string idVehicule)
        {
            string query = string.Format("DELETE FROM trajet WHERE depart = '{0}' AND arrivee = '{1}' AND distance = '{2}' AND date = '{3}' AND idVehicule = '{4}';", depart, arrivee, distance, date, idVehicule);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        public void SupprimerTrajet(string idTrajet)
        {
            string query = string.Format("DELETE FROM trajet WHERE idTrajet = '{0}';", idTrajet);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        public void SupprimerTrajetsVehicule(string idVehicule)
        {
            string query = string.Format("DELETE FROM trajet WHERE idVehicule = '{0}';", idVehicule);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        public void MettreAJourTrajet(string depart, string arrivee, string distance, string date, string idVehicule, string idTrajet)
        {
            string query = string.Format("UPDATE trajet SET depart = '{0}', arrivee = '{1}', distance = '{2}', date = '{3}', idVehicule = '{4}' " +
                "WHERE idTrajet = '{5}'", depart, arrivee, distance, date, idVehicule, idTrajet);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
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
        public string ObtenirIdEntretienAvecReste(string description, string freqKm, string kmDerniereMaintenance, string dateDerniereMaintenance, string fait, string idVehicule)
        {
            string idMaintenance = string.Empty;

            string select = string.Format("SELECT idMaintenance " +
                "FROM maintenance " +
                "WHERE description = '{0}' AND freqKm = '{1}' AND kmDerniereMaintenance = '{2}' AND dateDerniereMaintenance = '{3}' AND fait = '{4}' AND idVehicule = '{5}' LIMIT 1;", 
                description, freqKm, kmDerniereMaintenance, dateDerniereMaintenance, fait, idVehicule);

            SQLiteCommand command = new SQLiteCommand(select, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();
            while (dtReader.Read())
            {
                idMaintenance = dtReader["idMaintenance"].ToString();
            }

            return idMaintenance;
        }
        public void MettreAJourEntretien(string idMaintenance, string fait)
        {
            string query = string.Format("UPDATE maintenance SET fait = '{0}' " +
                "WHERE idMaintenance = '{1}'", fait, idMaintenance);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        public void CreerEntretien(string description, string freqKm, string kmPremiereMaintenance, string kmDerniereMaintenance, string dateDerniereMaintenance, string fait, string idVehicule)
        {
            string query = string.Format("INSERT INTO maintenance (description, freqKm, kmPremiereMaintenance, kmDerniereMaintenance, dateDerniereMaintenance, fait, idVehicule)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", description, freqKm, kmPremiereMaintenance, kmDerniereMaintenance, dateDerniereMaintenance, fait, idVehicule);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        public string ObtenirIdEntretienAvecReste(string description, string freqKm, string kmDerniereMaintenance, string idVehicule)
        {
            string idMaintenance = string.Empty;

            string select = string.Format("SELECT idMaintenance " +
                "FROM maintenance " +
                "WHERE description = '{0}' AND freqKm = '{1}' AND kmDerniereMaintenance = '{2}' AND idVehicule = '{3}' LIMIT 1;",
                description, freqKm, kmDerniereMaintenance, idVehicule);

            SQLiteCommand command = new SQLiteCommand(select, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();
            while (dtReader.Read())
            {
                idMaintenance = dtReader["idMaintenance"].ToString();
            }

            return idMaintenance;
        }
        public void SupprimerEntretien(string idEntretien)
        {
            string query = string.Format("DELETE FROM maintenance WHERE idMaintenance = '{0}';", idEntretien);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
        public void MettreAJourEntretien(string description, string freqKm, string idMaintenance)
        {
            string query = string.Format("UPDATE maintenance SET description = '{0}', freqKm = '{1}' " +
                "WHERE idMaintenance = '{2}'", description, freqKm, idMaintenance);

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
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
        public void CreerPointInteret(PointInteret pointInteret)
        {
            //Remplacer les ' par des double '' pour éviter les erreur avec le SQL
            string query = string.Format("INSERT INTO pointInteret (lat, lng, nom, visite, description) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", pointInteret.Lat, pointInteret.Lng, pointInteret.Nom.Replace("'", "''"), pointInteret.Visite ,pointInteret.Description.Replace("'", "''"));

            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.ExecuteNonQuery();
        }
    }
}
