using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class GenericClassMathOperations<T> where T : INumber<T>
    {
        public T Add(T a, T b) 
        {
            return a+b;
        }
        public T Subtract(T a, T b)
        {
            return a-b;
        }
        public T Divide(T a, T b) 
        {
            return a/b; 
        }
        public T Multiply(T a, T b)
        { 
            return a*b; 
        }

    }
}
