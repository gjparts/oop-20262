namespace _17_Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*en C# y en JAVA una clase abstracta no puede ser instanciada
             por medios tradicionales o sea no puede crear un nuevo objeto
            a partir de una clase abstracta.*/
            //SerVivo s1 = new SerVivo("Marsupial");

            Gato g1 = new Gato("Naranjoso");
            g1.Vivir();
            //tambien puede usar los metodos por separado
            g1.Hablar();
            g1.Alimentarse();
        }
    }
}
