using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP11
{
    public class Foursider :IClonable<Foursider>,IComparable<Foursider>,IShape
    {
        public Foursider(double ab,double bc, double cd, double ad, double alpha, double beta) 
        {
            AB = ab;
            BC = bc;
            CD = cd;
            AD = ad;
            Alpha = alpha;
            Beta = beta;
        }
        public double AB {  get; private set; }
        public double BC { get; private set; }
        public double CD { get; private set; }
        public double AD { get; private set; }
        public double Alpha { get; private set; }
        public double Beta { get; private set; }
        public override string  ToString()
        {
            return GetName()+", площа = "+GetArea();
        }
        public virtual string GetName()
        {
            return "Чотирикутник";
        }
        public virtual double GetArea()
        {
            var alphaInRad = Alpha* Math.PI / 180;
            var betaInRad = Beta* Math.PI / 180;
            return 0.5*AB*BC*Math.Abs(Math.Sin(alphaInRad))+0.5*CD*AD*Math.Abs(Math.Sin(betaInRad));
        }
        public int CompareTo(Foursider obj)
        {
            if (GetArea() > obj.GetArea()) return 1;
            else if(GetArea() < obj.GetArea())return -1;
            else return 0;
        }
        public Foursider Clone()
        {
            return this;
        }
        
    }
}
