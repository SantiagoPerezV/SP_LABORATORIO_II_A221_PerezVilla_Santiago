namespace TallerFrankyUi
{
    partial class FrmReparacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReparacion));
            lstTaller = new ListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lstTaller
            // 
            lstTaller.FormattingEnabled = true;
            lstTaller.ItemHeight = 15;
            lstTaller.Location = new Point(201, 134);
            lstTaller.Margin = new Padding(4, 3, 4, 3);
            lstTaller.Name = "lstTaller";
            lstTaller.Size = new Size(694, 274);
            lstTaller.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(584, 427);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 45);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(788, 427);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(185, 45);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1142, 632);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lstTaller);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReparacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReparacion";
            FormClosing += FrmReparacion_FormClosing;
            Load += FrmReparacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstTaller;
        private Button btnEliminar;
        private Button btnModificar;
    }
}

