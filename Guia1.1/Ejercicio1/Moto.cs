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
            int añosDeUso = añoACalcular - this.modelo;
            double valorActualizado = this.valorFabricacion - (valorFabricacion * (añosDeUso / vidaUtil));
            return valorActualizado;
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            int añosDeUso = añoACalcular - this.modelo;
            double valorActualizado = this.valorFabricacion*Math.Pow(1-tasaDepreciacion,añosDeUso);
            return valorActualizado;
        }

        public string VerDescripcion(double depLineal, double depAnual)
        {
            string marcaModelo = "Marca: " + this.marca + ". Modelo: " + this.modelo;
            string valorFabricacion = "Valor fabricación: $" + this.valorFabricacion;
            string depreciacionLineal = "Depreciación lineal: $" + depLineal;
            string depreciacionAnual = "Depreciación lineal: $" + depAnual;

            return marcaModelo + "\n" + valorFabricacion + "\n" + depreciacionLineal + "\n" + depreciacionAnual;
        }
    }
}
