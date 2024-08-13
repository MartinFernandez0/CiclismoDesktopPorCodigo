namespace CiclismoDesktopPorCodigo.Views.New_Edit
{
    partial class NuevoEditarTipoProductoView
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
            txtDescripcionTipoProducto = new TextBox();
            label2 = new Label();
            txtNombreTipoProducto = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtDescripcionTipoProducto
            // 
            txtDescripcionTipoProducto.Location = new Point(44, 105);
            txtDescripcionTipoProducto.Multiline = true;
            txtDescripcionTipoProducto.Name = "txtDescripcionTipoProducto";
            txtDescripcionTipoProducto.Size = new Size(211, 23);
            txtDescripcionTipoProducto.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 87);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 46;
            label2.Text = "Descripción:";
            // 
            // txtNombreTipoProducto
            // 
            txtNombreTipoProducto.Location = new Point(44, 52);
            txtNombreTipoProducto.Multiline = true;
            txtNombreTipoProducto.Name = "txtNombreTipoProducto";
            txtNombreTipoProducto.Size = new Size(211, 23);
            txtNombreTipoProducto.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 34);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 44;
            label1.Text = "Nombre del Tipo de producto:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(159, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 44);
            btnCancelar.TabIndex = 55;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(23, 174);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 44);
            btnGuardar.TabIndex = 54;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // NuevoEditarTipoProductoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 230);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcionTipoProducto);
            Controls.Add(label2);
            Controls.Add(txtNombreTipoProducto);
            Controls.Add(label1);
            Name = "NuevoEditarTipoProductoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion tipo de productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcionTipoProducto;
        private Label label2;
        private TextBox txtNombreTipoProducto;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}