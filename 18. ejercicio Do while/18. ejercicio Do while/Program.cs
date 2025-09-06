namespace _18._ejercicio_Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; 
             para cada usuario se debe hacer lo siguiente: 
             - Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario,
             el número de cuenta, el saldo y “Es apto para el crédito” 
             - Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, 
            el número de cuenta, el saldo y “No es apto para el crédito” 
            El algoritmo debe permitir preguntar la información de usuarios, hasta que se le
            indique que ya no se desea preguntar más. 
            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le 
            pregunto por la información, y debe mostrar el promedio de los saldos.*/

            string nombre;
            string numeroCuenta;
            double saldo;
            double sumaSaldos = 0;
            int contadorUsuarios = 0;
            string respuesta;

            do
            {
                Console.Write("Ingrese el nombre del usuario: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese el número de cuenta: ");
                numeroCuenta = Console.ReadLine();

                Console.Write("Ingrese el saldo: ");
                saldo = Convert.ToDouble(Console.ReadLine());

                
                contadorUsuarios++;
                sumaSaldos += saldo;

                
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}, Cuenta: {numeroCuenta}, Saldo: {saldo}, Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"Nombre: {nombre}, Cuenta: {numeroCuenta}, Saldo: {saldo}, No es apto para el crédito");
                }

                Console.Write("¿Desea ingresar otro usuario? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            
            double promedio = (contadorUsuarios > 0) ? sumaSaldos / contadorUsuarios : 0;

            Console.WriteLine($"\nTotal de usuarios: {contadorUsuarios}");
            Console.WriteLine($"Promedio de saldos: {promedio}");
        }
    }
}
