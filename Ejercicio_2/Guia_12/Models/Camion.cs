using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    public class Camion
    {
        private Stack<Auto> transporte = new Stack<Auto>();
        private DateTime fecha;
        private int cantidad;
        private double valorasegurado;
        public int NroRegistro { get; set; }
        public Camion(DateTime fecha, int cantidad)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
        }
        public void cargarvehiculo(Auto unauto)
        {
            if (transporte.Count < cantidad)
            {
                transporte.Push(unauto);
            }
        }
        public Auto retirarvehiculo()
        {
            if (transporte.Count > 0)
            {
                return eliminado = transporte.Pop();
            }
            return null;
        }
    }
}
