using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Forms
{
    public partial class Form1 : Form
    {
        double valor = 0;//utilizado para armazenar valor que esta na tela ao selecionar uma operação
        string operacao = "";//utizado para o switch
        bool opecacaoSelecionada = false;//utilizado na condição IF para zerar ou não a tela 

        public Form1()
        {
            InitializeComponent();
        }

        //botões referentes a teclado numerico 0 ao 9 e .
        //resultado é referente a tela da calculadora
        private void Button_Click(object sender, EventArgs e)
        {
            //este if verifica duas condições onde ele zera a tela
            if (resultado.Text == "0" || opecacaoSelecionada)
                resultado.Clear();

            opecacaoSelecionada = false;
            Button b = (Button)sender;
            resultado.Text = resultado.Text + b.Text;
        }
        //função referente ao botão CE, zera o visor da calculadora
        private void Button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        //função refetente a escolha da operação
        //este metodo ira armazenar a opação na variavel b e o numero da tela na variavel valor
        //em seguida altera a variavel booleana para verdadeiro o que faz zerar a tela
        private void Operacao_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacao = b.Text;
            valor = double.Parse(resultado.Text);
            opecacaoSelecionada = true;
            calculo.Text = valor + " " + operacao;
        }

        //método com switch para realizar os calculos ao selecionar o botão resultado
        private void button16_Click(object sender, EventArgs e)
        {
            calculo.Text = "";
            switch (operacao)
            {
                case "+":
                    resultado.Text = (valor + double.Parse(resultado.Text)).ToString();
                    break;
                case "-":
                    resultado.Text = (valor - double.Parse(resultado.Text)).ToString();
                    break;
                case "*":
                    resultado.Text = (valor * double.Parse(resultado.Text)).ToString();
                    break;
                case "/":
                    resultado.Text = (valor / double.Parse(resultado.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }
        //botão CE zera a tela e limpa a variavel valor
        private void button17_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            valor = 0;
        }

       
    }
}
