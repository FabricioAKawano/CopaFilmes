using FAK.CopaFilmes.Api.Core;
using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FAK.CopaFilmes.Testes
{
    public class SemiFinalJogar : TestesBase
    {
        private readonly List<FilmeModel> _filmesSelecionados;

        public SemiFinalJogar()
        {
            _filmesSelecionados = new List<FilmeModel>();
            _filmesSelecionados.Add(ObterFilme("tt4154756"));
            _filmesSelecionados.Add(ObterFilme("tt3501632"));
            _filmesSelecionados.Add(ObterFilme("tt3606756"));
            _filmesSelecionados.Add(ObterFilme("tt4881806"));
        }

        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarVingadoresVencedorDoPrimeiroJogo()
        {
            //arrange
            var fase01 = new SemiFinal();

            //action
            var resultado = fase01.Jogar(_filmesSelecionados);

            //assert
            Assert.Equal("Vingadores: Guerra Infinita", resultado.First().Titulo);

        }

        [Fact]
        public void DadaUmaListaDeFilmesDeveraRetornarOsIncriveis2VencedorDoSegundoJogo()
        {
            //arrange
            var fase01 = new SemiFinal();

            //action
            var resultado = fase01.Jogar(_filmesSelecionados);

            //assert
            Assert.Equal("Os Incríveis 2", resultado.Last().Titulo);

        }
    }
}
