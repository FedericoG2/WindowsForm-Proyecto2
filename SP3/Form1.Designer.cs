
namespace SP3
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
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.numAnioFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtNroTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.txtDominio6Caracteres = new System.Windows.Forms.TextBox();
            this.txtAnioMasAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.numAnioFabricacion);
            this.grpRegistro.Controls.Add(this.txtTitular);
            this.grpRegistro.Controls.Add(this.txtDominio);
            this.grpRegistro.Controls.Add(this.txtNroTurno);
            this.grpRegistro.Controls.Add(this.label5);
            this.grpRegistro.Controls.Add(this.label3);
            this.grpRegistro.Controls.Add(this.label2);
            this.grpRegistro.Controls.Add(this.label1);
            this.grpRegistro.Location = new System.Drawing.Point(12, 12);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(413, 177);
            this.grpRegistro.TabIndex = 0;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registro de Turnos";
            // 
            // numAnioFabricacion
            // 
            this.numAnioFabricacion.Location = new System.Drawing.Point(120, 96);
            this.numAnioFabricacion.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numAnioFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAnioFabricacion.Name = "numAnioFabricacion";
            this.numAnioFabricacion.Size = new System.Drawing.Size(55, 20);
            this.numAnioFabricacion.TabIndex = 2;
            this.numAnioFabricacion.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(120, 130);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(271, 20);
            this.txtTitular.TabIndex = 3;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(120, 61);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 1;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.Location = new System.Drawing.Point(120, 27);
            this.txtNroTurno.MaxLength = 5;
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(65, 20);
            this.txtNroTurno.TabIndex = 0;
            this.txtNroTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroTurno.TextChanged += new System.EventHandler(this.txtNroTurno_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año Fabricación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dominio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Turno";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(443, 21);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 34);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(443, 76);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 34);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.txtDominio6Caracteres);
            this.grpConsulta.Controls.Add(this.txtAnioMasAntiguo);
            this.grpConsulta.Controls.Add(this.txtCantidadTurnos);
            this.grpConsulta.Controls.Add(this.label8);
            this.grpConsulta.Controls.Add(this.label7);
            this.grpConsulta.Controls.Add(this.label6);
            this.grpConsulta.Location = new System.Drawing.Point(12, 205);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(413, 137);
            this.grpConsulta.TabIndex = 3;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Estadísticas";
            // 
            // txtDominio6Caracteres
            // 
            this.txtDominio6Caracteres.Location = new System.Drawing.Point(215, 95);
            this.txtDominio6Caracteres.Name = "txtDominio6Caracteres";
            this.txtDominio6Caracteres.ReadOnly = true;
            this.txtDominio6Caracteres.Size = new System.Drawing.Size(59, 20);
            this.txtDominio6Caracteres.TabIndex = 2;
            this.txtDominio6Caracteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnioMasAntiguo
            // 
            this.txtAnioMasAntiguo.Location = new System.Drawing.Point(215, 60);
            this.txtAnioMasAntiguo.Name = "txtAnioMasAntiguo";
            this.txtAnioMasAntiguo.ReadOnly = true;
            this.txtAnioMasAntiguo.Size = new System.Drawing.Size(59, 20);
            this.txtAnioMasAntiguo.TabIndex = 1;
            this.txtAnioMasAntiguo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(215, 27);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(59, 20);
            this.txtCantidadTurnos.TabIndex = 0;
            this.txtCantidadTurnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Año del más Antiguo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cantidad de Turnos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(443, 214);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 34);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 355);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpRegistro);
            this.Name = "Form1";
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.NumericUpDown numAnioFabricacion;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNroTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.TextBox txtDominio6Caracteres;
        private System.Windows.Forms.TextBox txtAnioMasAntiguo;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultar;
    }
}

