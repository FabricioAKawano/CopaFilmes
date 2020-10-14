using FAK.CopaFilmes.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FAK.CopaFilmes.Api.Core
{
    public class Campeonato : ICampeonato
    {
        public ResultadoModel Inicio(IEnumerable<FilmeModel> filmesSelecionados)
        {
            if (filmesSelecionados.Count() != 8)
            {
                throw new ApplicationException("Filmes selecionados inválidos.");
            }

            try
            {
                var fase01 = new QuartasDeFinal();
                var fase02 = new SemiFinal();
                var fase03 = new Final();

                var vencedoresQuartasDeFinal = fase01.Jogar(filmesSelecionados.ToList());
                var vencedoresSemiFinal = fase02.Jogar(vencedoresQuartasDeFinal);
                var vencedoresFinal = fase03.Jogar(vencedoresSemiFinal);

                return new ResultadoModel { Campeao = vencedoresFinal.First().Titulo, ViceCampeao = vencedoresFinal.Last().Titulo };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
