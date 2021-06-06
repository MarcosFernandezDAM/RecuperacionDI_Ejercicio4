using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EJERCICIO 4!!!!!!!!!!!

namespace ejercicio4
{
    public delegate int Operacion(int num1, int num2);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable table = new Hashtable();
        String texto = "Suma";
        int min = 0;
        int sec = 0;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void cambiaChecked(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            texto = rb.Text;
            labelOperacion.Text = "" + rb.Tag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                table.Add(radioButtonSuma.Text, (Operacion)((num1, num2) => num1 + num2));
                table.Add(radioButtonResta.Text, (Operacion)((num1, num2) => num1 - num2));
                table.Add(radioButtonMulti.Text, (Operacion)((num1, num2) => num1 * num2));
                table.Add(radioButtonDiv.Text, (Operacion)((num1, num2) => num1 / num2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error en el dato");
                labelResultado.Text = "";
            }
            timer1.Start();
            this.Text = String.Format("{0,2:D2}:{1,2:D2}", min, sec);

        }
        private void BtnOperacion_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Text = "" + ((Operacion)table[texto])(Convert.ToInt32(textBoxNum1.Text), Convert.ToInt32(textBoxNum2.Text));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en el dato");
                labelResultado.Text = "";
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error en el dato");
                labelResultado.Text = "";
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error en el dato");
                labelResultado.Text = "";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
            this.Text = String.Format("{0,2:D2}:{1,2:D2}", min, sec);
        }
    }
}