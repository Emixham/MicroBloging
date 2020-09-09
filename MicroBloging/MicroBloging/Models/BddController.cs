using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroBloging.Models
{
    public class BddController : Controller
    {
        private MySqlConnection connection;

        // Constructeur
        public void Bdd()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=microblogging; UID=root; PASSWORD=root";
            this.connection = new MySqlConnection(connectionString);
        }

        [HttpPost]
        public void Index(String Message)
        {
            this.connection.Open();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "INSERT INTO post (contenu, dateheurePost) VALUES (@message,@dateHeure)";

            // utilisation de l'objet contact passé en paramètre
  
            cmd.Parameters.AddWithValue("@message", Message);
            DateTime localDate = DateTime.Now;
            cmd.Parameters.AddWithValue("@dateHeure", localDate);


            // Exécution de la commande SQL
            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            this.connection.Close();
        }
    }
}