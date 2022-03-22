using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Models
{
    public class Clase
    {

        //Properties
        public DateTime Fecha { get; set; }
        public string Alumno { get; set; }
        public string Asignatura { get; set; }
        public int Duracion { get; set; }
        public decimal Costo { get; set; }
        public bool Paga { get; set; }

    }
}
