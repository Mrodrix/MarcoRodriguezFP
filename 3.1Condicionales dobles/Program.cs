namespace _3._1Condicionales_dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona,
            si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona,
            indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”. 



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
                Console.WriteLine($"La persona {nombre}, no abona impuestos");*/

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18,
            se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario,
            mostrar el mensaje “No es apto para el contenido de este sitio web”.  */
                      
            int edad = 0;

            Console.WriteLine("Ingrese Su Edad");

            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {

                Console.WriteLine("Bienvenido a mi sitio web");

            }
            else
            {
                Console.WriteLine("No es apto para este sitio web");
            }

        }
    }
    
}
