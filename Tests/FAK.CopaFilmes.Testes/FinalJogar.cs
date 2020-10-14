using FAK.CopaFilmes.Api.Core;
using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FAK.CopaFilmes.Testes
{
    public class FinalJogar : TestesBase
    {
        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarVingadoresCampeao()
        {
            //arrange
            var filmes = new List<FilmeModel>
            {
                ObterFilme("tt4154756"),
                ObterFilme("tt3606756")
            };
            var fase01 = new Final();

            //action
            var resultado = fase01.Jogar(filmes);

            //assert
            Assert.Equal("Vingadores: Guerra Infinita", resultado.First().Titulo);

        }

        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarOsIncriveis2ViceCampeao()
        {
            //arrange
            var filmes = new List<FilmeModel>
            {
                ObterFilme("tt4154756"),
                ObterFilme("tt3606756")
            };
            var fase01 = new Final();

            //action
            var resultado = fase01.Jogar(filmes);

            //assert
            Assert.Equal("Os Incríveis 2", resultado.Last().Titulo);

        }
    }
}
