using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class square : rectangle
    {
        public square(double ab) : base(ab, ab) 
        {
            this.ab = ab;
        }
      
        public override string getName()
        {
            return "Квадрат";
        }
        public override double getArea()
        {
            return Math.Pow(ab,2);
        }
    }
}
