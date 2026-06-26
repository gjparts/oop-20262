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

            Empleado em1 = new Empleado();
            Console.WriteLine("Datos de em1 *************************");
            Console.WriteLine($"Nombre: {em1.Nombre}");
            Console.WriteLine($"Edad: {em1.Edad}");
            Console.WriteLine($"Genero: {em1.Genero}");
            Console.WriteLine($"Cargo: {em1.Cargo}");
            Console.WriteLine($"Carrera: {em1.Salario}");
            em1.Saludar();
            em1.Trabajar();

            Empleado em2 = new Empleado("Homero J, Simpson", 45, Enum.Genero.Masculino, 20000, "Supervisor");
            Console.WriteLine("Datos de em2 *************************");
            Console.WriteLine($"Nombre: {em2.Nombre}");
            Console.WriteLine($"Edad: {em2.Edad}");
            Console.WriteLine($"Genero: {em2.Genero}");
            Console.WriteLine($"Cargo: {em2.Cargo}");
            Console.WriteLine($"Carrera: {em2.Salario}");
            em2.Saludar();
            em2.Trabajar();

            Practicante pr1 = new Practicante(2);
            Console.WriteLine("Datos de pr1 *************************");
            Console.WriteLine($"Nombre: {pr1.Nombre}");
            Console.WriteLine($"Edad: {pr1.Edad}");
            Console.WriteLine($"Genero: {pr1.Genero}");
            Console.WriteLine($"Cargo: {pr1.Cargo}");
            Console.WriteLine($"Carrera: {pr1.Salario}");
            Console.WriteLine($"Meses: {pr1.Meses}");
            pr1.Saludar();
            pr1.Trabajar();

            Catedratico cat1 = new Catedratico("Gerardo", 43, Enum.Genero.Masculino, 15000, "Ing. Sistemas");
            Console.WriteLine("Datos de cat1 *************************");
            Console.WriteLine($"Nombre: {cat1.Nombre}");
            Console.WriteLine($"Edad: {cat1.Edad}");
            Console.WriteLine($"Genero: {cat1.Genero}");
            Console.WriteLine($"Cargo: {cat1.Cargo}");
            Console.WriteLine($"Carrera: {cat1.Salario}");
            Console.WriteLine($"Profesion: {cat1.Profesion}");
            cat1.Saludar();
            cat1.Trabajar();
            cat1.Educar();
        }
    }
}
