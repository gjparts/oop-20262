namespace _08_Asociacion_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Cliente c1 = new Cliente("Gerardo","1234123412345","","");
                Cliente c2 = new Cliente("Estevancito Maravilla", "4321431112234", "", "");

                CategoriaProducto cat1 = new CategoriaProducto("Bebidas","1");
                CategoriaProducto cat2 = new CategoriaProducto("Boquitas", "12A");
                CategoriaProducto cat3 = new CategoriaProducto("Frutas", "8A");
                CategoriaProducto cat4 = new CategoriaProducto("Limpieza", "4");

                Producto pr1 = new Producto("Coca Cola 3L", cat1, 80);
                Producto pr2 = new Producto("Doritos", cat2, 25);
                Producto pr3 = new Producto("Taqueritos Fuego", cat2, 25);
                Producto pr4 = new Producto("Manzana Unidad", cat3, 8);
                Producto pr5 = new Producto("Azistin Lavanda 1GL", cat4, 180);
                Producto pr6 = new Producto("Pera Unidad", cat3, 6.5f);

                Factura f1 = new Factura(1,DateTime.Now,c1,pr5);
                f1.Imprimir();

                Factura f2 = new Factura(2, new DateTime(2026, 6, 14), null, pr4);
                f2.Producto2 = pr4;
                f2.Producto3 = pr6;
                f2.Producto4 = pr4;
                f2.Imprimir();

                Factura f3 = new Factura(3, DateTime.Now, c2, pr1);
                f3.Producto4 = pr3;
                f3.Imprimir();

                //Objeto volatil
                new Factura(4, DateTime.Now, null, pr2).Imprimir();
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
