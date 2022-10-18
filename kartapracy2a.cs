using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            /*
            Console.WriteLine("Podaj dwie liczby");
            int l1 = int.Parse(Console.ReadLine());
            int l2 = int.Parse(Console.ReadLine());
            int wynik = 0;
            wynik = l1 + l2;
            if (wynik % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
            */


            //zadanie 2
            /*
            double sredniageo, sredniary;
            Console.WriteLine("Podaj 2 liczby");
            int l1 = int.Parse(Console.ReadLine());
            int l2 = int.Parse(Console.ReadLine());
            sredniary = (l1 + l2) / 2;
            sredniageo = l1 * l2;
            sredniageo = Math.Sqrt(sredniageo);
            if (sredniageo > sredniary)
            {
                Console.WriteLine("Średnia geometryczna jest większa od średniej arytmetycznej");
            }
            else if (sredniageo == sredniary)
            {
                Console.WriteLine($"Średnia arytmetyczna o wartości {sredniary} jest równa średniej geometrycznej o wartości {sredniageo}");
            }
            else
            {
                Console.WriteLine($"Średnia arytmetyczna o wartości {sredniary} jest większa średniej geometrycznej o wartości {sredniageo}");
            }
            */


            //zadanie 3
            /*
            Console.WriteLine("Podaj 3 liczby całkowite: ");
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (k == l)
            {
                if (k != m)
                {
                    Console.WriteLine("2 liczby są równe,a jedna jest inna");
                }
            }
            if(l == m)
            {
                if (l != k)
                {
                    Console.WriteLine("2 liczby są równe,a jedna jest inna");
                }
            }
            if(m == k)
            {
                if (m != l)
                {
                    Console.WriteLine("2 liczby są równe,a jedna jest inna");
                }
            }
            if(k == l)
            {
                if (l == m){Console.WriteLine("Wszystkie liczby są takie same");}
                    
                
            }
            else
            {
                Console.WriteLine("Wszystkie liczby są różne");
            }
            */


            //zadanie 4
            /*
            Console.WriteLine("Podaj liczbę całkowite: ");
            int a = int.Parse(Console.ReadLine());
            int wynik = 0;
            wynik = a;
            Console.WriteLine("Podaj kolejną liczbę:");
            int b = int.Parse(Console.ReadLine());
            if (wynik > b){ wynik = b; }
            Console.WriteLine("Podaj kolejną liczbę:");
            int c = int.Parse(Console.ReadLine());
            if (wynik > c) { wynik = c; }
            Console.WriteLine("Podaj kolejną liczbę:");
            int d = int.Parse(Console.ReadLine());
            if (wynik > d) { wynik = d; }
            Console.WriteLine($"Najmniejsza liczba spośród podanych to {wynik}");
            */


            //zadanie 5
            /*
            Console.WriteLine("Podaj 3 liczby- całkowite: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                if (a < b + c && b < a + c && c < a + b)
                {
                    Console.WriteLine("Trójkąt spełnia równanie");
                }
                else
                {
                    Console.WriteLine("Trójkąt nie spełnia równania");
                }
            }
            */


            // zadanie 6
            /*
            Console.WriteLine("Podaj 3 liczby- całkowite: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                if (a < b + c && b < a + c && c < a + b)
                {
                    Console.WriteLine("Trójkąt spełnia równanie");
                    if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
                    {
                        Console.WriteLine("Trójkąt prostokątny");
                    }
                    else if (a * a + b * b < c * c || a * a + c * c < b * b || c * c + b * b < a * a)
                    {
                        Console.WriteLine("Trójkąt ostrokątny");
                    }
                    else if (a * a + b * b > c * c || a * a + c * c > b * b || c * c + b * b > a * a)
                    {
                        Console.WriteLine("Trójkąt rozwartokątny");
                    }
                }
                else
                {
                    Console.WriteLine("Trójkąt nie spełnia równania");
                }
            }
            */
        }
    }
}
