using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFrankyUI
{
    public partial class FrmModificar : Form
    {
        Barco barcoModificar;

        public Barco BarcoModificar { get => barcoModificar; set => barcoModificar = value; }

        public FrmModificar(Barco barcoModificar)
        {
            InitializeComponent();
            this.barcoModificar = barcoModificar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool estadoReparadoBarco = false;

            int costoBarco = int.Parse(txtCosto.Text);
            int tripulacionBarco = int.Parse(txtTripulacion.Text);
            string estadoReparado = cmbEstadoReparado.Text;
            string operacion = cmbOperacion.Text;

            if(estadoReparado == "Si")
            {
                estadoReparadoBarco = true;
            }

            Enum.TryParse(operacion, out EOperacion operacionBarco);

            if(barcoModificar is Marina)
            {
                BarcoModificar = new Marina(estadoReparadoBarco, barcoModificar.Nombre, operacionBarco, tripulacionBarco);
                BarcoModificar.Costo = costoBarco;
            }
            else
            {
                BarcoModificar = new Pirata(estadoReparadoBarco, barcoModificar.Nombre, operacionBarco, tripulacionBarco);
                BarcoModificar.Costo = costoBarco;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }
    }
}
