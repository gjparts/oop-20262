using System.Threading.Channels;

namespace _02_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sumar(2, 3));
            Console.WriteLine(Sumar(2.5, 4.5));
            Console.WriteLine(Sumar(3.3, 4, 8.9));
            Saludar();
            //los metodos void no se imprimen porque no retornan valor:
            //Console.WriteLine(Saludar());

            Console.WriteLine(Adicionar(9, 5));
            Console.WriteLine(Adicionar(5.6, 4.5, 1.2));
            Console.WriteLine(Adicionar(2.2, 3.3));
            Despedida();

            double[] arreglo1 = {4.5,8,90.5,10,-8,3.1416};
            ImprimirArreglo(arreglo1);
            int[] arreglo2 = { 1,8,10,95 };
            ImprimirArreglo(arreglo2);
            float[] arreglo3 = { 2.5f, 6.7f, 9.3f, 1 };
            ImprimirArreglo(arreglo3);
        }

        //Metodos o funciones
        static double Sumar(double a, double b)
        {
            return a + b;
        }
        static double Sumar(double a, double b, double c)
        {
            return a + b + c;
        }
        static int Sumar(int a, int b)
        {
            return a + b;
        }
        //Pueden haber varios metodos con el mismo nombre siempre y cuando
        //sus firmas (signature) sean distintas a esto se le conoce como
        //sobrecarga de metodos/funciones (method overload)
        //la firma de un metodo esta conformada por su tipo, nombre y tipos de datos
        //de sus parametros:
        //double Sumar(double,double);
        //double Sumar(double,double,double);
        //int Sumar(int,int);
        //los nombres de los parametros no forman parte de la firma.
        //en C++ a la firma de funcion se le conoce como prototipo de funcion.

        static void Saludar()
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Como estan?");
            Console.WriteLine("Un gusto");
        }

        //Metodos/funciones de flecha: se utilizan mayormente
        //cuando el cuerpo del metodo/funcion tiene unicamente
        //una instruccion.
        static double Adicionar(double a, double b) => a + b;
        static double Adicionar(double a, double b, double c) => a + b + c;
        static int Adicionar(int a, int b) => a + b;
        static void Despedida() => Console.WriteLine("Adios.");

        //los Metodos tambien pueden recibir como parametros a Objetos
        static void ImprimirArreglo(double[] arreglo)
        {
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"posicion: {i}, valor: {arreglo[i]}");
            }
        }
        static void ImprimirArreglo(int[] arreglo)
        {
            //para no volver a escribir la logica de ImprimirArreglo para double[]
            //voy a sacar una copia del arreglo int[] y la voy a copiar
            //a un arreglo double[], luego mando a llamar ImprimirArreglo para
            //double[] y asi no tengo que preocuparme por duplicar codigo.
            double[] copia = new double[arreglo.Length];
            Array.Copy(arreglo,copia,arreglo.Length);
            ImprimirArreglo(copia);
        }
        static void ImprimirArreglo(float[] arreglo)
        {
            double[] copia = new double[arreglo.Length];
            Array.Copy(arreglo, copia, arreglo.Length);
            ImprimirArreglo(copia);
        }
    }
}
