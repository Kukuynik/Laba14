using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14
{
    class ComplexNumbers
    {
        public double r, i;
        public ComplexNumbers(double r, double i)
        {
            this.r = r;
            this.i = i;
        }
        public ComplexNumbers()
        {

        }

        static ComplexNumbers Sum(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers result = new ComplexNumbers();
            result.r = a.r + b.r;
            result.i = a.i + b.i;
            return result;
        }
        public static ComplexNumbers operator +(ComplexNumbers a,ComplexNumbers b)
        {
            return Sum(a, b);
        }

        static ComplexNumbers Substract(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers result = new ComplexNumbers();
            result.r = a.r - b.r;
            result.i = a.i - b.i;
            return result;
        }
        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            return Substract(a, b);
        }
        public static ComplexNumbers Multiplication(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers result = new ComplexNumbers();
            result.r = a.r * b.r - a.i * b.i;
            result.i = a.i * b.r + a.r * b.i;
            return result;
        }
        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            return Multiplication(a, b);
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", r, i);
        }



    }
}
