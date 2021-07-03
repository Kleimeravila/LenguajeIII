using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenguajeIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Agrerar_Click(object sender, EventArgs e)
        {
            string[] Nombre = new string[] { textBox_Nombre.Text };
            int[] Edad = new int[] { Convert.ToInt32(textBox_Edad.Text) };

            foreach (var items in Nombre)
            {
                comboBox_Registro.Items.Add(items);
            }

            foreach (var items in Edad)
            {
                comboBox_Registro.Items.Add(items);
            }

            textBox_Nombre.Clear();
            textBox_Edad.Clear();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Edad.Clear();
            textBox_Nombre.Clear();
            
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void button_Asc_Click(object sender, EventArgs e)
        //{
        //    string[] Nombre = new string[] { textBox_Nombre.Text };


        //    foreach (var item in Nombre)
        //    {
        //        comboBox_Registro.Items.Add(item);
        //    }

        //    comboBox_Registro.Sorted = false;

        //}

        private void button_Desc_Click(object sender, EventArgs e)
        {
            string[] Nombre = new string[] { textBox_Nombre.Text };
           

            foreach (var item in Nombre)
            {
                comboBox_Registro.Items.Add(item);
            }

            comboBox_Registro.Sorted = true;
        }
    }
}
