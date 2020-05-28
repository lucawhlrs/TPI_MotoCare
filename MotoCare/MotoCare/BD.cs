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
    }
}
