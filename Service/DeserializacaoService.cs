using System.Xml.Serialization;
using extractor_xml.Model;
using extractor_xml.Service.Interfaces;

namespace extractor_xml.Service
{
    public class DeserializacaoService : IDeseriailzacaoService
    {
        public DeserializacaoService() { }

        // cria um objeto Usuario e Deserializa os dados de um xml existente na pasta arquivosGerados atribuindo seus valores ao objeto Usuario
        public void DeSerializarObjeto()
        {
            Usuario usuario = new Usuario();
            using (StreamReader stream = new StreamReader(@"/Users/rhaynnerliberato/Projects/proj-extractor-xml/extractor-xml/arquivosParaLeitura/umUsuario.xml"))
            {
                try
                {
                    XmlSerializer deserializador = new XmlSerializer(typeof(Usuario));
                    usuario = (Usuario)deserializador.Deserialize(stream);

                    Console.WriteLine("-- Deserializacao de 1 Usuario --");
                    Console.WriteLine("Nome: " + usuario.Nome);
                }
                catch(Exception e)
                {
                    throw new Exception("Nenhum arquivo xml encontrado." + e.Message);
                }
            }
        }

        // cria uma lista objetos Usuario e Deserializa os dados de um xml existente na pasta arquivosGerados atribuindo seus valores a lista de usuarios criada
        public void DeSerializarListaObjetos()
        {
            List<Usuario> listaDeUsuarios = new List<Usuario>();

            using (StreamReader stream = new StreamReader(@"/Users/rhaynnerliberato/Projects/proj-extractor-xml/extractor-xml/arquivosParaLeitura/listaDeUsuarios.xml"))
            {
                try
                { 
                    XmlSerializer deserializador = new XmlSerializer(typeof(List<Usuario>));
                    listaDeUsuarios = (List<Usuario>)deserializador.Deserialize(stream);

                    Console.WriteLine("-- Deserializacao da lista de usuarios --");
                    listaDeUsuarios.ForEach(x => Console.WriteLine(x.Nome));
                }
                catch (Exception e)
                {
                    throw new Exception("Nenhum arquivo xml encontrado." + e.Message);
                }
        }
        }
    }
}

