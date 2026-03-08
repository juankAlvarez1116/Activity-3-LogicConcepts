using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
int validate = 0;

do
{
    validate = 0;
    var n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");
    if (n == 0)
    {
        Console.WriteLine("Lo ingresado no es valido, vuelva a intentarlo");
        Console.WriteLine("");
        continue;
    }

    Console.WriteLine("");

    int[,] matrix = new int[n, n];
    int sum = 0;
    int max = 0;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (i + 1) - j;
            Console.Write($"{matrix[i, j]}\t");
            sum += matrix[i, j];
            if (max < matrix[i, j])
                max = matrix[i, j];
            if (min > matrix[i, j])
                min = matrix[i, j];
        }
        Console.WriteLine();
    }

    Console.WriteLine("");
    Console.WriteLine($"La sumatoria es...: {sum,10:N0}");
    Console.WriteLine($"El valor máximo es: {max,10:N0}");
    Console.WriteLine($"El valor mínimo es: {min,10:N0}");

    Console.WriteLine("");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? [S]i o [N]o:", options);
        Console.WriteLine("");
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (validate == 1 || answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));