using FAK.CopaFilmes.Api.Core;
using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FAK.CopaFilmes.Testes
{
    public class QuartasDeFinalJogar : TestesBase
    {
        private readonly List<FilmeModel> _filmesSelecionados;

        public QuartasDeFinalJogar()
        {
            _filmesSelecionados = ObterFilmesSelecionados(new List<string>
            {
                "tt3606756",
                "tt4881806",
                "tt5164214",
                "tt7784604",
                "tt4154756",
                "tt5463162",
                "tt3778644",
                "tt3501632"
            });
        }

        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarVingadoresVencedorDoPrimeiroJogo()
        {
            //arrange
            var fase01 = new QuartasDeFinal();

            //action
            var resultado = fase01.Jogar(_filmesSelecionados);

            //assert
            Assert.Equal("Vingadores: Guerra Infinita", resultado.First().Titulo);

        }

        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarDeThorVencedorDoSegundoJogo()
        {
            //arrange
            var fase01 = new QuartasDeFinal();

            //action
            var resultado = fase01.Jogar(_filmesSelecionados);

            //assert
            Assert.Equal("Thor: Ragnarok", resultado.ElementAt(1).Titulo);

        }

        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarOsIncriveisVencedorDoTerceiroJogo()
        {
            //arrange
            var fase01 = new QuartasDeFinal();

            //action
            var resultado = fase01.Jogar(_filmesSelecionados);

            //assert
            Assert.Equal("Os Incríveis 2", resultado.ElementAt(2).Titulo);

        }

        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarJurassicWorldVencedorDoQuartoJogo()
        {
            //arrange
            var fase01 = new QuartasDeFinal();

            //action
            var resultado = fase01.Jogar(_filmesSelecionados);

            //assert
            Assert.Equal("Jurassic World: Reino Ameaçado", resultado.Last().Titulo);

        }
    }
}
