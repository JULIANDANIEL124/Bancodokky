
namespace dokky_2
{
    partial class Registre
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
            nombreTextBox = new TextBox();
            ContraseñaTextBox = new TextBox();
            GmailTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            LugarTextBox = new TextBox();
            EdadTextBox = new TextBox();
            Registrar = new Button();
            volver = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bindingSource1 = new BindingSource(components);
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(203, 92);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(360, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // ContraseñaTextBox
            // 
            ContraseñaTextBox.Location = new Point(203, 147);
            ContraseñaTextBox.Name = "ContraseñaTextBox";
            ContraseñaTextBox.Size = new Size(360, 23);
            ContraseñaTextBox.TabIndex = 1;
            // 
            // GmailTextBox
            // 
            GmailTextBox.Location = new Point(203, 201);
            GmailTextBox.Name = "GmailTextBox";
            GmailTextBox.Size = new Size(360, 23);
            GmailTextBox.TabIndex = 2;
            GmailTextBox.TextChanged += GmailTextBox_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(203, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // LugarTextBox
            // 
            LugarTextBox.Location = new Point(203, 363);
            LugarTextBox.Name = "LugarTextBox";
            LugarTextBox.Size = new Size(360, 23);
            LugarTextBox.TabIndex = 4;
            LugarTextBox.TextChanged += LugarTextBox_TextChanged;
            // 
            // EdadTextBox
            // 
            EdadTextBox.Location = new Point(203, 309);
            EdadTextBox.Name = "EdadTextBox";
            EdadTextBox.Size = new Size(360, 23);
            EdadTextBox.TabIndex = 5;
            // 
            // Registrar
            // 
            Registrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrar.Location = new Point(122, 431);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(208, 60);
            Registrar.TabIndex = 6;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // volver
            // 
            volver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volver.ForeColor = SystemColors.ActiveCaptionText;
            volver.Location = new Point(460, 431);
            volver.Name = "volver";
            volver.Size = new Size(188, 60);
            volver.TabIndex = 7;
            volver.Text = "Volver";
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 64);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 9;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(324, 119);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 10;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 173);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 11;
            label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 227);
            label4.Name = "label4";
            label4.Size = new Size(193, 25);
            label4.TabIndex = 12;
            label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(350, 281);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 13;
            label5.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(292, 335);
            label6.Name = "label6";
            label6.Size = new Size(178, 25);
            label6.TabIndex = 14;
            label6.Text = "Pais de nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(262, 9);
            label7.Name = "label7";
            label7.Size = new Size(241, 32);
            label7.TabIndex = 15;
            label7.Text = "Bienvenido a Dokky";
            // 
            // Registre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(746, 520);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(volver);
            Controls.Add(Registrar);
            Controls.Add(EdadTextBox);
            Controls.Add(LugarTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(GmailTextBox);
            Controls.Add(ContraseñaTextBox);
            Controls.Add(nombreTextBox);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Registre";
            Text = "registre";
            Load += Registre_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox nombreTextBox;
        private TextBox ContraseñaTextBox;
        private TextBox GmailTextBox;
        private DateTimePicker dateTimePicker1;
        private TextBox LugarTextBox;
        private TextBox EdadTextBox;
        private Button Registrar;
        private Button volver;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private EventHandler label6_Click;
        private BindingSource bindingSource1;
        private Label label7;
    }
}