﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace TallerFrankyUi
{
    public partial class FrmPrincipal : Form
    {
        Taller t1;
        public FrmPrincipal()
        {
            InitializeComponent();
            Taller t1 = new Taller();
            //TODO: Instanciar el taller
        }

        private void btnCargarBarco_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Preguntarle al usuario si esta seguro de salir del formulario
            Messagebox.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //TODO: Utilizar la clase XmlManager para guardar el archivo xml
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
