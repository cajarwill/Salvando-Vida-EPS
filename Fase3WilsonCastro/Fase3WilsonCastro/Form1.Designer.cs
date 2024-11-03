namespace Fase3WilsonCastro
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label3 = new Label();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            itemIniciarSesion = new ToolStripMenuItem();
            itemAcercaDe = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(570, 236);
            label3.Name = "label3";
            label3.Size = new Size(191, 15);
            label3.TabIndex = 2;
            label3.Text = "Digite la contraseña para el ingreso";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(587, 273);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(144, 23);
            txtClave.TabIndex = 3;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(545, 328);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(87, 26);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(683, 328);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 26);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(513, 64);
            label4.Name = "label4";
            label4.Size = new Size(285, 15);
            label4.TabIndex = 9;
            label4.Text = "SISTEMA DE REGISTRO DE USUARIOS EN CENTRO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(597, 95);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 10;
            label5.Text = "EPS Salvando Vidas";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemIniciarSesion, itemAcercaDe });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemIniciarSesion
            // 
            itemIniciarSesion.Name = "itemIniciarSesion";
            itemIniciarSesion.Size = new Size(87, 20);
            itemIniciarSesion.Text = "Iniciar sesión";
            itemIniciarSesion.Click += itemIniciarSesion_Click;
            // 
            // itemAcercaDe
            // 
            itemAcercaDe.Name = "itemAcercaDe";
            itemAcercaDe.Size = new Size(71, 20);
            itemAcercaDe.Text = "Acerca de";
            itemAcercaDe.Click += itemAcercaDe_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Inicio de sesión";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemIniciarSesion;
        private ToolStripMenuItem itemAcercaDe;
    }
}
