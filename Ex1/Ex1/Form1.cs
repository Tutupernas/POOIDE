using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            
        }

        Ex1 robson = new Ex1();
        Ex2 quadrado = new Ex2();
        Ex3 quadrado2 = new Ex3();
        Ex4 triangulo = new Ex4();
        Ex5 milhas = new Ex5();
        Ex6 dolar = new Ex6();
        Ex7 maior = new Ex7();
        Ex8 maior2 = new Ex8();
        Ex9 grande = new Ex9();
        Ex10 IMC = new Ex10();
        Ex11 verifica = new Ex11();
        Ex12 verifica2 = new Ex12();

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                robson.setAltura(int.Parse(valor1.Text));
                robson.setBase(int.Parse(valor2.Text));

                robson.calcularArea();


                resultado.Text = "A área do retângulo é: " + Convert.ToString(robson.getArea());
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                quadrado.setLado(int.Parse(valor1.Text));
                quadrado.calcularArea();

                resultado.Text = "A área do quadrado é: " + Convert.ToString(quadrado.getArea());

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                quadrado2.setDiag(int.Parse(valor1.Text));
                quadrado2.calculaArea();

                resultado.Text = "A área do quadrado é: " + Convert.ToString(quadrado2.getArea());

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                triangulo.setBase1(int.Parse(valor1.Text));
                triangulo.setAltura(int.Parse(valor2.Text));
                triangulo.calculaArea();

                resultado.Text = "A área do triangulo é: " + Convert.ToString(triangulo.getArea());

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                milhas.setMilhas(int.Parse(valor1.Text));               
                milhas.calculaQuilometros();

                resultado.Text = "A quantidade em quilometros é: " + Convert.ToString(milhas.getQuilometros());

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                dolar.setCotacao(double.Parse(valor1.Text));
                dolar.setDolar(double.Parse(valor2.Text));
                dolar.calculaDolar();

                resultado.Text = "A quantidade em reais é: " + Convert.ToString(dolar.getReais());

            }
            else if (comboBox1.SelectedIndex == 6)
            {
                maior.setvalorA(double.Parse(valor1.Text));
                maior.setvalorB(double.Parse(valor2.Text));
                

                resultado.Text = "O maior valor é: " + Convert.ToString(maior.verificaMaior());

            }
            else if (comboBox1.SelectedIndex == 7)
            {
                maior2.setvalorA(double.Parse(valor1.Text));
                maior2.setvalorB(double.Parse(valor2.Text));

                maior2.setIgual(false);

                if (maior2.verificaIgual() == true)
                {

                    resultado.Text = "Os valores são iguais";


                }
                else {

                    resultado.Text = "O maior valor é: " + Convert.ToString(maior2.verificaMaior());

                }
                

            }
            else if (comboBox1.SelectedIndex == 8)
            {
                grande.setBase(int.Parse(valor1.Text));
                grande.setAltura(int.Parse(valor2.Text));

                grande.calcularArea();

                if (grande.verificaMaior() == true)
                {

                    resultado.Text = "TERRENO GRANDE, ÁREA DE VALOR: " + Convert.ToString(grande.getArea());


                }
                else
                {

                    resultado.Text = "TERRENO PEQUENO, ÁREA DE VALOR: " + Convert.ToString(grande.getArea());

                }
                ;

            }
            else if (comboBox1.SelectedIndex == 9)
            {

                IMC.setPeso(double.Parse(valor1.Text));
                IMC.setAltura(double.Parse(valor2.Text));

                IMC.calcularIMC();

                

                if (IMC.getIMC() < 20)
                {

                    resultado.Text = "Abaixo do peso, IMC de valor: " + Convert.ToString(IMC.getIMC());


                }
                else if(IMC.getIMC() < 25)
                {

                    resultado.Text = "Peso ideal, IMC de valor: " + Convert.ToString(Math.Round(IMC.getIMC(),2));

                }
                else if (IMC.getIMC() >= 25)
                {

                    resultado.Text = "Acima do peso, IMC de valor: " + Convert.ToString(Math.Round(IMC.getIMC(), 2));

                }


            }
            else if (comboBox1.SelectedIndex == 10)
            {

                verifica.setLadoA(double.Parse(valor1.Text));
                verifica.setLadoB(double.Parse(valor2.Text));
                verifica.setLadoC(double.Parse(valor3.Text));





                if (verifica.ehTriangulo())
                {
                    resultado.Text = "É um triângulo:" + Convert.ToString(verifica.classificaTriangulo());
                    
                }
                else
                {
                    resultado.Text = "Não formam um triângulo";
                }


            }
            else if (comboBox1.SelectedIndex == 11)
            {

                verifica2.setLadoA(double.Parse(valor1.Text));
                verifica2.setLadoB(double.Parse(valor2.Text));
                verifica2.setLadoC(double.Parse(valor3.Text));





                if (verifica2.ehTriangulo())
                {
                    

                    if (verifica2.EhRetangulo())
                        resultado.Text = "É um triangulo retângulo";
                    else
                        resultado.Text = "É um triangulo mas não é retângulo";
                }
                else
                {
                    resultado.Text = "Os valores digitados NÃO formam um triângulo.";
                }


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                enunciado.Text = "ÁREA DO RETANGULO";
                valor2.Visible = true;
                altura.Visible = true;
                baze.Text = "Base";
                altura.Text = "Altura";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                enunciado.Text = "ÁREA DO QUADRADO";
                valor2.Visible = false;
                altura.Visible = false;
                baze.Text = "Aresta";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                enunciado.Text = "ÁREA DO QUADRADO";
                valor2.Visible = false;
                altura.Visible = false;
                baze.Text = "Diagonal";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                enunciado.Text = "ÁREA DO TRIANGULO";
                valor2.Visible = true;
                altura.Visible = true;
                baze.Text = "Base";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                enunciado.Text = "MILHAS MARITIMAS";
                valor2.Visible = false;
                altura.Visible = false;
                baze.Text = "Milhas";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                enunciado.Text = "COTAÇÃO ATUAL DOLAR";
                valor2.Visible = true;
                altura.Visible = true;
                baze.Text = "Cotação Dolar";
                altura.Text = "Qnt Dolares";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 6)
            {
                enunciado.Text = "VERIFICA MAIOR";
                valor2.Visible = true;
                altura.Visible = true;
                baze.Text = "NUMERO 1";
                altura.Text = "NUMERO 2";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 7)
            {
                enunciado.Text = "VERIFICA MAIOR OU IGUAL";
                valor2.Visible = true;
                altura.Visible = true;
                baze.Text = "NUMERO 1";
                altura.Text = "NUMERO 2";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 8)
            {
                enunciado.Text = "ÁREA DO TERRENO";
                valor2.Visible = true;
                altura.Visible = true;
                baze.Text = "Base";
                altura.Text = "Altura";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 9)
            {
                enunciado.Text = "CALCULO IMC";
                valor2.Visible = true;
                altura.Visible = true;
                baze.Text = "PESO";
                altura.Text = "ALTURA";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                lado.Visible = false;
                valor3.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 10)
            {
                enunciado.Text = "VERIFICA TRIANGULO";
                valor2.Visible = true;
                altura.Visible = true;
                lado.Visible = true;
                valor3.Visible = true;
                baze.Text = "LADO A";
                altura.Text = "LADO B";
                lado.Text = "LADO C";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                valor3.Text = "";

            }
            else if (comboBox1.SelectedIndex == 11)
            {
                enunciado.Text = "VERIFICA TRIANGULO RETANGULO";
                valor2.Visible = true;
                altura.Visible = true;
                lado.Visible = true;
                valor3.Visible = true;
                baze.Text = "LADO A";
                altura.Text = "LADO B";
                lado.Text = "LADO C";
                resultado.Text = "";
                valor1.Text = "";
                valor2.Text = "";
                valor3.Text = "";

            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
