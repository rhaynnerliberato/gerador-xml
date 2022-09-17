using System;
using extractor_xml.Model;

namespace extractor_xml.Repositorio
{
    /// <summary>
    /// Como nao estamos trabalhando com banco de dados, esta sendo inicializada uma lista com alguns usuarios
    /// </summary>
    public class MockUsuarioRepositorio
    {
        public List<Usuario> Usuarios = new List<Usuario>();

        public MockUsuarioRepositorio()
        {
            Usuarios.Add(new Usuario()
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
            });
            Usuarios.Add(new Usuario()
            {
                Nome = "Clark",
                Sobrenome = "Kent",
                Email = "super.man@email.com.br",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 12",
                    Cidade = "Serra",
                    Estado = "ES",
                    Bairro = "Carapina",
                    Numero = 75,
                    CEP = "29100-600"
                }
            });
            Usuarios.Add(new Usuario()
            {
                Nome = "Tony",
                Sobrenome = "Stark",
                Email = "homem.ferro@email.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 30",
                    Cidade = "Vila Velha",
                    Estado = "ES",
                    Bairro = "Ilha das Flores",
                    Numero = 15,
                    CEP = "29100-500"
                }
            });
            Usuarios.Add(new Usuario()
            {
                Nome = "Bruce",
                Sobrenome = "Wayne",
                Email = "batman@email.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 300",
                    Cidade = "Sao Paulo",
                    Estado = "SP",
                    Bairro = "Itaim Bibi",
                    Numero = 967,
                    CEP = "29500-800"
                }
            });
            Usuarios.Add(new Usuario()
            {
                Nome = "Michael",
                Sobrenome = "Jackson",
                Email = "michael.jackson@email.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 34",
                    Cidade = "Vitoria",
                    Estado = "ES",
                    Bairro = "Ilha do Frade",
                    Numero = 165,
                    CEP = "29100-200"
                }
            });
            Usuarios.Add(new Usuario()
            {
                Nome = "Bruce",
                Sobrenome = "Wyllis",
                Email = "bruce.wyllis@email.com.br",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 125",
                    Cidade = "Serra",
                    Estado = "ES",
                    Bairro = "Carapina",
                    Numero = 754,
                    CEP = "29100-600"
                }
            });
            Usuarios.Add(new Usuario()
            {
                Nome = "Renato",
                Sobrenome = "Russo",
                Email = "rento.russo@email.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 306",
                    Cidade = "Vila Velha",
                    Estado = "ES",
                    Bairro = "Ilha das Flores",
                    Numero = 153,
                    CEP = "29100-500"
                }
            });
            Usuarios.Add(new Usuario()
            {
                Nome = "Jorge",
                Sobrenome = "Aragao",
                Email = "aragao.jorge@email.com",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua 3300",
                    Cidade = "Sao Paulo",
                    Estado = "SP",
                    Bairro = "Itaim Bibi",
                    Numero = 9872,
                    CEP = "29500-800"
                }
            });
        }
    }
}

