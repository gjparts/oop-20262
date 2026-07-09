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

            Console.WriteLine("----------------");
            Humano h1 = new Humano("Godinez");
            h1.Vivir();

            //La ventaja de una clase abstracta es que permite estandarizar metodos

            /*Un clase abstracta puede ser instanciada a traves de un objeto
             que sea compatible para este caso cualquier objeto cuya clase sea heredada
            de la clase abstracta*/
            Console.WriteLine("--------------");
            SerVivo s1 = new Gato("Tinieblo");
            s1.Vivir();

            Console.WriteLine("--------------");
            SerVivo s2 = new Humano("Gerardo");
            s2.Vivir();
            //puede reescribir el objeto con otra clase compatible
            Console.WriteLine("--------------");
            s2 = new Gato("Gato vaca");
            s2.Vivir();

            /*un uso practico es usarlo para hacer colecciones de objetos compatibles*/
            Console.WriteLine("*****************");
            List<SerVivo> seres = new List<SerVivo>();
            seres.Add(g1);
            seres.Add(h1);
            seres.Add(s1);
            seres.Add(s2);
            seres.Add( new Humano("Kurko Bain") );

            foreach(SerVivo item in seres)
            {
                Console.WriteLine("+++++++++++++++++++++");
                item.Vivir();
            }

            /*Se acuerdan de la clase Math?*/
            double n = Math.Pow(5, 2);
            Console.WriteLine(n);
            /*El metodo Pow dentro de Math es un metodo estático.
             Los metodos estaticos estan siempre disponibles
            en la definicion de la clase no importa si esta ha sido
            instanciada en un objeto.
            Metodos como Sqrt, Abs, Round se pueden usar de forma estatica
            a esto se le conoce como Patrón Singleton (es un patron de diseño)*/

            //Como ejemplo, creamos en SerVivo algunos metodos estaticos
            //vamos a probarlos:
            SerVivo.Saludar();
            Console.WriteLine(SerVivo.FormulaCuadratica(1,4,1));
            //note que Saludar y FormulaCuadratica son metodos que pueden
            //utilizarse sin necesitad de instanciar un objeto

            //vamos a probar el metodo GetInstance de SerVivo
            //depende de la hora del dia el objeto creado sera Gato o sera Humano
            Console.WriteLine("------------------------------");
            SerVivo s6 = SerVivo.GetInstance();
            s6.Vivir();
        }
    }
}
