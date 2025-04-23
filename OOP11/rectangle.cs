using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class Rectangle : Paralelogram
    {
        public Rectangle(double ab, double bc) : base(ab, bc, 90)
        {
           
        }

        public override string GetName()
        {
            return "Прямокутник";
        }
        public override double GetArea()
        {
            return AB*BC;
        }
    }
}
