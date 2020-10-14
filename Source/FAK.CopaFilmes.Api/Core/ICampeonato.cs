using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;

namespace FAK.CopaFilmes.Api.Core
{
    public interface ICampeonato
    {
        ResultadoModel Inicio(IEnumerable<FilmeModel> filmesSelecionados);
    }
}
