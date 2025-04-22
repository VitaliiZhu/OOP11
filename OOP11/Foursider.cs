using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP11
{
    public class Foursider
    {
        public double ab {  get; set; }
        public double bc { get; set; }
        public double cd { get; set; }
        public double ad { get; set; }
        public double alpha { get; set; }
        public double beta { get; set; }
        public virtual string getName()
        {
            return "Чотирикутник";
        }
        public virtual double getArea()
        {

            return 0.5*ab*bc*Math.Sin(alpha)+0.5*cd*ad*Math.Sin(beta);
        }
        
    }
}
