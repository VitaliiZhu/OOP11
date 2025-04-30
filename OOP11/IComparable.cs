using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    public interface IComparable<T>
    {
         int CompareTo(T obj);
    }
}
