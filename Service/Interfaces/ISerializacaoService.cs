using System;
namespace extractor_xml.Service.Interfaces
{
    public interface ISerializacaoService
    {
        public void SerializarObjeto(string nomeArquivo);
        public void SerializarListaObjetos(string nomeArquivo);
    }
}

