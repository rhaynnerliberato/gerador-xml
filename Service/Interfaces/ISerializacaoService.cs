using System;
namespace extractor_xml.Service.Interfaces
{
    public interface ISerializacaoService
    {
        public bool SerializarObjeto(string nomeArquivo);
        public void SerializarListaObjetos(string nomeArquivo);
    }
}

