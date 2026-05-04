using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Amount * 0.90m;
        }

    }
}
