namespace Acceso_a_HW_y_SO
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
            this.btnSeri = new System.Windows.Forms.Button();
            this.btnCantidadUnidades = new System.Windows.Forms.Button();
            this.btnInventarioGeneral = new System.Windows.Forms.Button();
            this.lblSeri = new System.Windows.Forms.Label();
            this.lblUnidadesDisco = new System.Windows.Forms.Label();
            this.lblInventarioSistema = new System.Windows.Forms.Label();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.btnObtenerMac = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnProcesosActivos = new System.Windows.Forms.Button();
            this.btnMatarProcesos = new System.Windows.Forms.Button();
            this.gbCaja = new System.Windows.Forms.GroupBox();
            this.dgvCuadricula = new System.Windows.Forms.DataGridView();
            this.gbCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadricula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeri
            // 
            this.btnSeri.Location = new System.Drawing.Point(49, 31);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(96, 23);
            this.btnSeri.TabIndex = 0;
            this.btnSeri.Text = "LEER #SERI";
            this.btnSeri.UseVisualStyleBackColor = true;
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click);
            // 
            // btnCantidadUnidades
            // 
            this.btnCantidadUnidades.Location = new System.Drawing.Point(251, 31);
            this.btnCantidadUnidades.Name = "btnCantidadUnidades";
            this.btnCantidadUnidades.Size = new System.Drawing.Size(151, 23);
            this.btnCantidadUnidades.TabIndex = 1;
            this.btnCantidadUnidades.Text = "CANTIDAD DE UNIDADES";
            this.btnCantidadUnidades.UseVisualStyleBackColor = true;
            this.btnCantidadUnidades.Click += new System.EventHandler(this.btnCantidadUnidades_Click);
            // 
            // btnInventarioGeneral
            // 
            this.btnInventarioGeneral.Location = new System.Drawing.Point(480, 31);
            this.btnInventarioGeneral.Name = "btnInventarioGeneral";
            this.btnInventarioGeneral.Size = new System.Drawing.Size(136, 23);
            this.btnInventarioGeneral.TabIndex = 2;
            this.btnInventarioGeneral.Text = "INVENTARIO GENERAL";
            this.btnInventarioGeneral.UseVisualStyleBackColor = true;
            this.btnInventarioGeneral.Click += new System.EventHandler(this.btnInventarioGeneral_Click);
            // 
            // lblSeri
            // 
            this.lblSeri.Location = new System.Drawing.Point(36, 57);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(121, 17);
            this.lblSeri.TabIndex = 3;
            this.lblSeri.Text = "Disco Duro / CD /DVD";
            // 
            // lblUnidadesDisco
            // 
            this.lblUnidadesDisco.Location = new System.Drawing.Point(300, 57);
            this.lblUnidadesDisco.Name = "lblUnidadesDisco";
            this.lblUnidadesDisco.Size = new System.Drawing.Size(121, 17);
            this.lblUnidadesDisco.TabIndex = 4;
            this.lblUnidadesDisco.Text = "Del disco";
            // 
            // lblInventarioSistema
            // 
            this.lblInventarioSistema.Location = new System.Drawing.Point(457, 57);
            this.lblInventarioSistema.Name = "lblInventarioSistema";
            this.lblInventarioSistema.Size = new System.Drawing.Size(189, 17);
            this.lblInventarioSistema.TabIndex = 5;
            this.lblInventarioSistema.Text = "Procesadores / RAM / NIC / Patches";
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.Location = new System.Drawing.Point(46, 148);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(121, 17);
            this.lblMacAddress.TabIndex = 7;
            this.lblMacAddress.Text = "Address/Dirección";
            // 
            // btnObtenerMac
            // 
            this.btnObtenerMac.Location = new System.Drawing.Point(49, 122);
            this.btnObtenerMac.Name = "btnObtenerMac";
            this.btnObtenerMac.Size = new System.Drawing.Size(96, 23);
            this.btnObtenerMac.TabIndex = 6;
            this.btnObtenerMac.Text = "OBTENER MAC";
            this.btnObtenerMac.UseVisualStyleBackColor = true;
            this.btnObtenerMac.Click += new System.EventHandler(this.btnObtenerMac_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.Location = new System.Drawing.Point(271, 148);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(121, 17);
            this.lblRegistro.TabIndex = 9;
            this.lblRegistro.Text = "Editor De Registro";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(274, 122);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(96, 23);
            this.btnRegistro.TabIndex = 8;
            this.btnRegistro.Text = "REGISTRO";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnProcesosActivos
            // 
            this.btnProcesosActivos.Location = new System.Drawing.Point(478, 110);
            this.btnProcesosActivos.Name = "btnProcesosActivos";
            this.btnProcesosActivos.Size = new System.Drawing.Size(138, 23);
            this.btnProcesosActivos.TabIndex = 10;
            this.btnProcesosActivos.Text = "OBTENER PROCESOS";
            this.btnProcesosActivos.UseVisualStyleBackColor = true;
            this.btnProcesosActivos.Click += new System.EventHandler(this.btnProcesosActivos_Click);
            // 
            // btnMatarProcesos
            // 
            this.btnMatarProcesos.Location = new System.Drawing.Point(480, 148);
            this.btnMatarProcesos.Name = "btnMatarProcesos";
            this.btnMatarProcesos.Size = new System.Drawing.Size(138, 23);
            this.btnMatarProcesos.TabIndex = 11;
            this.btnMatarProcesos.Text = "MATAR PROCESOS";
            this.btnMatarProcesos.UseVisualStyleBackColor = true;
            this.btnMatarProcesos.Click += new System.EventHandler(this.btnMatarProcesos_Click);
            // 
            // gbCaja
            // 
            this.gbCaja.Controls.Add(this.btnSeri);
            this.gbCaja.Controls.Add(this.btnMatarProcesos);
            this.gbCaja.Controls.Add(this.btnCantidadUnidades);
            this.gbCaja.Controls.Add(this.btnProcesosActivos);
            this.gbCaja.Controls.Add(this.btnInventarioGeneral);
            this.gbCaja.Controls.Add(this.lblRegistro);
            this.gbCaja.Controls.Add(this.lblSeri);
            this.gbCaja.Controls.Add(this.btnRegistro);
            this.gbCaja.Controls.Add(this.lblUnidadesDisco);
            this.gbCaja.Controls.Add(this.lblMacAddress);
            this.gbCaja.Controls.Add(this.lblInventarioSistema);
            this.gbCaja.Controls.Add(this.btnObtenerMac);
            this.gbCaja.Location = new System.Drawing.Point(12, 12);
            this.gbCaja.Name = "gbCaja";
            this.gbCaja.Size = new System.Drawing.Size(661, 227);
            this.gbCaja.TabIndex = 12;
            this.gbCaja.TabStop = false;
            this.gbCaja.Text = "Funciones Acceso HW y SO";
            // 
            // dgvCuadricula
            // 
            this.dgvCuadricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuadricula.Location = new System.Drawing.Point(12, 259);
            this.dgvCuadricula.Name = "dgvCuadricula";
            this.dgvCuadricula.Size = new System.Drawing.Size(662, 194);
            this.dgvCuadricula.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 477);
            this.Controls.Add(this.dgvCuadricula);
            this.Controls.Add(this.gbCaja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadricula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeri;
        private System.Windows.Forms.Button btnCantidadUnidades;
        private System.Windows.Forms.Button btnInventarioGeneral;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Label lblUnidadesDisco;
        private System.Windows.Forms.Label lblInventarioSistema;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.Button btnObtenerMac;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnProcesosActivos;
        private System.Windows.Forms.Button btnMatarProcesos;
        private System.Windows.Forms.GroupBox gbCaja;
        private System.Windows.Forms.DataGridView dgvCuadricula;
    }
}

