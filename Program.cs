using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== Menú de ejercicios ===");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Ejercicio 1 - Promedio de 10 notas");
            Console.WriteLine("2. Ejercicio 2 - Contar mayores y menores de edad");
            Console.WriteLine("3. Ejercicio 3 - Nombre más largo y más corto");
            Console.WriteLine("4. Ejercicio 4 - Lista de supermercado interactiva");
            Console.WriteLine("5. Ejercicio 5 - Matriz 5x5 PIPIPIPI");
            Console.WriteLine("6. Ejercicio 6 - Temperaturas del mes");
            Console.WriteLine("7. Ejercicio 7 - Tablas de multiplicar del 1 al 9");
            Console.WriteLine("8. Ejercicio 8 - Buscaminas de Temu 10x10");
            Console.WriteLine("9. Ejercicio 9 - Sistema de calificaciones (diccionario)");
            Console.WriteLine("10. Ejercicio 10 - Simulador de fila de atención (cola del banco)");
            Console.WriteLine("11. Ejercicio 11 - Sistema de inventario (lista, diccionario, pila)");
            Console.Write("\nSeleccione un número de ejercicio: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente.\n");
                continue;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Saliendo...");
                    return;

                case 1:
                    Console.WriteLine("Ejercicio 1: Calcula y muestra el promedio de 10 notas.\n");
                    Ejercicio1.Run();
                    break;

                case 2:
                    Console.WriteLine("Ejercicio 2: Clasifica una lista de edades en mayores y menores de edad.\n");
                    Ejercicio2.Run();
                    break;

                case 3:
                    Console.WriteLine("Ejercicio 3: Encuentra el nombre más largo y el más corto de una lista.\n");
                    Ejercicio3.Run();
                    break;

                case 4:
                    Console.WriteLine("Ejercicio 4: Simula una lista de supermercado interactiva (comprados / no estaban en lista).\n");
                    Ejercicio4.Run();
                    break;

                case 5:
                    Console.WriteLine("Ejercicio 5: Genera una matriz 5x5 con 'P' e 'I' alternados.\n");
                    Ejercicio5.Run();
                    break;

                case 6:
                    Console.WriteLine("Ejercicio 6: Registra temperaturas en una matriz 5x7 y muestra máximos, mínimos y promedios.\n");
                    Ejercicio6.Run();
                    break;

                case 7:
                    Console.WriteLine("Ejercicio 7: Construye y muestra las tablas de multiplicar del 1 al 9.\n");
                    Ejercicio7.Run();
                    break;

                case 8:
                    Console.WriteLine("Ejercicio 8: Juego tipo buscaminas en tablero 10x10.\n");
                    Ejercicio8.Run();
                    break;

                case 9:
                    Console.WriteLine("Ejercicio 9: Sistema de calificaciones usando un diccionario (agregar/mostrar/mejor/peor).\n");
                    Ejercicio9.Run();
                    break;

                case 10:
                    Console.WriteLine("Ejercicio 10: Simulador de atención en ventanilla usando una cola.\n");
                    Ejercicio10.Run();
                    break;

                case 11:
                    Console.WriteLine("Ejercicio 11: Sistema de inventario con lista, diccionario y pila para historial.\n");
                    Ejercicio11.Run();
                    break;

                default:
                    Console.WriteLine("Opción inválida, intente nuevamente.");
                    break;
            }

            Console.WriteLine("\nPulse Enter para volver al menú...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

class Ejercicio1
{
    public static void Run()
    {
        List<double> notas = new List<double> { 7.5, 8.0, 6.5, 9.0, 5.5, 4.0, 8.5, 7.0, 6.0, 9.5 };

        double suma = 0;

        Console.WriteLine("=== Notas de los 10 exámenes ===");

        foreach (double nota in notas)
        {
            Console.WriteLine($"Nota: {nota}");
            suma += nota;
        }

        double promedio = suma / notas.Count;

        Console.WriteLine($"\nPromedio final: {promedio:F2}");
    }
}

class Ejercicio2
{
    public static void Run()
    {
        List<int> edades = new List<int> { 15, 22, 18, 30, 12, 25, 17, 65, 19, 33, 16, 50, 21, 14, 8, 36, 10, 45, 13, 20 };

        int mayores = 0;
        int menores = 0;

        foreach (int edad in edades)
        {
            if (edad >= 18)
                mayores++;
            else
                menores++;
        }

        Console.WriteLine("=== Clasificación por edad ===");
        Console.WriteLine($"Mayores de edad: {mayores}");
        Console.WriteLine($"Menores de edad: {menores}");
    }
}

class Ejercicio3
{
    public static void Run()
    {
        List<string> nombres = new List<string>
        {
            "Ana", "Carlos", "Lucia","Valentin", "Diego", "Rosa", "Marcos", "Eleonor", "Pedro", "Nora"
         };

        string nombreMasLargo = nombres[0];
        string nombreMasCorto = nombres[0];

        foreach (string nombre in nombres)
        {
            if (nombre.Length > nombreMasLargo.Length)
            {
                nombreMasLargo = nombre;
            }

            if (nombre.Length < nombreMasCorto.Length)
            {
                nombreMasCorto = nombre;
            }
        }

        Console.WriteLine("=== Resultado ===");
        Console.WriteLine("Nombre con más letras: " + nombreMasLargo + " (" + nombreMasLargo.Length + " letras)");
        Console.WriteLine("Nombre con menos letras: " + nombreMasCorto + " (" + nombreMasCorto.Length + " letras)");
    }
}

class Ejercicio4
{
    public static void Run()
    {
        List<string> listaSupermercado = new List<string>
        {
            "leche",
            "pan",
            "arroz",
            "huevos",
            "azucar",
            "fideos",
            "aceite",
            "sal"
        };

        List<string> comprados = new List<string>();
        List<string> noEstabanEnLista = new List<string>();

        string producto;

        Console.WriteLine("=== Lista de Supermercado ===");
        Console.WriteLine("Escriba los productos que va comprando.");
        Console.WriteLine("Para salir, escriba 'fin'.\n");

        while (true)
        {
            Console.Write("Ingrese un producto: ");
            producto = Console.ReadLine().ToLower();

            if (producto == "fin")
                break;

            if (listaSupermercado.Contains(producto))
            {
                listaSupermercado.Remove(producto);
                comprados.Add(producto);
                Console.WriteLine(" El producto estaba en la lista y fue comprado.");
            }
            else
            {
                // Si ya fue comprado, avisar y no añadir a la lista de "no estaban"
                if (comprados.Contains(producto))
                {
                    Console.WriteLine(" Ese producto ya fue comprado anteriormente.");
                }
                else if (!noEstabanEnLista.Contains(producto))
                {
                    noEstabanEnLista.Add(producto);
                    Console.WriteLine(" El producto no estaba en la lista, pero se agregó.");
                }
                else
                {
                    // Evita duplicados en `noEstabanEnLista`
                    Console.WriteLine(" Ese producto ya está en la lista de artículos que no estaban.");
                }
            }
        }

        Console.WriteLine("\n=== Resultados ===");

        Console.WriteLine("\n Productos no comprados (quedaron en la lista):");
        foreach (string item in listaSupermercado)
        {
            Console.WriteLine("- " + item);
        }

        Console.WriteLine("\n Productos que compró pero no estaban en la lista:");
        foreach (string item in noEstabanEnLista)
        {
            Console.WriteLine("- " + item);
        }

        // Combina comprados y noEstabanEnLista sin duplicados para mostrar todos los comprados
        HashSet<string> todosComprados = new HashSet<string>(comprados);
        foreach (string item in noEstabanEnLista)
        {
            todosComprados.Add(item);
        }

        Console.WriteLine("\n Productos comprados:");
        foreach (string item in todosComprados)
        {
            Console.WriteLine("- " + item);
        }
    }
}

class Ejercicio5
{
    public static void Run()
    {
        char[,] matriz = new char[5, 5];

        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                if ((fila + columna) % 2 == 0)
                    matriz[fila, columna] = 'P';
                else
                    matriz[fila, columna] = 'I';
            }
        }

        Console.WriteLine("=== Matriz 5x5 ===\n");

        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write(matriz[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Ejercicio6
{
    public static void Run()
    {
        Random random = new Random();

        int[,] temperaturas = new int[5, 7];

        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        int diaDelMes = 1;

        for (int semana = 0; semana < 5; semana++)
        {
            for (int dia = 0; dia < 7; dia++)
            {
                if (diaDelMes <= 31)
                {
                    temperaturas[semana, dia] = random.Next(7, 38);
                    diaDelMes++;
                }
                else
                {
                    temperaturas[semana, dia] = 0;
                }
            }
        }

        Console.WriteLine("Temperaturas registradas (°C):\n");
        diaDelMes = 1;
        for (int semana = 0; semana < 5; semana++)
        {
            for (int dia = 0; dia < 7; dia++)
            {
                if (temperaturas[semana, dia] != 0)
                    Console.Write($"{temperaturas[semana, dia],2} ");
                else
                    Console.Write(" - ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n==================================");

        for (int semana = 0; semana < 5; semana++)
        {
            int tempMax = int.MinValue;
            int tempMin = int.MaxValue;
            int diaMax = 0, diaMin = 0;
            int sumaSemana = 0;
            int diasValidos = 0;

            for (int dia = 0; dia < 7; dia++)
            {
                int temp = temperaturas[semana, dia];
                if (temp == 0) continue;

                if (temp > tempMax)
                {
                    tempMax = temp;
                    diaMax = dia;
                }
                if (temp < tempMin)
                {
                    tempMin = temp;
                    diaMin = dia;
                }

                sumaSemana += temp;
                diasValidos++;
            }

            double promedio = (double)sumaSemana / diasValidos;

            Console.WriteLine($"\nSemana {semana + 1}:");
            Console.WriteLine($"  Máxima: {tempMax}°C el {dias[diaMax]}");
            Console.WriteLine($"  Mínima: {tempMin}°C el {dias[diaMin]}");
            Console.WriteLine($"  Promedio: {promedio:F2}°C");
        }

        int tempMaxMes = int.MinValue;
        int semanaMax = 0;
        int diaMaxMes = 0;
        diaDelMes = 1;

        for (int semana = 0; semana < 5; semana++)
        {
            for (int dia = 0; dia < 7; dia++)
            {
                int temp = temperaturas[semana, dia];
                if (temp == 0) continue;

                if (temp > tempMaxMes)
                {
                    tempMaxMes = temp;
                    semanaMax = semana;
                    diaMaxMes = dia;
                }
                diaDelMes++;
            }
        }

        Console.WriteLine("\n==================================");
        Console.WriteLine($"Temperatura más alta del mes: {tempMaxMes}°C");
        Console.WriteLine($"Se registró un {dias[diaMaxMes]} de la semana {semanaMax + 1}");
    }
}

class Ejercicio7
{
    public static void Run()
    {
        int[,] tabla = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            tabla[0, i] = i;
            tabla[i, 0] = i;
        }

        for (int fila = 1; fila < 10; fila++)
        {
            for (int columna = 1; columna < 10; columna++)
            {
                tabla[fila, columna] = tabla[fila, 0] * tabla[0, columna];
            }
        }

        Console.WriteLine("=== TABLAS DE MULTIPLICAR DEL 1 AL 9 ===\n");

        for (int fila = 0; fila < 10; fila++)
        {
            for (int columna = 0; columna < 10; columna++)
            {
                Console.Write($"{tabla[fila, columna],4}");
            }
            Console.WriteLine();
        }
    }
}

class Ejercicio8
{
    public static void Run()
    {
        const int filas = 10;
        const int columnas = 10;
        char[,] tablero = new char[filas, columnas];
        Random random = new Random();

        int cantidadX = random.Next(20, 40);
        int aciertos = 0;
        int intentosFallidos = 0;
        int totalIntentosPermitidos = 3;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                tablero[i, j] = '*';
            }
        }

        int colocadas = 0;
        while (colocadas < cantidadX)
        {
            int f = random.Next(filas);
            int c = random.Next(columnas);

            if (tablero[f, c] != 'X')
            {
                tablero[f, c] = 'X';
                colocadas++;
            }
        }

        char[,] tableroVisible = new char[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                tableroVisible[i, j] = '*';
            }
        }

        Console.WriteLine("Bienvenido al buscaminas de temu :V");
        Console.WriteLine($"Hay {cantidadX} X escondidas en el tablero 10x10.");
        Console.WriteLine($"Tenés {totalIntentosPermitidos} oportunidades para fallar.\n");

        // --- Ciclo del juego ---
        while (intentosFallidos < totalIntentosPermitidos && aciertos < cantidadX)
        {
            Console.WriteLine("Tablero actual:");
            MostrarTablero(tableroVisible);

            Console.Write("\nIngrese la fila (0–9): ");
            int fila = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese la columna (0–9): ");
            int columna = int.Parse(Console.ReadLine() ?? "0");

            if (fila < 0 || fila >= filas || columna < 0 || columna >= columnas)
            {
                Console.WriteLine("Posición fuera del rango, intenta de nuevo.\n");
                continue;
            }

            if (tablero[fila, columna] == 'X')
            {
                Console.WriteLine(" ¡Acertaste una X!\n");
                tableroVisible[fila, columna] = 'X';
                tablero[fila, columna] = 'O';
                aciertos++;
            }
            else
            {
                Console.WriteLine(" No había una X allí.\n");
                tableroVisible[fila, columna] = '-';
                intentosFallidos++;
                Console.WriteLine($"Te quedan {totalIntentosPermitidos - intentosFallidos} intentos.\n");
            }
        }

        Console.WriteLine("\n=== FIN DEL JUEGO ===");
        if (aciertos == cantidadX)
            Console.WriteLine("¡Encontraste todas las X! ¡Ganaste!");
        else
            Console.WriteLine("Te quedaste sin intentos.");

        Console.WriteLine("\nTablero final (X = escondidas, * = vacías):\n");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (tablero[i, j] == 'O')
                    Console.Write("X ");
                else if (tablero[i, j] == 'X')
                    Console.Write("X ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void MostrarTablero(char[,] tablero)
    {
        int filas = tablero.GetLength(0);
        int columnas = tablero.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Ejercicio9
{
    public static void Run()
    {
        // Usar comparador para evitar duplicados por diferencias de mayúsculas/minúsculas
        Dictionary<string, double> calificaciones = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("Sistema de calificaciones del curso");
        Console.WriteLine("Ingrese los nombres y notas de los alumnos.");
        Console.WriteLine("Escriba 'fin' para terminar.\n");

        //  Agregar alumnos y sus notas ---
        while (true)
        {
            Console.Write("Nombre del alumno: ");
            string nombre = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine(" Nombre vacío. Intente de nuevo.\n");
                continue;
            }

            if (nombre.Equals("fin", StringComparison.OrdinalIgnoreCase))
                break;

            // Si ya existe, preguntar si desea sobrescribir
            if (calificaciones.ContainsKey(nombre))
            {
                Console.WriteLine($" El alumno '{nombre}' ya existe con nota {calificaciones[nombre]}.");
                Console.Write("¿Desea sobrescribir la nota? (s/n): ");
                string respuesta = Console.ReadLine()?.Trim().ToLower() ?? "n";
                if (respuesta != "s")
                {
                    Console.WriteLine("Se omitió la actualización.\n");
                    continue;
                }
            }

            double nota;
            while (true)
            {
                Console.Write("Nota del alumno: ");
                string inputNota = Console.ReadLine();
                if (double.TryParse(inputNota, out nota))
                    break;
                Console.WriteLine("Entrada inválida. Introduzca un número válido para la nota.");
            }

            calificaciones[nombre] = nota;
            Console.WriteLine(" Alumno agregado/actualizado.\n");
        }

        if (calificaciones.Count == 0)
        {
            Console.WriteLine(" No se ingresaron alumnos.");
            return;
        }

        //  Mejor promedio general ---
        double sumaNotas = 0;
        foreach (var alumno in calificaciones)
        {
            sumaNotas += alumno.Value;
        }
        double promedio = sumaNotas / calificaciones.Count;

        //  Buscar mejor y peor nota ---
        string mejorAlumno = "";
        string peorAlumno = "";
        double mejorNota = double.MinValue;
        double peorNota = double.MaxValue;

        foreach (var alumno in calificaciones)
        {
            if (alumno.Value > mejorNota)
            {
                mejorNota = alumno.Value;
                mejorAlumno = alumno.Key;
            }
            if (alumno.Value < peorNota)
            {
                peorNota = alumno.Value;
                peorAlumno = alumno.Key;
            }
        }

        Console.WriteLine("\n=== Resultados del curso ===");
        Console.WriteLine($"Promedio general: {promedio:F2}");
        Console.WriteLine($"Mejor alumno: {mejorAlumno} con nota {mejorNota}");
        Console.WriteLine($"Peor alumno: {peorAlumno} con nota {peorNota}");

        Console.WriteLine("\nListado completo de alumnos:");
        foreach (var alumno in calificaciones)
        {
            Console.WriteLine($" - {alumno.Key}: {alumno.Value}");
        }
    }
}

class Ejercicio10
{
    public static void Run()
    {
        Queue<string> filaClientes = new Queue<string>();

        Console.WriteLine("Simulador de atención en ventanilla bancaria");
        Console.WriteLine("Ingrese los nombres de los clientes. Escriba 'fin' para terminar.\n");

        // Encolar nombres de clientes ---
        while (true)
        {
            Console.Write("Nombre del cliente: ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "fin")
                break;

            filaClientes.Enqueue(nombre);
            Console.WriteLine("Cliente agregado a la fila.\n");
        }

        // Verificar si hay clientes en la cola
        if (filaClientes.Count == 0)
        {
            Console.WriteLine("No hay clientes en la fila.");
            return;
        }

        Console.WriteLine("\n=== Iniciando atención ===\n");

        //  Atender uno por uno ---
        while (filaClientes.Count > 0)
        {
            // Mostrar quién está siendo atendido ---
            string clienteAtendido = filaClientes.Dequeue();
            Console.WriteLine($" Atendiendo a: {clienteAtendido}");
            Console.WriteLine($"Personas restantes en la fila: {filaClientes.Count}\n");

            // Simulación: pequeña pausa (solo para realismo)
            System.Threading.Thread.Sleep(2000);
        }

        Console.WriteLine(" Todos los clientes fueron atendidos. ¡Buen trabajo!");
    }
}

class Ejercicio11
{
    public static void Run()
    {
        // Lista de productos disponibles
        List<string> productos = new List<string>();

        // Diccionario con stock de cada producto
        Dictionary<string, int> stock = new Dictionary<string, int>();

        // Pila para registrar el historial de acciones
        Stack<string> historial = new Stack<string>();

        int opcion;

        do
        {
            Console.WriteLine("\n=====  SISTEMA DE INVENTARIO =====");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Vender producto");
            Console.WriteLine("3. Mostrar inventario actual");
            Console.WriteLine("4. Ver últimas 3 acciones");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida, intente nuevamente.");
                continue;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    // AGREGAR PRODUCTO
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese la cantidad: ");
                    if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                    {
                        if (stock.ContainsKey(nombre))
                        {
                            stock[nombre] += cantidad;
                            historial.Push($"Se agregó {cantidad} unidades más de '{nombre}'.");
                        }
                        else
                        {
                            productos.Add(nombre);
                            stock[nombre] = cantidad;
                            historial.Push($"Se agregó el nuevo producto '{nombre}' con {cantidad} unidades.");
                        }

                        Console.WriteLine("Producto agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida.");
                    }
                    break;

                case 2:
                    // VENDER PRODUCTO
                    Console.Write("Ingrese el nombre del producto vendido: ");
                    string vendido = Console.ReadLine();

                    if (stock.ContainsKey(vendido))
                    {
                        Console.Write("Ingrese la cantidad vendida: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidadVendida) && cantidadVendida > 0)
                        {
                            if (stock[vendido] >= cantidadVendida)
                            {
                                stock[vendido] -= cantidadVendida;
                                historial.Push($"Se vendió {cantidadVendida} unidades de '{vendido}'.");

                                Console.WriteLine("Venta registrada correctamente.");

                                // Si se acaba el stock, quitarlo de la lista
                                if (stock[vendido] == 0)
                                {
                                    stock.Remove(vendido);
                                    productos.Remove(vendido);
                                    historial.Push($"El producto '{vendido}' se quedó sin stock y fue removido del inventario.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay suficiente stock disponible.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El producto no existe en el inventario.");
                    }
                    break;

                case 3:
                    // MOSTRAR INVENTARIO
                    Console.WriteLine("Inventario actual:");
                    if (productos.Count == 0)
                    {
                        Console.WriteLine("No hay productos en el inventario.");
                    }
                    else
                    {
                        foreach (var prod in productos)
                        {
                            Console.WriteLine($"- {prod}: {stock[prod]} unidades");
                        }
                    }
                    break;

                case 4:
                    // MOSTRAR ÚLTIMAS 3 ACCIONES
                    Console.WriteLine("Últimas acciones realizadas:");
                    if (historial.Count == 0)
                    {
                        Console.WriteLine("No hay acciones registradas.");
                    }
                    else
                    {
                        int mostrar = Math.Min(3, historial.Count);
                        var acciones = historial.ToArray();

                        for (int i = 0; i < mostrar; i++)
                        {
                            Console.WriteLine($"- {acciones[i]}");
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Saliendo del sistema de inventario...");
                    break;

                default:
                    Console.WriteLine("Opción inválida, intente nuevamente.");
                    break;
            }

        } while (opcion != 5);
    }
}