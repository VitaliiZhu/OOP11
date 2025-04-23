using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class rectangle : paralelogram
    {
        public rectangle(double ab, double bc) : base(ab, bc, 90)
        {
            this.ab = ab;
            this.bc = bc;
        }

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
