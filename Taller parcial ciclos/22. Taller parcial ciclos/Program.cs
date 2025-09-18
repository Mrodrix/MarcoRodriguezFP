using System.Diagnostics.Contracts;

namespace _22._Taller_parcial_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            le permitirá al usuario, introducir tantas calificaciones como así desee,
            en el momento en que seleccione que no desea continuar capturando
            calificaciones, el algoritmo debe presentar el promedio de las
            calificaciones capturadas previamente.

            int contador = 0;
            double acumulador = 0;
            double nota = 0;
            double promedio = 0;
            char statusNota = ' ';

            do
            {
                Console.WriteLine("Ingrese una nota");
                nota = double.Parse(Console.ReadLine());
                acumulador = acumulador + nota;
                Console.WriteLine("¿Quiere ingresar otra nota? s:si  n:no");
                statusNota = char.Parse(Console.ReadLine());
                contador++;

            } while (statusNota == 's');

            promedio = acumulador / contador;
            Console.WriteLine($"El promedio de las notas es {promedio}");*/


            /*Se requiere un algoritmo para mostrar por pantalla los divisores de un
            número ingresado por teclado.
            Tener en cuenta que dados dos números enteros a y b, se dice que b es
            divisor de a si se cumple que al efectuar una división entera a/b el
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de
            una división de dos números.
            Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3,
            2, 1 que son los divisores del número 6. 

            int numero;
            int i;

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            i = numero;
            do
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
                i--;

            } while (i >= 1);*/

            /* Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.
            Ejemplo: b=2, e=5  25=2*2*2*2*2= 32
            Mostrar por pantalla el resultado de la potenciación.
            Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’ 

            int NBase = 0;
            int NExponente = 0;
            int i = 0;
            int resultado = 1;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un número como base");
                NBase = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un número como exponente");
                NExponente = int.Parse(Console.ReadLine());

                resultado = 1;
                i = 1;

                while (i<= NExponente)
                {
                    resultado = resultado * NBase;
                    i++;
                }
                Console.WriteLine($"El resultado de la potenciación es {resultado}");

                Console.WriteLine("Desea continuar? s:si  n:no");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta != 'n');*/

            /*Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
            kilómetros durante 10 días, para determinar si es apto para la prueba de
            5 kilómetros. Para considerarlo apto debe cumplir las siguientes
            condiciones:
             Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
             Que al menos en una de las pruebas realice un tiempo menor de 15
            minutos.
             Que su promedio sea menor o igual a 18 minutos.
            Diseñar un algoritmo para registrar los datos y decidir si es apto para la
            competencia.

            int dias = 10;
            double tiempo = 0;
            double sumaTiempos = 0;
            bool algunMenor15 = false;
            bool algunMayor20 = false;

            for (int i = 1; i <= dias; i++)
            {
                Console.WriteLine($"Escriba el tiempo del día {i} (minutos):");
                tiempo = double.Parse(Console.ReadLine());

                sumaTiempos += tiempo;

                if (tiempo < 15)
                {
                    algunMenor15 = true;
                }

                if (tiempo > 20)
                {
                    algunMayor20 = true;
                }
            }

            double promedio = sumaTiempos / dias;

            if (!algunMayor20 && algunMenor15 && promedio <= 18)
            {
                Console.WriteLine($"El atleta es apto para la competencia y su promedio es {promedio}");
            }
            else
            {
                Console.WriteLine($"El atleta NO es apto para la competencia y su promedio es {promedio}");
            }
            */


            /* Se aplicó una encuesta a n personas solicitando su opinión sobre el
             tema del servicio militar obligatorio para las mujeres. Las opciones de
             respuesta fueron: a favor, en contra y no responde. Se solicita un
             algoritmo que calcule qué porcentaje de los encuestados marcó cada
             una de las respuestas. 

            char respuesta = ' ';
            int Favor = 0;
            int Contra = 0;
            int NoResponde = 0;
            char status = ' ';
            int CantidadPersonas = 0;

            do
            {
                Console.WriteLine("Cual es su posicion con respecto al servicio militar obligatorio para las mujeres? " +
                "  f: a favor" +
                "  c: en contra" +
                "  barra espaciadora para no responder");
                respuesta = char.Parse(Console.ReadLine());

                if(respuesta == 'f')
                {
                    Favor++;
                }
                else if (respuesta == 'c')
                {
                    Contra++;
                }
                else if(respuesta== ' ')
                {
                    NoResponde++;
                }
                Console.WriteLine("Desea añadir más respuestas? s:si  n:no");
                status = char.Parse(Console.ReadLine());

                CantidadPersonas++;

            } while (status == 's');

            Console.WriteLine($"Porcentaje a favor {(Favor * 100) / CantidadPersonas}, porcentaje en contra {(Contra * 100) / CantidadPersonas}, no responde {(NoResponde * 100) / CantidadPersonas}");
            */

            /*Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos
            de esos números son positivos, cuántos negativos, cuántos son neutros
            (0); además que imprima por pantalla la sumatoria de los números
            positivos y la de los negativos. */

            int numero = 0;
            int contadorPositivo = 0;
            int contadorNegativo = 0;
            int neutro = 0;
            int sumapositivos = 0;
            int sumanegativos = 0;
            
            
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    contadorNegativo++;
                    sumanegativos += numero;
                }
                else if (numero > 0)
                {
                    contadorPositivo++;
                    sumapositivos += numero;
                }
                else if (numero == 0)
                {
                    neutro++;
                }
            }
            Console.WriteLine($"{contadorNegativo} numeros negativos, su suma es {sumanegativos}, {contadorPositivo} numeros positivos, su suma es {sumapositivos}, {neutro} veces fue el numero 0");

        }
    }
}
