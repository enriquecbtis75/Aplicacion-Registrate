using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_Registrate.Aplicaciones;

namespace Aplicacion_Registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string nom =  textBox1.Text;
            string nom2 = textBox2.Text;
            string nom3 = textBox3.Text;
            string nom4 = textBox4.Text;
           

            string sexo = comboBox1.SelectedItem.ToString();
            string region = listBox1.SelectedItem.ToString();


            MessageBox.Show("Nombre: " + nom + "\n Apellido: " + nom2 +    "\nEmail: " + nom3 + "\nContraseña: " + nom4 +    "\nSexo: " + sexo + "\nRegión: " + region, "Inicio");
        }
            catch
            {
                MessageBox.Show("error");
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
