using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            else if (Ex == 7) Ex7();
            else if (Ex == 8) Ex8();
            else if (Ex == 9) Ex9();
            else if (Ex == 10) Ex10();
            else if (Ex == 11) Ex11();
            else if (Ex == 12) Ex12();
            else if (Ex == 15) Ex15();
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Nu exista acel exercitiu");
            }
            Main();
        }

        private static void Ex15()
        {
            //WIP ATM
            Console.WriteLine("Introduceti secventa");
                string Numere;
                int x = 0, z = 1, a = 0;
                Numere = Console.ReadLine();
                char[] separator = new char[] { ' ', ',', ';' };
                string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int[] y = Array.ConvertAll(n, int.Parse);
            while (y[x] <= y[z])
            {
                x++;
                z++;
                if (z == y.findIndex(y.Max()))
                {
                    Console.WriteLine("a + 1");
                    a++;
                    break;
                }
            }
            while (y[x] >= y[z])
            {
                x++;
                z++;
                if (z == y.Length)
                {
                    Console.WriteLine("a + 2");
                    a++;
                    break;
                }
            }
                
            if (a == 0 || a == 1 ) Console.WriteLine("Secventa nu este bitonica");
            else if (a == 2) Console.WriteLine("Secventa este bitonica");

        }
            private static void Ex12()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Not working");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Introduceti secventa");
                string Numere;
                int x = 0;
                string[] p = new string[] { ", ", " ", "," };
                Numere = Console.ReadLine();
                char[] separator = new char[] { '0' };
                char[] S = new char[] { ' ', ',', ';' };
                string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string i in n)
                {
                    if (n[x] == p[0]) n[x] = n[x + 1];
                    else if (n[x] == p[1]) n[x] = n[x + 1];
                    else if (n[x] == p[2]) n[x] = n[x + 1];
                    x++;
                }
                Console.WriteLine(n.Length);

            }

            private static void Ex11()
            {
                Console.WriteLine("Introduceti secventa");
                int x = 0;
                string Numere;
                Numere = Console.ReadLine();
                char[] separator = new char[] { ' ', ',', ';' };
                string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int[] y = Array.ConvertAll(n, int.Parse);
                foreach (int c in y)
                {
                    y[x] = -c;
                    x++;
                }
                Console.WriteLine($"Suma inverselor acestor numere este {y.Sum()}");
            }

            private static void Ex10()
            {
                Console.WriteLine("Introduceti secventa");
                string Numere;
                int x = 0, z = 0, a = 1;
                Numere = Console.ReadLine();
                char[] separator = new char[] { ' ', ',', ';' };
                string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int[] y = Array.ConvertAll(n, int.Parse);
                while (x < y.Length - 1)
                {
                    if (y[x] == y[x + 1])
                    {
                        a++;
                    }
                    else if (y[x] != y[x + 1]) a = 1;
                    if (z < a) z = a;
                    x++;
                }
                Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {z}");
            }

            private static void Ex9()
            {
                Console.WriteLine("Introduceti secventa");
                string Numere;
                int x = 0, z = 1, a = 0;
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
                        a++;
                        break;
                    }
                    else if (y[x] > y[z])
                    {
                        a = 0;
                    }
                }
                x = 0; z = 1;
                while (y[x] >= y[z])
                {
                    x++;
                    z++;
                    if (z == y.Length)
                    {
                        a++;
                        a++;
                        break;
                    }
                    else if (y[x] < y[z])
                    {
                        a = 0;
                    }
                }
                if (a == 1) Console.WriteLine("Secventa este monoton crescatoare");
                else if (a == 2) Console.WriteLine("Secventa este monoton descrescatoare");
                else if (a == 0) Console.WriteLine("Secventa nu este monotona");
            }

            private static void Ex8()
            {
                int f1, f2, n, y = 2;
                Console.WriteLine("Alege f1");
                Console.Write("f1 = ");
                f1 = int.Parse(Console.ReadLine());
                Console.Write("f2 = ");
                f2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Alege termenul pe care il cauti");
                n = int.Parse(Console.ReadLine()) - 1;
                int[] x = new int[n + 1];
                x[0] = f1; x[1] = f2;
                while (y <= n)
                {
                    x[y] = x[(y - 1)] + x[(y - 2)];
                    y++;
                }
                Console.WriteLine($"Al {y}-lea termen este {x[n]}");
            }

            private static void Ex7()
            {
                Console.WriteLine("Introduceti secventa");
                string Numere;
                Numere = Console.ReadLine();
                char[] separator = new char[] { ' ', ',', ';' };
                string[] n = Numere.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int[] y = Array.ConvertAll(n, int.Parse);
                Console.WriteLine($"Cel mai mare nr este {y.Max()}");
                Console.WriteLine($"Cel mai mic nr este {y.Min()}");
            }

            private static void Ex6()
            {
                Console.WriteLine("Introduceti secventa");
                string Numere;
                int x = 0, z = 1, a = 0;
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

            //   private static void Ex3()
            //   {
            //       Console.WriteLine("Introduceti ultimul termen al secventei");
            //       int n, sum = 1, prod = 1, mult = 2;
            //       n = int.Parse(Console.ReadLine());
            //       while (mult <= n)
            //       {  
            //           sum = sum + mult;
            //           prod = prod * mult;
            //           mult++;
            //       }
            //       Console.WriteLine($"Suma nr. de la 1 la {n} este {sum}");
            //       Console.WriteLine($"Produsul nr. de la 1 la {n} este {prod}");
            //   }

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

