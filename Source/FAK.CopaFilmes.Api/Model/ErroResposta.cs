using System;

namespace FAK.CopaFilmes.Api.Model
{
    public class ErroResposta
    {
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        public ErroResposta InnerError { get; set; }

        public static ErroResposta From(Exception e)
        {
            if (e == null)
            {
                return null;
            }

            return new ErroResposta
            {
                Codigo = e.HResult,
                Mensagem = e.Message,
                InnerError = From(e.InnerException)
            };
        }
    }
}
