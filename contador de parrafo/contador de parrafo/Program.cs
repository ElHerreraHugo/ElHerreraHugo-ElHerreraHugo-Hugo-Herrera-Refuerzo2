
Console.WriteLine("Ingrese un texto o un Parrafo");
string parrafo = Console.ReadLine();


string[] texto = parrafo.Split(' ');


Dictionary<string, int> frecuencia = new Dictionary<string, int>();


foreach (string palabra in texto)


    if (frecuencia.ContainsKey(palabra)) 
    {
        frecuencia[palabra]++;
    }
    else
    {
        frecuencia.Add(palabra, 1);
    }


Console.WriteLine("Se encontro el Resultado de Cada Palabra y con su frecuencia");
foreach (KeyValuePair<string, int> par in frecuencia)
{
    Console.WriteLine($"{par.Key}: {par.Value}");
}



