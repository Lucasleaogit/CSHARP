using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDados
{
   public class Autor
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }

        public Autor(string nome, string apelido)
        {
            Nome = nome;
            Apelido = apelido;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Autor: {Nome} {Apelido}");
        }
    }
}
