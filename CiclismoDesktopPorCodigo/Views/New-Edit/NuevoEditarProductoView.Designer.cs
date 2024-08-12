namespace CiclismoDesktopPorCodigo.Views.New___Edit
{
    partial class NuevoEditarProductoView
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
            txtTallaProducto = new TextBox();
            label3 = new Label();
            txtColorProducto = new TextBox();
            label2 = new Label();
            txtNombreProducto = new TextBox();
            label1 = new Label();
            txtClaseProducto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMFProducto = new TextBox();
            label6 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            numericUpDownPrecioProducto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioProducto).BeginInit();
            SuspendLayout();
            // 
            // txtTallaProducto
            // 
            txtTallaProducto.Location = new Point(58, 146);
            txtTallaProducto.Multiline = true;
            txtTallaProducto.Name = "txtTallaProducto";
            txtTallaProducto.Size = new Size(211, 23);
            txtTallaProducto.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 129);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 44;
            label3.Text = "Talla:";
            // 
            // txtColorProducto
            // 
            txtColorProducto.Location = new Point(58, 98);
            txtColorProducto.Multiline = true;
            txtColorProducto.Name = "txtColorProducto";
            txtColorProducto.Size = new Size(211, 23);
            txtColorProducto.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 80);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 42;
            label2.Text = "Color:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(58, 45);
            txtNombreProducto.Multiline = true;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(211, 23);
            txtNombreProducto.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 27);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 40;
            label1.Text = "Nombre del producto:";
            // 
            // txtClaseProducto
            // 
            txtClaseProducto.Location = new Point(58, 295);
            txtClaseProducto.Multiline = true;
            txtClaseProducto.Name = "txtClaseProducto";
            txtClaseProducto.Size = new Size(211, 23);
            txtClaseProducto.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 277);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 50;
            label4.Text = "Clase Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 229);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 48;
            label5.Text = "Precio $:";
            // 
            // txtMFProducto
            // 
            txtMFProducto.Location = new Point(58, 194);
            txtMFProducto.Multiline = true;
            txtMFProducto.Name = "txtMFProducto";
            txtMFProducto.Size = new Size(211, 23);
            txtMFProducto.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 176);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 46;
            label6.Text = "M y F";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(170, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 44);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(34, 389);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 44);
            btnGuardar.TabIndex = 52;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numericUpDownPrecioProducto
            // 
            numericUpDownPrecioProducto.Location = new Point(99, 247);
            numericUpDownPrecioProducto.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownPrecioProducto.Name = "numericUpDownPrecioProducto";
            numericUpDownPrecioProducto.Size = new Size(120, 23);
            numericUpDownPrecioProducto.TabIndex = 54;
            // 
            // NuevoEditarProductoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 450);
            Controls.Add(numericUpDownPrecioProducto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtClaseProducto);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtMFProducto);
            Controls.Add(label6);
            Controls.Add(txtTallaProducto);
            Controls.Add(label3);
            Controls.Add(txtColorProducto);
            Controls.Add(label2);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Name = "NuevoEditarProductoView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Editar Producto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTallaProducto;
        private Label label3;
        private TextBox txtColorProducto;
        private Label label2;
        private TextBox txtNombreProducto;
        private Label label1;
        private TextBox txtClaseProducto;
        private Label label4;
        private Label label5;
        private TextBox txtMFProducto;
        private Label label6;
        private Button btnCancelar;
        private Button btnGuardar;
        private NumericUpDown numericUpDownPrecioProducto;
    }
}