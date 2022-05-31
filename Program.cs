using System;

namespace test1
{
    class Class1
    {
        [STAThread]
        public static void Main(string[] args)
        {
            double r, k, t;
            Console.WriteLine("Kör kerülete és területe\nKérlek, add meg a kör sugarát: ");
            r = Convert.ToDouble(Console.ReadLine());
            k = 2 * r * Math.PI;
            t = r * r * Math.PI;
            Console.WriteLine("A kör sugara: {0}\nA kör kerülete: {1}\nA kör területe: {2}", r, k, t);
        }
    }
}
