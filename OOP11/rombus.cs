using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class rombus : paralelogram
    {
        public double ab {  get; set; }
        public double alpha { get; set; }
         public override string getName()
        {
            return "Ромб";
        }
        public override double getArea()
        {
            return Math.Pow(ab,2)*Math.Sin(alpha);
        }
    }
}
