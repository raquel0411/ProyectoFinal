using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Ambiente1
    {
        public Ambiente1() { }
        public object Maquina1 { get; private set; }
        public void LlenarDatosAletoriosMaq1(int NumeroDatos, List<Variables>Maquina1,int limiteInferior, int limiteSuperior)
        {
            Random aleatorios = new Random(Environment.TickCount);
            for (int i = 0; i < NumeroDatos; i++)
            {
                double value = (double)aleatorios.NextDouble();
                int value4 = aleatorios.Next(limiteInferior, limiteSuperior);
                Variables variables = new Variables();
                variables.RateProduccion = value4;
                Maquina1.Add(variables);

            }
        }
        public object Demanda { get; private set; }
        public void LLenarDatosAleatoriosDem(int NumeroDatos,List<Variables>Demanda,int limiteInferior, int limiteSuperior)
        {
            Random aleatorios = new Random(Environment.TickCount);
            for (int i = 0; i < NumeroDatos; i++)
            {
                double value = (double)aleatorios.NextDouble();
                double value1 = aleatorios.Next(limiteInferior, limiteSuperior);
                double value2 = aleatorios.Next(limiteInferior, limiteSuperior);
                int value3 = aleatorios.Next(limiteInferior, limiteSuperior);
                Variables variables = new Variables();
                variables.Demanda = value1;
                variables.CantidadRequerida = value2;
                variables.Fecha = value3;
                Demanda.Add(variables);

            }


        }

        
            



    }
    
}
