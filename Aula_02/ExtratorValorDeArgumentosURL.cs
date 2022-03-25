using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }
            int indiceInterrogacao = url.IndexOf('?');

            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        public string GetValor(string parametro)
        {
            string termo = parametro.ToUpper() + "=";
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);
            int indiceValor = indiceTermo + termo.Length;

            string resultado = _argumentos.Substring(indiceValor);
            int indiceEComercial = resultado.IndexOf("&");

            if(indiceEComercial == -1)
            {
                return resultado;
            }
            return resultado.Remove(indiceEComercial);
        }
    }
}
