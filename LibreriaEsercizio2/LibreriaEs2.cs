using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEsercizio2
{
    public class LibreriaEs2
    {
        public static bool VerificaIntero(double n)
        {
            int n1 = (int)n;
            if (n1 == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Arrotondamento(double n)
        {
            int n1 = (int)(n + 0.5);
            return n1;
        }
        public static bool PariDispari
    }
}
