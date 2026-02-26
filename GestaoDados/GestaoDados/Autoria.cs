using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDados
{
    public class Autoria
    {
        public Autor Autor { get; set; }
        public Relatorio Relatorio { get; set; }
        public int Posicao { get; set; }
        public bool Anonimo { get; set; }
        public Autoria(Autor autor, Relatorio relatorio, int posicao, bool anonimo)
        {
            Autor = autor;
            Relatorio = relatorio;
            Posicao = posicao;
            Anonimo = anonimo;
        }
    }
}
