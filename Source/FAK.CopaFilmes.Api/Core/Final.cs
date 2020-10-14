using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;

namespace FAK.CopaFilmes.Api.Core
{
    public class Final : CampeonatoRegras
    {
        public override List<FilmeModel> Jogar(List<FilmeModel> filmes)
        {
            filme01 = filmes.First();
            filme02 = filmes.Last();
            var vencedor = ObterVencedor();

            if (filme01.Id == vencedor.Id)
            {
                return new List<FilmeModel> { filme01, filme02 };
            }
            else
            {
                return new List<FilmeModel> { filme02, filme01 };
            }
        }
    }
}
