namespace Ejercicio03Fer.Windows
{
    partial class frmCuadrado
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
            label1 = new Label();
            txtLado = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 46);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el valor del lado:";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(191, 43);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(147, 23);
            txtLado.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.ok_24px;
            btnOk.Location = new Point(54, 119);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 48);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(263, 119);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 180);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtLado);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(409, 219);
            MinimizeBox = false;
            MinimumSize = new Size(409, 219);
            Name = "frmCuadrado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculos de un cuadrado";
            FormClosing += frmCuadrado_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLado;
        private Button btnOk;
        private Button btnCancelar;
    }
}