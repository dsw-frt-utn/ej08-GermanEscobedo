namespace Dsw2026Ej8.Problema3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            //hago una copia del valor
            int copiaValor = originalValue;

            //hago que solo se modifique la copia 
            copiaValor++;

            //hago copia de product
            Product copiaProducto = product;

            //se modifica la desc del producto 
            copiaProducto.SetDescription("descripcion modificada");

            return $"{originalValue}-{copiaValor}-{copiaProducto.GetDescription}";
        }

    }
}
