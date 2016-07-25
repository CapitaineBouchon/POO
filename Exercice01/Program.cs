using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Forme[] Tableau = { new Carre(2), new
            Cercle(3), new Carre(5), new Triangle(6, 7) };
            float s = 0;
            foreach (Forme fo in Tableau)
            {
                s = fo.Aire();
                Console.WriteLine(s);
            }
            
            Console.ReadLine();
        }
    }

    public abstract class Forme
    {
        public virtual float Aire()
        {
            return 0;
        }
    }

    public class Carre : Forme
    {
        private float cote;
        public Carre(float c)
        {
            cote = c;
        }
        public override float Aire()
        {
            return (float)Math.Pow(cote, 2);
        }
    }

    public class Cercle : Forme
    {
        private float rayon;
        public Cercle(float r)
        {
            rayon = r;
        }
        public override float Aire()
        {
            return (float)(Math.PI * Math.Pow(rayon, 2));
        }
    }

    public class Triangle : Forme
    {
        private float baseTr;
        private float hauteurTr;

        public Triangle(float b, float h)
        {
            baseTr = b;
            hauteurTr = h;
        }
        public override float Aire()
        {
            return (float)((baseTr*hauteurTr)/2);
        }

    }

}
