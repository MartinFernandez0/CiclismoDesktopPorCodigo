namespace CiclismoDesktopPorCodigo.Views.New_Edit
{
    partial class NuevoEditarClienteStoredProcedureView
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtApellidoContacto = new TextBox();
            label3 = new Label();
            txtNombreContacto = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 217);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 44);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(111, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 44);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellidoContacto
            // 
            txtApellidoContacto.Location = new Point(175, 109);
            txtApellidoContacto.Name = "txtApellidoContacto";
            txtApellidoContacto.Size = new Size(239, 23);
            txtApellidoContacto.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 112);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 40;
            label3.Text = "Apellido Contacto:";
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Location = new Point(175, 67);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(239, 23);
            txtNombreContacto.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 38;
            label2.Text = "Nombre Contacto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(239, 23);
            txtNombre.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 36;
            label1.Text = "Nombre:";
            // 
            // NuevoEditarClienteStoredProcedureView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 297);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellidoContacto);
            Controls.Add(label3);
            Controls.Add(txtNombreContacto);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "NuevoEditarClienteStoredProcedureView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion SP Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtApellidoContacto;
        private Label label3;
        private TextBox txtNombreContacto;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}