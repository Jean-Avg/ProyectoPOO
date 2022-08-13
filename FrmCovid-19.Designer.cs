
using System;

namespace Covid_19
{
    partial class FrmCovid19
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pickCovid19 = new System.Windows.Forms.PictureBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.TxtFechaActual = new System.Windows.Forms.TextBox();
            this.FechaActual = new System.Windows.Forms.Timer(this.components);
            this.btnCerrarA = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatosP = new System.Windows.Forms.TabPage();
            this.gbSintomas = new System.Windows.Forms.GroupBox();
            this.bntdiagnostico = new System.Windows.Forms.Button();
            this.lblLinea = new System.Windows.Forms.Label();
            this.btnresumir = new System.Windows.Forms.Button();
            this.chkIncapacidad = new System.Windows.Forms.CheckBox();
            this.chkDolor = new System.Windows.Forms.CheckBox();
            this.chkRespiracion = new System.Windows.Forms.CheckBox();
            this.chkCansancio = new System.Windows.Forms.CheckBox();
            this.chkFiebre = new System.Windows.Forms.CheckBox();
            this.chkTos = new System.Windows.Forms.CheckBox();
            this.lblSintomasGraves = new System.Windows.Forms.Label();
            this.lblSintomasBasicos = new System.Windows.Forms.Label();
            this.gbInformacionPacientes = new System.Windows.Forms.GroupBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.DtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.lblFechaN = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.RbOtro = new System.Windows.Forms.RadioButton();
            this.RbFemenino = new System.Windows.Forms.RadioButton();
            this.RbMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pickCovid19)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDatosP.SuspendLayout();
            this.gbSintomas.SuspendLayout();
            this.gbInformacionPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DIÁGNOSTICO DE PACIENTES";
            // 
            // pickCovid19
            // 
            this.pickCovid19.BackgroundImage = global::Covid_19.Properties.Resources.imagen_covid;
            this.pickCovid19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pickCovid19.Location = new System.Drawing.Point(397, 9);
            this.pickCovid19.Name = "pickCovid19";
            this.pickCovid19.Size = new System.Drawing.Size(217, 69);
            this.pickCovid19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickCovid19.TabIndex = 1;
            this.pickCovid19.TabStop = false;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(792, 63);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(89, 20);
            this.lblFechaActual.TabIndex = 2;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // TxtFechaActual
            // 
            this.TxtFechaActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtFechaActual.Enabled = false;
            this.TxtFechaActual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaActual.Location = new System.Drawing.Point(887, 60);
            this.TxtFechaActual.Name = "TxtFechaActual";
            this.TxtFechaActual.Size = new System.Drawing.Size(68, 26);
            this.TxtFechaActual.TabIndex = 3;
            this.TxtFechaActual.TextChanged += new System.EventHandler(this.TxtFechaActual_TextChanged);
            // 
            // FechaActual
            // 
            this.FechaActual.Enabled = true;
            this.FechaActual.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCerrarA
            // 
            this.btnCerrarA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarA.Location = new System.Drawing.Point(869, 9);
            this.btnCerrarA.Name = "btnCerrarA";
            this.btnCerrarA.Size = new System.Drawing.Size(86, 45);
            this.btnCerrarA.TabIndex = 4;
            this.btnCerrarA.Text = "Cerrar Aplicación";
            this.btnCerrarA.UseVisualStyleBackColor = true;
            this.btnCerrarA.Click += new System.EventHandler(this.btnCerrarA_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatosP);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 498);
            this.tabControl1.TabIndex = 5;
            // 
            // tabDatosP
            // 
            this.tabDatosP.Controls.Add(this.gbSintomas);
            this.tabDatosP.Controls.Add(this.gbInformacionPacientes);
            this.tabDatosP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDatosP.Location = new System.Drawing.Point(4, 27);
            this.tabDatosP.Name = "tabDatosP";
            this.tabDatosP.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosP.Size = new System.Drawing.Size(931, 467);
            this.tabDatosP.TabIndex = 0;
            this.tabDatosP.Text = "Datos del Paciente";
            this.tabDatosP.UseVisualStyleBackColor = true;
            // 
            // gbSintomas
            // 
            this.gbSintomas.BackColor = System.Drawing.SystemColors.Control;
            this.gbSintomas.Controls.Add(this.bntdiagnostico);
            this.gbSintomas.Controls.Add(this.lblLinea);
            this.gbSintomas.Controls.Add(this.btnresumir);
            this.gbSintomas.Controls.Add(this.chkIncapacidad);
            this.gbSintomas.Controls.Add(this.chkDolor);
            this.gbSintomas.Controls.Add(this.chkRespiracion);
            this.gbSintomas.Controls.Add(this.chkCansancio);
            this.gbSintomas.Controls.Add(this.chkFiebre);
            this.gbSintomas.Controls.Add(this.chkTos);
            this.gbSintomas.Controls.Add(this.lblSintomasGraves);
            this.gbSintomas.Controls.Add(this.lblSintomasBasicos);
            this.gbSintomas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbSintomas.Location = new System.Drawing.Point(476, 6);
            this.gbSintomas.Name = "gbSintomas";
            this.gbSintomas.Size = new System.Drawing.Size(449, 457);
            this.gbSintomas.TabIndex = 1;
            this.gbSintomas.TabStop = false;
            this.gbSintomas.Text = "Síntomas";
            // 
            // bntdiagnostico
            // 
            this.bntdiagnostico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bntdiagnostico.Location = new System.Drawing.Point(272, 275);
            this.bntdiagnostico.Name = "bntdiagnostico";
            this.bntdiagnostico.Size = new System.Drawing.Size(138, 23);
            this.bntdiagnostico.TabIndex = 11;
            this.bntdiagnostico.Text = "Nuevo Diagnóstico";
            this.bntdiagnostico.UseVisualStyleBackColor = false;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(8, 232);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(435, 16);
            this.lblLinea.TabIndex = 10;
            this.lblLinea.Text = "_____________________________________________________________";
            // 
            // btnresumir
            // 
            this.btnresumir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnresumir.Location = new System.Drawing.Point(50, 275);
            this.btnresumir.Name = "btnresumir";
            this.btnresumir.Size = new System.Drawing.Size(75, 23);
            this.btnresumir.TabIndex = 9;
            this.btnresumir.Text = "Resumir";
            this.btnresumir.UseVisualStyleBackColor = false;
            this.btnresumir.Click += new System.EventHandler(this.btnresumir_Click);
            // 
            // chkIncapacidad
            // 
            this.chkIncapacidad.AutoSize = true;
            this.chkIncapacidad.Location = new System.Drawing.Point(144, 194);
            this.chkIncapacidad.Name = "chkIncapacidad";
            this.chkIncapacidad.Size = new System.Drawing.Size(253, 20);
            this.chkIncapacidad.TabIndex = 8;
            this.chkIncapacidad.Text = "Incapacidad para hablar o moverse";
            this.chkIncapacidad.UseVisualStyleBackColor = true;
            this.chkIncapacidad.CheckedChanged += new System.EventHandler(this.chkIncapacidad_CheckedChanged);
            // 
            // chkDolor
            // 
            this.chkDolor.AutoSize = true;
            this.chkDolor.Location = new System.Drawing.Point(144, 168);
            this.chkDolor.Name = "chkDolor";
            this.chkDolor.Size = new System.Drawing.Size(203, 20);
            this.chkDolor.TabIndex = 7;
            this.chkDolor.Text = "Dolor o presión en el pecho";
            this.chkDolor.UseVisualStyleBackColor = true;
            this.chkDolor.CheckedChanged += new System.EventHandler(this.chkPresion_CheckedChanged);
            // 
            // chkRespiracion
            // 
            this.chkRespiracion.AutoSize = true;
            this.chkRespiracion.Location = new System.Drawing.Point(144, 142);
            this.chkRespiracion.Name = "chkRespiracion";
            this.chkRespiracion.Size = new System.Drawing.Size(266, 20);
            this.chkRespiracion.TabIndex = 6;
            this.chkRespiracion.Text = "Dificultad para respirar o falta de aire";
            this.chkRespiracion.UseVisualStyleBackColor = true;
            this.chkRespiracion.CheckedChanged += new System.EventHandler(this.chkRespiracion_CheckedChanged);
            // 
            // chkCansancio
            // 
            this.chkCansancio.AutoSize = true;
            this.chkCansancio.Location = new System.Drawing.Point(144, 85);
            this.chkCansancio.Name = "chkCansancio";
            this.chkCansancio.Size = new System.Drawing.Size(93, 20);
            this.chkCansancio.TabIndex = 5;
            this.chkCansancio.Text = "Cansancio";
            this.chkCansancio.UseVisualStyleBackColor = true;
            this.chkCansancio.CheckedChanged += new System.EventHandler(this.chkCansancio_CheckedChanged);
            // 
            // chkFiebre
            // 
            this.chkFiebre.AutoSize = true;
            this.chkFiebre.Location = new System.Drawing.Point(144, 59);
            this.chkFiebre.Name = "chkFiebre";
            this.chkFiebre.Size = new System.Drawing.Size(68, 20);
            this.chkFiebre.TabIndex = 4;
            this.chkFiebre.Text = "Fiebre";
            this.chkFiebre.UseVisualStyleBackColor = true;
            this.chkFiebre.CheckedChanged += new System.EventHandler(this.chkFiebre_CheckedChanged);
            // 
            // chkTos
            // 
            this.chkTos.AutoSize = true;
            this.chkTos.Location = new System.Drawing.Point(144, 33);
            this.chkTos.Name = "chkTos";
            this.chkTos.Size = new System.Drawing.Size(48, 20);
            this.chkTos.TabIndex = 3;
            this.chkTos.Text = "Tos";
            this.chkTos.UseVisualStyleBackColor = true;
            this.chkTos.CheckedChanged += new System.EventHandler(this.chkTos_CheckedChanged);
            // 
            // lblSintomasGraves
            // 
            this.lblSintomasGraves.AutoSize = true;
            this.lblSintomasGraves.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintomasGraves.ForeColor = System.Drawing.Color.Navy;
            this.lblSintomasGraves.Location = new System.Drawing.Point(6, 141);
            this.lblSintomasGraves.Name = "lblSintomasGraves";
            this.lblSintomasGraves.Size = new System.Drawing.Size(115, 16);
            this.lblSintomasGraves.TabIndex = 2;
            this.lblSintomasGraves.Text = "Síntomas Graves";
            this.lblSintomasGraves.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSintomasBasicos
            // 
            this.lblSintomasBasicos.AutoSize = true;
            this.lblSintomasBasicos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintomasBasicos.ForeColor = System.Drawing.Color.Navy;
            this.lblSintomasBasicos.Location = new System.Drawing.Point(6, 35);
            this.lblSintomasBasicos.Name = "lblSintomasBasicos";
            this.lblSintomasBasicos.Size = new System.Drawing.Size(119, 16);
            this.lblSintomasBasicos.TabIndex = 1;
            this.lblSintomasBasicos.Text = "Síntomas Básicos";
            // 
            // gbInformacionPacientes
            // 
            this.gbInformacionPacientes.Controls.Add(this.txtNacionalidad);
            this.gbInformacionPacientes.Controls.Add(this.lblNacionalidad);
            this.gbInformacionPacientes.Controls.Add(this.txtEstadoCivil);
            this.gbInformacionPacientes.Controls.Add(this.lblEstadoCivil);
            this.gbInformacionPacientes.Controls.Add(this.DtpFechaN);
            this.gbInformacionPacientes.Controls.Add(this.lblFechaN);
            this.gbInformacionPacientes.Controls.Add(this.txtCorreo);
            this.gbInformacionPacientes.Controls.Add(this.lblCorreo);
            this.gbInformacionPacientes.Controls.Add(this.txtOtro);
            this.gbInformacionPacientes.Controls.Add(this.RbOtro);
            this.gbInformacionPacientes.Controls.Add(this.RbFemenino);
            this.gbInformacionPacientes.Controls.Add(this.RbMasculino);
            this.gbInformacionPacientes.Controls.Add(this.lblSexo);
            this.gbInformacionPacientes.Controls.Add(this.txtDireccion);
            this.gbInformacionPacientes.Controls.Add(this.lblDireccion);
            this.gbInformacionPacientes.Controls.Add(this.cbProvincia);
            this.gbInformacionPacientes.Controls.Add(this.lblProvincia);
            this.gbInformacionPacientes.Controls.Add(this.txtSegundoApellido);
            this.gbInformacionPacientes.Controls.Add(this.lblSegundoApellido);
            this.gbInformacionPacientes.Controls.Add(this.txtPrimerApellido);
            this.gbInformacionPacientes.Controls.Add(this.lblPrimerApellido);
            this.gbInformacionPacientes.Controls.Add(this.txtNombre);
            this.gbInformacionPacientes.Controls.Add(this.lblNombre);
            this.gbInformacionPacientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbInformacionPacientes.Location = new System.Drawing.Point(6, 6);
            this.gbInformacionPacientes.Name = "gbInformacionPacientes";
            this.gbInformacionPacientes.Size = new System.Drawing.Size(464, 457);
            this.gbInformacionPacientes.TabIndex = 0;
            this.gbInformacionPacientes.TabStop = false;
            this.gbInformacionPacientes.Text = "Información Pacientes";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(169, 419);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(231, 22);
            this.txtNacionalidad.TabIndex = 22;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.ForeColor = System.Drawing.Color.Navy;
            this.lblNacionalidad.Location = new System.Drawing.Point(6, 419);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(92, 16);
            this.lblNacionalidad.TabIndex = 21;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoCivil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoCivil.Location = new System.Drawing.Point(169, 384);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(231, 22);
            this.txtEstadoCivil.TabIndex = 20;
            this.txtEstadoCivil.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.Navy;
            this.lblEstadoCivil.Location = new System.Drawing.Point(6, 384);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(82, 16);
            this.lblEstadoCivil.TabIndex = 19;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // DtpFechaN
            // 
            this.DtpFechaN.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtpFechaN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaN.Location = new System.Drawing.Point(284, 349);
            this.DtpFechaN.Name = "DtpFechaN";
            this.DtpFechaN.Size = new System.Drawing.Size(116, 22);
            this.DtpFechaN.TabIndex = 18;
            // 
            // lblFechaN
            // 
            this.lblFechaN.AutoSize = true;
            this.lblFechaN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaN.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaN.Location = new System.Drawing.Point(6, 349);
            this.lblFechaN.Name = "lblFechaN";
            this.lblFechaN.Size = new System.Drawing.Size(151, 16);
            this.lblFechaN.TabIndex = 17;
            this.lblFechaN.Text = "Fecha de Naciemiento";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(169, 312);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(231, 22);
            this.txtCorreo.TabIndex = 16;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Navy;
            this.lblCorreo.Location = new System.Drawing.Point(6, 314);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(126, 16);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // txtOtro
            // 
            this.txtOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtro.Enabled = false;
            this.txtOtro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtro.Location = new System.Drawing.Point(253, 278);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(147, 22);
            this.txtOtro.TabIndex = 14;
            // 
            // RbOtro
            // 
            this.RbOtro.AutoSize = true;
            this.RbOtro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbOtro.Location = new System.Drawing.Point(169, 278);
            this.RbOtro.Name = "RbOtro";
            this.RbOtro.Size = new System.Drawing.Size(51, 20);
            this.RbOtro.TabIndex = 13;
            this.RbOtro.TabStop = true;
            this.RbOtro.Text = "Otro";
            this.RbOtro.UseVisualStyleBackColor = true;
            this.RbOtro.CheckedChanged += new System.EventHandler(this.RbOtro_CheckedChanged);
            // 
            // RbFemenino
            // 
            this.RbFemenino.AutoSize = true;
            this.RbFemenino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFemenino.Location = new System.Drawing.Point(315, 252);
            this.RbFemenino.Name = "RbFemenino";
            this.RbFemenino.Size = new System.Drawing.Size(83, 20);
            this.RbFemenino.TabIndex = 12;
            this.RbFemenino.TabStop = true;
            this.RbFemenino.Text = "Femenino";
            this.RbFemenino.UseVisualStyleBackColor = true;
            this.RbFemenino.CheckedChanged += new System.EventHandler(this.RbFemenino_CheckedChanged);
            // 
            // RbMasculino
            // 
            this.RbMasculino.AutoSize = true;
            this.RbMasculino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMasculino.Location = new System.Drawing.Point(169, 252);
            this.RbMasculino.Name = "RbMasculino";
            this.RbMasculino.Size = new System.Drawing.Size(85, 20);
            this.RbMasculino.TabIndex = 11;
            this.RbMasculino.TabStop = true;
            this.RbMasculino.Text = "Masculino";
            this.RbMasculino.UseVisualStyleBackColor = true;
            this.RbMasculino.CheckedChanged += new System.EventHandler(this.RbMasculino_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Navy;
            this.lblSexo.Location = new System.Drawing.Point(6, 252);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 16);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(169, 179);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(231, 56);
            this.txtDireccion.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion.Location = new System.Drawing.Point(6, 181);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 16);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección";
            // 
            // cbProvincia
            // 
            this.cbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbProvincia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Items.AddRange(new object[] {
            "San José",
            "Cartago",
            "Heredia",
            "Alajuela",
            "Guanacaste",
            "Puntarenas",
            "Limón"});
            this.cbProvincia.Location = new System.Drawing.Point(169, 138);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(231, 24);
            this.cbProvincia.TabIndex = 7;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.Navy;
            this.lblProvincia.Location = new System.Drawing.Point(6, 138);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(68, 16);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia";
            this.lblProvincia.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(169, 104);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(231, 22);
            this.txtSegundoApellido.TabIndex = 5;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.Navy;
            this.lblSegundoApellido.Location = new System.Drawing.Point(6, 106);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(122, 16);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(169, 68);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(231, 22);
            this.txtPrimerApellido.TabIndex = 3;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.Navy;
            this.lblPrimerApellido.Location = new System.Drawing.Point(6, 70);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(108, 16);
            this.lblPrimerApellido.TabIndex = 2;
            this.lblPrimerApellido.Text = "Pirmer Apellido";
            this.lblPrimerApellido.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(169, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(6, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCovid19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrarA);
            this.Controls.Add(this.TxtFechaActual);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.pickCovid19);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCovid19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de pacientes con covid19";
            ((System.ComponentModel.ISupportInitialize)(this.pickCovid19)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDatosP.ResumeLayout(false);
            this.gbSintomas.ResumeLayout(false);
            this.gbSintomas.PerformLayout();
            this.gbInformacionPacientes.ResumeLayout(false);
            this.gbInformacionPacientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pickCovid19;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.TextBox TxtFechaActual;
        private System.Windows.Forms.Timer FechaActual;
        private System.Windows.Forms.Button btnCerrarA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatosP;
        private System.Windows.Forms.GroupBox gbInformacionPacientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.RadioButton RbOtro;
        private System.Windows.Forms.RadioButton RbFemenino;
        private System.Windows.Forms.RadioButton RbMasculino;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.DateTimePicker DtpFechaN;
        private System.Windows.Forms.Label lblFechaN;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.GroupBox gbSintomas;
        private System.Windows.Forms.Label lblSintomasGraves;
        private System.Windows.Forms.Label lblSintomasBasicos;
        private System.Windows.Forms.Button bntdiagnostico;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Button btnresumir;
        private System.Windows.Forms.CheckBox chkIncapacidad;
        private System.Windows.Forms.CheckBox chkDolor;
        private System.Windows.Forms.CheckBox chkRespiracion;
        private System.Windows.Forms.CheckBox chkCansancio;
        private System.Windows.Forms.CheckBox chkFiebre;
        private System.Windows.Forms.CheckBox chkTos;
    }
}

