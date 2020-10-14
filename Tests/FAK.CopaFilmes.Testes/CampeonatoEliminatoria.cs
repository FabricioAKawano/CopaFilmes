using FAK.CopaFilmes.Api.Core;
using System;
using System.Collections.Generic;
using Xunit;

namespace FAK.CopaFilmes.Testes
{
    public class CampeonatoEliminatoria : TestesBase
    {
        [Fact]
        public void DadaUmaListaDeFilmesDeterminadaDeveraRetornarCampeaoVingadores()
        {
            //arrange
            var filmesSelecionados = ObterFilmesSelecionados(new List<string>
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
            var campeonato = new Campeonato();

            //action
            var resultado = campeonato.Inicio(filmesSelecionados);

            //assert
            Assert.Equal("Vingadores: Guerra Infinita", resultado.Campeao);
        }

        [Fact]
        public void DadaUmaListaDeFilmesDeterminadaDeveraRetornarViceCampeaoOsIncriveis2()
        {
            //arrange
            var filmesSelecionados = ObterFilmesSelecionados(new List<string>
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
            var campeonato = new Campeonato();

            //action
            var resultado = campeonato.Inicio(filmesSelecionados);

            //assert
            Assert.Equal("Os Incríveis 2", resultado.ViceCampeao);
        }

        [Fact]
        public void DadaUmaListaDeFilmesInvalidaDeveraLancarExceptionFilmesSelecionadosInvalidos()
        {
            //arrange
            var filmesSelecionados = ObterFilmesSelecionados(new List<string>
            {
                "tt3606756",
                "tt4881806",
                "tt5164214",
                "tt7784604",
                "tt4154756",
                "tt5463162",
                //"tt3778644",
                //"tt3501632"
            });
            var campeonato = new Campeonato();

            //action
            var ex = Assert.Throws<ApplicationException>(() => campeonato.Inicio(filmesSelecionados));

            //assert
            Assert.Equal("Filmes selecionados inválidos.", ex.Message);
        }
    }
}
