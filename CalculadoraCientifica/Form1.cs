using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creamos un booleano
        bool secuencia = true;
        //creamos un String para las operaciones matemáticas
        String operacion, borrado;
        //para almacenar numeros creamos un double:cualquier tipo de numero
        double numero1, numero2, resultado;


        //SON NUMEROS DE LA CALCULADORA
        private void num1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "1";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "2";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }

        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "3";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }

        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "4";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }

        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "5";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }

        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "6";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }

        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "7";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }

        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "8";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }

        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                //agregara a la pantalla el boton uno
                Pantalla.Text = "";
                Pantalla.Text = "9";
                secuencia = false;

                //si secuencia es false pondre lo que hay en la pantalla +1
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }

        }

        private void num0_Click(object sender, EventArgs e)
        {
            //mientras en la pantalla haya un 0 va a devolver la misma variable
            if (Pantalla.Text == "0")
            {
                return;
                //si hay otro digito va a devolver lo que hay en la pantalla mas el digito 0.
            }
            else
            {

                Pantalla.Text = Pantalla.Text + "0";
            }
        }

        // FIN DE LOS NUMERO DE LA CALCULADORA


        //AQUÍ EMPIEZAN LOS BOTONES DE LAS OPERACIONES MATEMÁTICAS
        private void Suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;

        }

        private void Resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;

        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultado = Math.Sqrt(numero1);
            Pantalla.Text = resultado.ToString();
            secuencia = true;

        }

        private void Cuadrado_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Pantalla.Text);
            resultado = numero1 * numero1;
            Pantalla.Text = resultado.ToString();
            secuencia = true;
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Pantalla.Text);
            if (operacion == "+")
            {
                resultado = numero1 + numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = numero1 - numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = numero1 * numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = numero1 / numero2;
                Pantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void Retroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            Pantalla.Text = borrado;


            if (Pantalla.Text == "")
            {
                Pantalla.Text = "0";
                secuencia = true;
            }
            if (Pantalla.Text == "-")
            {
                Pantalla.Text = "0";
                secuencia = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
   

        private void Borrar_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;

        }

        private void Multiplicación_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;

        }

        private void Division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(Pantalla.Text);
            secuencia = true;

        }

    }
}
     
        
    

            
    

