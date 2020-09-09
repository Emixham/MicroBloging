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
            string connectionString = "SERVER=127.0.0.1; DATABASE=mli; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
    }
}