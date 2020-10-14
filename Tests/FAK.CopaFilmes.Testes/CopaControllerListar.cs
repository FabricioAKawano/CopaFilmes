using FAK.CopaFilmes.Api.Controllers;
using FAK.CopaFilmes.Api.Core;
using FAK.CopaFilmes.Api.Infraestrutura;
using FAK.CopaFilmes.Api.Model;
using Moq;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;


namespace FAK.CopaFilmes.Testes
{
    public class CopaControllerListar : TestesBase
    {
        private readonly List<FilmeModel> _filmesSelecionados;

        public CopaControllerListar()
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
        public void QuandoChamarIniciarDeveraSerInvocadoApenasUmaVezMetodoInicioDoCampeonato()
        {
            //arrange            
            var campeonatoMock = new Mock<ICampeonato>();
            var empresaclientMock = new Mock<EmpresaApiCliente>(It.IsAny<HttpClient>());
            var controller = new CopaController(empresaclientMock.Object, campeonatoMock.Object);

            //action
            var resultado = controller.Iniciar(_filmesSelecionados);

            //assert
            campeonatoMock.Verify(c => c.Inicio(_filmesSelecionados), Times.Once());
        }
    }
}
