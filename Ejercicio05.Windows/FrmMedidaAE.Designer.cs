namespace Ejercicio05.Windows
{
    partial class FrmMedidaAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TxtMedida = new TextBox();
            BtnOk = new Button();
            BtnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 41);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Medida (en metros):";
            // 
            // TxtMedida
            // 
            TxtMedida.Location = new Point(139, 33);
            TxtMedida.Name = "TxtMedida";
            TxtMedida.Size = new Size(100, 23);
            TxtMedida.TabIndex = 1;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(20, 94);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 49);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(196, 94);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 49);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmMedidaAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 177);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOk);
            Controls.Add(TxtMedida);
            Controls.Add(label1);
            Name = "FrmMedidaAE";
            Text = "FrmMedidaAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtMedida;
        private Button BtnOk;
        private Button BtnCancelar;
        private ErrorProvider errorProvider1;
    }
}