using System;

public class Program
{
    public static void Main(string[] args)
    {
        string url = "pagina?argumentos";
        int indiceInterrogacao = url.IndexOf('?');

        string argumentos = url.Substring(indiceInterrogacao + 1);

        Console.WriteLine(argumentos);
        // Console.WriteLine(indiceInterrogacao);
    }
}

