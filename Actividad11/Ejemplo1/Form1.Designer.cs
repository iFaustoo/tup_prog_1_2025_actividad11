namespace WinFormsApp1
{
    partial class Mostrar
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(492, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 0;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Mostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 607);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Mostrar";
            Text = "Form 1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
