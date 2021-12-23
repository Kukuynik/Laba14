using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14
{
    class RationalNumbers
    {
        public int numerator;
        public int denominator;

        public RationalNumbers(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }

        public static bool operator ==(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.numerator / number1.denominator) == (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static bool operator !=(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.numerator / number1.denominator) != (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static bool operator <(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.numerator / number1.denominator) < (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static bool operator >(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.numerator / number1.denominator) > (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static bool operator <=(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.numerator / number1.denominator) <= (number2.numerator / number2.denominator)) return true;
            else return false;
        }
        public static bool operator >=(RationalNumbers number1, RationalNumbers number2)
        {
            if ((number1.numerator / number1.denominator) >= (number2.numerator / number2.denominator)) return true;
            else return false;
        }

        public static RationalNumbers operator +(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers((number1.numerator * number2.denominator) + (number1.denominator * number2.numerator), number1.denominator * number2.denominator);
        }

        public static RationalNumbers operator -(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers((number1.numerator * number2.denominator) - (number1.denominator * number2.numerator), number1.denominator * number2.denominator);
        }

        public static RationalNumbers operator ++(RationalNumbers number1)
        {
            return new RationalNumbers(number1.numerator += number1.denominator, number1.denominator);
        }

        public static RationalNumbers operator --(RationalNumbers number1)
        {
            return new RationalNumbers(number1.numerator -= number1.denominator, number1.denominator);
        }

        public static RationalNumbers operator *(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers(number1.numerator * number2.numerator, number1.denominator * number2.denominator);
        }

        public static RationalNumbers operator /(RationalNumbers number1, RationalNumbers number2)
        {
            return new RationalNumbers(number1.numerator * number2.denominator, number2.numerator * number1.denominator);
        }


        public float GetFloat()
        {
            return numerator / denominator;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public override bool Equals(object obj)
        {
            return obj is RationalNumbers numbers &&
                   numerator == numbers.numerator &&
                   denominator == numbers.denominator;
        }

        public override int GetHashCode()
        {
            int hashCode = -671859081;
            hashCode = hashCode * -1521134295 + numerator.GetHashCode();
            hashCode = hashCode * -1521134295 + denominator.GetHashCode();
            return hashCode;
        }
    }
}
