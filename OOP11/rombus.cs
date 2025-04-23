using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class rombus : paralelogram
    {
        public rombus(double ab, double alpha) : base(ab,ab,alpha) 
        {
            this.ab = ab;
            this.alpha = alpha;
        }

         public override string getName()
        {
            return "Ромб";
        }
        public override double getArea()
        {
            var pow = Math.Pow(ab, 2);
            alpha *= Math.PI / 180;
            var sin = Math.Sin(alpha);
            return pow * sin;
        }
    }
}
