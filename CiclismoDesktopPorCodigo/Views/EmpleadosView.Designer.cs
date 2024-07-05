namespace CiclismoDesktopPorCodigo.Views
{
    partial class EmpleadosView
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
            dataGridEmpleados = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dataGridEmpleados
            // 
            dataGridEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleados.Location = new Point(60, 53);
            dataGridEmpleados.Name = "dataGridEmpleados";
            dataGridEmpleados.Size = new Size(681, 278);
            dataGridEmpleados.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(648, 357);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 41);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(318, 357);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 41);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "El&iminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(189, 357);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 41);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(60, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 41);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridEmpleados);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "EmpleadosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion Empleados";
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridEmpleados;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
    }
}