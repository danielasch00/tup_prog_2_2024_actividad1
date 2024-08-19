using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Moto
    {
        readonly string marca;
        readonly int modelo;
        readonly double valorFabricacion;

        public string Marca { get {return this.marca; }}
        public int Modelo { get { return this.modelo; } }
        public double ValorFabricacion { get { return this.valorFabricacion; } }

        public Moto (string marca, int modelo, double valorFabricacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.valorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            return 0;
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            return 0;
        }

        public string VerDescripcion()
        {
            return "";
        }
    }
}
