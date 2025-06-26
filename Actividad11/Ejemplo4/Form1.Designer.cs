namespace Ejemplo4
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
            btmOrdenar = new Button();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(27, 269);
            tbPromedio.Margin = new Padding(5, 6, 5, 6);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(448, 137);
            tbPromedio.TabIndex = 17;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(352, 76);
            btnPromedio.Margin = new Padding(5, 6, 5, 6);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(123, 94);
            btnPromedio.TabIndex = 16;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(136, 108);
            lbPromedio.Margin = new Padding(5, 0, 5, 0);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(91, 21);
            lbPromedio.TabIndex = 15;
            lbPromedio.Text = "lbPromedio";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(136, 18);
            tbValor.Margin = new Padding(5, 6, 5, 6);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(162, 29);
            tbValor.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 22);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 13;
            label1.Text = "Valor";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(352, 18);
            btnRegistrar.Margin = new Padding(5, 6, 5, 6);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(123, 45);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btmOrdenar
            // 
            btmOrdenar.Location = new Point(484, 280);
            btmOrdenar.Margin = new Padding(4);
            btmOrdenar.Name = "btmOrdenar";
            btmOrdenar.Size = new Size(96, 32);
            btmOrdenar.TabIndex = 18;
            btmOrdenar.Text = "Ordenar";
            btmOrdenar.UseVisualStyleBackColor = true;
            btmOrdenar.Click += btmOrdenar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(39, 230);
            tbBuscar.Margin = new Padding(5, 6, 5, 6);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(162, 29);
            tbBuscar.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(231, 212);
            btnBuscar.Margin = new Padding(5, 6, 5, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(123, 45);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 447);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(btmOrdenar);
            Controls.Add(tbPromedio);
            Controls.Add(btnPromedio);
            Controls.Add(lbPromedio);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
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
        private Button btmOrdenar;
        private TextBox tbBuscar;
        private Button btnBuscar;
    }
}
