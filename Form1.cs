using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4_Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea ingresar los valores del vector?", "Datos del vector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Presiona algún botón", "Botón presionado", botones, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                MessageBox.Show("Presionaste si");
                
            }
            else
            {
                MessageBox.Show("Presionaste no");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string m;
            string n;
            
            m = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor a agregar", "Agregar valor", "", 300, 200);
            n = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la posición en dónde desea agregar este valor", "Agregar valor", "", 300, 200);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string r;
            string s;

            r = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la posición 1", "Cambio posición", "", 300, 200);
            s = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la posición 2", "Cambio posición", "", 300, 200);
        }
    }
}
