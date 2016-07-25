using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clientUn = new Client("Paul", "Weller", "Londre");
            Client clientDeux = new Client("White", "Jack", "Detroit");
            Client clientTrois = new Client("Claypool", "Les", "San Fransisco");
            Client clientQuatre = new Client("Thunders", "Johnny", "New York");            
        }
    }

    public class Client
    {
        public string Nom;
        public string Prenom;
        public string Adresse;
        public string Ville;
        
        public Client()
        {

        }

        public Client(string nom, string prenom, string ville)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Ville = ville;
        }
    }
}
