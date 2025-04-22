using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class rectangle : paralelogram
    {
        public double ab {  get; set; }
        public double bc { get; set; }
        public override string getName()
        {
            return "Прямокутник";
        }
        public override double getArea()
        {
            return ab*bc;
        }
    }
}
