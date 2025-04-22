using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class paralelogram : Foursider
    {
        public double ab {  get; set; }
        public double bc { get; set; }
        public double alpha {  get; set; }
        public override  string getName()
        {
            return "Паралелограм";
        }
        public override double getArea()
        {
            return ab * (Math.Abs(90-alpha)*bc);
        }
    }
}
