using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;

namespace Taller_Programación_modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  1. Desarrolla un programa que permita:
               Ingresar una palabra
               LLevar la palabra ingresada a un vector de caracteres
               Contar la cantidad de vocales y consonantes en la palabra proporcionada por el
              usuario.*/

            /* string palabra = IngresarPalabra();
             char[] vector = ConvertirAVector(palabra);
             int vocales = ContarVocales(vector);
             int consonantes = ContarConsonantes(vector);

             Console.WriteLine("\nLa palabra ingresada es: " + palabra);
             Console.WriteLine("Cantidad de vocales: " + vocales);
             Console.WriteLine("Cantidad de consonantes: " + consonantes);
         }

         static string IngresarPalabra()
         {
             Console.Write("Ingrese una palabra: ");
             return Console.ReadLine();
         }

         static char[] ConvertirAVector(string palabra)
         {
             return palabra.ToCharArray();
         }

         static int ContarVocales(char[] vector)
         {
             int contador = 0;
             foreach (char c in vector)
             {
                 char letra = Char.ToLower(c);
                 if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                 {
                     contador++;
                 }
             }
             return contador;
         }

         static int ContarConsonantes(char[] vector)
         {
             int contador = 0;
             foreach (char c in vector)
             {
                 char letra = Char.ToLower(c);
                 if (Char.IsLetter(letra) && !(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'))
                 {
                     contador++;
                 }
             }
             return contador;
         }*/

            /*2.Crear un programa que permita gestionar una lista de tareas:
              Agregar tareas.
              Eliminar tareas
              Mostrar la lista de tareas*/
            /* List<string> tareas = new List<string>();
             int opcion;

             do
             {
                 opcion = MostrarMenu();
                 Console.WriteLine();

                 switch (opcion)
                 {
                     case 1:
                         AgregarTarea(tareas);
                         break;
                     case 2:
                         EliminarTarea(tareas);
                         break;
                     case 3:
                         MostrarTareas(tareas);
                         break;
                     case 4:
                         Console.WriteLine("Saliendo del programa...");
                         break;
                     default:
                         Console.WriteLine("Opción no válida, intente nuevamente.");
                         break;
                 }

                 Console.WriteLine();
             } while (opcion != 4);
         }

         static int MostrarMenu()
         {
             Console.WriteLine("=== GESTIÓN DE TAREAS ===");
             Console.WriteLine("1. Agregar tarea");
             Console.WriteLine("2. Eliminar tarea");
             Console.WriteLine("3. Mostrar tareas");
             Console.WriteLine("4. Salir");
             Console.Write("Seleccione una opción: ");

             int opcion;
             int.TryParse(Console.ReadLine(), out opcion);
             return opcion;
         }

         static void AgregarTarea(List<string> tareas)
         {
             Console.Write("Ingrese la descripción de la tarea: ");
             string tarea = Console.ReadLine();
             tareas.Add(tarea);
             Console.WriteLine("Tarea agregada con éxito.");
         }

         static void EliminarTarea(List<string> tareas)
         {
             if (tareas.Count == 0)
             {
                 Console.WriteLine("No hay tareas para eliminar.");
                 return;
             }

             MostrarTareas(tareas);
             Console.Write("Ingrese el número de la tarea que desea eliminar: ");
             int indice;
             if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= tareas.Count)
             {
                 tareas.RemoveAt(indice - 1);
                 Console.WriteLine("Tarea eliminada correctamente.");
             }
             else
             {
                 Console.WriteLine("Número inválido.");
             }
         }

         static void MostrarTareas(List<string> tareas)
         {
             if (tareas.Count == 0)
             {
                 Console.WriteLine("No hay tareas en la lista.");
             }
             else
             {
                 Console.WriteLine("=== LISTA DE TAREAS ===");
                 for (int i = 0; i < tareas.Count; i++)
                 {
                     Console.WriteLine((i + 1) + ". " + tareas[i]);
                 }
             }
         }*/

            /*Desarrolla un programa que permita:
             Elegir un tipo de unidad de medida
            o Masa
            o Capacidad
            o Longitud
            o Tiempo
             Elegir una unidad de medida para convertir.
            o Masa
             De kilogramos a gramos
             De gramos a Kilogramos
            o Capacidad
             De litro a mililitro
             De mililitro a litro
            o Longitud
             De kilometro a metro
             De metro a kilometro
            o Tiempo
             De hora a segundos
             De segundos a hora
             Ingresar un valor para convertir.
             Al final mostrar el valor y la unidad a convertir, y el valor y la unidad a la que se
            convirtió. Ej: “1 kilometro son 1000 metros”*/

            /*int tipo = ElegirTipoUnidad();
            double valor, resultado = 0;
            string unidadOrigen = "", unidadDestino = "";

            switch (tipo)
            {
                case 1:
                    ConvertirMasa(ref valor, ref resultado, ref unidadOrigen, ref unidadDestino);
                    break;
                case 2:
                    ConvertirCapacidad(ref valor, ref resultado, ref unidadOrigen, ref unidadDestino);
                    break;
                case 3:
                    ConvertirLongitud(ref valor, ref resultado, ref unidadOrigen, ref unidadDestino);
                    break;
                case 4:
                    ConvertirTiempo(ref valor, ref resultado, ref unidadOrigen, ref unidadDestino);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine($"\n{valor} {unidadOrigen} son {resultado} {unidadDestino}");
        }

        static int ElegirTipoUnidad()
        {
            Console.WriteLine("=== CONVERSOR DE UNIDADES ===");
            Console.WriteLine("1. Masa");
            Console.WriteLine("2. Capacidad");
            Console.WriteLine("3. Longitud");
            Console.WriteLine("4. Tiempo");
            Console.Write("Seleccione el tipo de unidad: ");

            int tipo;
            int.TryParse(Console.ReadLine(), out tipo);
            return tipo;
        }

        static void ConvertirMasa(ref double valor, ref double resultado, ref string unidadOrigen, ref string unidadDestino)
        {
            Console.WriteLine("\n--- CONVERSIÓN DE MASA ---");
            Console.WriteLine("1. Kilogramos a Gramos");
            Console.WriteLine("2. Gramos a Kilogramos");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            valor = double.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                resultado = valor * 1000;
                unidadOrigen = "kilogramos";
                unidadDestino = "gramos";
            }
            else if (opcion == 2)
            {
                resultado = valor / 1000;
                unidadOrigen = "gramos";
                unidadDestino = "kilogramos";
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }

        static void ConvertirCapacidad(ref double valor, ref double resultado, ref string unidadOrigen, ref string unidadDestino)
        {
            Console.WriteLine("\n--- CONVERSIÓN DE CAPACIDAD ---");
            Console.WriteLine("1. Litros a Mililitros");
            Console.WriteLine("2. Mililitros a Litros");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            valor = double.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                resultado = valor * 1000;
                unidadOrigen = "litros";
                unidadDestino = "mililitros";
            }
            else if (opcion == 2)
            {
                resultado = valor / 1000;
                unidadOrigen = "mililitros";
                unidadDestino = "litros";
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }

        static void ConvertirLongitud(ref double valor, ref double resultado, ref string unidadOrigen, ref string unidadDestino)
        {
            Console.WriteLine("\n--- CONVERSIÓN DE LONGITUD ---");
            Console.WriteLine("1. Kilómetros a Metros");
            Console.WriteLine("2. Metros a Kilómetros");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            valor = double.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                resultado = valor * 1000;
                unidadOrigen = "kilómetros";
                unidadDestino = "metros";
            }
            else if (opcion == 2)
            {
                resultado = valor / 1000;
                unidadOrigen = "metros";
                unidadDestino = "kilómetros";
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }

        static void ConvertirTiempo(ref double valor, ref double resultado, ref string unidadOrigen, ref string unidadDestino)
        {
            Console.WriteLine("\n--- CONVERSIÓN DE TIEMPO ---");
            Console.WriteLine("1. Horas a Segundos");
            Console.WriteLine("2. Segundos a Horas");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            valor = double.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                resultado = valor * 3600;
                unidadOrigen = "horas";
                unidadDestino = "segundos";
            }
            else if (opcion == 2)
            {
                resultado = valor / 3600;
                unidadOrigen = "segundos";
                unidadDestino = "horas";
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }*/

            /* Utiliza programación modular para crear un programa que permita:
              Recorrer una matriz y llenarla con nombres de contactos.
              Ingresar un nombre y buscarlo en la matriz
              Si se encuentra el nombre, cambiarlo en la matriz por un nuevo nombre que ingresa
             el usuario
              Mostrar por pantalla el nombre encontrado, su posición en la matriz(f, c), y el nuevo
             nombre ingresado*/

            /* string[,] contactos = LlenarMatriz();
             BuscarYCambiar(contactos);
             MostrarMatriz(contactos);


             static string[,] LlenarMatriz()
             {
                 Console.Write("Ingrese la cantidad de filas: ");
                 int filas = int.Parse(Console.ReadLine());

                 Console.Write("Ingrese la cantidad de columnas: ");
                 int columnas = int.Parse(Console.ReadLine());

                 string[,] matriz = new string[filas, columnas];

                 Console.WriteLine("\n--- Ingreso de contactos ---");
                 for (int i = 0; i < filas; i++)
                 {
                     for (int j = 0; j < columnas; j++)
                     {
                         Console.Write($"Ingrese el nombre para la posición ({i},{j}): ");
                         matriz[i, j] = Console.ReadLine();
                     }
                 }

                 return matriz;
             }

             static void BuscarYCambiar(string[,] matriz)
             {
                 Console.Write("\nIngrese el nombre que desea buscar: ");
                 string nombreBuscado = Console.ReadLine();
                 bool encontrado = false;

                 for (int i = 0; i < matriz.GetLength(0); i++)
                 {
                     for (int j = 0; j < matriz.GetLength(1); j++)
                     {
                         if (matriz[i, j].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                         {
                             encontrado = true;
                             Console.Write($"Nombre encontrado en posición ({i},{j}). Ingrese el nuevo nombre: ");
                             string nuevoNombre = Console.ReadLine();
                             Console.WriteLine($"\n{nombreBuscado} en ({i},{j}) fue cambiado por {nuevoNombre}.");
                             matriz[i, j] = nuevoNombre;
                         }
                     }
                 }

                 if (!encontrado)
                 {
                     Console.WriteLine("\nEl nombre no fue encontrado en la matriz.");
                 }
             }

             static void MostrarMatriz(string[,] matriz)
             {
                 Console.WriteLine("\n--- MATRIZ DE CONTACTOS ACTUALIZADA ---");
                 for (int i = 0; i < matriz.GetLength(0); i++)
                 {
                     for (int j = 0; j < matriz.GetLength(1); j++)
                     {
                         Console.Write(matriz[i, j] + "\t");
                     }
                     Console.WriteLine();
                 }
             }*/

            /* Crear un programa que implemente el juego de tres en raya(triqui o gato), para dos
             jugadores.El programa debe:
              Dibujar el tablero
              Permitir realizar movimientos.
              Verificar ganadores*/

            char[,] tablero = InicializarTablero();
            char jugadorActual = 'X';
            bool juegoTerminado = false;

            while (!juegoTerminado)
            {
                Console.Clear();
                DibujarTablero(tablero);
                RealizarMovimiento(tablero, jugadorActual);

                if (HayGanador(tablero, jugadorActual))
                {
                    Console.Clear();
                    DibujarTablero(tablero);
                    Console.WriteLine($"\n¡Jugador {jugadorActual} ha ganado!");
                    juegoTerminado = true;
                }
                else if (TableroLleno(tablero))
                {
                    Console.Clear();
                    DibujarTablero(tablero);
                    Console.WriteLine("\n¡Empate!");
                    juegoTerminado = true;
                }
                else
                {
                    jugadorActual = CambiarJugador(jugadorActual);
                }
            }

            Console.WriteLine("\nFin del juego.");
        }

        static char[,] InicializarTablero()
        {
            char[,] tablero = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = ' ';
                }
            }
            return tablero;
        }

        static void DibujarTablero(char[,] tablero)
        {
            Console.WriteLine("=== TRES EN RAYA ===");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("---+---+---");
            }
        }

        static void RealizarMovimiento(char[,] tablero, char jugador)
        {
            int fila, columna;
            bool movimientoValido = false;

            do
            {
                Console.WriteLine($"\nTurno del jugador {jugador}:");
                Console.Write("Ingrese la fila (0-2): ");
                fila = LeerEntero();

                Console.Write("Ingrese la columna (0-2): ");
                columna = LeerEntero();

                if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3 && tablero[fila, columna] == ' ')
                {
                    tablero[fila, columna] = jugador;
                    movimientoValido = true;
                }
                else
                {
                    Console.WriteLine("Movimiento inválido. Intente nuevamente.");
                }
            } while (!movimientoValido);
        }

        static int LeerEntero()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Ingrese un número: ");
            }
            return numero;
        }

        static bool HayGanador(char[,] t, char j)
        {
            
            for (int i = 0; i < 3; i++)
                if (t[i, 0] == j && t[i, 1] == j && t[i, 2] == j)
                    return true;

            
            for (int j2 = 0; j2 < 3; j2++)
                if (t[0, j2] == j && t[1, j2] == j && t[2, j2] == j)
                    return true;

            
            if (t[0, 0] == j && t[1, 1] == j && t[2, 2] == j) return true;
            if (t[0, 2] == j && t[1, 1] == j && t[2, 0] == j) return true;

            return false;
        }

        static bool TableroLleno(char[,] tablero)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tablero[i, j] == ' ')
                        return false;
            return true;
        }

        static char CambiarJugador(char jugador)
        {
            return (jugador == 'X') ? 'O' : 'X';
        }
    }
}    