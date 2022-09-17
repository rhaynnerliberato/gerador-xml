using System;
using System.IO;
using System.Xml.Serialization;
using extractor_xml.Model;
using extractor_xml.Repositorio;

namespace ExctractorXml
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(" ", "").Replace(":", "") + ".xml";

            //SerializarObjeto(nomeArquivo);
            //DeSerializarObjeto();

            SerializarListaObjetos(nomeArquivo);
            //DeSerializarListaObjetos();


            #region Serializacao
            // cria um objeto Usuario e serializa para um arquivo xml dentro da pasta arquivosGerados
            static void SerializarObjeto(string nomeArquivo)
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
                    serializador.Serialize(stream, usuario);
                }
            }

            #endregion Serializacao

            #region DeSerializacao
            // cria um objeto Usuario NULL e Deserializa os dados de um xml existente na pasta arquivosGerados atribuindo seus valores ao objeto Usuario
            static void DeSerializarObjeto()
            {
                Usuario usuario = new Usuario();
                using (StreamReader stream = new StreamReader(@"/Users/rhaynnerliberato/Projects/proj-extractor-xml/extractor-xml/arquivosGerados/arquivoParaDeSerializar.xml"))
                {
                    XmlSerializer deSerializador = new XmlSerializer(typeof(Usuario));
                    usuario = (Usuario)deSerializador.Deserialize(stream);
                }
            }

            #endregion DeSerializacao

            #region SerilizacaoDeLista
            static void SerializarListaObjetos(string nomeArquivo)
            {
                MockUsuarioRepositorio listaDeUsuarios = new MockUsuarioRepositorio();

                using (StreamWriter stream = new StreamWriter(Path.Combine(@"/Users/rhaynnerliberato/Projects/proj-extractor-xml/extractor-xml/arquivosGerados", nomeArquivo)))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Usuario>));
                    serializador.Serialize(stream, listaDeUsuarios.Usuarios);
                }
            }
            #endregion SerializacaoDeLista

            #region DeserializacaoDeLista
            static void DeSerializarListaObjetos()
            {
                List<Usuario> listaDeUsuarios = new List<Usuario>();

                using (StreamReader stream = new StreamReader(@"/Users/rhaynnerliberato/Projects/proj-extractor-xml/extractor-xml/arquivosGerados/9172022101752AM.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Usuario>));
                    listaDeUsuarios = (List<Usuario>)serializador.Deserialize(stream);
                }
            }
            #endregion DeserializacaoDeLista
        }
    }
}