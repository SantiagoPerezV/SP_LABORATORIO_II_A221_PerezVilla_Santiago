using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Clases.Excepciones;

namespace TallerFrankyUi
{
    public partial class FrmPrincipal : Form
    {
        Taller taller;
        XmlManager xml;
        public FrmPrincipal()
        {
            InitializeComponent();
            //TODO: Instanciar el taller
            taller = new Taller();
            xml = new XmlManager();
        }

        private void btnCargarBarco_Click(object sender, EventArgs e)
        {
            FrmBarco frmbarco = new FrmBarco();
            if (frmbarco.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    taller.IngresarBarco(frmbarco.BarcoForm);
                    StringBuilder sb = new StringBuilder();
                    foreach(Barco b in taller.Barcos)
                    {
                        sb.AppendLine($"{b.ToString()}");
                    }
                    MessageBox.Show(sb.ToString());
                }
                catch(BarcoEncontradoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            FrmReparacion frmReparacion = new FrmReparacion(taller);
            frmReparacion.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Preguntarle al usuario si esta seguro de salir del formulario
            var resultado = MessageBox.Show("¿Desea cerrar?", "Confirmar", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //TODO: Utilizar la clase XmlManager para guardar el archivo xml
            xml.Guardar(taller.Barcos);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists(".\\Barcos.xml"))
            {
                taller.Barcos = xml.Leer();
            }
        }
    }
}
