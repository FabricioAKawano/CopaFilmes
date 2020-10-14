using FAK.CopaFilmes.Api.Core;
using FAK.CopaFilmes.Api.Infraestrutura;
using FAK.CopaFilmes.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FAK.CopaFilmes.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CopaController : ControllerBase
    {
        private readonly EmpresaApiCliente _cliente;
        private readonly ICampeonato _campeonato;

        public CopaController(EmpresaApiCliente cliente, ICampeonato campeonato)
        {
            _cliente = cliente;
            _campeonato = campeonato;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var filmes = await _cliente.ObterFilmesAsync();
            return Ok(filmes);
        }

        [HttpPost]
        public IActionResult Iniciar([FromBody] List<FilmeModel> model)
        {
            var resultado = _campeonato.Inicio(model);
            return Ok(resultado);
        }
    }
}
