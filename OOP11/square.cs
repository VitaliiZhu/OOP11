using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public class Square : Rectangle
    {
        public Square(double ab) : base(ab, ab) 
        {
            
        }
      
        public override string GetName()
        {
            return "Квадрат";
        }
        public override double GetArea()
        {
            return Math.Pow(AB,2);
        }
    }
}
