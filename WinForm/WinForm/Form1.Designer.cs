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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).BeginInit();
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
            this.DGV_DatosPaciente.Location = new System.Drawing.Point(201, 12);
            this.DGV_DatosPaciente.Name = "DGV_DatosPaciente";
            this.DGV_DatosPaciente.RowHeadersVisible = false;
            this.DGV_DatosPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_DatosPaciente.Size = new System.Drawing.Size(435, 388);
            this.DGV_DatosPaciente.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Imagenes esperadas";
            // 
            // L_ImagenesEsperadas
            // 
            this.L_ImagenesEsperadas.AutoSize = true;
            this.L_ImagenesEsperadas.Location = new System.Drawing.Point(133, 56);
            this.L_ImagenesEsperadas.Name = "L_ImagenesEsperadas";
            this.L_ImagenesEsperadas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEsperadas.TabIndex = 24;
            this.L_ImagenesEsperadas.Text = "label2";
            this.L_ImagenesEsperadas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Imagenes encontradas";
            // 
            // L_ImagenesEncontradas
            // 
            this.L_ImagenesEncontradas.AutoSize = true;
            this.L_ImagenesEncontradas.Location = new System.Drawing.Point(133, 86);
            this.L_ImagenesEncontradas.Name = "L_ImagenesEncontradas";
            this.L_ImagenesEncontradas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEncontradas.TabIndex = 26;
            this.L_ImagenesEncontradas.Text = "label4";
            this.L_ImagenesEncontradas.Visible = false;
            // 
            // CHB_SinImagenesSetUp
            // 
            this.CHB_SinImagenesSetUp.AutoSize = true;
            this.CHB_SinImagenesSetUp.Location = new System.Drawing.Point(12, 121);
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
            this.CHB_DosImagenes3D.Location = new System.Drawing.Point(12, 155);
            this.CHB_DosImagenes3D.Name = "CHB_DosImagenes3D";
            this.CHB_DosImagenes3D.Size = new System.Drawing.Size(130, 17);
            this.CHB_DosImagenes3D.TabIndex = 28;
            this.CHB_DosImagenes3D.Text = "Hay dos imágenes 3D";
            this.CHB_DosImagenes3D.UseVisualStyleBackColor = true;
            this.CHB_DosImagenes3D.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

