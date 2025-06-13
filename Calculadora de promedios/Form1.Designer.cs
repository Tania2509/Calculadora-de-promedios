namespace Calculadora_de_promedios
{
    partial class frmSistemasDeNotasITR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistemasDeNotasITR));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.txtNotaUno = new System.Windows.Forms.TextBox();
            this.txtNotaDos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnAgregarPromedio = new System.Windows.Forms.Button();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.txtNotaTres);
            this.groupBox1.Controls.Add(this.txtNotaUno);
            this.groupBox1.Controls.Add(this.txtNotaDos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de notas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora_de_promedios.Properties.Resources.icons8_user_100;
            this.pictureBox1.Location = new System.Drawing.Point(369, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(37, 213);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(55, 23);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Location = new System.Drawing.Point(148, 161);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(139, 26);
            this.txtNotaTres.TabIndex = 9;
            this.tlpAyuda.SetToolTip(this.txtNotaTres, "Ingresa valores entre 0 y 10");
            // 
            // txtNotaUno
            // 
            this.txtNotaUno.Location = new System.Drawing.Point(148, 48);
            this.txtNotaUno.Name = "txtNotaUno";
            this.txtNotaUno.Size = new System.Drawing.Size(139, 26);
            this.txtNotaUno.TabIndex = 8;
            this.tlpAyuda.SetToolTip(this.txtNotaUno, "Ingresa valores entre 0 y 10\r\n");
            // 
            // txtNotaDos
            // 
            this.txtNotaDos.Location = new System.Drawing.Point(148, 102);
            this.txtNotaDos.Name = "txtNotaDos";
            this.txtNotaDos.Size = new System.Drawing.Size(139, 26);
            this.txtNotaDos.TabIndex = 7;
            this.tlpAyuda.SetToolTip(this.txtNotaDos, "Ingresa valores entre 0 y 10");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 2:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.txtPromedio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(197, 41);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(134, 22);
            this.txtPromedio.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Promedio Obtenido";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnNuevoRegistro);
            this.groupBox3.Controls.Add(this.btnAgregarPromedio);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(611, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 264);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Calculadora_de_promedios.Properties.Resources.icons8_salida_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 73);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevoRegistro.ForeColor = System.Drawing.Color.White;
            this.btnNuevoRegistro.Image = global::Calculadora_de_promedios.Properties.Resources.icons8_escoba_32;
            this.btnNuevoRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(3, 102);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(136, 72);
            this.btnNuevoRegistro.TabIndex = 11;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistro.UseVisualStyleBackColor = false;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // btnAgregarPromedio
            // 
            this.btnAgregarPromedio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarPromedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPromedio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPromedio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPromedio.Image = global::Calculadora_de_promedios.Properties.Resources.icons8_add_user_male_32;
            this.btnAgregarPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPromedio.Location = new System.Drawing.Point(3, 18);
            this.btnAgregarPromedio.Name = "btnAgregarPromedio";
            this.btnAgregarPromedio.Size = new System.Drawing.Size(136, 72);
            this.btnAgregarPromedio.TabIndex = 12;
            this.btnAgregarPromedio.Text = "Agregar Promedio";
            this.btnAgregarPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPromedio.UseVisualStyleBackColor = false;
            this.btnAgregarPromedio.Click += new System.EventHandler(this.btnAgregarPromedio_Click);
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.IsBalloon = true;
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de Ayuda";
            // 
            // frmSistemasDeNotasITR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistemasDeNotasITR";
            this.Text = "Sistemas de notas ITR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNotaTres;
        private System.Windows.Forms.TextBox txtNotaUno;
        private System.Windows.Forms.TextBox txtNotaDos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.Button btnAgregarPromedio;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}

