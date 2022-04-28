using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }//fim do construtor

        private void button1_Click(object sender, EventArgs e)//adicao
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Adicao(num1, num2);
                label3.Text = "" + resultado;
            }catch(Exception erro)
            {
                MessageBox.Show("os numeros nao foram digitados!\n\n" + erro);
            }
        }//fim botao adição

        private void button6_Click(object sender, EventArgs e)//radicaliza
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double resultado = model.Radicaliza(num1);
                if (resultado == -1)
                {
                    label3.Text = "impossivel calcular a raiz!";
                }
                else
                {
                    label3.Text = "" + resultado;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("os numeros nao foram digitados!\n\n" + erro);
            }
        }//fim botao radicaliza

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o primeiro numero

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o segundo numero

        private void subtracao_Click(object sender, EventArgs e)//subtracao
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Subtracao(num1, num2);
                label3.Text = "" + resultado;
            }
            catch (Exception erro)
            {
                MessageBox.Show("os numeros nao foram digitados!\n\n" + erro);
            }
        }//fim botao subtração

        private void multiplicacao_Click(object sender, EventArgs e)//multiplicacao
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Multiplicacao(num1, num2);
                label3.Text = "" + resultado;
            }
            catch (Exception erro)
            {
                MessageBox.Show("os numeros nao foram digitados!\n\n" + erro);
            }
        }//fim botao multiplicação

        private void divisao_Click(object sender, EventArgs e)//divisao
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Divisao(num1, num2);
                //tratadno a validãção
                if (resultado == -1)
                {
                    label3.Text = "" + resultado;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("os numeros nao foram digitados!\n\n" + erro);
            }
        }//fim botao divisão

        private void expoente_Click(object sender, EventArgs e)//potencia
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Potencia(num1, num2);
                label3.Text = "" + resultado;
            }
            catch (Exception erro)
            {
                MessageBox.Show("os numeros nao foram digitados!\n\n" + erro);
            }
        }//fim botao expoente potencia

        private void label3_Click(object sender, EventArgs e)//resultado
        {

        }
    }//fim da classe
}//fim do projeto
