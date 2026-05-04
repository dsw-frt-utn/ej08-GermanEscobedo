using System;
using System.Collections.Generic;
using System.Text;
using Dsw2026Ej8.Problema5.Problema5;

namespace Dsw2026Ej8.Problema5.Problema5
{
    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }

    }
}
