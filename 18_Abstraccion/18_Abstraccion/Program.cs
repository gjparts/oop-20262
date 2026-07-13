namespace _18_Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo(8, 4);
            Console.WriteLine($"Area de r1: {r1.CalcularArea()}");
            Console.WriteLine($"Perimetro de r1: {r1.CalcularPerimetro()}");

            Console.WriteLine("----------------------");
            Circulo c1 = new Circulo(4.5);
            Console.WriteLine($"Area de c1: {c1.CalcularArea()}");
            Console.WriteLine($"Perimetro de c1: {c1.CalcularPerimetro()}");

            Console.WriteLine("----------------------");
            TrianguloEquilatero t1 = new TrianguloEquilatero(3,4);
            Console.WriteLine($"Area de t1: {t1.CalcularArea()}");
            Console.WriteLine($"Perimetro de t1: {t1.CalcularPerimetro()}");

            //No olviden que Figura pueder apuntado a cualquier objeto compatible
            Figura f1 = c1;
            Console.WriteLine("----------------------");
            Console.WriteLine($"Area de f1: {f1.CalcularArea()}");
            Console.WriteLine($"Perimetro de f1: {f1.CalcularPerimetro()}");

            //se puede optimizar el codigo que ya hicimos de la siguiente manera:
            Figura[] arreglo = { r1, c1, t1, f1 };
            foreach(Figura item in arreglo)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine($"Area de {item.Nombre}: {item.CalcularArea()}");
                Console.WriteLine($"Perimetro de {item.Nombre}: {item.CalcularPerimetro()}");
            }

        }
    }
}
