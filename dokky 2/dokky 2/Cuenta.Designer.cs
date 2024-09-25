namespace dokky_2
{
    partial class CuentaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            nombreLabel = new Label();
            saldoLabel = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            button6 = new Button();
            label6 = new Label();
            label7 = new Label();
            Salir = new Button();
            SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(12, 9);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(21, 25);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "*";
            nombreLabel.Click += nombreLabel_Click;
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saldoLabel.Location = new Point(240, 27);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new Size(21, 25);
            saldoLabel.TabIndex = 1;
            saldoLabel.Text = "*";
            saldoLabel.Click += saldoLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 27);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 2;
            label1.Text = "CA";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(192, 81);
            button1.Name = "button1";
            button1.Size = new Size(70, 51);
            button1.TabIndex = 3;
            button1.Text = "<--\r\n-->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 135);
            label2.Name = "label2";
            label2.Size = new Size(55, 30);
            label2.TabIndex = 4;
            label2.Text = "Transferir\r\ndinero\r\n";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(282, 81);
            button2.Name = "button2";
            button2.Size = new Size(75, 51);
            button2.TabIndex = 5;
            button2.Text = "📝​​\r\n";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(379, 81);
            button3.Name = "button3";
            button3.Size = new Size(75, 51);
            button3.TabIndex = 6;
            button3.Text = "💸​";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(192, 168);
            button4.Name = "button4";
            button4.Size = new Size(70, 61);
            button4.TabIndex = 7;
            button4.Text = "👉​💴​\r\n";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 138);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 8;
            label3.Text = "Pago de\r\nservicios\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 138);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 9;
            label4.Text = "Extraer sin \r\ntarjeta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 232);
            label5.Name = "label5";
            label5.Size = new Size(49, 30);
            label5.TabIndex = 10;
            label5.Text = "Ingresar\r\ndinero\r\n";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(282, 168);
            button5.Name = "button5";
            button5.Size = new Size(70, 61);
            button5.TabIndex = 11;
            button5.Text = "📈​";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(379, 171);
            button6.Name = "button6";
            button6.Size = new Size(70, 58);
            button6.TabIndex = 12;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 232);
            label6.Name = "label6";
            label6.Size = new Size(55, 30);
            label6.TabIndex = 13;
            label6.Text = "Inversiòn\r\nRapida";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 232);
            label7.Name = "label7";
            label7.Size = new Size(48, 30);
            label7.TabIndex = 14;
            label7.Text = "Mostrar\r\nMàs";
            // 
            // Salir
            // 
            Salir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salir.Location = new Point(12, 268);
            Salir.Name = "Salir";
            Salir.Size = new Size(82, 45);
            Salir.TabIndex = 15;
            Salir.Text = "Salir de \r\nla cuenta";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // CuentaForm
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(474, 325);
            Controls.Add(Salir);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(saldoLabel);
            Controls.Add(nombreLabel);
            Name = "CuentaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label saldoLabel;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button5;
        private Button button6;
        private Label label6;
        private Label label7;
        private Button Salir;
    }
}
