namespace TallerFrankyUI
{
    partial class FrmModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnModificar = new Button();
            txtCosto = new TextBox();
            txtTripulacion = new TextBox();
            cmbEstadoReparado = new ComboBox();
            cmbOperacion = new ComboBox();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(125, 267);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(113, 12);
            txtCosto.Name = "txtCosto";
            txtCosto.PlaceholderText = "Costo";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 2;
            // 
            // txtTripulacion
            // 
            txtTripulacion.Location = new Point(113, 56);
            txtTripulacion.Name = "txtTripulacion";
            txtTripulacion.PlaceholderText = "Tripulacion";
            txtTripulacion.Size = new Size(100, 23);
            txtTripulacion.TabIndex = 4;
            // 
            // cmbEstadoReparado
            // 
            cmbEstadoReparado.FormattingEnabled = true;
            cmbEstadoReparado.Items.AddRange(new object[] { "Si", "No" });
            cmbEstadoReparado.Location = new Point(12, 117);
            cmbEstadoReparado.Name = "cmbEstadoReparado";
            cmbEstadoReparado.Size = new Size(121, 23);
            cmbEstadoReparado.TabIndex = 5;
            cmbEstadoReparado.Text = "¿Esta reparado?";
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "Reparar_Mastil", "Pintar", "Cambiar_Velas", "Reparar_Mascaron", "Reparar_Casco", "Recargar_Cañones" });
            cmbOperacion.Location = new Point(214, 117);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 6;
            cmbOperacion.Text = "Operacion";
            // 
            // FrmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 345);
            Controls.Add(cmbOperacion);
            Controls.Add(cmbEstadoReparado);
            Controls.Add(txtTripulacion);
            Controls.Add(txtCosto);
            Controls.Add(btnModificar);
            Name = "FrmModificar";
            Text = "FrmModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private TextBox txtCosto;
        private TextBox txtTripulacion;
        private ComboBox cmbEstadoReparado;
        private ComboBox cmbOperacion;
    }
}