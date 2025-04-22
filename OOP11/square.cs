using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class square : rectangle
    {
        public double ab {  get; set; }
        public override string getName()
        {
            return "Квадрад";
        }
        public override double getArea()
        {
            return Math.Pow(ab,2);
        }
    }
}
