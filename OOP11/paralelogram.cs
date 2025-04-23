using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class paralelogram : Foursider
    {
        public paralelogram(double ab, double bc, double alpha):base(ab,bc,ab,bc,alpha,180-alpha)
        {
            this.ab = ab;
            this.bc = bc;
            this.alpha = alpha;
        }
        public override  string getName()
        {
            return "Паралелограм";
        }
        public override double getArea()
        {
            alpha *= Math.PI / 180;
            return ab * (Math.Cos(Math.Abs(90-alpha))*bc);
        }
    }
}
