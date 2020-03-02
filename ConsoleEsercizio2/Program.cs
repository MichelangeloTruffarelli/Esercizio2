using LibreriaEsercizio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEsercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("inserisci un numero");
                try
                {
                    double n = double.Parse(Console.ReadLine());
                    if (LibreriaEs2.VerificaIntero(n))
                    {
                        Console.WriteLine($"Il numero {n} è intero");
                    }
                    else
                    {
                        Console.WriteLine("il numero non è intero");
                        n = (int)(n + 0.5);
                    }
                    int n1 = (int)n;
                    if (n1 == n)
                    {
                        Console.WriteLine("il numero è intero");
                    }
                    if (n1 % 2 == 0)
                    {
                        Console.WriteLine("il numero è pari");
                    }
                    else
                    {
                        Console.WriteLine("il numero è dispari");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("devi inserire un numero", e.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
