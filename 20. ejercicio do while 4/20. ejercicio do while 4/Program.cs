namespace _20._ejercicio_do_while_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
            El número de partidos perdidos  
            El número de partidos empatados  
            El número de partidos ganados  
            El porcentaje de partidos perdidos  
            El porcentaje de partidos empatados  
            El porcentaje de partidos ganados */

            int contador = 1;
            int ganados = 0;
            int perdidos = 0;
            int empatados = 0;
            int opcion;

            do
            {
                Console.WriteLine("Partido #" + contador);
                Console.WriteLine("Ingrese el resultado del partido: 1. Ganado  2. Perdido  3. Empatado");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    ganados++;
                }
                else if (opcion == 2)
                {
                    perdidos++;
                }
                else if (opcion == 3)
                {
                    empatados++;
                }
                

                contador++;

            } while (contador <= 30);

            double porcentajeGanados = (ganados * 100.0) / 30;
            double porcentajePerdidos = (perdidos * 100.0) / 30;
            double porcentajeEmpatados = (empatados * 100.0) / 30;

            Console.WriteLine("\nResultados del equipo en 30 partidos:");
            Console.WriteLine("Partidos ganados: " + ganados);
            Console.WriteLine("Partidos perdidos: " + perdidos);
            Console.WriteLine("Partidos empatados: " + empatados);
            Console.WriteLine("Porcentaje de partidos ganados: " + porcentajeGanados + "%");
            Console.WriteLine("Porcentaje de partidos perdidos: " + porcentajePerdidos + "%");
            Console.WriteLine("Porcentaje de partidos empatados: " + porcentajeEmpatados + "%");
        }
    }
}
