using System;


namespace Aula_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string url = "https:www.bytebank.com/cambio?origem=real&destino=dolar";
            //int indiceInterrogacao = url.IndexOf('?');

            //string argumentos = url.Substring(indiceInterrogacao + 1);

            //Console.WriteLine(argumentos);
            // Console.WriteLine(indiceInterrogacao);

            ExtratorValorDeArgumentosURL extrato = new ExtratorValorDeArgumentosURL(url);

            Console.WriteLine("Valor da Origem: " + extrato.GetValor("origem"));
        }
    }


}
