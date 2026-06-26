namespace _13_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Gerardo", 43, Enum.Genero.Masculino, "20012002049", "Ing. Industrial");
            Console.WriteLine("Datos de e1 *************************");
            Console.WriteLine($"Nombre: {e1.Nombre}");
            Console.WriteLine($"Edad: {e1.Edad}");
            Console.WriteLine($"Genero: {e1.Genero}");
            Console.WriteLine($"Cuenta: {e1.Cuenta}");
            Console.WriteLine($"Carrera: {e1.Carrera}");
            e1.Saludar();
            e1.Estudiar();
            /*Observe que Estudiante como hereda de la clase Persona tiene
             las propiedades Nombre, Edad, Genero asi como las propiedades
            Cuenta y Carrera. La clase Estudiante tambien tiene acceso a los
            metodos Saludar y Estudiar.*/

        }
    }
}
