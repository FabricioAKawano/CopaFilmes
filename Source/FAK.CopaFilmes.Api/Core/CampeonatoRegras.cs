using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;

namespace FAK.CopaFilmes.Api.Core
{
    public abstract class CampeonatoRegras
    {
        public abstract List<FilmeModel> Jogar(List<FilmeModel> filmes);

        protected FilmeModel filme01;
        protected FilmeModel filme02;
        protected FilmeModel ObterVencedor()
        {
            if (filme01.Nota == filme02.Nota)
            {
                return new List<FilmeModel> { filme01, filme02 }.OrderBy(f => f.Titulo).First();
            }

            if (filme01.Nota > filme02.Nota)
            {
                return filme01;
            }
            else
            {
                return filme02;
            }
        }
    }
}
