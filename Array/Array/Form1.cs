using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArray1_Click(object sender, EventArgs e)
        {
            //Criando e iniciando um simples array
            //Neste caso o tamanho do Array pode variar 
            string[] times = { "Corinthians", "Palmeiras", "São Paulo", "Santos" };

            //recuperando o conteúdo de um array
            MessageBox.Show("Time" + times[0]);
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            //Criando os naipes e tipos de cartas
            string[] face = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei" };

            string[] naipe = { "Ouros", "Paus", "Espadas", "Copas" };

            //A linha abaixo ajuda no entendimento do raciocínio lógico
            //MessageBox.Show("Carta Sorteada: " + numeros[10] + " de " + naipe[3]);

            Random numero = new Random();

            //Função para gerar números aleatórios dos números e naipes
            //Criando duas variáveis que vão receber números aleatórios
            string n = naipe[numero.Next(4)];
            string f = face[numero.Next(13)];

            //Criando o Array aleatório de Números e Naipes de cartas
            MessageBox.Show(f + " de " + n);
        }

        private void btnArray2_Click(object sender, EventArgs e)
        {
            //Outra forma de declarar e iniciar um Array 
            //Neste caso o Array SEMPRE tem um tamanho fixo

            //"Criando um objeto Array do tipo inteiro de tamanho 5"

            int[] numeros = new int[5];
            numeros[0] = 1;
            numeros[1] = 5;
            numeros[2] = 18;
            numeros[3] = 45;
            numeros[4] = 90;

            MessageBox.Show("Número: " + numeros[2]);
        }

        private void btnArray3_Click(object sender, EventArgs e)
        {
            //Preenchendo o Array com o laço for
            int[] numeros = new int[5];

            //A estrutura abaixo cria as variáveis que irão preencher as 5 "casinhas" do Array

            //++ equivale a i=i+1
            for (int i = 0; i < 5; i++)
            {
                numeros[i] = i;
                //listBox1.Items.Add(i);
                listBox1.Items.Add("numeros [" + i + "] = " + i);
            }
        }

        private void btnArray4_Click(object sender, EventArgs e)
        {
            //Outra forma de iniciar um Array
            //Uso do laço foi para exibir o conteúdo do Array
            //Uso do .Length

            int[] pares = new int[] { 2, 4, 6, 8 };

            // .Length -- identifica o tamanho total do Array
            for (int i = 0; i < pares.Length; i++)
            {
                listBox2.Items.Add(pares[i]);
            }
        }

        private void btnArray5_Click(object sender, EventArgs e)
        {
            //Uso do foreach (laço for simplificado)
            string[] semana = new string[7];
            semana[0] = "Segunda";
            semana[1] = "Terça";
            semana[2] = "Quarta";
            semana[3] = "Quinta";
            semana[4] = "Sexta";
            semana[5] = "Sábado";
            semana[6] = "Domingo";
            

            //foreach (tipo de varávelnome (qualquer nome) in nome_Array)
            foreach (string dia in semana)
            {
                listBox3.Items.Add(dia);
            }

        }

        private void btnArray6_Click(object sender, EventArgs e)
        {
            // Array multidimensional "MATRIZ"
            // [,] 2 dimensões [linha,coluna]
            //[,,] 3 dimensaões 
            // [,,,] 4 dimensões
            // ....
            // a linha abaixo cria e inicaliza um array de 2 dimensões com 2 linhas e 4 colunas [2,4]
            double[,] notas = new double[2, 4] { { 8,7,9,3 }, {4, 5, 8, 6 } };
            // exemplo da tabela de notas do aluno
            MessageBox.Show("Nota: " + notas[0, 2]);

        }
    }
}
