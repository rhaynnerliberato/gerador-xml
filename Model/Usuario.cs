using System.Runtime.Serialization;

namespace extractor_xml.Model
{
    [Serializable]
    public class Usuario : ISerializable
    {
        public Usuario() { }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }


        #region MetodoSerializacao
        /// <summary>
        /// Funcao de serializacao (armazena dados da lista de objetos no arquivo xml)
        /// SerializationInfo contem os pares de chave-valor
        /// StreamingContext pode conter informacoes adicionais, mas nao estamos usando aqui
        /// </summary>
        /// <param name="=info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                info.AddValue("Nome", Nome);
                info.AddValue("Sobrenome", Sobrenome);
                info.AddValue("Email", Email);
                info.AddValue("Endereco", Endereco);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion MetodoSerializacao

        #region MetodoDeserializacao
        /// <summary>
        /// Funcao de deserializacao (le dados do objeto do arquivo xml)
        /// </summary>
        /// <param name="=info"></param>
        /// <param name="context"></param>
        public Usuario(SerializationInfo info, StreamingContext context)
        {
            //pega os valores de informacoes do arquivo xml e atribui as propriedades
            Nome = (string)info.GetValue("Nome", typeof(string));
            Sobrenome = (string)info.GetValue("Sobrenome", typeof(string));
            Email = (string)info.GetValue("Email", typeof(string));
            Endereco = (Endereco)info.GetValue("Endereco", typeof(Endereco));
        }
        #endregion MetodoDeserializacao
    }
}

