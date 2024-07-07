using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using TallerFrankyUI;

namespace TallerFrankyUi
{
    public partial class FrmReparacion : Form
    {
        Taller tallerForm;
        CrudBarco crudBarco;
        public FrmReparacion(Taller tallerForm)
        {
            InitializeComponent();
            this.tallerForm = tallerForm;
            crudBarco = new CrudBarco();
        }

        private void FrmReparacion_Load(object sender, EventArgs e)
        {
            //TODO: Asocio el evento que va a imprimir el ticket
            //TODO: Instanciar y comenzar el hilo que se va a encargar de reparar los barcos del taller
            lstTaller.DataSource = this.tallerForm.Barcos;
        }

        private void FrmReparacion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lblBarcoTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = lstTaller.SelectedIndex;
            Barco barcoSeleccionado = this.tallerForm.Barcos[index];
            crudBarco.EliminarBarco(barcoSeleccionado.Nombre);

            this.tallerForm.Barcos = crudBarco.SeleccionarBarcos();
            lstTaller.DataSource = this.tallerForm.Barcos;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = lstTaller.SelectedIndex;
            Barco barcoSeleccionado = this.tallerForm.Barcos[index];
            FrmModificar frmModificar = new FrmModificar(barcoSeleccionado);
            if (frmModificar.ShowDialog() == DialogResult.OK)
            {
                crudBarco.ModificarBarco(frmModificar.BarcoModificar);
                this.tallerForm.Barcos = crudBarco.SeleccionarBarcos();
                lstTaller.DataSource = this.tallerForm.Barcos;
            }
        }
    }
}
