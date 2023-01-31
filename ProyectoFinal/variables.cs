using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Variables
    {
        public double Demanda { get; set; }
        public double CantidadRequerida { get; set; }
        public int Fecha { get; set; }
        public int RateProduccion { get; set; }

        public Variables() { }
        public Variables(Variables v1)
        {
            Demanda = v1.Demanda;
            CantidadRequerida = v1.CantidadRequerida;
            Fecha = v1.Fecha;
            RateProduccion = v1.RateProduccion;

        }
    }
}
