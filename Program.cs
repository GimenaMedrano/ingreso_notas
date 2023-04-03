void notas()
{
    int n;
    do
    {
        Console.WriteLine("Ingrese el número de alumnos a registrar: (0 para salir)");
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Error: debe ingresar un número.");
        }
    } while (n <= 0);

    string[] nombre = new string[n];
    int[] notas = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Ingrese el nombre del estudiante {0}: ", i + 1);
        string nombre_input = Console.ReadLine();
        while (string.IsNullOrEmpty(nombre_input) || nombre_input.Any(char.IsDigit))
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un nombre (no se permiten números o cadenas vacías).");
            nombre_input = Console.ReadLine();
        }
        nombre[i] = nombre_input;

        Console.WriteLine("Ingrese la nota del estudiante {0}: ", i + 1);
        string nota_input = Console.ReadLine();
        int nota_result;
        while (!int.TryParse(nota_input, out  nota_result))
        {
            Console.WriteLine("Entrada inválida. Debe ingresar una nota (debe ser un número entero).");
            nota_input = Console.ReadLine();
        }
        notas[i] = nota_result;
    }

    int menor = 100;
    int mayor = 0;
    int nt_mayor = 0;
    int nt_menor = 0;
    for (int i = 0; i < n; i++)
    {
        if (notas[i] < menor)
        {
            menor = notas[i];
            nt_menor = i;
        }
        if (notas[i] > mayor)
        {
            mayor = notas[i];
            nt_mayor = i;
        }
    }
    Console.WriteLine("La nota mayor es de " + nombre[nt_mayor] + " con una puntuación de " + mayor);
    Console.WriteLine("La nota menor es de " + nombre[nt_menor] + " con una puntuación de " + menor);
}

notas();