using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema1
{
    public partial class ProductHelper
    {
        private const string Separador = " - ";

        private string FormatearPrecio(decimal price)
        {
            return price.ToString("C");
        }
    }
}
