using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
    public class Auto
    {
        private int numeroregistro;
        private string modelo;
        public double precio {  get; set; }
        public Auto(int registro, string modelo)
        {
            this.numeroregistro = registro;
            this.modelo = modelo;
        }
        public int nroregistro()
        {
            return numeroregistro;
        }
        public override string ToString()
        {
            return $"{numeroregistro};{modelo}";
        }
    }
}
