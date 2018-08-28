using ApiMySql.Model;
using ApiMySql.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApiMySql.Controller
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;

        /*
        Construtor com a dependência de uma interface de repositório. Esta interface terá sua instância injetada pelo contexto
        de injeção do .net core, configurado no arquivo startup.cs na linha 46
         */
        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        [Produces(typeof(Pessoa))]
        public IActionResult Get()
        {
            var pessoas = _pessoaRepository.GetAll();

            if (pessoas.Count() == 0)
                return NoContent();

            return Ok(pessoas);
        }
    }
}