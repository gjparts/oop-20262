namespace _07_Asociacion_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Barrio b1 = new Barrio("El Carmen", "Honduras", "SPS", "Cortés");

                Direccion d1 = new Direccion(b1, "Calle al centro de salud", "N/A", "1033");
                Direccion d2 = new Direccion(b1, "Carretera al Ocotillo", "N/A", "N/A");
                Direccion d3 = new Direccion(new Barrio("Benque", "HN", "SPS", "Cortes"), "7", "8", "N/A");

                Empresa e1 = new Empresa("Taller Bueso", "Mecanica", d1, "12341234");
                Empresa e2 = new Empresa(
                    "ALUTECH",
                    "Construccion",
                    new Direccion(
                        new Barrio(
                            "Guamilito",
                            "HN",
                            "SPS",
                            "Cortes"
                            ),
                        "10",
                        "11 y 12",
                        "777"
                        ),
                    "9999-7878"
                    );
                //lo anterior crea una empresa y su Direccion y Barrio son objetos de un solo uso
                //observe que para mayor legibilidad del codigo se opto por organizarlo de
                //forma vertial para facilitar su lectura.

                Cargo c1 = new Cargo("Electricista", Enum.JornadaLaboral.Matutina, e1, 15000);
                Cargo c2 = new Cargo("Gerente",Enum.JornadaLaboral.Mixta,e2,40000);

                Estudiante es1 = new Estudiante("20012002049", "Gerardo", "Sistemas", 43, d1, c1);
                es1.Imprimir();

                Estudiante es2 = new Estudiante("1234", "Filomeno", "Derecho", 23, d2, null);
                es2.Imprimir();

                Estudiante es3 = new Estudiante("5678", "Kurko Bain", "Psicologia", 30, d3, c2);
                es3.Imprimir();

                //a es3 le subieron el salario, le dieron 10 mil mas de lo que ganaba
                es3.Trabajo.Salario += 10000;
                //se sobreescribio la propiedad Salario del Trabajo de es3

                //es3 se cambio de domicilio:
                Direccion d4 = new Direccion(b1, "Principal", "Principal", "1234");
                es3.Direccion = d4;
                //observe que sobre-escribimos la propiedad Direccion para es3 porque el
                //set de esa propiedad lo permite
                Console.WriteLine("------------------- CAMBIO DE DOMICILIO DE es3 -------------------");
                es3.Imprimir();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
