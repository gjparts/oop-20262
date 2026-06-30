namespace _39_control_fuljo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que tenga un estructura
            while infinita, en cada iteracion va a
            preguntar al usuario un numero entero.
            La idea es adivinar un numero secreto.
            -> el numero secreto va a ser generado
               al azar entre 1 y 10
            -> El numero secreto va a cambiar en
               cada iteracion
            -> Si adivina el numero secreto entonces
               se termina la estructura infinita y
               se felicita al usuario.
            -> Resuelvalo utilizando break al menos una vez.*/

            int numero;
            Random r = new Random(); //generador de numeros
            int azar;

            while (true)
            {
                try
                {
                    Console.Write("Adivine un numero entero entre 1 y 10: ");
                    numero = int.Parse(Console.ReadLine());
                    azar = r.Next(1, 11);
                    if(numero == azar)
                    {
                        Console.WriteLine("Felicidades!");
                        Console.Beep(500, 1000);
                        break; //termina while infinito
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Solo se acepta numeros enteros");
                }
            }
        }
    }
}
