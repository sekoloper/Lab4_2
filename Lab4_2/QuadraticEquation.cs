using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get => _a;
            set => _a = value;
        }

        public double B
        {
            get => _b;
            set => _b = value;
        }

        public double C
        {
            get => _c;
            set => _c = value;
        }

        public QuadraticEquation()
        {
            _a = 0;
            _b = 0;
            _c = 0;
        }

        public QuadraticEquation(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double[] Solve()
        {
            if (_a == 0)
            {
                if (_b == 0)
                {
                    return new double[0];
                }
                return new double[] { -_c / _b };
            }

            double discriminant = GetDiscriminant();

            if (discriminant < 0)
            {
                return new double[0];
            }
            else if (discriminant == 0)
            {
                double root = -_b / (2 * _a);
                return new double[] { root };
            }
            else
            {
                double sqrtD = Math.Sqrt(discriminant);
                double root1 = (-_b + sqrtD) / (2 * _a);
                double root2 = (-_b - sqrtD) / (2 * _a);
                return new double[] { root1, root2 };
            }
        }

        private double GetDiscriminant()
        {
            if (_a == 0 && _b == 0)
            {
                return -1;
            }
            return _b * _b - 4 * _a * _c;
        }

        public override string ToString()
        {
            return $"{_a}*x^2 + {_b}*x + {_c} = 0";
        }

        public static QuadraticEquation operator ++(QuadraticEquation equation)
        {
            return new QuadraticEquation(equation._a + 1, equation._b + 1, equation._c + 1);
        }

        public static QuadraticEquation operator --(QuadraticEquation equation)
        {
            return new QuadraticEquation(equation._a - 1, equation._b - 1, equation._c - 1);
        }

        public static implicit operator double(QuadraticEquation equation)
        {
            return equation.GetDiscriminant();
        }

        public static explicit operator bool(QuadraticEquation equation)
        {
            return equation.GetDiscriminant() >= 0;
        }

        public static bool operator ==(QuadraticEquation eq1, QuadraticEquation eq2)
        {
            if (eq1 is null || eq2 is null) return false;

            return Math.Abs(eq1._a - eq2._a) < double.Epsilon &&
                   Math.Abs(eq1._b - eq2._b) < double.Epsilon &&
                   Math.Abs(eq1._c - eq2._c) < double.Epsilon;
        }

        public static bool operator !=(QuadraticEquation eq1, QuadraticEquation eq2)
        {
            return !(eq1 == eq2);
        }
    }
}
