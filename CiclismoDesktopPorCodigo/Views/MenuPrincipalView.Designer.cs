namespace CiclismoDesktopPorCodigo
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalView));
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionarEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            gestionarProductosToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesStoredProcedureToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnEmpleado = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            button1 = new Button();
            btnTipoProducto = new Button();
            btnClienteSP = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(788, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarClientesToolStripMenuItem, gestionarEmpleadosToolStripMenuItem, gestionarProductosToolStripMenuItem, gestionarClientesStoredProcedureToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(65, 20);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            gestionarClientesToolStripMenuItem.Size = new Size(271, 22);
            gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            gestionarClientesToolStripMenuItem.Click += gestionarClientesToolStripMenuItem_Click;
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            gestionarEmpleadosToolStripMenuItem.Size = new Size(271, 22);
            gestionarEmpleadosToolStripMenuItem.Text = "Gestionar Empleados";
            gestionarEmpleadosToolStripMenuItem.Click += gestionarEmpleadosToolStripMenuItem_Click;
            // 
            // gestionarProductosToolStripMenuItem
            // 
            gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            gestionarProductosToolStripMenuItem.Size = new Size(271, 22);
            gestionarProductosToolStripMenuItem.Text = "Gestionar Productos";
            gestionarProductosToolStripMenuItem.Click += gestionarProductosToolStripMenuItem_Click;
            // 
            // gestionarClientesStoredProcedureToolStripMenuItem
            // 
            gestionarClientesStoredProcedureToolStripMenuItem.Name = "gestionarClientesStoredProcedureToolStripMenuItem";
            gestionarClientesStoredProcedureToolStripMenuItem.Size = new Size(271, 22);
            gestionarClientesStoredProcedureToolStripMenuItem.Text = "Gestionar Clientes (Stored Procedure)";
            gestionarClientesStoredProcedureToolStripMenuItem.Click += gestionarClientesStoredProcedureToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(158, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(290, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 161);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(546, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 149);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Anchor = AnchorStyles.Bottom;
            btnEmpleado.BackColor = Color.MediumSeaGreen;
            btnEmpleado.Font = new Font("Segoe UI", 10F);
            btnEmpleado.Location = new Point(94, 222);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(114, 51);
            btnEmpleado.TabIndex = 54;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnClientes
            // 
            btnClientes.Anchor = AnchorStyles.Bottom;
            btnClientes.BackColor = Color.MediumSeaGreen;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.Location = new Point(329, 222);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(114, 51);
            btnClientes.TabIndex = 55;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Anchor = AnchorStyles.Bottom;
            btnProductos.BackColor = Color.MediumSeaGreen;
            btnProductos.Font = new Font("Segoe UI", 10F);
            btnProductos.Location = new Point(538, 222);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(114, 51);
            btnProductos.TabIndex = 56;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(662, 394);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 57;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTipoProducto
            // 
            btnTipoProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTipoProducto.BackColor = Color.MediumSeaGreen;
            btnTipoProducto.Font = new Font("Segoe UI", 10F);
            btnTipoProducto.Location = new Point(538, 279);
            btnTipoProducto.Name = "btnTipoProducto";
            btnTipoProducto.Size = new Size(114, 51);
            btnTipoProducto.TabIndex = 63;
            btnTipoProducto.Text = "&Tipos Productos";
            btnTipoProducto.UseVisualStyleBackColor = false;
            btnTipoProducto.Click += btnTipoProducto_Click;
            // 
            // btnClienteSP
            // 
            btnClienteSP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClienteSP.BackColor = Color.MediumSeaGreen;
            btnClienteSP.Font = new Font("Segoe UI", 10F);
            btnClienteSP.Location = new Point(329, 279);
            btnClienteSP.Name = "btnClienteSP";
            btnClienteSP.Size = new Size(114, 51);
            btnClienteSP.TabIndex = 64;
            btnClienteSP.Text = "Procedimiento Almacenado";
            btnClienteSP.UseVisualStyleBackColor = false;
            btnClienteSP.Click += btnClienteSP_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.pexels_alscre_28476481;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(788, 450);
            Controls.Add(btnClienteSP);
            Controls.Add(btnTipoProducto);
            Controls.Add(button1);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Controls.Add(btnEmpleado);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ciclismo Desktop por code";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem gestionarEmpleadosToolStripMenuItem;
        private ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnEmpleado;
        private Button btnClientes;
        private Button btnProductos;
        private Button button1;
        private Button btnTipoProducto;
        private ToolStripMenuItem gestionarClientesStoredProcedureToolStripMenuItem;
        private Button btnClienteSP;
    }
}
