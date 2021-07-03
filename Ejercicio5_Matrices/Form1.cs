using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Matriz_button_Click(object sender, EventArgs e)
        {
            int Fila = Convert.ToInt32(Fila_textBox.Text);
            int Columna = Convert.ToInt32(Columna_textBox.Text);
            int[,] Matrices = new int[Fila, Columna];

            Random Numeros = new Random();

            for (int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < Columna; j++)
                {
                    Matrices[i, j] = Numeros.Next(1, 100);
                }

                Matriz_dataGridView.ColumnCount = Columna;
                Matriz_dataGridView.RowCount = Fila;
                
            }

            for (int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < Columna; j++)
                {
                    Matriz_dataGridView.Rows[i].Cells[j].Value = Matrices[i, j].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fila_textBox.Clear();
            Columna_textBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
