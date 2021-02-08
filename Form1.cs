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

        private void optCartao1_CheckedChanged(object sender, EventArgs e)
        {
            //marcada a opcao checked
        }

        private void valorServico(object sender, KeyEventArgs e)
        {
           try
            {
                float valorServico = (float)Convert.ToDouble(txbValorServico.Text);
            }
            catch
            {
                txbValorServico.Text = "";
            }
        }
    }
}
