using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDados
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Morada { get; set; }

        public string NC { get; set; }

        public Cliente(string nome, string morada, string nc)
        {
            Nome = nome;
            Morada = morada;
            NC = nc;
        }
    }
}
