using extractor_xml.Service;

namespace ExctractorXml
{
    public class Program
    {

        static void Main(string[] args)
        {
            //define o nome do arquivo gerado
            string nomeArquivo = "Arquivo_" + DateTime.Now.ToString().Replace(@"/", "").Replace(" ", "").Replace(":", "") + ".xml";

            //inicializacao dos servicos
            SerializacaoService serializacaoService = new SerializacaoService();
            DeserializacaoService deserializacaoService = new DeserializacaoService();

            //declaracao de variaveis locais
            string serializeOuDeserialize = "";
            string umOuLista = "";

            //Menu inicial
            Console.WriteLine("* * * ESCOLHA UMA OPERACAO * * *");
            Console.WriteLine("1 - Serializar");
            Console.WriteLine("2 - Deserializar");

            serializeOuDeserialize = Console.ReadLine();


            if(serializeOuDeserialize == "1") //Serializar
            {
                Console.WriteLine("* * * ESCOLHA O TIPO DE SERIALIZACAO * * *");
                Console.WriteLine("1 - Serializar 1 Usuario");
                Console.WriteLine("2 - Serializar LISTA de Usuarios");
                umOuLista = Console.ReadLine();
                Serializar(umOuLista);
            }
            else if (serializeOuDeserialize == "2") //Deserializar
            {
                Console.WriteLine("* * * ESCOLHA O TIPO DE DESERIALIZACAO * * *");
                Console.WriteLine("1 - Deserializar 1 Usuario");
                Console.WriteLine("2 - Deserializar LISTA de Usuarios");
                umOuLista = Console.ReadLine();
                Deserializar(umOuLista);
            }
            else
            {
                Console.WriteLine("Opcao Invalida!");
            }


            void Serializar(string opcao)
            {
                if (opcao == "1")
                {
                    serializacaoService.SerializarObjeto(nomeArquivo);
                }
                if (opcao == "2")
                {
                    serializacaoService.SerializarListaObjetos(nomeArquivo);
                }
            }

            void Deserializar(string opcao)
            {
                if (opcao == "1")
                {
                    deserializacaoService.DeSerializarObjeto();
                }
                if (opcao == "2")
                {
                    deserializacaoService.DeSerializarListaObjetos();
                }
            }

            Console.WriteLine("Fim do processamento.");
        }
    }
}