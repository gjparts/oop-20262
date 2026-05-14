namespace _01_Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bases de C#
            //comentario de un renglon
            /*Comentario
             de varios
            renglones
             */
            Console.WriteLine("Imprime y pasa a la siguiente linea");
            Console.WriteLine(); //imprime salto de linea
            Console.Write("Imprime y no pasa a la siguiente linea");
            Console.Write("Hola UNAH");
            Console.Write("Sistemas");
            //impresion de caracteres de escape
            Console.WriteLine("\ngato\nperro\nconejo\njirafa");
            Console.WriteLine("rojo\tamarillo\tazul");

            //dar color al texto en la terminal
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto color amarillo");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Texto amarillo en fondo azul oscuro");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto verde en fondo amarillo");

            //regresar los colores de la terminal a su valor default
            Console.ResetColor();

            //usar varios colores en una linea de texto
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Uva");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fresa");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Naranja");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Sandia");

            Console.ResetColor();
            Console.WriteLine();

            //Pausar la ejecucion del codigo en la terminal
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //se pone true para no imprimir la tecla

            //limpiar la terminal
            Console.Clear();

            //imprimir texto RAW (sin tratamiento)
            Console.WriteLine(@"String de
varios renglones
y que ignora los caracteres de escape \n\n\n\n\t fin");

            //interpolacion de variables
            int numero = 5;
            //imprimir el contenido de una variable sin concatenar:
            Console.WriteLine($"el valor de numero es {numero}");
            //forma tradicional de imprimir una variable:
            Console.WriteLine("El valor de numero es "+numero);

            //Pausar la ejecucion del codigo en la terminal y limpiar
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //se pone true para no imprimir la tecla
            Console.Clear();

            //Cambiar la posicion del cursor de impresion en la terminal
            Console.SetCursorPosition(70,5);
            //la primer linea es CERO, y la primer columna es CERO
            Console.WriteLine("Texto en columna 70, linea 5");

            Console.SetCursorPosition(15,18);
            Console.WriteLine("Hola");

            Console.SetCursorPosition(0, 21);
            Console.WriteLine("Adios");

            //importante el texto de aviso que el programa
            //ha terminado se imprime abajo de la ultima linea
            //donde Usted coloco el cursor por ultima vez.

            //Pausar la ejecucion del codigo en la terminal y limpiar
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //se pone true para no imprimir la tecla
            Console.Clear();

            //variables (igual que en Java y C++)
            int x = 5;
            double precio = 5.67;
            float valor = 100.45f;
            long num = 1234123412345L;

            //bloque de caza de errores
            try
            {
                //codigo propenso a fallar
                //Capturar datos para colocarlos en las variables
                int a;
                Console.Write("Digite un numero entero: ");
                a = int.Parse(Console.ReadLine());

                double b;
                Console.Write("Digite un numero: ");
                b = double.Parse(Console.ReadLine());

                float c;
                Console.Write("Digite un numero: ");
                c = float.Parse(Console.ReadLine());

                long d;
                Console.Write("Digite un entero largo: ");
                d = long.Parse(Console.ReadLine());

                //imprimo usando interpolacion
                Console.WriteLine($"valor de a: {a}, valor de b: {b}");
                Console.WriteLine($"valor de c: {c}, valor de d: {d}");
            }
            catch (Exception ex)
            {
                //codigo a ejecutar en caso de falla
                Console.WriteLine("Conversion ha fallado");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
