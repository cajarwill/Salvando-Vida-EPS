namespace Fase3WilsonCastro
{
    partial class frmEstructurasDatos
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            label12 = new Label();
            dtFechadeAcceso = new DateTimePicker();
            label11 = new Label();
            groupBox2 = new GroupBox();
            rdExamendeLaboratorio = new RadioButton();
            rdMedicinaGeneral = new RadioButton();
            txtEdad = new TextBox();
            label10 = new Label();
            txtNrodeIdentificacion = new TextBox();
            label9 = new Label();
            txtReportedeDatos = new TextBox();
            boxTipodeEstructura = new ComboBox();
            txtValordelCopago = new TextBox();
            boxEstratoSocioeconomico = new ComboBox();
            txtNombreCompleto = new TextBox();
            boxTipodeIdentificacion = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabEstructuras = new TabControl();
            tabControl = new TabPage();
            btnEliminarPila = new Button();
            btnReportePila = new Button();
            dgPila = new DataGridView();
            tabPage2 = new TabPage();
            btnEliminarCola = new Button();
            btnReporteCola = new Button();
            dgCola = new DataGridView();
            tabPage3 = new TabPage();
            btnEliminarLista = new Button();
            btnReporteLista = new Button();
            dgLista = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabEstructuras.SuspendLayout();
            tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPila).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCola).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 30);
            label1.Name = "label1";
            label1.Size = new Size(285, 15);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE REGISTRO DE USUARIOS EN CENTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(358, 57);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "EPS Salvando Vidas";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dtFechadeAcceso);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtNrodeIdentificacion);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtReportedeDatos);
            groupBox1.Controls.Add(boxTipodeEstructura);
            groupBox1.Controls.Add(txtValordelCopago);
            groupBox1.Controls.Add(boxEstratoSocioeconomico);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(boxTipodeIdentificacion);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(24, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 258);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(646, 208);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(544, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(434, 208);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(485, 240);
            label12.Name = "label12";
            label12.Size = new Size(258, 15);
            label12.TabIndex = 19;
            label12.Text = "Los campos marcados con (*) son obligatorios.";
            // 
            // dtFechadeAcceso
            // 
            dtFechadeAcceso.Format = DateTimePickerFormat.Short;
            dtFechadeAcceso.Location = new Point(581, 169);
            dtFechadeAcceso.Name = "dtFechadeAcceso";
            dtFechadeAcceso.Size = new Size(140, 23);
            dtFechadeAcceso.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(434, 175);
            label11.Name = "label11";
            label11.Size = new Size(104, 15);
            label11.TabIndex = 17;
            label11.Text = "*Fecha de acceso:";
            label11.Click += label11_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdExamendeLaboratorio);
            groupBox2.Controls.Add(rdMedicinaGeneral);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(434, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 44);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "*Tipo de atención";
            // 
            // rdExamendeLaboratorio
            // 
            rdExamendeLaboratorio.AutoSize = true;
            rdExamendeLaboratorio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdExamendeLaboratorio.Location = new Point(137, 19);
            rdExamendeLaboratorio.Name = "rdExamendeLaboratorio";
            rdExamendeLaboratorio.Size = new Size(144, 19);
            rdExamendeLaboratorio.TabIndex = 1;
            rdExamendeLaboratorio.TabStop = true;
            rdExamendeLaboratorio.Text = "Examen de laboratorio";
            rdExamendeLaboratorio.UseVisualStyleBackColor = true;
            rdExamendeLaboratorio.CheckedChanged += rdExamendeLaboratorio_CheckedChanged;
            // 
            // rdMedicinaGeneral
            // 
            rdMedicinaGeneral.AutoSize = true;
            rdMedicinaGeneral.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdMedicinaGeneral.Location = new Point(6, 19);
            rdMedicinaGeneral.Name = "rdMedicinaGeneral";
            rdMedicinaGeneral.Size = new Size(116, 19);
            rdMedicinaGeneral.TabIndex = 0;
            rdMedicinaGeneral.TabStop = true;
            rdMedicinaGeneral.Text = "Medicina general";
            rdMedicinaGeneral.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(581, 78);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(140, 23);
            txtEdad.TabIndex = 15;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(432, 81);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 14;
            label10.Text = "*Edad:";
            // 
            // txtNrodeIdentificacion
            // 
            txtNrodeIdentificacion.Location = new Point(581, 40);
            txtNrodeIdentificacion.Name = "txtNrodeIdentificacion";
            txtNrodeIdentificacion.Size = new Size(140, 23);
            txtNrodeIdentificacion.TabIndex = 13;
            txtNrodeIdentificacion.KeyPress += txtNrodeIdentificacion_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(432, 43);
            label9.Name = "label9";
            label9.Size = new Size(134, 15);
            label9.TabIndex = 12;
            label9.Text = "*Nro. de identificación:";
            // 
            // txtReportedeDatos
            // 
            txtReportedeDatos.Enabled = false;
            txtReportedeDatos.Location = new Point(178, 204);
            txtReportedeDatos.Name = "txtReportedeDatos";
            txtReportedeDatos.Size = new Size(175, 23);
            txtReportedeDatos.TabIndex = 11;
            // 
            // boxTipodeEstructura
            // 
            boxTipodeEstructura.FormattingEnabled = true;
            boxTipodeEstructura.Location = new Point(178, 167);
            boxTipodeEstructura.Name = "boxTipodeEstructura";
            boxTipodeEstructura.Size = new Size(175, 23);
            boxTipodeEstructura.TabIndex = 10;
            // 
            // txtValordelCopago
            // 
            txtValordelCopago.Enabled = false;
            txtValordelCopago.Location = new Point(178, 137);
            txtValordelCopago.Name = "txtValordelCopago";
            txtValordelCopago.Size = new Size(175, 23);
            txtValordelCopago.TabIndex = 9;
            // 
            // boxEstratoSocioeconomico
            // 
            boxEstratoSocioeconomico.FormattingEnabled = true;
            boxEstratoSocioeconomico.Location = new Point(178, 105);
            boxEstratoSocioeconomico.Name = "boxEstratoSocioeconomico";
            boxEstratoSocioeconomico.Size = new Size(175, 23);
            boxEstratoSocioeconomico.Sorted = true;
            boxEstratoSocioeconomico.TabIndex = 8;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(178, 73);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(175, 23);
            txtNombreCompleto.TabIndex = 7;
            // 
            // boxTipodeIdentificacion
            // 
            boxTipodeIdentificacion.FormattingEnabled = true;
            boxTipodeIdentificacion.Location = new Point(178, 35);
            boxTipodeIdentificacion.Name = "boxTipodeIdentificacion";
            boxTipodeIdentificacion.Size = new Size(175, 23);
            boxTipodeIdentificacion.Sorted = true;
            boxTipodeIdentificacion.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 212);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 5;
            label8.Text = "Reporte de datos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 175);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 4;
            label7.Text = "*Tipo de estructura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 145);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 3;
            label6.Text = "Valor del copago:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 113);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 2;
            label5.Text = "*Estrato socioeconómico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 81);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 1;
            label4.Text = "*Nombre completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 43);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 0;
            label3.Text = "*Tipo de identificación:";
            // 
            // tabEstructuras
            // 
            tabEstructuras.Controls.Add(tabControl);
            tabEstructuras.Controls.Add(tabPage2);
            tabEstructuras.Controls.Add(tabPage3);
            tabEstructuras.Location = new Point(28, 337);
            tabEstructuras.Name = "tabEstructuras";
            tabEstructuras.SelectedIndex = 0;
            tabEstructuras.Size = new Size(746, 98);
            tabEstructuras.TabIndex = 4;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(btnEliminarPila);
            tabControl.Controls.Add(btnReportePila);
            tabControl.Controls.Add(dgPila);
            tabControl.Location = new Point(4, 24);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Padding(3);
            tabControl.Size = new Size(738, 70);
            tabControl.TabIndex = 0;
            tabControl.Text = "Pila";
            tabControl.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPila
            // 
            btnEliminarPila.Location = new Point(657, 41);
            btnEliminarPila.Name = "btnEliminarPila";
            btnEliminarPila.Size = new Size(75, 23);
            btnEliminarPila.TabIndex = 24;
            btnEliminarPila.Text = "Eliminar";
            btnEliminarPila.UseVisualStyleBackColor = true;
            btnEliminarPila.Click += btnEliminarPila_Click;
            // 
            // btnReportePila
            // 
            btnReportePila.Location = new Point(657, 7);
            btnReportePila.Name = "btnReportePila";
            btnReportePila.Size = new Size(75, 23);
            btnReportePila.TabIndex = 23;
            btnReportePila.Text = "Reporte";
            btnReportePila.UseVisualStyleBackColor = true;
            btnReportePila.Click += btnReportePila_Click;
            // 
            // dgPila
            // 
            dgPila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPila.Location = new Point(6, 6);
            dgPila.Name = "dgPila";
            dgPila.RowTemplate.Height = 25;
            dgPila.Size = new Size(645, 58);
            dgPila.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEliminarCola);
            tabPage2.Controls.Add(btnReporteCola);
            tabPage2.Controls.Add(dgCola);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(738, 70);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cola";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCola
            // 
            btnEliminarCola.Location = new Point(657, 41);
            btnEliminarCola.Name = "btnEliminarCola";
            btnEliminarCola.Size = new Size(75, 23);
            btnEliminarCola.TabIndex = 27;
            btnEliminarCola.Text = "Eliminar";
            btnEliminarCola.UseVisualStyleBackColor = true;
            btnEliminarCola.Click += btnEliminarCola_Click;
            // 
            // btnReporteCola
            // 
            btnReporteCola.Location = new Point(657, 7);
            btnReporteCola.Name = "btnReporteCola";
            btnReporteCola.Size = new Size(75, 23);
            btnReporteCola.TabIndex = 26;
            btnReporteCola.Text = "Reporte";
            btnReporteCola.UseVisualStyleBackColor = true;
            btnReporteCola.Click += btnReporteCola_Click;
            // 
            // dgCola
            // 
            dgCola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCola.Location = new Point(6, 6);
            dgCola.Name = "dgCola";
            dgCola.RowTemplate.Height = 25;
            dgCola.Size = new Size(645, 58);
            dgCola.TabIndex = 25;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnEliminarLista);
            tabPage3.Controls.Add(btnReporteLista);
            tabPage3.Controls.Add(dgLista);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(738, 70);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lista";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLista
            // 
            btnEliminarLista.Location = new Point(657, 41);
            btnEliminarLista.Name = "btnEliminarLista";
            btnEliminarLista.Size = new Size(75, 23);
            btnEliminarLista.TabIndex = 30;
            btnEliminarLista.Text = "Eliminar";
            btnEliminarLista.UseVisualStyleBackColor = true;
            btnEliminarLista.Click += btnEliminarLista_Click;
            // 
            // btnReporteLista
            // 
            btnReporteLista.Location = new Point(657, 7);
            btnReporteLista.Name = "btnReporteLista";
            btnReporteLista.Size = new Size(75, 23);
            btnReporteLista.TabIndex = 29;
            btnReporteLista.Text = "Reporte";
            btnReporteLista.UseVisualStyleBackColor = true;
            btnReporteLista.Click += btnReporteLista_Click;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(6, 6);
            dgLista.Name = "dgLista";
            dgLista.RowTemplate.Height = 25;
            dgLista.Size = new Size(645, 58);
            dgLista.TabIndex = 28;
            // 
            // frmEstructurasDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tabEstructuras);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEstructurasDatos";
            Text = "EstructurasDatos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabEstructuras.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPila).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCola).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtReportedeDatos;
        private ComboBox boxTipodeEstructura;
        private TextBox txtValordelCopago;
        private ComboBox boxEstratoSocioeconomico;
        private TextBox txtNombreCompleto;
        private ComboBox boxTipodeIdentificacion;
        private GroupBox groupBox2;
        private RadioButton rdExamendeLaboratorio;
        private RadioButton rdMedicinaGeneral;
        private TextBox txtEdad;
        private Label label10;
        private TextBox txtNrodeIdentificacion;
        private Label label9;
        private Label label11;
        private DateTimePicker dtFechadeAcceso;
        private Label label12;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private TabControl tabEstructuras;
        private TabPage tabControl;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnEliminarPila;
        private Button btnReportePila;
        private DataGridView dataGridView1;
        private Button btnEliminarCola;
        private Button btnReporteCola;
        private DataGridView dataGridView2;
        private Button button1;
        private Button btnReporteLista;
        private DataGridView dataGridView3;
        private DataGridView dgPila;
        private DataGridView dgCola;
        private Button btnEliminarLista;
        private DataGridView dgLista;
    }
}