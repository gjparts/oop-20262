namespace _15_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato("Misifus", 4, true, "Gato negro", true);
            g1.Imprimir();
            g1.Hablar();
            g1.Ronronear();
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1);
            //solo imprimir un objeto es como mandar a llamar a ToString()

            Perro p1 = new Perro("Rambo", 4, false, "Perro Bravo", "Doberman");
            p1.Imprimir();
            p1.Hablar();
            p1.Jugar();
            Console.WriteLine(p1.ToString());

            
        }
    }
}
