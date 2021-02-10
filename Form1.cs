using SimuladorTaxaDeCartao.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorTaxaDeCartao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        * Declaração de variáveis
        **/
        Cartao cartao1 = new Cartao();
        Cartao cartao2 = new Cartao();
        Cartao cartao3 = new Cartao();
        double valorDoServico = 0;
        private void valoresCartoesPadrao()
        {
            cartao1.Valor = 0;
            cartao1.Taxa = 0;
            cartao1.SubTotal = 0;
            cartao2.Valor = 0;
            cartao2.Taxa = 0;
            cartao2.SubTotal = 0;
            cartao3.Valor = 0;
            cartao3.Taxa = 0;
            cartao3.SubTotal = 0;
        }
        /*
        * Dados
        **/
        double[] taxas = {1.2, 2, 3, 3.5, 4, 5, 6, 6.8, 7, 8, 9, 11, 13};
        private void valorServico(object sender, EventArgs e)
        {
            try
            {
                valorDoServico = Convert.ToDouble(txbValorServico.Text);
                valorEmEspecie();
            }
            catch
            {
                txbValorServico.Text = 0.ToString();
            }
        }

        private void valorCartao1(object sender, EventArgs e)
        {
            try
            {
                cartao1.Valor = Convert.ToDouble(txbValorCartao1.Text);
                valorEmEspecie();
            }
            catch
            {
                txbValorCartao1.Text = 0.ToString();
            }
        }

        private void valorCartao2(object sender, EventArgs e)
        {
            try
            {
                cartao2.Valor = Convert.ToDouble(txbValorCartao2.Text);
                valorEmEspecie();
            }
            catch
            {
                txbValorCartao2.Text = 0.ToString();
            }
        }

        private void valorCartao3(object sender, EventArgs e)
        {
            try
            {
                cartao3.Valor = Convert.ToDouble(txbValorCartao3.Text);
                valorEmEspecie(); 
            }
            catch
            {
                txbValorCartao3.Text = 0.ToString();
            }
        }

        private void valorEmEspecie()
        {
            double valoresCartoes = cartao1.Valor + cartao2.Valor + cartao3.Valor;
            txbDinheiro.Text = (valorDoServico - valoresCartoes).ToString();
        }
        private void totalTaxas()
        {
            txbTaxas.Text = (cartao1.Taxa + cartao2.Taxa + cartao3.Taxa).ToString();
        }
        private void valorTotal()
        {
            txbResultado.Text = (cartao1.SubTotal + cartao2.SubTotal + cartao3.SubTotal).ToString();
        }
        private void optCartao1_CheckedChanged(object sender, EventArgs e)
        {
            if (opt1Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[0]);
            if (opt2Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[1]);
            if (opt3Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[2]);
            if (opt4Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[3]);
            if (opt5Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[4]);
            if (opt6Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[5]);
            if (opt7Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[6]);
            if (opt8Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[7]);
            if (opt9Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[8]);
            if (opt10Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[9]);
            if (opt11Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[10]);
            if (opt12Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[11]);
            if (opt13Cartao1.Checked == true) txbResultadoCartao1.Text = cartao1.CalcularPagamento(taxas[12]);
            totalTaxas();
            valorTotal();
        }
        private void optCartao2_CheckedChanged(object sender, EventArgs e)
        {
            if (opt1Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[0]);
            if (opt2Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[1]);
            if (opt3Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[2]);
            if (opt4Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[3]);
            if (opt5Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[4]);
            if (opt6Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[5]);
            if (opt7Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[6]);
            if (opt8Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[7]);
            if (opt9Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[8]);
            if (opt10Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[9]);
            if (opt11Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[10]);
            if (opt12Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[11]);
            if (opt13Cartao2.Checked == true) txbResultadoCartao2.Text = cartao2.CalcularPagamento(taxas[12]);
            totalTaxas();
            valorTotal();
        }
        private void optCartao3_CheckedChanged(object sender, EventArgs e)
        {
            if (opt1Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[0]);
            if (opt2Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[1]);
            if (opt3Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[2]);
            if (opt4Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[3]);
            if (opt5Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[4]);
            if (opt6Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[5]);
            if (opt7Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[6]);
            if (opt8Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[7]);
            if (opt9Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[8]);
            if (opt10Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[9]);
            if (opt11Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[10]);
            if (opt12Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[11]);
            if (opt13Cartao3.Checked == true) txbResultadoCartao3.Text = cartao3.CalcularPagamento(taxas[12]);
            totalTaxas();
            valorTotal();
        }
    }
}
