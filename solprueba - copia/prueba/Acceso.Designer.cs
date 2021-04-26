namespace prueba
{
    partial class Acceso
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
            this.Webong = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.us = new System.Windows.Forms.TextBox();
            this.pas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.men = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Hora = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.Fecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Webong
            // 
            this.Webong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Webong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Webong.Location = new System.Drawing.Point(484, 302);
            this.Webong.Name = "Webong";
            this.Webong.Size = new System.Drawing.Size(124, 36);
            this.Webong.TabIndex = 0;
            this.Webong.Text = "Ingresar";
            this.Webong.UseVisualStyleBackColor = true;
            this.Webong.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(480, 132);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "BIENVENIDO";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // us
            // 
            this.us.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.us.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.us.Location = new System.Drawing.Point(484, 200);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(124, 20);
            this.us.TabIndex = 2;
            this.us.TextChanged += new System.EventHandler(this.us_TextChanged);
            // 
            // pas
            // 
            this.pas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pas.Location = new System.Drawing.Point(484, 249);
            this.pas.MaxLength = 20;
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(124, 20);
            this.pas.TabIndex = 3;
            this.pas.TextChanged += new System.EventHandler(this.pas_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // men
            // 
            this.men.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.men.AutoSize = true;
            this.men.BackColor = System.Drawing.Color.Transparent;
            this.men.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men.Location = new System.Drawing.Point(631, 249);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(24, 20);
            this.men.TabIndex = 6;
            this.men.Text = "...";
            this.men.Click += new System.EventHandler(this.men_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(997, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(36, 9);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(48, 20);
            this.Hora.TabIndex = 8;
            this.Hora.Text = "Hora";
            this.Hora.Click += new System.EventHandler(this.Hora_Click);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(12, 32);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(59, 20);
            this.Fecha.TabIndex = 9;
            this.Fecha.Text = "Fecha";
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.men);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.us);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Webong);
            this.Name = "Acceso";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Acceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Webong;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox us;
        private System.Windows.Forms.TextBox pas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label men;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label Fecha;
    }
}

