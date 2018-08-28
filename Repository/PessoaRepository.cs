using System.Collections.Generic;
using ApiMySql.Model;
using MySql.Data.MySqlClient;
using Dapper;

namespace ApiMySql.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository(string connectionString)
        {
            _connectionString = connectionString;   // Injetando a string de conexão no construtor da classe
        }

        public IEnumerable<Pessoa> GetAll()
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                /*
                Usando o extension Method Query<> do dapper para a obtenção dos registros de pessoa.
                O extension method depende do namespace delcarado como using no arquivo de classe: using Dapper;
                Basicamente é feita uma query, obtendo todos os registros na tabela Pessoa e mapeando para o objeto pessoa,
                especificado em Query<Pessoa>. Caso os nomes das colunas da tabela sejam diferentes das propriedades do
                objeto de retorno, deve-se usar o recurso de rename de colunas no select, por exemplo:
                SELECT Codigo as Id, Nome as Usuario FROM Pessoa. Neste select estamos mapeando a coluna Codigo para a 
                propriedade Id do objeto de retorno, se for o caso.
                 */
                return connection.Query<Pessoa>("SELECT Codigo, Nome, Endereco FROM Pessoa ORDER BY Nome ASC");
            }
        }
    }
}