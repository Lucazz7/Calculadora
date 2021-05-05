using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        String opecacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '1';
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '2';
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '3';
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '4';
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '5';
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '6';
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '7';
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '8'; 
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '9'; 
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '0';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_resu.Text += '.'; ;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            if (txt_resu.Text != "")
            {
                valor2 = decimal.Parse(txt_resu.Text, CultureInfo.InvariantCulture);

                if (opecacao == "SOMA")
                {
                    txt_resu.Text = Convert.ToString(valor1 + valor2);
                }
                else if (opecacao == "SUBTRACAO")
                {
                    txt_resu.Text = Convert.ToString(valor1 - valor2);
                }
                else if (opecacao == "MULTIPLICACAO")
                {
                    txt_resu.Text = Convert.ToString(valor1 * valor2);
                }
                else if (opecacao == "DIVISAO")
                {
                    txt_resu.Text = Convert.ToString(valor1 / valor2);
                }
            }
            else
            {
                txt_resu.Text = "O campo esta vazio ensira algum valor! Precione C para limpar";
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txt_resu.Text != "")
            {
                valor1 = decimal.Parse(txt_resu.Text, CultureInfo.InvariantCulture);

                txt_resu.Text = "";

                opecacao = "SOMA";

                labelOperacao.Text = " + ";
            }
            else
            {
                txt_resu.Text = "O campo esta vazio ensira algum valor";
            }
            

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (txt_resu.Text != "")
            {
                valor1 = decimal.Parse(txt_resu.Text, CultureInfo.InvariantCulture);

                txt_resu.Text = "";

                opecacao = "SUBTRACAO";

                labelOperacao.Text = " - ";
            }
            else
            {
                txt_resu.Text = "O campo esta vazio ensira algum valor";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txt_resu.Text != "")
            {
                valor1 = decimal.Parse(txt_resu.Text, CultureInfo.InvariantCulture);

                txt_resu.Text = "";

                opecacao = "MULTIPLICACAO";

                labelOperacao.Text = " X ";


            }else
            {
                txt_resu.Text = "O campo esta vazio ensira algum valor";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txt_resu.Text != "")
            {
                valor1 = decimal.Parse(txt_resu.Text, CultureInfo.InvariantCulture);

                txt_resu.Text = "";

                opecacao = "DIVISAO";

                labelOperacao.Text = " / ";
            }
            else
            {
                txt_resu.Text = "O campo esta vazio ensira algum valor";
            }

                
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_resu.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txt_resu.Text = "";
            labelOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }
    }
}
