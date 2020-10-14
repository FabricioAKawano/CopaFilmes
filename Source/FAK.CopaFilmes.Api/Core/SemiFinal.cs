using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;

namespace FAK.CopaFilmes.Api.Core
{
    public class SemiFinal : CampeonatoRegras
    {
        public CampeonatoRegras ProximaFase { get; set; }
        public override List<FilmeModel> Jogar(List<FilmeModel> filmes)
        {
            int quantidadeFilmes = filmes.Count();
            int interador = quantidadeFilmes / 2;

            for (int i = 0; i < interador; i++)
            {
                filme01 = filmes.ElementAt(i);
                filme02 = filmes.ElementAt(quantidadeFilmes - 1 - i);
                FilmeModel vencedor = ObterVencedor();
                if (vencedor.Id == filme01.Id)
                {
                    filmes.RemoveAt(quantidadeFilmes - 1 - i);
                }
                else
                {
                    filmes.RemoveAt(i);
                }
            }

            return filmes;
        }
    }
}
