using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4_Vectores
{
    class Validar
    {
        //método para validar que solo se introduzcan valores numéricos en los TextBox.
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))// Verifica si lo que se introduce por teclado es un número
            {
                v.Handled = false; //Este valor booleano permite lo que se declaro (valores numéricos) 
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo puedes introducir valores numericos enteros mayores a 0");
            }
        }
    }
}
