namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation();
            Console.WriteLine(qe.ToString());

            Console.Write($"Есть корни? {(bool)qe}\n\n");

            double a = InputValidation.InputDoubleWithValidation("Введите коэффициент a: ", double.MinValue, double.MaxValue);
            double b = InputValidation.InputDoubleWithValidation("Введите коэффициент b: ", double.MinValue, double.MaxValue);
            double c = InputValidation.InputDoubleWithValidation("Введите коэффициент c: ", double.MinValue, double.MaxValue);

            QuadraticEquation qe2 = new QuadraticEquation(a, b, c);
            Console.WriteLine(qe2.ToString());

            qe2++;
            Console.WriteLine(qe2.ToString());

            qe2--;
            Console.WriteLine(qe2.ToString());

            Console.Write($"Есть корни? {(bool)qe2}\n");

            double[] roots = qe2.Solve();

            Console.WriteLine("\nКорни уравнения: ");
            if (roots.Length == 0)
            {
                Console.WriteLine("Нет таких...");
            }
            foreach (var root in roots)
            {
                Console.WriteLine(root);
            }

            Console.WriteLine($"Дискриминант: {qe2 + 0}");
        }
    }
}
