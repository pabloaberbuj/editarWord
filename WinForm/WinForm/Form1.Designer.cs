namespace WinForm
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
            this.BT_Cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_DosisFraccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_DosisTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_ISO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Etapa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Equipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Modalidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Patología = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_CantidadDeCampos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BT_HacerDocumentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Cargar
            // 
            this.BT_Cargar.Location = new System.Drawing.Point(578, 12);
            this.BT_Cargar.Name = "BT_Cargar";
            this.BT_Cargar.Size = new System.Drawing.Size(75, 23);
            this.BT_Cargar.TabIndex = 0;
            this.BT_Cargar.Text = "Cargar";
            this.BT_Cargar.UseVisualStyleBackColor = true;
            this.BT_Cargar.Click += new System.EventHandler(this.BT_CargarClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(139, 9);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TB_Nombre.TabIndex = 2;
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(139, 49);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_ID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // TB_DosisFraccion
            // 
            this.TB_DosisFraccion.Location = new System.Drawing.Point(139, 89);
            this.TB_DosisFraccion.Name = "TB_DosisFraccion";
            this.TB_DosisFraccion.Size = new System.Drawing.Size(100, 20);
            this.TB_DosisFraccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dosis Fracción";
            // 
            // TB_DosisTotal
            // 
            this.TB_DosisTotal.Location = new System.Drawing.Point(139, 133);
            this.TB_DosisTotal.Name = "TB_DosisTotal";
            this.TB_DosisTotal.Size = new System.Drawing.Size(100, 20);
            this.TB_DosisTotal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dosis Total";
            // 
            // TB_ISO
            // 
            this.TB_ISO.Location = new System.Drawing.Point(139, 300);
            this.TB_ISO.Name = "TB_ISO";
            this.TB_ISO.Size = new System.Drawing.Size(100, 20);
            this.TB_ISO.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ISO";
            // 
            // TB_Etapa
            // 
            this.TB_Etapa.Location = new System.Drawing.Point(139, 256);
            this.TB_Etapa.Name = "TB_Etapa";
            this.TB_Etapa.Size = new System.Drawing.Size(100, 20);
            this.TB_Etapa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Etapa nº";
            // 
            // TB_Equipo
            // 
            this.TB_Equipo.Location = new System.Drawing.Point(139, 214);
            this.TB_Equipo.Name = "TB_Equipo";
            this.TB_Equipo.Size = new System.Drawing.Size(100, 20);
            this.TB_Equipo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Equipo";
            // 
            // TB_Modalidad
            // 
            this.TB_Modalidad.Location = new System.Drawing.Point(139, 176);
            this.TB_Modalidad.Name = "TB_Modalidad";
            this.TB_Modalidad.Size = new System.Drawing.Size(100, 20);
            this.TB_Modalidad.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Modalidad";
            // 
            // TB_Patología
            // 
            this.TB_Patología.Location = new System.Drawing.Point(139, 379);
            this.TB_Patología.Name = "TB_Patología";
            this.TB_Patología.Size = new System.Drawing.Size(100, 20);
            this.TB_Patología.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Patología";
            // 
            // TB_CantidadDeCampos
            // 
            this.TB_CantidadDeCampos.Location = new System.Drawing.Point(139, 337);
            this.TB_CantidadDeCampos.Name = "TB_CantidadDeCampos";
            this.TB_CantidadDeCampos.Size = new System.Drawing.Size(100, 20);
            this.TB_CantidadDeCampos.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cantidad de campos";
            // 
            // BT_HacerDocumentos
            // 
            this.BT_HacerDocumentos.Enabled = false;
            this.BT_HacerDocumentos.Location = new System.Drawing.Point(578, 204);
            this.BT_HacerDocumentos.Name = "BT_HacerDocumentos";
            this.BT_HacerDocumentos.Size = new System.Drawing.Size(144, 23);
            this.BT_HacerDocumentos.TabIndex = 21;
            this.BT_HacerDocumentos.Text = "Hacer Documentos";
            this.BT_HacerDocumentos.UseVisualStyleBackColor = true;
            this.BT_HacerDocumentos.Click += new System.EventHandler(this.BT_HacerDocumentos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_HacerDocumentos);
            this.Controls.Add(this.TB_Patología);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_CantidadDeCampos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_ISO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Etapa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Equipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Modalidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_DosisTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_DosisFraccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_DosisFraccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_DosisTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_ISO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Etapa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Equipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Modalidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Patología;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_CantidadDeCampos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BT_HacerDocumentos;
    }
}

