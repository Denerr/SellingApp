using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String cidade, pagamento;
        public void getCity(string chosenCity)
        {
            cidade = chosenCity;
        }

        public void getPayment(string chosenPayment)
        {
            pagamento = chosenPayment;
        }


        public void selectPayment()
        {
            if(rdbDinheiro.Checked == true)
            {
                getPayment(rdbDinheiro.Text);
            }
            else if (rdbCartao.Checked == true)
            {
                getPayment(rdbCartao.Text);
            }
            else if (rdbPix.Checked == true)
            {
                getPayment(rdbPix.Text);
            }
            else
            {
                getPayment(rdbOutro.Text);
            }
            
        }

        public void calculoTotal()
        {
            double unidade, total;
            int quantidade;

            if(txtUnidade.Text == null || txtQuantidade.Text == null)
            {
                total = 0;
                txtTotal.Text = total.ToString();

            }
            else
            {
                unidade = Double.Parse(txtUnidade.Text);
                quantidade = int.Parse(txtQuantidade.Text);

                total = unidade * quantidade;
                txtTotal.Text = total.ToString();
            }
        }

        private void selectCity()
        {
            double valor;


            if (rdbViradouro.Checked == true)
            {
                valor = 2.75;
                getCity(rdbViradouro.Text);
            }
            else if (rdbTerraRoxa.Checked == true)
            {
                valor = 3.75;
                getCity(rdbTerraRoxa.Text);
            }
            else
            {
                valor = 0;
            }

            txtUnidade.Text = valor.ToString();
        }

        private void rdbViradouro_CheckedChanged(object sender, EventArgs e)
        {
            selectCity();
        }

        private void rdbTerraRoxa_CheckedChanged(object sender, EventArgs e)
        {
            selectCity();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            calculoTotal();
            selectPayment();

            string texto, titulo, info;
            var valorTotal = txtTotal.Text;
            var nome = txtName.Text;
            var quantidade = txtQuantidade.Text;
            var dataCompra = dtpDataVenda.Text;

            texto = "\n\nO valor total da venda é de: " + valorTotal;
            titulo = "Deseja Cadastrar a Venda?";
            info = "Informações da Venda \n\n" +
                   "Nome: " + nome +
                   "\nQuantidade: " + quantidade +
                   "\nCidade: " + cidade +
                   "\nPagamento: " + pagamento +
                   "\nData da Compra: " + dataCompra;

            var resultado = MessageBox.Show(info + texto, titulo, MessageBoxButtons.YesNo);
            if(resultado == DialogResult.No)
            {
                MessageBox.Show("Venda Cancelada!");
            }
            else
            {
                MessageBox.Show("Venda Cadastrada");
            }
        }
    }
}
