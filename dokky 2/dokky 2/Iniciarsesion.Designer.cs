

namespace dokky_2
{
    partial class Iniciarsesion
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
            usuariotextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ContraseñatextBox = new TextBox();
            inisiarsecion = new Button();
            volver = new Button();
            SuspendLayout();
            // 
            // usuariotextBox
            // 
            usuariotextBox.Location = new Point(149, 55);
            usuariotextBox.Name = "usuariotextBox";
            usuariotextBox.Size = new Size(243, 23);
            usuariotextBox.TabIndex = 0;
            usuariotextBox.TextChanged += usuariotextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 50);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 110);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // ContraseñatextBox
            // 
            ContraseñatextBox.Location = new Point(156, 115);
            ContraseñatextBox.Name = "ContraseñatextBox";
            ContraseñatextBox.Size = new Size(243, 23);
            ContraseñatextBox.TabIndex = 3;
            ContraseñatextBox.TextChanged += ContraseñatextBox_TextChanged;
            // 
            // inisiarsecion
            // 
            inisiarsecion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inisiarsecion.Location = new Point(26, 187);
            inisiarsecion.Name = "inisiarsecion";
            inisiarsecion.Size = new Size(136, 59);
            inisiarsecion.TabIndex = 4;
            inisiarsecion.Text = "Iniciar";
            inisiarsecion.UseVisualStyleBackColor = true;
            inisiarsecion.Click += inisiarsecion_Click_1;
            // 
            // volver
            // 
            volver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volver.Location = new Point(255, 187);
            volver.Name = "volver";
            volver.Size = new Size(144, 59);
            volver.TabIndex = 5;
            volver.Text = "Volver";
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // Iniciarsesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(429, 316);
            Controls.Add(volver);
            Controls.Add(inisiarsecion);
            Controls.Add(ContraseñatextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usuariotextBox);
            Name = "Iniciarsesion";
            Text = "Iniciarsesion";
            ResumeLayout(false);
            PerformLayout();
        }

      
     
        private void ContraseñatextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void usuariotextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private TextBox usuariotextBox;
        private Label label1;
        private Label label2;
        private TextBox ContraseñatextBox;
        private Button inisiarsecion;
        private Button volver;
    }
}