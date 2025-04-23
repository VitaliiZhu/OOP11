using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP11
{
    public class Foursider
    {
        public Foursider(double ab,double bc, double cd, double ad, double alpha, double beta) 
        {
            this.ab = ab;
            this.bc = bc;
            this.cd = cd;
            this.ad = ad;
            this.alpha = alpha;
            this.beta = beta;
        }
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
            alpha *= Math.PI / 180;
            beta *= Math.PI / 180;
            return 0.5*ab*bc*Math.Abs(Math.Sin(alpha))+0.5*cd*ad*Math.Abs(Math.Sin(beta));
        }
        
    }
}
