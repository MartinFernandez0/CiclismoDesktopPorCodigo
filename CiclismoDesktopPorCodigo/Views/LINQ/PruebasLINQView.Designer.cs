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
            btnPruebaArray = new Button();
            btnPruebaSQL = new Button();
            btnPruebasXML = new Button();
            bntJSON = new Button();
            btnPruebaSelect = new Button();
            btnPruebaWhere = new Button();
            btnPruebaWhereAvanzado = new Button();
            txtFiltro = new TextBox();
            btnOrderBy = new Button();
            txtOrderByAvanzado = new Button();
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
            // btnPruebaArray
            // 
            btnPruebaArray.Location = new Point(41, 113);
            btnPruebaArray.Name = "btnPruebaArray";
            btnPruebaArray.Size = new Size(88, 40);
            btnPruebaArray.TabIndex = 1;
            btnPruebaArray.Text = "Prueba Array";
            btnPruebaArray.UseVisualStyleBackColor = true;
            btnPruebaArray.Click += btnPruebaArray_Click;
            // 
            // btnPruebaSQL
            // 
            btnPruebaSQL.Location = new Point(41, 63);
            btnPruebaSQL.Name = "btnPruebaSQL";
            btnPruebaSQL.Size = new Size(88, 40);
            btnPruebaSQL.TabIndex = 2;
            btnPruebaSQL.Text = "Prueba SQL";
            btnPruebaSQL.UseVisualStyleBackColor = true;
            btnPruebaSQL.Click += btnPruebaSQL_Click;
            // 
            // btnPruebasXML
            // 
            btnPruebasXML.Location = new Point(41, 12);
            btnPruebasXML.Name = "btnPruebasXML";
            btnPruebasXML.Size = new Size(88, 40);
            btnPruebasXML.TabIndex = 3;
            btnPruebasXML.Text = "Prueba XML";
            btnPruebasXML.UseVisualStyleBackColor = true;
            btnPruebasXML.Click += btnPruebasXML_Click;
            // 
            // bntJSON
            // 
            bntJSON.Location = new Point(154, 12);
            bntJSON.Name = "bntJSON";
            bntJSON.Size = new Size(88, 40);
            bntJSON.TabIndex = 4;
            bntJSON.Text = "Prueba JSON";
            bntJSON.UseVisualStyleBackColor = true;
            bntJSON.Click += bntJSON_Click;
            // 
            // btnPruebaSelect
            // 
            btnPruebaSelect.Location = new Point(154, 63);
            btnPruebaSelect.Name = "btnPruebaSelect";
            btnPruebaSelect.Size = new Size(88, 40);
            btnPruebaSelect.TabIndex = 5;
            btnPruebaSelect.Text = "Prueba Select";
            btnPruebaSelect.UseVisualStyleBackColor = true;
            btnPruebaSelect.Click += btnPruebaSelect_Click;
            // 
            // btnPruebaWhere
            // 
            btnPruebaWhere.Location = new Point(154, 113);
            btnPruebaWhere.Name = "btnPruebaWhere";
            btnPruebaWhere.Size = new Size(88, 40);
            btnPruebaWhere.TabIndex = 6;
            btnPruebaWhere.Text = "Prueba Where";
            btnPruebaWhere.UseVisualStyleBackColor = true;
            btnPruebaWhere.Click += btnPruebaWhere_Click;
            // 
            // btnPruebaWhereAvanzado
            // 
            btnPruebaWhereAvanzado.Location = new Point(262, 12);
            btnPruebaWhereAvanzado.Name = "btnPruebaWhereAvanzado";
            btnPruebaWhereAvanzado.Size = new Size(88, 40);
            btnPruebaWhereAvanzado.TabIndex = 7;
            btnPruebaWhereAvanzado.Text = "Prueba Where Avanzado";
            btnPruebaWhereAvanzado.UseVisualStyleBackColor = true;
            btnPruebaWhereAvanzado.Click += btnPruebaWhereAvanzado_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(461, 145);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(185, 23);
            txtFiltro.TabIndex = 8;
            // 
            // btnOrderBy
            // 
            btnOrderBy.Location = new Point(262, 63);
            btnOrderBy.Name = "btnOrderBy";
            btnOrderBy.Size = new Size(88, 40);
            btnOrderBy.TabIndex = 9;
            btnOrderBy.Text = "Prueba OrderBy";
            btnOrderBy.UseVisualStyleBackColor = true;
            btnOrderBy.Click += btnOrderBy_Click;
            // 
            // txtOrderByAvanzado
            // 
            txtOrderByAvanzado.Location = new Point(262, 113);
            txtOrderByAvanzado.Name = "txtOrderByAvanzado";
            txtOrderByAvanzado.Size = new Size(88, 40);
            txtOrderByAvanzado.TabIndex = 10;
            txtOrderByAvanzado.Text = "Prueba OrderBy Avanzado";
            txtOrderByAvanzado.UseVisualStyleBackColor = true;
            txtOrderByAvanzado.Click += txtOrderByAvanzado_Click;
            // 
            // PruebasLINQView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOrderByAvanzado);
            Controls.Add(btnOrderBy);
            Controls.Add(txtFiltro);
            Controls.Add(btnPruebaWhereAvanzado);
            Controls.Add(btnPruebaWhere);
            Controls.Add(btnPruebaSelect);
            Controls.Add(bntJSON);
            Controls.Add(btnPruebasXML);
            Controls.Add(btnPruebaSQL);
            Controls.Add(btnPruebaArray);
            Controls.Add(dataGridResultados);
            Name = "PruebasLINQView";
            Text = "PruebasLINQView";
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridResultados;
        private Button btnPruebaArray;
        private Button btnPruebaSQL;
        private Button btnPruebasXML;
        private Button bntJSON;
        private Button btnPruebaSelect;
        private Button btnPruebaWhere;
        private Button btnPruebaWhereAvanzado;
        private TextBox txtFiltro;
        private Button btnOrderBy;
        private Button txtOrderByAvanzado;
    }
}