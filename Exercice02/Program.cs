using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture polo = new Voiture("Wolkswagen", 2, 5, 4);
        }
    }

    public abstract class Vehicule
    {
        public string Marque;
        public int Puissance;
        public int Passager;
        public virtual void Marche()
        {

        }
       
    }

    public class Voiture : Vehicule
    {
        private int RouesMotrice;
       public Voiture(string marque, int puissance, int passager, int rouesMotrice)
        {
            this.Marque = marque;
            this.Puissance = puissance;
            this.Puissance = passager;
            this.RouesMotrice = rouesMotrice;
        }

        public override void Marche()
        {
            
        }

    }

    public class Avion : Vehicule
    {
        public void Vehicule(string marque, int puissance, int passager)
        {
            this.Marque = marque;
            this.Puissance = puissance;
            this.Puissance = passager;
        }
    }

    public class Velo : Vehicule
    {
        public void vehicule(string marque, int puissance, int passager)
        {
            this.Marque = marque;
            this.Puissance = puissance;
            this.Puissance = passager;
        }
    }

    public class Camion : Vehicule
    {
        public void vehicule(string marque, int puissance, int passager)
        {
            this.Marque = marque;
            this.Puissance = puissance;
            this.Puissance = passager;
        }
    }
}
