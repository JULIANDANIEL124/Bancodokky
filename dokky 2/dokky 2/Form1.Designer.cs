
namespace dokky_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            iniciarsesion = new Button();
            label3 = new Label();
            Registrarse = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 32);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al banco Dokky";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 247);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(322, 50);
            label2.TabIndex = 1;
            label2.Text = "Esta opcion sirve mas que nada si\r\n ya te registrate anterior mente.";
            // 
            // iniciarsesion
            // 
            iniciarsesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniciarsesion.Location = new Point(347, 314);
            iniciarsesion.Margin = new Padding(4);
            iniciarsesion.Name = "iniciarsesion";
            iniciarsesion.Size = new Size(176, 70);
            iniciarsesion.TabIndex = 2;
            iniciarsesion.Text = "Iniciar Cuenta";
            iniciarsesion.UseVisualStyleBackColor = true;
            iniciarsesion.Click += iniciarsesion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-4, 247);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(315, 50);
            label3.TabIndex = 3;
            label3.Text = "Esta opcion sirve para poder \r\nregistrate en nuesta plata forma\r\n";
            // 
            // Registrarse
            // 
            Registrarse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrarse.Location = new Point(67, 314);
            Registrarse.Name = "Registrarse";
            Registrarse.Size = new Size(179, 67);
            Registrarse.TabIndex = 4;
            Registrarse.Text = "Registrarse";
            Registrarse.UseVisualStyleBackColor = true;
            Registrarse.Click += Registrarse_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(612, 316);
            button1.Name = "button1";
            button1.Size = new Size(176, 67);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 439);
            Controls.Add(button1);
            Controls.Add(Registrarse);
            Controls.Add(label3);
            Controls.Add(iniciarsesion);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Button iniciarsesion;
        private Label label3;
        private Button Registrarse;
        private Button button1;
    }
}
