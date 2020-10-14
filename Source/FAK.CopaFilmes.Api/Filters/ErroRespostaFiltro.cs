using FAK.CopaFilmes.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FAK.CopaFilmes.Api.Filters
{
    public class ErroRespostaFiltro : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var erroResposta = ErroResposta.From(context.Exception);
            context.Result = new ObjectResult(erroResposta) { StatusCode = 500 };
        }
    }
}
