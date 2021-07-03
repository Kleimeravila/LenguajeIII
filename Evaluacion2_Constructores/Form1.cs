using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2_Constructores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_button_Click(object sender, EventArgs e)
        {
            CPromedio Promedio = new CPromedio();
            Promedio.NombreEstudiante = Nombre_textBox.Text;
            Promedio.NumeroCuenta = Convert.ToDecimal(NumCuenta_textBox.Text);
            Promedio.nota1 = Convert.ToDecimal(N1_textBox.Text);
            Promedio.nota2 = Convert.ToDecimal(N2_textBox.Text);
            Promedio.nota3 = Convert.ToDecimal(N3_textBox.Text);
            Promedio.nota4 = Convert.ToDecimal(N4_textBox.Text);


            decimal prom = Promedio.devolverPromedio();
            if (prom >= 70)
            {
                MessageBox.Show(" Alumno Aprobado, Su promedio es de: " + prom); 
            }
            else
            {
                MessageBox.Show(" Alumno Reprobado, Su promedio es de: " + prom);
            }
        }
    }
}
