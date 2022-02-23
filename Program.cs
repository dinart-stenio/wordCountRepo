


try
{
    int wordqtd = default(int);
    Console.WriteLine("\n Digite a quantidade de palavras", wordqtd);
   
    wordqtd = int.Parse(Console.ReadLine());

    List<string> palavras = new List<string>();

    int i = 1;

    while (i <= wordqtd)
    {
        string palavra = default(string);
        Console.WriteLine($"\n Digite a palavra número :  {i}",palavra);
        palavra = Console.ReadLine();
        palavras.Add(palavra);
        i++;
    }

    palavras.OrderBy(p => p.Length).ToList();
    foreach (var palavra in palavras)
    {
        Console.WriteLine($"\n A palavra : {palavra} tem o seguinte tamanho: {palavra.Length}");
    }
}
catch (ArgumentException e)
{
    Console.WriteLine("Número invalido digite apenas números");
}



