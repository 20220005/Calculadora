using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private double resultado;
        private string operacion;

        public Form1()
        {
            InitializeComponent();
        }
        public void label(String display)
        {

            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "";

            }
            txtdisplay.Text += display;
        }



        private void btn0_Click(object sender, EventArgs e)
        {
            label("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label("2");
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            label("3");
        }


        private void btndot_Click(object sender, EventArgs e)
        {
            label(".");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            label("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            label("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            label("9");
        }



        private void btnadd_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(txtdisplay.Text);
            operacion = "+";
            txtdisplay.Text = "0";

        }

        private void btnsubstract_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(txtdisplay.Text);
            operacion = "-";
            txtdisplay.Text = "0";

        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(txtdisplay.Text);
            operacion = "*";
            txtdisplay.Text = "0";

        }

        private void btndivide_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(txtdisplay.Text);
            operacion = "/";
            txtdisplay.Text = "0";


        }
        private void btnequals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtdisplay.Text);
            calcular(operacion);

        }

        private void btncuadrado_Click(object sender, EventArgs e)
        {
            resultado = (Convert.ToDouble(txtdisplay.Text));
            resultado = Math.Pow(resultado, 2);

            txtdisplay.Text = Convert.ToString(resultado);

        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            resultado = Math.Sqrt(Convert.ToDouble(txtdisplay.Text));
            txtdisplay.Text = Convert.ToString(resultado);
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            resultado = 0;
            txtdisplay.Text = "0";

        }


        private void btnclear_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Length > 1)
            {
                txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
            }
            else
            {
                txtdisplay.Text = "0";
            }
        }
        public void calcular(String operacion)
        {
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    txtdisplay.Text = Convert.ToString(resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    txtdisplay.Text = Convert.ToString(resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    txtdisplay.Text = Convert.ToString(resultado);
                    break;
                case "/":
                    resultado = num1 / num2;
                    txtdisplay.Text = Convert.ToString(resultado);
                    break;
            }
        }

    }
}
