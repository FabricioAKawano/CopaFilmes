using FAK.CopaFilmes.Api.Model;
using System.Collections.Generic;
using System.Linq;

namespace FAK.CopaFilmes.Testes
{
    public class TestesBase
    {
        private readonly List<FilmeModel> _listaDeFilmes;

        public TestesBase()
        {
            _listaDeFilmes = new List<FilmeModel>
            {
                new FilmeModel { Id = "tt3606756",
                    Titulo = "Os Incríveis 2",
                    Ano = 2018,
                    Nota = 8.5 },
                new FilmeModel { Id = "tt4881806",
                    Titulo = "Jurassic World: Reino Ameaçado",
                    Ano = 2018,
                    Nota = 6.7 },
                new FilmeModel { Id = "tt5164214",
                    Titulo = "Oito Mulheres e um Segredo",
                    Ano = 2018,
                    Nota = 6.3 },
                new FilmeModel { Id = "tt7784604",
                    Titulo = "Hereditário",
                    Ano = 2018,
                    Nota = 7.8 },
                new FilmeModel { Id = "tt4154756",
                    Titulo = "Vingadores: Guerra Infinita",
                    Ano = 2018,
                    Nota = 8.8 },
                new FilmeModel { Id = "tt5463162",
                    Titulo = "Deadpool 2",
                    Ano = 2018,
                    Nota = 8.1 },
                new FilmeModel { Id = "tt3778644",
                    Titulo = "Han Solo: Uma História Star Wars",
                    Ano = 2018,
                    Nota = 7.2 },
                new FilmeModel { Id = "tt3501632",
                    Titulo = "Thor: Ragnarok",
                    Ano = 2017,
                    Nota = 7.9 },
                new FilmeModel { Id = "tt2854926",
                    Titulo = "Te Peguei!",
                    Ano = 2018,
                    Nota = 7.1 },
                new FilmeModel { Id = "tt0317705",
                    Titulo = "Os Incríveis",
                    Ano = 2004,
                    Nota = 8.0 },
                new FilmeModel { Id = "tt3799232",
                    Titulo = "A Barraca do Beijo",
                    Ano = 2018,
                    Nota = 6.4 },
                new FilmeModel { Id = "tt1365519",
                    Titulo = "Tomb Raider: A Origem",
                    Ano = 2018,
                    Nota = 6.5 },
                new FilmeModel { Id = "tt1825683",
                    Titulo = "Pantera Negra",
                    Ano = 2018,
                    Nota = 7.5 },
                new FilmeModel { Id = "tt5834262",
                    Titulo = "Hotel Artemis",
                    Ano = 2018,
                    Nota = 6.3 },
                new FilmeModel { Id = "tt7690670",
                    Titulo = "Superfly",
                    Ano = 2018,
                    Nota = 5.1 },
                new FilmeModel { Id = "tt6499752",
                    Titulo = "Upgrade",
                    Ano = 2018,
                    Nota = 7.8 }
            };
        }

        protected List<FilmeModel> ObterFilmesSelecionados(List<string> filmesId)
        {
            return _listaDeFilmes.Where(lf => filmesId.Any(fi => fi.Equals(lf.Id))).ToList();
        }

        protected FilmeModel ObterFilme(string filmeId)
        {
            return _listaDeFilmes.First(lf => lf.Id.Equals(filmeId));
        }
    }
}
