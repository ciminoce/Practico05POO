namespace Ejercicio05.Windows
{
    partial class FrmMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedidas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            TsbNuevo = new ToolStripButton();
            TsbBorrar = new ToolStripButton();
            TsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbSalir = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colMedida = new DataGridViewTextBoxColumn();
            TxtSuma = new TextBox();
            label2 = new Label();
            TxtCantidad = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbBorrar, TsbEditar, toolStripSeparator1, TsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(345, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = (Image)resources.GetObject("TsbNuevo.Image");
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(46, 35);
            TsbNuevo.Text = "Nuevo";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevo.Click += TsbNuevo_Click;
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = (Image)resources.GetObject("TsbBorrar.Image");
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(43, 35);
            TsbBorrar.Text = "Borrar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbEditar
            // 
            TsbEditar.Image = (Image)resources.GetObject("TsbEditar.Image");
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(41, 35);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // TsbSalir
            // 
            TsbSalir.Image = (Image)resources.GetObject("TsbSalir.Image");
            TsbSalir.ImageTransparentColor = Color.Magenta;
            TsbSalir.Name = "TsbSalir";
            TsbSalir.Size = new Size(33, 35);
            TsbSalir.Text = "Salir";
            TsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbSalir.Click += TsbSalir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 38);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtSuma);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(TxtCantidad);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(345, 412);
            splitContainer1.SplitterDistance = 294;
            splitContainer1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMedida });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(345, 294);
            dgvDatos.TabIndex = 0;
            // 
            // colMedida
            // 
            colMedida.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMedida.HeaderText = "Medida (en Mts.)";
            colMedida.Name = "colMedida";
            colMedida.ReadOnly = true;
            // 
            // TxtSuma
            // 
            TxtSuma.Location = new Point(79, 47);
            TxtSuma.Name = "TxtSuma";
            TxtSuma.ReadOnly = true;
            TxtSuma.Size = new Size(100, 23);
            TxtSuma.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 50);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Suma:";
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(79, 18);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.ReadOnly = true;
            TxtCantidad.Size = new Size(100, 23);
            TxtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad:";
            // 
            // FrmMedidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmMedidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Medidas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbBorrar;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbSalir;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colMedida;
        private TextBox TxtSuma;
        private Label label2;
        private TextBox TxtCantidad;
        private Label label1;
    }
}
