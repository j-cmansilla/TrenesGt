namespace TeMueveGt
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grupoConfiguracion = new System.Windows.Forms.GroupBox();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVagones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadTrenes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grupoCreacionDeTrenes = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioSi = new System.Windows.Forms.RadioButton();
            this.btnCrearTren = new System.Windows.Forms.Button();
            this.grupoReservarComprar = new System.Windows.Forms.GroupBox();
            this.btnDisponiblidad = new System.Windows.Forms.Button();
            this.radioComprar = new System.Windows.Forms.RadioButton();
            this.radioReservar = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grupoDisponibilidad = new System.Windows.Forms.GroupBox();
            this.txtAsientosDisponiblesReporte = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.txtPrecioAhorro = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPrecioLujo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadVagonesDeLujo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupoDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnImprimirOCancelar = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.grupoCantidadDeAsientos = new System.Windows.Forms.GroupBox();
            this.txtAsientosDeLujoSeleccionados = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAsientosDeAhorroSeleccionados = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAsientosReservados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAsientosComprados = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bigTextBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grupoConfiguracion.SuspendLayout();
            this.grupoCreacionDeTrenes.SuspendLayout();
            this.grupoReservarComprar.SuspendLayout();
            this.grupoDisponibilidad.SuspendLayout();
            this.grupoDatosCliente.SuspendLayout();
            this.grupoCantidadDeAsientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoConfiguracion
            // 
            this.grupoConfiguracion.Controls.Add(this.txtPrecioLujo);
            this.grupoConfiguracion.Controls.Add(this.label23);
            this.grupoConfiguracion.Controls.Add(this.txtPrecioAhorro);
            this.grupoConfiguracion.Controls.Add(this.label22);
            this.grupoConfiguracion.Controls.Add(this.txtAsientos);
            this.grupoConfiguracion.Controls.Add(this.label4);
            this.grupoConfiguracion.Controls.Add(this.txtFilas);
            this.grupoConfiguracion.Controls.Add(this.label3);
            this.grupoConfiguracion.Controls.Add(this.txtVagones);
            this.grupoConfiguracion.Controls.Add(this.label2);
            this.grupoConfiguracion.Controls.Add(this.label1);
            this.grupoConfiguracion.Controls.Add(this.txtCantidadTrenes);
            this.grupoConfiguracion.Controls.Add(this.button1);
            this.grupoConfiguracion.Location = new System.Drawing.Point(13, 13);
            this.grupoConfiguracion.Name = "grupoConfiguracion";
            this.grupoConfiguracion.Size = new System.Drawing.Size(171, 209);
            this.grupoConfiguracion.TabIndex = 0;
            this.grupoConfiguracion.TabStop = false;
            this.grupoConfiguracion.Text = "Configuración inicial";
            this.grupoConfiguracion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(105, 93);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(54, 20);
            this.txtAsientos.TabIndex = 8;
            this.txtAsientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsientos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asientos por fila:";
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(105, 69);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(54, 20);
            this.txtFilas.TabIndex = 6;
            this.txtFilas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filas por vagon:";
            // 
            // txtVagones
            // 
            this.txtVagones.Location = new System.Drawing.Point(105, 43);
            this.txtVagones.Name = "txtVagones";
            this.txtVagones.Size = new System.Drawing.Size(54, 20);
            this.txtVagones.TabIndex = 4;
            this.txtVagones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vagones por tren:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de trenes:";
            // 
            // txtCantidadTrenes
            // 
            this.txtCantidadTrenes.Location = new System.Drawing.Point(105, 19);
            this.txtCantidadTrenes.Name = "txtCantidadTrenes";
            this.txtCantidadTrenes.Size = new System.Drawing.Size(54, 20);
            this.txtCantidadTrenes.TabIndex = 1;
            this.txtCantidadTrenes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadTrenes_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grupoCreacionDeTrenes
            // 
            this.grupoCreacionDeTrenes.Controls.Add(this.label5);
            this.grupoCreacionDeTrenes.Controls.Add(this.txtCantidadVagonesDeLujo);
            this.grupoCreacionDeTrenes.Controls.Add(this.label6);
            this.grupoCreacionDeTrenes.Controls.Add(this.radioNo);
            this.grupoCreacionDeTrenes.Controls.Add(this.radioSi);
            this.grupoCreacionDeTrenes.Controls.Add(this.btnCrearTren);
            this.grupoCreacionDeTrenes.Enabled = false;
            this.grupoCreacionDeTrenes.Location = new System.Drawing.Point(190, 13);
            this.grupoCreacionDeTrenes.Name = "grupoCreacionDeTrenes";
            this.grupoCreacionDeTrenes.Size = new System.Drawing.Size(284, 152);
            this.grupoCreacionDeTrenes.TabIndex = 1;
            this.grupoCreacionDeTrenes.TabStop = false;
            this.grupoCreacionDeTrenes.Text = "Creación de trenes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tren de lujo:";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(47, 62);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 12;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioSi
            // 
            this.radioSi.AutoSize = true;
            this.radioSi.Location = new System.Drawing.Point(9, 62);
            this.radioSi.Name = "radioSi";
            this.radioSi.Size = new System.Drawing.Size(34, 17);
            this.radioSi.TabIndex = 11;
            this.radioSi.TabStop = true;
            this.radioSi.Text = "Si";
            this.radioSi.UseVisualStyleBackColor = true;
            this.radioSi.CheckedChanged += new System.EventHandler(this.radioSi_CheckedChanged);
            // 
            // btnCrearTren
            // 
            this.btnCrearTren.Location = new System.Drawing.Point(7, 118);
            this.btnCrearTren.Name = "btnCrearTren";
            this.btnCrearTren.Size = new System.Drawing.Size(271, 23);
            this.btnCrearTren.TabIndex = 0;
            this.btnCrearTren.Text = "Crear Tren";
            this.btnCrearTren.UseVisualStyleBackColor = true;
            this.btnCrearTren.Click += new System.EventHandler(this.button2_Click);
            // 
            // grupoReservarComprar
            // 
            this.grupoReservarComprar.Controls.Add(this.btnDisponiblidad);
            this.grupoReservarComprar.Controls.Add(this.grupoDatosCliente);
            this.grupoReservarComprar.Controls.Add(this.radioComprar);
            this.grupoReservarComprar.Controls.Add(this.radioReservar);
            this.grupoReservarComprar.Controls.Add(this.label7);
            this.grupoReservarComprar.Enabled = false;
            this.grupoReservarComprar.Location = new System.Drawing.Point(13, 245);
            this.grupoReservarComprar.Name = "grupoReservarComprar";
            this.grupoReservarComprar.Size = new System.Drawing.Size(461, 266);
            this.grupoReservarComprar.TabIndex = 2;
            this.grupoReservarComprar.TabStop = false;
            this.grupoReservarComprar.Text = "Reservar/Comprar";
            // 
            // btnDisponiblidad
            // 
            this.btnDisponiblidad.Location = new System.Drawing.Point(187, 25);
            this.btnDisponiblidad.Name = "btnDisponiblidad";
            this.btnDisponiblidad.Size = new System.Drawing.Size(261, 25);
            this.btnDisponiblidad.TabIndex = 22;
            this.btnDisponiblidad.Text = "Verificar Disponibilidad";
            this.btnDisponiblidad.UseVisualStyleBackColor = true;
            this.btnDisponiblidad.Click += new System.EventHandler(this.btnDisponiblidad_Click);
            // 
            // radioComprar
            // 
            this.radioComprar.AutoSize = true;
            this.radioComprar.Location = new System.Drawing.Point(81, 33);
            this.radioComprar.Name = "radioComprar";
            this.radioComprar.Size = new System.Drawing.Size(64, 17);
            this.radioComprar.TabIndex = 16;
            this.radioComprar.TabStop = true;
            this.radioComprar.Text = "Comprar";
            this.radioComprar.UseVisualStyleBackColor = true;
            // 
            // radioReservar
            // 
            this.radioReservar.AutoSize = true;
            this.radioReservar.Location = new System.Drawing.Point(7, 33);
            this.radioReservar.Name = "radioReservar";
            this.radioReservar.Size = new System.Drawing.Size(68, 17);
            this.radioReservar.TabIndex = 15;
            this.radioReservar.TabStop = true;
            this.radioReservar.Text = "Reservar";
            this.radioReservar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Operación:";
            // 
            // grupoDisponibilidad
            // 
            this.grupoDisponibilidad.Controls.Add(this.txtAsientosComprados);
            this.grupoDisponibilidad.Controls.Add(this.label11);
            this.grupoDisponibilidad.Controls.Add(this.txtAsientosReservados);
            this.grupoDisponibilidad.Controls.Add(this.label8);
            this.grupoDisponibilidad.Controls.Add(this.txtAsientosDisponiblesReporte);
            this.grupoDisponibilidad.Controls.Add(this.label17);
            this.grupoDisponibilidad.Enabled = false;
            this.grupoDisponibilidad.Location = new System.Drawing.Point(480, 13);
            this.grupoDisponibilidad.Name = "grupoDisponibilidad";
            this.grupoDisponibilidad.Size = new System.Drawing.Size(305, 152);
            this.grupoDisponibilidad.TabIndex = 3;
            this.grupoDisponibilidad.TabStop = false;
            this.grupoDisponibilidad.Text = "Disponibilidad Del Tren";
            // 
            // txtAsientosDisponiblesReporte
            // 
            this.txtAsientosDisponiblesReporte.Enabled = false;
            this.txtAsientosDisponiblesReporte.Location = new System.Drawing.Point(113, 23);
            this.txtAsientosDisponiblesReporte.Name = "txtAsientosDisponiblesReporte";
            this.txtAsientosDisponiblesReporte.Size = new System.Drawing.Size(183, 20);
            this.txtAsientosDisponiblesReporte.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Asientos disponibles:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(6, 81);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(218, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Enabled = false;
            this.btnCancelarCompra.Location = new System.Drawing.Point(6, 110);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(218, 23);
            this.btnCancelarCompra.TabIndex = 24;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // txtPrecioAhorro
            // 
            this.txtPrecioAhorro.Location = new System.Drawing.Point(105, 118);
            this.txtPrecioAhorro.Name = "txtPrecioAhorro";
            this.txtPrecioAhorro.Size = new System.Drawing.Size(54, 20);
            this.txtPrecioAhorro.TabIndex = 10;
            this.txtPrecioAhorro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioAhorro_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Precio Ahorro:";
            // 
            // txtPrecioLujo
            // 
            this.txtPrecioLujo.Location = new System.Drawing.Point(105, 141);
            this.txtPrecioLujo.Name = "txtPrecioLujo";
            this.txtPrecioLujo.Size = new System.Drawing.Size(54, 20);
            this.txtPrecioLujo.TabIndex = 12;
            this.txtPrecioLujo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioLujo_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 141);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Precio Lujo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vagones de lujo:";
            // 
            // txtCantidadVagonesDeLujo
            // 
            this.txtCantidadVagonesDeLujo.Enabled = false;
            this.txtCantidadVagonesDeLujo.Location = new System.Drawing.Point(195, 38);
            this.txtCantidadVagonesDeLujo.Name = "txtCantidadVagonesDeLujo";
            this.txtCantidadVagonesDeLujo.Size = new System.Drawing.Size(54, 20);
            this.txtCantidadVagonesDeLujo.TabIndex = 13;
            this.txtCantidadVagonesDeLujo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadVagonesDeLujo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(55, 27);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(380, 20);
            this.txtNombreCliente.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "DPI:";
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(55, 53);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(380, 20);
            this.txtDPI.TabIndex = 17;
            this.txtDPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(6, 123);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(429, 23);
            this.btnContinuar.TabIndex = 18;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(429, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grupoDatosCliente
            // 
            this.grupoDatosCliente.Controls.Add(this.btnCancelarReserva);
            this.grupoDatosCliente.Controls.Add(this.btnImprimirOCancelar);
            this.grupoDatosCliente.Controls.Add(this.btnCancelar);
            this.grupoDatosCliente.Controls.Add(this.btnContinuar);
            this.grupoDatosCliente.Controls.Add(this.txtDPI);
            this.grupoDatosCliente.Controls.Add(this.label10);
            this.grupoDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grupoDatosCliente.Controls.Add(this.label9);
            this.grupoDatosCliente.Location = new System.Drawing.Point(7, 68);
            this.grupoDatosCliente.Name = "grupoDatosCliente";
            this.grupoDatosCliente.Size = new System.Drawing.Size(441, 181);
            this.grupoDatosCliente.TabIndex = 17;
            this.grupoDatosCliente.TabStop = false;
            this.grupoDatosCliente.Text = "Datos Del Cliente";
            // 
            // btnImprimirOCancelar
            // 
            this.btnImprimirOCancelar.Enabled = false;
            this.btnImprimirOCancelar.Location = new System.Drawing.Point(6, 94);
            this.btnImprimirOCancelar.Name = "btnImprimirOCancelar";
            this.btnImprimirOCancelar.Size = new System.Drawing.Size(207, 23);
            this.btnImprimirOCancelar.TabIndex = 20;
            this.btnImprimirOCancelar.Text = "Imprimir";
            this.btnImprimirOCancelar.UseVisualStyleBackColor = true;
            this.btnImprimirOCancelar.Click += new System.EventHandler(this.btnImprimirOCancelar_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Enabled = false;
            this.btnCancelarReserva.Location = new System.Drawing.Point(219, 94);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(216, 23);
            this.btnCancelarReserva.TabIndex = 21;
            this.btnCancelarReserva.Text = "Cancelar Reservación";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // grupoCantidadDeAsientos
            // 
            this.grupoCantidadDeAsientos.Controls.Add(this.txtAsientosDeLujoSeleccionados);
            this.grupoCantidadDeAsientos.Controls.Add(this.btnConfirmar);
            this.grupoCantidadDeAsientos.Controls.Add(this.btnCancelarCompra);
            this.grupoCantidadDeAsientos.Controls.Add(this.label12);
            this.grupoCantidadDeAsientos.Controls.Add(this.label13);
            this.grupoCantidadDeAsientos.Controls.Add(this.txtAsientosDeAhorroSeleccionados);
            this.grupoCantidadDeAsientos.Enabled = false;
            this.grupoCantidadDeAsientos.Location = new System.Drawing.Point(480, 259);
            this.grupoCantidadDeAsientos.Name = "grupoCantidadDeAsientos";
            this.grupoCantidadDeAsientos.Size = new System.Drawing.Size(262, 152);
            this.grupoCantidadDeAsientos.TabIndex = 25;
            this.grupoCantidadDeAsientos.TabStop = false;
            this.grupoCantidadDeAsientos.Text = "Cantidad de asientos";
            // 
            // txtAsientosDeLujoSeleccionados
            // 
            this.txtAsientosDeLujoSeleccionados.Location = new System.Drawing.Point(113, 43);
            this.txtAsientosDeLujoSeleccionados.Name = "txtAsientosDeLujoSeleccionados";
            this.txtAsientosDeLujoSeleccionados.Size = new System.Drawing.Size(111, 20);
            this.txtAsientosDeLujoSeleccionados.TabIndex = 16;
            this.txtAsientosDeLujoSeleccionados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsientosDeLujoSeleccionados_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Asientos de lujo:";
            // 
            // txtAsientosDeAhorroSeleccionados
            // 
            this.txtAsientosDeAhorroSeleccionados.Location = new System.Drawing.Point(112, 20);
            this.txtAsientosDeAhorroSeleccionados.Name = "txtAsientosDeAhorroSeleccionados";
            this.txtAsientosDeAhorroSeleccionados.Size = new System.Drawing.Size(112, 20);
            this.txtAsientosDeAhorroSeleccionados.TabIndex = 14;
            this.txtAsientosDeAhorroSeleccionados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsientosDeAhorroSeleccionados_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Asientos de ahorro:";
            // 
            // txtAsientosReservados
            // 
            this.txtAsientosReservados.Enabled = false;
            this.txtAsientosReservados.Location = new System.Drawing.Point(113, 47);
            this.txtAsientosReservados.Name = "txtAsientosReservados";
            this.txtAsientosReservados.Size = new System.Drawing.Size(183, 20);
            this.txtAsientosReservados.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Asientos reservados:";
            // 
            // txtAsientosComprados
            // 
            this.txtAsientosComprados.Enabled = false;
            this.txtAsientosComprados.Location = new System.Drawing.Point(113, 73);
            this.txtAsientosComprados.Name = "txtAsientosComprados";
            this.txtAsientosComprados.Size = new System.Drawing.Size(183, 20);
            this.txtAsientosComprados.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Asientos comprados:";
            // 
            // bigTextBox
            // 
            this.bigTextBox.Location = new System.Drawing.Point(749, 279);
            this.bigTextBox.Name = "bigTextBox";
            this.bigTextBox.ReadOnly = true;
            this.bigTextBox.Size = new System.Drawing.Size(425, 243);
            this.bigTextBox.TabIndex = 26;
            this.bigTextBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(749, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "SALIDA:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 534);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bigTextBox);
            this.Controls.Add(this.grupoCantidadDeAsientos);
            this.Controls.Add(this.grupoDisponibilidad);
            this.Controls.Add(this.grupoReservarComprar);
            this.Controls.Add(this.grupoCreacionDeTrenes);
            this.Controls.Add(this.grupoConfiguracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Te mueve";
            this.grupoConfiguracion.ResumeLayout(false);
            this.grupoConfiguracion.PerformLayout();
            this.grupoCreacionDeTrenes.ResumeLayout(false);
            this.grupoCreacionDeTrenes.PerformLayout();
            this.grupoReservarComprar.ResumeLayout(false);
            this.grupoReservarComprar.PerformLayout();
            this.grupoDisponibilidad.ResumeLayout(false);
            this.grupoDisponibilidad.PerformLayout();
            this.grupoDatosCliente.ResumeLayout(false);
            this.grupoDatosCliente.PerformLayout();
            this.grupoCantidadDeAsientos.ResumeLayout(false);
            this.grupoCantidadDeAsientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoConfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadTrenes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVagones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupoCreacionDeTrenes;
        private System.Windows.Forms.Button btnCrearTren;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grupoReservarComprar;
        private System.Windows.Forms.RadioButton radioComprar;
        private System.Windows.Forms.RadioButton radioReservar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDisponiblidad;
        private System.Windows.Forms.GroupBox grupoDisponibilidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtAsientosDisponiblesReporte;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.TextBox txtPrecioLujo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPrecioAhorro;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadVagonesDeLujo;
        private System.Windows.Forms.GroupBox grupoDatosCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImprimirOCancelar;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.GroupBox grupoCantidadDeAsientos;
        private System.Windows.Forms.TextBox txtAsientosDeLujoSeleccionados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAsientosDeAhorroSeleccionados;
        private System.Windows.Forms.TextBox txtAsientosComprados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAsientosReservados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox bigTextBox;
        private System.Windows.Forms.Label label14;
    }
}

