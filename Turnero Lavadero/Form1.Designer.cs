namespace Turnero_Lavadero
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
            this.components = new System.ComponentModel.Container();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btAgendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPepe = new System.Windows.Forms.Label();
            this.ComboxDia = new System.Windows.Forms.ComboBox();
            this.ComboxHorario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboxLavado = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.ErrorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorNumero = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblDia.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDia.Location = new System.Drawing.Point(12, 223);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(296, 17);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Elija el dia en el que quiere un turno para el lavadero";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblHorario.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHorario.Location = new System.Drawing.Point(12, 292);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(280, 17);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Elija el horario en el que quiere realizar su lavado";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblinfo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(571, 56);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(151, 20);
            this.lblinfo.TabIndex = 4;
            this.lblinfo.Text = "Turnos ya reservados\r\n";
            // 
            // btAgendar
            // 
            this.btAgendar.Location = new System.Drawing.Point(21, 453);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(98, 23);
            this.btAgendar.TabIndex = 5;
            this.btAgendar.Text = "Programar cita";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "El lavadero de Grasso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label2.Location = new System.Drawing.Point(620, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ubicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label3.Location = new System.Drawing.Point(572, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Entre Ruta 9 y esquina Paraguay\r\n\r\n";
            // 
            // lblPepe
            // 
            this.lblPepe.AutoSize = true;
            this.lblPepe.Location = new System.Drawing.Point(15, 402);
            this.lblPepe.Name = "lblPepe";
            this.lblPepe.Size = new System.Drawing.Size(0, 13);
            this.lblPepe.TabIndex = 11;
            // 
            // ComboxDia
            // 
            this.ComboxDia.FormattingEnabled = true;
            this.ComboxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.ComboxDia.Location = new System.Drawing.Point(21, 250);
            this.ComboxDia.Name = "ComboxDia";
            this.ComboxDia.Size = new System.Drawing.Size(177, 21);
            this.ComboxDia.TabIndex = 13;
            // 
            // ComboxHorario
            // 
            this.ComboxHorario.FormattingEnabled = true;
            this.ComboxHorario.Items.AddRange(new object[] {
            "08:00 hs",
            "09:30 hs",
            "10:00 hs",
            "12:00 hs",
            "15:00 hs",
            "16:30 hs",
            "18:00 hs",
            "19:00 hs"});
            this.ComboxHorario.Location = new System.Drawing.Point(21, 328);
            this.ComboxHorario.Name = "ComboxHorario";
            this.ComboxHorario.Size = new System.Drawing.Size(177, 21);
            this.ComboxHorario.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowText;
            this.label5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(12, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Elija el tipo de lavado que quiere realizar\r\n";
            // 
            // ComboxLavado
            // 
            this.ComboxLavado.FormattingEnabled = true;
            this.ComboxLavado.Items.AddRange(new object[] {
            "Lavado Artesanal P/Moto $3.000",
            "Lavado Premium P/Moto $6.000",
            "Lavado Artesanal P/Auto $8.000",
            "Lavado Premium P/Auto  $12.000",
            "Lavado Artesanal P/Camioneta $10.000",
            "Lavado Premium P/Camionetas $15.000"});
            this.ComboxLavado.Location = new System.Drawing.Point(18, 402);
            this.ComboxLavado.Name = "ComboxLavado";
            this.ComboxLavado.Size = new System.Drawing.Size(177, 21);
            this.ComboxLavado.TabIndex = 16;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(572, 101);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(0, 13);
            this.lblSalida.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(165, 17);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Ingrese su nombre completo\r\n";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNumero.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumero.Location = new System.Drawing.Point(12, 101);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(176, 17);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Ingrese su numero de telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 131);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(176, 20);
            this.txtNumero.TabIndex = 21;
            // 
            // ErrorNombre
            // 
            this.ErrorNombre.ContainerControl = this;
            // 
            // ErrorNumero
            // 
            this.ErrorNumero.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 561);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.ComboxLavado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboxHorario);
            this.Controls.Add(this.ComboxDia);
            this.Controls.Add(this.lblPepe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btAgendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPepe;
        private System.Windows.Forms.ComboBox ComboxDia;
        private System.Windows.Forms.ComboBox ComboxHorario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboxLavado;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ErrorProvider ErrorNombre;
        private System.Windows.Forms.ErrorProvider ErrorNumero;
    }
}

