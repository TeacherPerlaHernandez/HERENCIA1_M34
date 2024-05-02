using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Sumar suma = new Sumar(); //instancie, o
                                      //hice un nuevo objeto suma
            //llamar al metodo de clase suma operar
            resultado.Text = suma.operar
            (int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Restar resta = new Restar(); //instancie, o
                                      //hice un nuevo objeto suma
                                      //llamar al metodo de clase suma operar
            resultado.Text = resta.operar
            (int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            valor1.Clear();
            valor2.Clear();
            resultado.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Multiplicar multiplicar = new Multiplicar(); //instancie, o
                                         //hice un nuevo objeto suma
                                         //llamar al metodo de clase suma operar
            resultado.Text = multiplicar.operar
            (int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }
    }
}
