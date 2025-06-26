namespace Ejemplo2
{
    partial class FormPrincipal
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
            btnRegistrar = new Button();
            label1 = new Label();
            tbValor = new TextBox();
            lbPromedio = new Label();
            btnPromedio = new Button();
            tbPromedio = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(268, 31);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 32);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 1;
            label1.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(100, 31);
            tbValor.Margin = new Padding(4);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(127, 29);
            tbValor.TabIndex = 2;
            tbValor.TextChanged += tbValor_TextChanged;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(100, 95);
            lbPromedio.Margin = new Padding(4, 0, 4, 0);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(91, 21);
            lbPromedio.TabIndex = 3;
            lbPromedio.Text = "lbPromedio";
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(268, 72);
            btnPromedio.Margin = new Padding(4);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(96, 67);
            btnPromedio.TabIndex = 4;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(15, 158);
            tbPromedio.Margin = new Padding(4);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(349, 99);
            tbPromedio.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 289);
            Controls.Add(tbPromedio);
            Controls.Add(btnPromedio);
            Controls.Add(lbPromedio);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Ejemplo2. Sin vectores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label label1;
        private TextBox tbValor;
        private Label lbPromedio;
        private Button btnPromedio;
        private TextBox tbPromedio;
    }
}
