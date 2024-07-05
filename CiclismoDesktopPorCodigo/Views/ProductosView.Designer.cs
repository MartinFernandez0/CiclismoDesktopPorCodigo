namespace CiclismoDesktopPorCodigo.Views
{
    partial class ProductosView
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
            dataGridProductos = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // dataGridProductos
            // 
            dataGridProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Location = new Point(60, 53);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.Size = new Size(681, 278);
            dataGridProductos.TabIndex = 19;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(639, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 41);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(309, 381);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 41);
            btnEliminar.TabIndex = 23;
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
            btnEditar.TabIndex = 22;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(51, 381);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 21;
            button1.Text = "&Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(button1);
            Controls.Add(dataGridProductos);
            Name = "ProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProductos;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button button1;
    }
}