namespace _05_CuentaAhorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                CuentaAhorro a1 = new CuentaAhorro("Gerardo","12345");
                //prueba del metodo get:
                Console.WriteLine($"Saldo de a1: {a1.Saldo}");
                //prueba de los metodos set:
                //a1.Saldo = 1200;  //esto no se puede hacer desde afuera de la clase
                a1.Depositar(3000);
                Console.WriteLine($"Saldo de a1: {a1.Saldo}");
                a1.Depositar(500);
                Console.WriteLine($"Saldo de a1: {a1.Saldo}");
                //a1.Depositar(-800);
                a1.Retirar(1000);
                Console.WriteLine($"Saldo de a1: {a1.Saldo}");
                //a1.Retirar(-1000);
                a1.Retirar(2501);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
