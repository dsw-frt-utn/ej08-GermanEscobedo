using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {

           //Calculo cantidad vendida y verifico si es positivo
           decimal totalCalculado = 0;
            if (quantity > 0)
            {
                totalCalculado = quantity * unitPrice;
            }
            //Asigno parametros y calculo
            var resumen = new
            {
                Code = productCode,
                ProductDescription = productDescription,
                Quantity = quantity,
                Total = totalCalculado

            };

            return $"{resumen.Code} - {resumen.Description} - {resumen.Total}" ;
        }



    }
}