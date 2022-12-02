using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme___setul_2
{
    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Selecteaza nr. exercituiului");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int Ex = 0;
            try
            {
                Ex = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
                Main();
            }


            if (Ex == 1) Ex1();
            else if (Ex == 2) Ex2();
            else if (Ex == 3) Ex3();
            else if (Ex == 4) Ex4();
            else if (Ex == 5) Ex5();
            else if (Ex == 6) Ex6();
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Nu exista acel exercitiu");
            }
            Main();
        }

        private static void Ex6()
        {
            Console.WriteLine("Introduceti secventa");
            string Numere;
            int x = 0,z = 1,a = 0;
            Numere = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int[] y = Array.ConvertAll(n, int.Parse);
            while (y[x] <= y[z])
            {
                x++;
                z++;
                if (z == y.Length)
                {
                    a = 1;
                    break;
                }
                else if (y[x] > y[z])
                {
                    a = 0;
                }
            }
            if (a == 1) Console.WriteLine("Secventa este crescatoare");
            else if (a == 0) Console.WriteLine("Secventa nu este crescatoare");

        }



        private static void Ex5()
        {
            Console.WriteLine("Introduceti secventa");
            string Numere;
            Numere = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int[] y = Array.ConvertAll(n, int.Parse);
            int c = 0, e = 0;
            while (c < y.Length)
            {
                if (y.findIndex(c) == y[c]) e++;
                c++;
            }
            Console.WriteLine($"{e} elemente corespund pozitiei lor");
        }


        private static void Ex4()
        {
            Console.WriteLine("Introduceti secventa");
            string Numere;
            Numere = Console.ReadLine();
            Console.WriteLine("Introduceti nr. pe care il cautati");
            int z, a = int.Parse(Console.ReadLine());
            char[] separator = new char[] { ' ', ',', ';' };
            string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int[] y = Array.ConvertAll(n, int.Parse);
            z = y.findIndex(a);
            Console.WriteLine($"Numarul {a} este pe pozitia {z}");

        }
        private static void Ex3()
        {
            Console.WriteLine("Introduceti ultimul termen al secventei");
            int n, z = 0, rezp = 1, y;
            n = int.Parse(Console.ReadLine());
            y = n + 1;
            int[] Multiplicator = new int[y];
            while (z < n)
            {
                z++;
                Multiplicator[z] = z;
                rezp = rezp * Multiplicator[z];
            }
            Console.WriteLine("Suma este " + rezp);
            Console.WriteLine("Produsul este " + Multiplicator.Sum());
        }

     ///   private static void Ex3()
     ///   {
     ///       Console.WriteLine("Introduceti ultimul termen al secventei");
     ///       int n, sum = 1, prod = 1, mult = 2;
     ///       n = int.Parse(Console.ReadLine());
     ///       while (mult <= n)
     ///       {  
     ///           sum = sum + mult;
     ///           prod = prod * mult;
     ///           mult++;
     ///       }
     ///       Console.WriteLine($"Suma nr. de la 1 la {n} este {sum}");
     ///       Console.WriteLine($"Produsul nr. de la 1 la {n} este {prod}");
     ///   }

        private static void Ex2()
        {
            Console.WriteLine("Introduceti secventa");
            string Numere;
            int a, y = 0, z, poz = 0, neg = 0, zer = 0;
            Numere = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] x = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            z = x.Length;
            while (y < z)
            {
                a = int.Parse(x[y]);
                y++;
                if (a < 0) neg++;
                else if (a > 0) poz++;
                else if (a == 0) zer++;
            }
            Console.WriteLine($"In aceasta secventa aceasta sunt {poz} nr. pozitive, sunt {neg} nr. negative si {zer} nr. egale cu 0 ");
        }

        private static void Ex1()
        {
            Console.WriteLine("Introduceti secventa");
            string Numere;
            int a, y = 0, z, NPare = 0;
            Numere = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] x = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            z = x.Length;
            while (y < z)
            {
                a = int.Parse(x[y]);
                y++;
                if (a % 2 == 0) NPare++;
            }
            Console.WriteLine($"In aceasta secventa sunt {NPare} nr. pare din {z} numere");
        }
    }
}
