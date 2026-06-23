namespace _11_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List: es una estructura de datos basada en la lista vinculada
             que permite crear una coleccion que puede cambiar de tamaño
            dinamicamente por lo tanto sus elementos se posicionan de forma
            aleatoria en la memoria principal.
            -> List permite almacenar elementos ya sea de forma homogenea como heterogenea.
            -> en C# la clase List viene incluida en el lenguaje de forma nativa.*/

            //Coleccion Heterogenea: cada item puede ser de tipo de dato distinto.
            List<object> lista1 = new List<object>();
            /*Observe el termino <object> que se encierra en <>
             cuando se utiliza este tipo de termino se le conoce como Generic
            o Generico y su funcion es determinar el tipo de dato
            soportado por una coleccion.
            en C# la clase object es compatible con todos los demas tipos de datos
            y clases de C# ya que es el ancestro comun de todos ellos.*/

            //Agregar items a la lista heterogenea:
            lista1.Add("Ingenieria");
            lista1.Add(200);
            lista1.Add(3.1416f);
            lista1.Add('Z');
            lista1.Add(3.12345);
            lista1.Add(DateTime.Now);
            lista1.Add("Gerardo");
            //Observe que lista1 esta almacenando diferentes
            //objetos de diferentes tipos de dato.

            //Imprimir el contenido de un List
            //usando un recorrido tradicional
            for(int i = 0; i < lista1.Count(); i++)
            {
                Console.WriteLine(lista1[i]);
            }
            //como en los arreglos en List se usa corchete/brackets para
            //acceder a cada uno de sus elementos.

            //usando foreach
            Console.WriteLine("**************************");
            foreach(object item in lista1)
            {
                Console.WriteLine(item);
            }
            //object es el tipo de dato usado para la coleccion lista1

            //usando el metodo Join de la clase String
            Console.WriteLine("**************************");
            Console.WriteLine(string.Join("\n",lista1));
            /*String.Join devuelve un String con todos los elementos
             de una coleccion unidos; pero le coloca un separados entre cada
            uno de ellos, en este caso el separador que utilice es \n o sea
            un nuevo renglon entre cada item; pero Usted puede usar cualquier
            separador que quiera.*/
            Console.WriteLine("**************************");
            Console.WriteLine(string.Join(", ", lista1));

            //obtener el tamaño de un List
            //se hace por medio del metodo Count el cual devuelve un entero:
            Console.WriteLine($"El tamaño de lista1 es {lista1.Count()}");
            
            int longitud = lista1.Count();
            Console.WriteLine($"El tamaño de lista1 es {longitud}");

            //Coleccion homogenea: solo admite un tipo de dato
            //ejemplo: lista de numeros enteros
            List<int> lista2 = new List<int>();
            lista2.Add(3);
            lista2.Add(-8);
            lista2.Add(5);
            lista2.Add(140);
            lista2.Add(100000);
            lista2.Add(0);

            Console.WriteLine("**************************");
            Console.WriteLine(string.Join("\n", lista2));

            //lista de elementos string
            List<string> lista3 = new List<string>();
            lista3.Add("Rojo");
            lista3.Add("Amarillo");
            lista3.Add("Azul");
            lista3.Add("Verde");

            Console.WriteLine("**************************");
            Console.WriteLine(string.Join("\n", lista3));

            //leer un elemento de una List en C# se hace como en los arreglos
            //mediante el uso de brackets o corchetes []
            Console.WriteLine($"item 0 en lista3: {lista3[0]}");
            Console.WriteLine($"item 3 en lista2: {lista2[3]}");
            Console.WriteLine($"item 1 en lista1: {lista1[1]}");

            //Eliminar un elemento dentro de un List en determinada posicion
            lista3.RemoveAt(1); //eso elimina Amarillo de lista3

            Console.WriteLine("**************************");
            Console.WriteLine(string.Join("\n", lista3));

            //Si Add se usa para agregar un nuevo item al final de la lista
            //existe el metodo Insert que permite agregar un nuevo item
            //en la posicion que desee en la lista
            lista3.Insert(2, "Gris"); //inserta  Gris en la posicion 2 de lista3

            Console.WriteLine("**************************");
            Console.WriteLine(string.Join("\n", lista3));

            //Si desea reemplazar (sobreescribir) un elemento existente
            //en una lista, hagalo igual que en los arreglos:
            lista3[1] = "Naranja";

            Console.WriteLine("**************************");
            Console.WriteLine(string.Join("\n", lista3));

            List<string> lista4 = new List<string>(["Honduras","Guatemala","El Salvador"]);
            Console.WriteLine("**************************");
            Console.WriteLine(string.Join("\n", lista4));

        }
    }
}
