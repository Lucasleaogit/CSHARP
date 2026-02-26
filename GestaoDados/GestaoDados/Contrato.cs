using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDados
{
    class Contrato
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public double Valor { get; set; }
        public Cliente Cliente { get; set; }
        public Contrato(DateTime inicio, DateTime fim, double valor, Cliente cliente)
        {
            Inicio = inicio;
            Fim = fim;
            Valor = valor;
            Cliente = cliente;
        }
    }
}  
