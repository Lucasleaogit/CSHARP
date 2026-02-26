using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDados
{
   public class Relatorio
    {
        public String Titulo { get; set; }
        public String Resumo { get; set; }
        public String Texto { get; set; }
        public StringInfo Imagem { get; set; }
        public String Link { get; set; }

        public List<Acesso> Acessos { get; set; } = new List<Acesso>();

        public Relatorio(string titulo, string resumo, string texto, StringInfo imagem, string link)
        {
            Titulo = titulo;
            Resumo = resumo;
            Texto = texto;
            Imagem = imagem;
            Link = link;
        }

        public void RegistrarAcesso(Acesso acesso)
        {
            Acessos.Add(acesso);
        }
    }
}
