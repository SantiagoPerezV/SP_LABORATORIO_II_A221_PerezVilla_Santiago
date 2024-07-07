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

namespace TallerFrankyUi
{
    public partial class FrmBarco : Form
    {
        Barco barcoForm;

        public Barco BarcoForm
        {
            get => barcoForm;
        }

        public FrmBarco()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {

        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //TODO:Validar si el barco es pirata o marina y lo instancio
            // retornar DialogResult OK y cerrar el formulario

            string nombre = txtNombre.Text;
            string tipo = cmbTipo.Text;
            string operacion = cmbOperacion.Text;

            Enum.TryParse(tipo, out ETipoBarco tipoBarco);
            Enum.TryParse(operacion, out EOperacion operacionBarco);

            if(tipoBarco == ETipoBarco.Marina)
            {
                barcoForm = new Marina(false, nombre, operacionBarco, 0);
            }
            else
            {
                barcoForm = new Pirata(false, nombre, operacionBarco, 0);
            }

            this.DialogResult = DialogResult.OK;

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
