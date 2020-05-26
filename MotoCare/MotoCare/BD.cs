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
                while ((bytesRead = reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, (int)bytesRead);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        }
        public List<Image> GetAnnonceImageById(string idAnnonce)
        {
            List<Image> images = new List<Image>();

            string query = string.Format("SELECT DISTINCT" +
               " im.image AS Image" +
               " FROM User AS us, Annonce AS an, Vehicule AS ve, Image AS im, Marque AS ma, Model AS mo" +
               " WHERE im.idAnnonce = '{0}';", idAnnonce);

            SQLiteCommand command = new SQLiteCommand(query, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                byte[] buffer = GetBytes(dtReader);
                images.Add(ByteArrayToImage(buffer));
            }

            return images;
        }
        public List<Vehicule> LireVehicules()
        {
            List<Vehicule> vehicules = new List<Vehicule>();
            sql = "SELECT idVehicule, nom, description, kmInitial, kmReel, photo FROM vehicule";
            SQLiteCommand command = new SQLiteCommand(sql, maConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();

            while (dtReader.Read())
            {
                //byte[] buffer = GetBytes(dtReader);

                vehicules.Add(new Vehicule(
                    dtReader["idVehicule"].ToString(),
                    dtReader["nom"].ToString(),
                    dtReader["description"].ToString(),
                    dtReader["kmInitial"].ToString(),
                    dtReader["kmReel"].ToString(),
                    ByteArrayToImage((byte[])GetBytes(dtReader))
                    ));
            }
            return vehicules;
        }
        public byte[] ImageToBytesArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public void CreerVehicule(string nom, string description, string kmInitial, string kmReel, byte[] photoEnByte)
        {
            string query = string.Format("INSERT INTO vehicule (nom, description, kmInitial, kmReel, photo) " +
                                            "VALUES ('{0}', '{1}', '{2}', '{3}', @photo);", nom, description, kmInitial, kmReel);
            SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
            sQLiteCommand.Parameters.Add("@photo", DbType.Binary, 20).Value = photoEnByte;
            sQLiteCommand.ExecuteNonQuery();
        }



        //public void CreateRestaurant(Restaurant restaurant)
        //{
        //    string query = string.Format("INSERT INTO restaurants (nom, lat, long, description, nourriture, prix, adresse, telephone) " +
        //                                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", restaurant.Nom.Replace("'", "''"), restaurant.Lat, restaurant.Long, restaurant.Description.Replace("'", "''"), restaurant.Nourriture, restaurant.Prix, restaurant.Adresse.Replace("'", "''"), restaurant.Telephone);

        //    SQLiteCommand sQLiteCommand = new SQLiteCommand(query, maConnexion);
        //    sQLiteCommand.ExecuteNonQuery();
        //}
    }
}
