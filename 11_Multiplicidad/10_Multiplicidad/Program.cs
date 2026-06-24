namespace _11_Multiplicidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Barrio b1 = new Barrio("El Centro", "Centro", "21105");
                Barrio b2 = new Barrio("Santa Marta", "Este", "21101");

                Direccion d1 = new Direccion(b1);
                d1.Calle = "7";
                d1.Avenida = "7 y 8";

                Empresa e1 = new Empresa("COFISA", d1, "12341234");

                Persona per1 = new Persona("1234", "Gerardo Portillo", "5555");
                per1.EmpresaLabora = e1;
                per1.Imprimir();

                Persona per2 = new Persona("1111", "Filomeno Colinas", "");
                per2.Imprimir();

                Persona per3 = new Persona("2222", "Miguelito Jackson", "1212");
                per3.Direccion = new Direccion(b2);
                //observe como llenamos los demas datos de la direccion
                //de per3 desde fuera del constructor a traves de su ruta:
                per3.Direccion.Calle = "Principal";
                per3.Direccion.Avenida = "6";
                per3.Direccion.Casa = "1033";

                Empresa e2 = new Empresa("Pollo Gol", new Direccion(new Barrio("Montefresco", "Este", "21101")), "3333");
                e2.Direccion.Calle = "20 calle";
                e2.Direccion.Avenida = "9 y 10";

                //asignar esta empresa a per3
                per3.EmpresaLabora = e2;

                //mascotas de per3
                Mascota m1 = new Mascota("Firualis", "Perro");
                Mascota m2 = new Mascota("Misifus", "Gato");
                Mascota m3 = new Mascota("Paquito", "Loro");
                Mascota[] arreglo1 = { m1, m2, null, m3 };
                per3.Mascotas = arreglo1;

                //diplomas de per3
                Diploma diploma1 = new Diploma("Washington Academy","Electronica Basica");
                List<Diploma> reconocimientos = new List<Diploma>();
                reconocimientos.Add( new Diploma("INFOP","Reparacion de motores diesel") );
                reconocimientos.Add(diploma1);
                per3.Diplomas = reconocimientos;

                //conyuge
                Persona per4 = new Persona("77777777", "Herminia Lopez", "111111111");
                per3.Conyuge = per4;

                //hijos
                Persona per5 = new Persona("000000","Estevancito Maravilla","");
                Persona per6 = new Persona("111111", "Filomeno Jr.", "");
                List<Persona> hijos123 = new List<Persona>();
                hijos123.Add(per5);
                hijos123.Add(per6);
                hijos123.Add(new Persona("222222","Jorgito Filomeno Segundo Jr.",""));
                per3.Hijos = hijos123;

                per3.Imprimir();

                //per3 y per4 tienen hijos en comun: (si gusta puede relacionarlos tambien)
                per4.Conyuge = per3;
                per4.Hijos = hijos123;
                per4.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
