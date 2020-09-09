using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroBloging.Models
{
    public class Utilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Libelle { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int[] Utilisateurs { get; set; }


    }
}