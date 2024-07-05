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
            btnAgregar = new Button();
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(99, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridProductos);
            Name = "ProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProductos;
        private Button btnAgregar;
    }
}