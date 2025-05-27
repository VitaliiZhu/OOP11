using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class Rombus : Paralelogram
    {
        public Rombus(double ab, double alpha) : base(ab,ab,alpha) 
        {
        }

         public override string GetName()
        {
            return "Ромб";
        }
        public override double GetArea()
        {
            var pow = Math.Pow(AB, 2);
            var alphaInRad = Alpha * Math.PI / 180;
            var sin = Math.Sin(alphaInRad);
            return pow * sin;
        }
        public override Foursider Clone()
        {
            return new Rombus(AB, Alpha);
        }
    }
}
