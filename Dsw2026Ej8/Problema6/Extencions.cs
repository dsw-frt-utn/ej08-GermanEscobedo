using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Problema6
{
    public static class Extencions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "Sin Codigo";

            }

            return code.Trim().ToUpper().Replace(" ", " - ");
        }


    }
}
