using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.Utilidades
{
      static class Validadores
    {
        public static bool esNumeroInt(string numeroStr)
        {
            int n;
            return int.TryParse(numeroStr, out n);
        }
        public static int obtenerNumeroInt(string numeroStr)
        {
            int n;
            bool esInt =  int.TryParse(numeroStr, out n);
            if (esInt) {
                return n;
            } else { return -1; }
        }
        public static bool esNumeroFloat(string numeroStr)
        {
            int n;
            return int.TryParse(numeroStr, out n);
        }
        public static int obtenerNumeroFloat(string numeroStr)
        {
            int n;
            bool esInt = int.TryParse(numeroStr, out n);
            if (esInt)
            {
                return n;
            }
            else { return -1; }
        }
    }

}
