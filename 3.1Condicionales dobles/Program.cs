namespace _3._1Condicionales_dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona,
            si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona,
            indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”. */



            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona {nombre}, no abona impuestos");
            }
        }
    }
}
