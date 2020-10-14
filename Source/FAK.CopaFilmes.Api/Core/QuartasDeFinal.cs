using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;

namespace FAK.CopaFilmes.Api.Core
{
    public class QuartasDeFinal : CampeonatoRegras
    {
        public override List<FilmeModel> Jogar(List<FilmeModel> filmes)
        {
            filmes = filmes.OrderBy(f => f.Titulo).ToList();
            int quantidadeFilmes = filmes.Count();
            int interador = quantidadeFilmes / 2;
            FilmeModel[] vencedores = new FilmeModel[interador];

            for (int i = 0; i < interador; i++)
            {
                filme01 = filmes.ElementAt(i);
                filme02 = filmes.ElementAt(quantidadeFilmes - 1 - i);
                vencedores[i] = ObterVencedor();
            }

            return vencedores.ToList();
        }
    }
}
