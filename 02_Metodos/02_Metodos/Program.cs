namespace _02_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sumar(2,3));
            Saludar();
            //los metodos void no se imprimen porque no retornan valor:
            //Console.WriteLine(Saludar());
        }

        //Metodos o funciones
        static double Sumar(double a, double b)
        {
            return a + b;
        }
        static void Saludar()
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Como estan?");
            Console.WriteLine("Un gusto");
        }
    }
}
