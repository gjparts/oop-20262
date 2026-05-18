namespace _03_Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Manejo de Fechas en C#
             * En C# existen diversos tipos de datos para el manejo
             * de fecha y hora, los tipos de dato mas usados son:
             * DateTime almacena fecha y hora
             * DateOnly guarda unicamente fecha
             * TimeOnly guarda unicamente hora
             * Estos ultimos dos existen a partir de .Net en version 6
             */

            //obtener la fecha/hora de la computadora
            DateTime hoy = DateTime.Now;
            Console.WriteLine(hoy);

            //reloj un pantalla:
            /*while (true)
            {
                hoy = DateTime.Now;
                Console.WriteLine(hoy);
                Thread.Sleep(500); //pausa de medio segundo
                Console.Clear();
            }*/

            //DateTime de forma nativa no puede ser asignada
            //a un valor null:
            //DateTime x = null;
            //pero es posible saltarse esa validacion usando el
            //modificador ?
            DateTime? x = null;
            //lo anterior no es una buena practica; pero puede llegar
            //a resolver algunos problemas (o generar mas)

            //tambien puede usarse para saltarse la validacion
            //que impide utilizar una variable sin asignarle valor
            DateTime? z = null;
            Console.WriteLine(z);

            //el modificar ? permite declarar una variavle
            //la cual sera inicializada con un valor no referenciable
            //o sea (sin memoria)

            //establecer fecha y hora fijos
            DateTime fecha1 = new DateTime(1982, 10, 15, 7, 33, 24);
            Console.WriteLine(fecha1);

            DateTime fecha2 = new DateTime(2026, 5, 10, 19, 50, 0);
            Console.WriteLine(fecha2);

            //solo fecha:
            DateOnly fecha = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(fecha);

            //solo hora
            TimeOnly hora = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(hora);

            //establecer una fecha fija
            DateOnly fecha3 = new DateOnly(1985, 8, 9);
            Console.WriteLine(fecha3);

            //establecer una hora fija
            TimeOnly hora2 = new TimeOnly(18, 29, 1);
            Console.WriteLine(hora2);

            //Imprimir DateTime utilizando formatos predefinidos
            Console.WriteLine($"Fecha corta: {hoy.ToShortDateString()}");
            Console.WriteLine($"Fecha larga: {hoy.ToLongDateString()}");

            //Imprimir DateTime usando su propia mascara de entrada
            Console.WriteLine($"Fecha con formato: {hoy.ToString("yyyy/MM/dd hh:mm:ss tt")}");

            //Convertir un String a DateTime
            String str = "25/12/2026 23:45:7";
            DateTime fecha4 = DateTime.Parse(str);
            Console.WriteLine(fecha4);

            //Captura de fecha
            Console.Write("Digite una fecha (año/mes/dia hora:minuto:segundo): ");
            try
            {
                DateTime fecha5 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Dato ingresado: {fecha5}");

                //extraer datos del DateTime
                Console.WriteLine($"Año: {fecha5.Year}");
                Console.WriteLine($"Mes: {fecha5.Month}");
                Console.WriteLine($"Dia: {fecha5.Day}");
                Console.WriteLine($"Hora: {fecha5.Hour}");
                Console.WriteLine($"Minuto: {fecha5.Minute}");
                Console.WriteLine($"Segundo: {fecha5.Second}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("La fecha ingresada no esta en formato correcto.");
            }

        }
    }
}
