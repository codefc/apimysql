using System.Collections.Generic;
using ApiMySql.Model;

namespace ApiMySql.Repository
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> GetAll();
    }
}