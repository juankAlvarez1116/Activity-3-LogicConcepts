using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
int validate = 0;

do
{
    validate = 0;
    var n = ConsoleExtension.GetInt("Ingrese el número a descomponer:  ");
    if (n == 0)
    {
        Console.WriteLine("Lo ingresado no es valido, vuelva a intentarlo");
        Console.WriteLine("");
        validate = 1;
        continue;
    }

    var primes = GetPrimes(n);

    Console.WriteLine("");
    Console.Write($"{n} = ");

    for (int i = 0; i < primes.Count; i++)
    {
        Console.Write($"{primes[i]} ");
        if (i < primes.Count - 1)
            Console.Write("x ");
    }

    Console.WriteLine("");
    Console.WriteLine("");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? [S]i o [N]o:", options);
        Console.WriteLine("");
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (validate == 1 || answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

List<int> GetPrimes(int n)
{
    var primes = new List<int>();
    for (int i = 2; i <= n; i++)
    {
        while (n % i == 0 && ConsoleExtension.IsPrime(i))
        {
            primes.Add(i);
            n /= i;
        }
    }
    return primes;
}