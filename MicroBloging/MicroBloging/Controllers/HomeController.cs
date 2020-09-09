using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroBloging.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(String Message)
        {

            return View();
            //this.connection.Open();

            //// Création d'une commande SQL en fonction de l'objet connection
            //MySqlCommand cmd = this.connection.CreateCommand();

            //// Requête SQL
            //cmd.CommandText = "INSERT INTO post (contenu, dateheurePost) VALUES (@message,@dateHeure)";

            //// utilisation de l'objet contact passé en paramètre

            //cmd.Parameters.AddWithValue("@message", Message);
            //DateTime localDate = DateTime.Now;
            //cmd.Parameters.AddWithValue("@dateHeure", localDate);


            //// Exécution de la commande SQL
            //cmd.ExecuteNonQuery();

            //// Fermeture de la connexion
            //this.connection.Close();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}