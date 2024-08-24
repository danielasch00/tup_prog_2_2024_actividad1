using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Consecionaria : Form
    {
        Moto moto;
        public Consecionaria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            fVerResultados verResultados = new fVerResultados();
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nudModelo.Value);
            double valorFabricacion = Convert.ToDouble(tbValor.Text);
            moto = new Moto(marca, modelo, valorFabricacion);

            int añoACalcular = Convert.ToInt32(nudACalcular.Value);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);
            double tasaDepreciacion = Convert.ToDouble(tbTasa.Text);

            MessageBox.Show(moto.VerDescripcion(moto.CalcularDepreciacionLineal(añoACalcular, vidaUtil), moto.CalcularDepreciacionAnual(añoACalcular, tasaDepreciacion)));

        }
    }
}
