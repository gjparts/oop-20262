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

            //Operaciones con fechas
            DateTime fecha6 = DateTime.Now;
            Console.WriteLine(fecha6);

            //Sumar 10 dias a fecha6
            fecha6 = fecha6.AddDays(10);
            Console.WriteLine(fecha6);

            //Restar 1 mes a fecha6
            fecha6 = fecha6.AddMonths(-1);
            Console.WriteLine(fecha6);

            //Tambien se pueden desencadenar:
            //sumar 1 año y 2 meses a fecha6
            fecha6 = fecha6.AddYears(1).AddMonths(2);
            Console.WriteLine(fecha6);

            //ejercicio: haga un programa que capture una fecha
            //el programa va a mostrar el primer y ultimo dia de la
            //fecha capturada.
            //ejemplo:
            //Digite fecha: 2026/3/13
            //Primer dia del mes: 2026/3/1
            //Ultimo dia del mes: 2026/3/31
            try
            {
                Console.Write("Digite fecha: ");
                DateTime fecha7 = DateTime.Parse(Console.ReadLine());
                //forma 1:
                Console.WriteLine($"Primer dia del mes: {fecha7.AddDays(-fecha7.Day+1)}");
                Console.WriteLine($"Ultimo dia del mes: {fecha7.AddDays(-fecha7.Day + 1).AddMonths(1).AddDays(-1)}");

                //forma 2: usando variables
                DateTime primero = fecha7.AddDays(-fecha7.Day + 1);
                DateTime ultimo = primero.AddMonths(1).AddDays(-1);
                Console.WriteLine($"Primer dia del mes: {primero}");
                Console.WriteLine($"Ultimo dia del mes: {ultimo}");

                //forma 3: explorando los metodos de DateTime
                primero = new DateTime(fecha7.Year, fecha7.Month, 1);
                ultimo = new DateTime(fecha7.Year, fecha7.Month, DateTime.DaysInMonth(fecha7.Year, fecha7.Month));
                Console.WriteLine($"Primer dia del mes: {primero}");
                Console.WriteLine($"Ultimo dia del mes: {ultimo}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Fecha no valida.");
            }

            //Comparacion de fechas
            try
            {
                DateTime a, b;
                Console.Write("digite la fecha A: ");
                a = DateTime.Parse (Console.ReadLine());
                Console.Write("digite la fecha B: ");
                b = DateTime.Parse(Console.ReadLine());

                //son iguales?
                if( a == b )
                    Console.WriteLine("Las fechas son iguales");
                else
                {
                    if (a > b)
                        Console.WriteLine("fecha A es mayor a fecha B");
                    else
                        Console.WriteLine("fecha B es mayor a fecha A");
                }

                //Obtener la diferencia en dias entre las dos fechas
                TimeSpan diferencia;
                if (a > b)
                    diferencia = a - b;
                else
                    diferencia = b - a;

                Console.WriteLine($"Dias de diferencia entre A y B: {diferencia.Days}");
                Console.WriteLine($"horas de diferencia entre A y B: {diferencia.TotalHours}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fecha digitada no es valida");
            }

        }
    }
}
