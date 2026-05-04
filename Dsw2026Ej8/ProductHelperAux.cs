using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelperAux
    {
        private const string Separador = " - ";

        private string FormatearPrecio(decimal price)
        {
            return price.ToString("C");
        }
    }
}
