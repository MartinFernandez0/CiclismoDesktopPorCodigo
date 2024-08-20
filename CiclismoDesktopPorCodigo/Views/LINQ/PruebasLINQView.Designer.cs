namespace CiclismoDesktopPorCodigo.Views.LINQ
{
    partial class PruebasLINQView
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
            dataGridResultados = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).BeginInit();
            SuspendLayout();
            // 
            // dataGridResultados
            // 
            dataGridResultados.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultados.Location = new Point(121, 185);
            dataGridResultados.Name = "dataGridResultados";
            dataGridResultados.Size = new Size(534, 233);
            dataGridResultados.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(41, 113);
            button1.Name = "button1";
            button1.Size = new Size(88, 40);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // PruebasLINQView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridResultados);
            Name = "PruebasLINQView";
            Text = "PruebasLINQView";
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridResultados;
        private Button button1;
    }
}