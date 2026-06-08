namespace _06_Asociacion_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pruebas
            //primero cree objetos para las clases no dependientes
            Fabricante samsung = new Fabricante("Samsung Electronics Co.", "Korea", "no se");
            Fabricante lg = new Fabricante("LG Chemical", "Korea", "tampoco se");
            Fabricante apple = new Fabricante("Apple Computer Inc.","USA","Tim Cook");
            Fabricante huawei = new Fabricante("Huawei Corp.","China","");

            Operador tigo = new Operador("TIGO","Centroamerica");
            Operador claro = new Operador("Claro","Honduras");

            //luego cree objetos para las clases dependientes por orden de dependencia
            Bateria b1 = new Bateria(lg, 4500);
            Bateria b2 = new Bateria(lg, 6300);
            Bateria b3 = new Bateria(new Fabricante("ATL", "Hong Kong", ""), 6500);
            /*Note que para b3 su Marca no la asignamos aun objeto que estaba
             en una variable, sino que de un solo creamos el objeto de tipo
            Fabricante (ATL, Hong Kong) y esta referencia queda almacenada
            como la Marca para b3.
            A esto se le conoce como Objeto de un solo uso, se hace normalmente
            cuando no necesito reutilizar el objeto en otra parte.
            Tambien se le conoce como Objeto sin variable.*/

            Chip sim1 = new Chip(tigo, 99152959);
            Chip sim2 = new Chip(claro, 33133313);
            Chip sim3 = new Chip(tigo, 99989998);
            Chip sim4 = new Chip(new Operador("Verizon", "USA"), 1300234535);
            Chip sim5 = new Chip(claro, 35353535);
            /*el proveedor de servicios de sim4 es un objeto de un solo uso como
             se explico arriba.
            Recomendaciones:
            1) si el objeto lo va a ocupar muchas veces (como tigo y claro) entonces
               se recomienda ponero en una variable.
            2) si el objeto solo lo va ocupar una vez lo mejor es hacer
               un objeto de un solo uso.*/

            SmartPhone sm1 = new SmartPhone(samsung, "S24", Enum.Capacidad.c256GB,
                Enum.Capacidad.c8GB, b3, sim1, null);
            sm1.Imprimir();
            //Note que sm1 no tiene Chip2 (null)

            SmartPhone sm2 = new SmartPhone(apple,"iPhone 17 Pro Max",Enum.Capacidad.c512GB,
                Enum.Capacidad.c8GB,b2,sim5,null);
            sm2.Imprimir();

            SmartPhone sm3 = new SmartPhone(huawei, "Honor Play", Enum.Capacidad.c512GB,
                Enum.Capacidad.c8GB, b1, sim3, sim4);
            sm3.Imprimir();

            //tambien puede crear algo conocido como Objeto Volatil
            //normalmente se usan cuando Usted solo necesita ejecutar
            //algun metodo dentro de él:
            new SmartPhone(huawei, "Y10", Enum.Capacidad.c4GB, Enum.Capacidad.c4GB,
                b1, sim2, null).Imprimir();
            //el objeto anterior nace, ejecuta Imprimir() y luego muere.
            //el objeto volatil no se asigna a ninguna variable.

        }
    }
}
