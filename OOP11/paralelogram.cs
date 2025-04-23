using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class Paralelogram : Foursider
    {
        public Paralelogram(double ab, double bc, double alpha):base(ab,bc,ab,bc,alpha,180-alpha)
        {
           
        }
        public override  string GetName()
        {
            return "Паралелограм";
        }
        public override double GetArea()
        {
            var alphaInRad =Alpha* Math.PI / 180;
            return AB * (Math.Cos(Math.Abs(90-alphaInRad))*BC);
        }
    }
}
