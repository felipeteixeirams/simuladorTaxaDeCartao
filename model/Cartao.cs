using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladorTaxaDeCartao.model
{
    class Cartao
    {
        public double Valor { get; set; }
        public double Taxa { get; set; }
        public double SubTotal { get; set; }
        public string CalcularPagamento(double taxa)
        {
            this.Taxa = (this.Valor * taxa) / 100;
            this.SubTotal = this.Valor + this.Taxa;
            return SubTotal.ToString("C");
        }
    }
}
