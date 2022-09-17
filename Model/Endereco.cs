using System;
namespace extractor_xml.Model
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
    }
}

