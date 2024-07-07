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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosView));
            dataGridEmpleados = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // dataGridEmpleados
            // 
            dataGridEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEmpleados.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleados.Location = new Point(60, 53);
            dataGridEmpleados.Name = "dataGridEmpleados";
            dataGridEmpleados.ReadOnly = true;
            dataGridEmpleados.Size = new Size(681, 278);
            dataGridEmpleados.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(639, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 41);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Atras";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(309, 381);
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
            btnEditar.Location = new Point(180, 381);
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
            btnAgregar.Location = new Point(51, 381);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 41);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Bottom;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(496, 340);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(72, 98);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 59;
            pictureBox6.TabStop = false;
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox6);
            Controls.Add(dataGridEmpleados);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "EmpleadosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Empleados";
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridEmpleados;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private PictureBox pictureBox6;
    }
}