using System;
using System.Xml.Serialization;
using extractor_xml.Model;
using extractor_xml.Repositorio;
using extractor_xml.Service.Interfaces;

namespace extractor_xml.Service
{
    public class SerializacaoService : ISerializacaoService
    {

        // cria um objeto Usuario e serializa para um arquivo xml dentro da pasta arquivosGerados
        public bool SerializarObjeto(string nomeArquivo)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Peter",
                Sobrenome = "Park",
                Email = "spider.man@email.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 3",
                    Cidade = "Vitoria",
                    Estado = "ES",
                    Bairro = "Ilha do Frade",
                    Numero = 1675,
                    CEP = "29100-200"
                }
            };

            using (StreamWriter stream = new StreamWriter(Path.Combine(@"/Users/rhaynnerliberato/Projects/proj-extractor-xml/extractor-xml/arquivosGerados", nomeArquivo)))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
                try
                {
                    serializador.Serialize(stream, usuario);
                    return true;
                }
                catch
                {
                    return false;
                }
                

            }
        }

        //serializa uma lista de objetos Usuario mockado no repositorio
        public void SerializarListaObjetos(string nomeArquivo)
        {
            MockUsuarioRepositorio listaDeUsuarios = new MockUsuarioRepositorio();

            using (StreamWriter stream = new StreamWriter(Path.Combine(@"/Users/rhaynnerliberato/Projects/proj-extractor-xml/extractor-xml/arquivosGerados", nomeArquivo)))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Usuario>));
                serializador.Serialize(stream, listaDeUsuarios.Usuarios);
            }
        }
    }
}

