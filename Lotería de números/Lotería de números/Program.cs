

int[] numerosGanadores = new int[6];


{
    Random random = new Random();

    for (int i = 0; i < numerosGanadores.Length; i++)
    {
        int numeroAleatorio;
        do
        {
            numeroAleatorio = random.Next(1, 50);
        } while (numerosGanadores.Contains(numeroAleatorio));

        numerosGanadores[i] = numeroAleatorio;
    }
   
}

List<int> Usuario = new List<int>();

Console.WriteLine("Ingrese 6 Numeros Diferente y no Repetido");

while (Usuario.Count < 6)
{
    Console.Write("\nIngresa un número Diferente entre 1 y 49: ");
    if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= 49 && !Usuario.Contains(numero))
    {
        Usuario.Add(numero);
    }
    else
    {
        Console.WriteLine("Numero invalido o repetido. Intentalo de nuevo.");
    }
}


int aciertos = 0;

foreach (int randomNumeros in Usuario)
{

    if (Usuario.Contains(randomNumeros))
    {

        aciertos = 0 ;
    }
}


foreach (int numeroGanador in numerosGanadores)
{
    if (Usuario.Contains(numeroGanador))
    {
        aciertos++;
    }
}



Console.WriteLine("Números ganadores:");
Console.WriteLine(string.Join(", ", numerosGanadores));


Console.WriteLine("\nTus números elegidos:");
Console.WriteLine(string.Join(", ", Usuario));



Console.WriteLine($"\nNúmero de aciertos: {aciertos}");

if (aciertos == numerosGanadores.Length)
{
    Console.WriteLine("¡Felicidades! Acertaste todos los números.");
}




