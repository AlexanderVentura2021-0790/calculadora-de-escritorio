using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaCalculadora
{ 

    public enum operacion
    {
        NoDefinida = 0,
        suma = 1,
        resta = 2,
        division = 3,
        multiplicacion = 4,
        modulo = 5,
    }
    public partial class Form1 : Form

    {
        double valor1 = 0;
        double valor2 = 0;
        operacion operador = operacion.NoDefinida;
        bool UnNumeroLeido = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void LeerNumero (string numero)

        {
            UnNumeroLeido = true;
            if (CajaResultado.Text == "0" && CajaResultado.Text != null)
            {
                CajaResultado.Text = numero;
            }
            else
            {

                CajaResultado.Text += numero;

            }

        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)       
            {
                case operacion.suma:
                    resultado = valor1 + valor2;
                    break;
                case operacion.resta:
                    resultado = valor1 - valor2;
                    break;
                case operacion.multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case operacion.division:
                    if(valor2 ==0)
                    {
                        MessageBox.Show("no se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case operacion.modulo:
                    resultado = valor1 % valor2;
                    break;

            }
            return resultado;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text.Length > 1)
            {
                string txtResultado = CajaResultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                CajaResultado.Text = txtResultado;

                if(txtResultado.Length==1 && txtResultado.Contains("-"))
                {
                    CajaResultado.Text = "0";
                }
                else 
                {
                    CajaResultado.Text = txtResultado;
                }
            }
            else
            {
                CajaResultado.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCero_Click(object sender, EventArgs e)

        {
            UnNumeroLeido = true;
            if (CajaResultado.Text == "0")
            {
                return;

            }
            else
            {
                CajaResultado.Text += "0";
            }
           
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }


        private void ObtenerValor (string operador )
        {
            valor1 = Convert.ToDouble(CajaResultado.Text);
            lblHistorial.Text = CajaResultado.Text + operador;
            CajaResultado.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)

        {
            operador = operacion.suma;
            ObtenerValor("+");
            
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if(valor2==0 && UnNumeroLeido)
            {
                valor2 = Convert.ToDouble(CajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                UnNumeroLeido = false;
                CajaResultado.Text = Convert.ToString(resultado);


            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {

            operador = operacion.resta;
            ObtenerValor("-");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {

            operador = operacion.multiplicacion;
            ObtenerValor("x");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {

            operador = operacion.modulo;
            ObtenerValor("%");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            operador = operacion.division;
            ObtenerValor("/");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CajaResultado.Text = "0";
            lblHistorial.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)


        {   if (CajaResultado.Text.Contains("."))
            {
                return;
            } 

            CajaResultado.Text += ".";
        }
    }
}
