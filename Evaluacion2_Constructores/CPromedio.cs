using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2_Constructores
{
    class CPromedio
    {


        public string NombreEstudiante { get; set; }
        public decimal NumeroCuenta { get; set; }
        public decimal nota1 { get; set; }
        public decimal nota2 { get; set; }
        public decimal nota3 { get; set; }
        public decimal nota4 { get; set; }

        public CPromedio() { }

       public CPromedio (string _NombreEstudiante, int _NumeroCuenta)
        {
            NombreEstudiante = _NombreEstudiante;
            NumeroCuenta = _NumeroCuenta;
        }

        public CPromedio (string _NombreEstudiante, decimal _NumeroCuenta, decimal _Nota1, decimal _Nota2, decimal _Nota3, decimal _Nota4)
        {
            NombreEstudiante = _NombreEstudiante;
            NumeroCuenta = _NumeroCuenta;
            nota1 = _Nota1;
            nota2 = _Nota2;
            nota3 = _Nota3;
            nota4 = _Nota4;
        }

        public decimal devolverPromedio()
        {
            decimal promedio;
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            return promedio;
        }
    }

}
