namespace _04_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*en C# las convenciones o notaciones para nombrar clases y objetos
             son:
            - utilice Pascal Case para nombrar clases,
              La primer letra de cada palabra va en mayusculas,ejm:
              Mascota
              Persona
              CuentaBancaria
              UbicacionDeOrigen

            - utilice camel Case para nombrar objetos y variables:
              La primer letra va en minusculas y luego cada palabra
              inicia en mayusculas, ejm:
              m1
              mascota1
              cuentaBancaria42
              docenteAsignadoCarrera
            
            - para nombrar objetos y variables tambien puede usar
              la notacion snake case, consiste en escribir todo
              en minusculas y separar cada palabra con guion bajo,
              esta notacion se usa mas en python, ejm:
              m1
              mascota1
              cuenta_bancaria_42
              docente_asignado_carrera
             */

            //Instanciar un nuevo objeto de clase Mascota
            Mascota m1 = new Mascota();
            //m1 es el objeto
            //Mascota es la clase

            //asignar valores a las propiedades de m1 (set):
            m1.Nombre = "Firulais";
            m1.Especie = "Perro";
            m1.Edad = 2;
            m1.Genero = 'M';

            //leer los valores de las propiedades de m1 (get):
            Console.WriteLine("Propiedades de m1:");
            Console.WriteLine($"Nombre: {m1.Nombre}");
            Console.WriteLine($"Especie: {m1.Especie}");
            Console.WriteLine($"Edad: {m1.Edad}");
            Console.WriteLine($"Genero: {m1.Genero}");
            Console.WriteLine($"Hash de memoria: {m1.GetHashCode()}");

            Persona per1 = new Persona();
            Console.WriteLine("******************");
            //escritura (set)
            per1.Nombre = "Gerardo Portillo";
            per1.Edad = 43;
            per1.Genero = 'M';
            per1.DNI = "1401198201055";
            //lectura (get)
            per1.Imprimir();

            Persona per2 = new Persona();
            //lectura (get)
            per2.Imprimir();

            //cambiar el valor de una propiedad ya definida:
            per2.Nombre = "Filomeno Colinas";
            Console.WriteLine($"Nombre: {per2.Nombre}");

            Persona per3 = new Persona("Estebancito Maravilla", 80, 'M', "1234");
            per3.Imprimir();

            Persona per4 = new Persona("Pedro Picapiedra", 35);
            per4.Imprimir();

            Console.WriteLine($"per1 es mayor de edad? {per1.EsMayorDeEdad()}");
            Console.WriteLine($"per2 es mayor de edad? {per2.EsMayorDeEdad()}");
            Console.WriteLine($"per3 es mayor de edad? {per3.EsMayorDeEdad()}");
            Console.WriteLine($"per4 es mayor de edad? {per4.EsMayorDeEdad()}");
            if( per1.EsMayorDeEdad() == true )
                Console.WriteLine("per1 es mayor de edad");
            else
                Console.WriteLine("per1 no es mayor de edad");

            Carro c1 = new Carro();
            c1.Imprimir();

            Carro c2 = new Carro("Toyota", "Rav4", "Blanco", 2018);
            c2.Imprimir();


            try
            {
                //codigo propenso a fallar
                Empleado em2 = new Empleado("Paul Allen", 70, 'M', 100000, 'P');
                em2.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
