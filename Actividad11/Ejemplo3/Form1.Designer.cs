namespace Ejemplo3
{
    partial class Form1
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
            tbPromedio = new TextBox();
            btnPromedio = new Button();
            lbPromedio = new Label();
            tbValor = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(34, 171);
            tbPromedio.Margin = new Padding(4);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(349, 99);
            tbPromedio.TabIndex = 11;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(287, 85);
            btnPromedio.Margin = new Padding(4);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(96, 67);
            btnPromedio.TabIndex = 10;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(119, 108);
            lbPromedio.Margin = new Padding(4, 0, 4, 0);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(69, 15);
            lbPromedio.TabIndex = 9;
            lbPromedio.Text = "lbPromedio";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(119, 44);
            tbValor.Margin = new Padding(4);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(127, 23);
            tbValor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 7;
            label1.Text = "Valor";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(287, 44);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 32);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 292);
            Controls.Add(tbPromedio);
            Controls.Add(btnPromedio);
            Controls.Add(lbPromedio);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPromedio;
        private Button btnPromedio;
        private Label lbPromedio;
        private TextBox tbValor;
        private Label label1;
        private Button btnRegistrar;
    }
}
