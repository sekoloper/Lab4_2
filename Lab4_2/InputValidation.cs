using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class InputValidation
    {
        static public double InputDoubleWithValidation(string s, double left, double right)
        {
            bool _ok;
            double _a;
            do
            {
                Console.WriteLine(s);
                _ok = double.TryParse(Console.ReadLine(), out _a);
                if (_ok)
                {
                    if (_a < left || _a > right)
                    {
                        _ok = false;
                    }
                }
                if (!_ok)
                {
                    ConsoleColor tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                    Console.WriteLine("Повторите ввод\n");
                    Console.ForegroundColor = tmp;
                }
            } while (!_ok);
            return _a;
        }
    }
}
