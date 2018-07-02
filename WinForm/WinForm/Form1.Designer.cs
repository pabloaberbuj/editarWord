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
            this.BT_HacerDocumentos = new System.Windows.Forms.Button();
            this.DGV_DatosPaciente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.L_ImagenesEsperadas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_ImagenesEncontradas = new System.Windows.Forms.Label();
            this.CHB_SinImagenesSetUp = new System.Windows.Forms.CheckBox();
            this.CHB_DosImagenes3D = new System.Windows.Forms.CheckBox();
            this.GB_CamposSetUp = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).BeginInit();
            this.GB_CamposSetUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Cargar
            // 
            this.BT_Cargar.Location = new System.Drawing.Point(12, 12);
            this.BT_Cargar.Name = "BT_Cargar";
            this.BT_Cargar.Size = new System.Drawing.Size(75, 23);
            this.BT_Cargar.TabIndex = 0;
            this.BT_Cargar.Text = "Cargar";
            this.BT_Cargar.UseVisualStyleBackColor = true;
            this.BT_Cargar.Click += new System.EventHandler(this.BT_CargarClick);
            // 
            // BT_HacerDocumentos
            // 
            this.BT_HacerDocumentos.Enabled = false;
            this.BT_HacerDocumentos.Location = new System.Drawing.Point(15, 292);
            this.BT_HacerDocumentos.Name = "BT_HacerDocumentos";
            this.BT_HacerDocumentos.Size = new System.Drawing.Size(144, 23);
            this.BT_HacerDocumentos.TabIndex = 21;
            this.BT_HacerDocumentos.Text = "Hacer Documentos";
            this.BT_HacerDocumentos.UseVisualStyleBackColor = true;
            this.BT_HacerDocumentos.Click += new System.EventHandler(this.BT_HacerDocumentos_Click);
            // 
            // DGV_DatosPaciente
            // 
            this.DGV_DatosPaciente.AllowUserToAddRows = false;
            this.DGV_DatosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DatosPaciente.Location = new System.Drawing.Point(332, 12);
            this.DGV_DatosPaciente.Name = "DGV_DatosPaciente";
            this.DGV_DatosPaciente.RowHeadersVisible = false;
            this.DGV_DatosPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_DatosPaciente.Size = new System.Drawing.Size(435, 388);
            this.DGV_DatosPaciente.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Imagenes esperadas";
            // 
            // L_ImagenesEsperadas
            // 
            this.L_ImagenesEsperadas.AutoSize = true;
            this.L_ImagenesEsperadas.Location = new System.Drawing.Point(136, 228);
            this.L_ImagenesEsperadas.Name = "L_ImagenesEsperadas";
            this.L_ImagenesEsperadas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEsperadas.TabIndex = 24;
            this.L_ImagenesEsperadas.Text = "label2";
            this.L_ImagenesEsperadas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Imagenes encontradas";
            // 
            // L_ImagenesEncontradas
            // 
            this.L_ImagenesEncontradas.AutoSize = true;
            this.L_ImagenesEncontradas.Location = new System.Drawing.Point(136, 258);
            this.L_ImagenesEncontradas.Name = "L_ImagenesEncontradas";
            this.L_ImagenesEncontradas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEncontradas.TabIndex = 26;
            this.L_ImagenesEncontradas.Text = "label4";
            this.L_ImagenesEncontradas.Visible = false;
            // 
            // CHB_SinImagenesSetUp
            // 
            this.CHB_SinImagenesSetUp.AutoSize = true;
            this.CHB_SinImagenesSetUp.Location = new System.Drawing.Point(12, 166);
            this.CHB_SinImagenesSetUp.Name = "CHB_SinImagenesSetUp";
            this.CHB_SinImagenesSetUp.Size = new System.Drawing.Size(154, 17);
            this.CHB_SinImagenesSetUp.TabIndex = 27;
            this.CHB_SinImagenesSetUp.Text = "No hay imágenes de setUp";
            this.CHB_SinImagenesSetUp.UseVisualStyleBackColor = true;
            this.CHB_SinImagenesSetUp.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // CHB_DosImagenes3D
            // 
            this.CHB_DosImagenes3D.AutoSize = true;
            this.CHB_DosImagenes3D.Location = new System.Drawing.Point(12, 199);
            this.CHB_DosImagenes3D.Name = "CHB_DosImagenes3D";
            this.CHB_DosImagenes3D.Size = new System.Drawing.Size(130, 17);
            this.CHB_DosImagenes3D.TabIndex = 28;
            this.CHB_DosImagenes3D.Text = "Hay dos imágenes 3D";
            this.CHB_DosImagenes3D.UseVisualStyleBackColor = true;
            this.CHB_DosImagenes3D.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // GB_CamposSetUp
            // 
            this.GB_CamposSetUp.Controls.Add(this.textBox4);
            this.GB_CamposSetUp.Controls.Add(this.textBox3);
            this.GB_CamposSetUp.Controls.Add(this.textBox2);
            this.GB_CamposSetUp.Controls.Add(this.textBox1);
            this.GB_CamposSetUp.Controls.Add(this.label6);
            this.GB_CamposSetUp.Controls.Add(this.label5);
            this.GB_CamposSetUp.Controls.Add(this.label4);
            this.GB_CamposSetUp.Controls.Add(this.label2);
            this.GB_CamposSetUp.Location = new System.Drawing.Point(12, 50);
            this.GB_CamposSetUp.Name = "GB_CamposSetUp";
            this.GB_CamposSetUp.Size = new System.Drawing.Size(275, 100);
            this.GB_CamposSetUp.TabIndex = 37;
            this.GB_CamposSetUp.TabStop = false;
            this.GB_CamposSetUp.Text = "Campos SetUp";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(59, 20);
            this.textBox4.TabIndex = 44;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 20);
            this.textBox3.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 20);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tamaño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Gantry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Campo SetUp 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Campo SetUp 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB_CamposSetUp);
            this.Controls.Add(this.CHB_DosImagenes3D);
            this.Controls.Add(this.CHB_SinImagenesSetUp);
            this.Controls.Add(this.L_ImagenesEncontradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_ImagenesEsperadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_DatosPaciente);
            this.Controls.Add(this.BT_HacerDocumentos);
            this.Controls.Add(this.BT_Cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).EndInit();
            this.GB_CamposSetUp.ResumeLayout(false);
            this.GB_CamposSetUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Cargar;
        private System.Windows.Forms.Button BT_HacerDocumentos;
        private System.Windows.Forms.DataGridView DGV_DatosPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_ImagenesEsperadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_ImagenesEncontradas;
        private System.Windows.Forms.CheckBox CHB_SinImagenesSetUp;
        private System.Windows.Forms.CheckBox CHB_DosImagenes3D;
        private System.Windows.Forms.GroupBox GB_CamposSetUp;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

