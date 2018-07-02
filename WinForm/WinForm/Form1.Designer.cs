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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Cargar
            // 
            this.BT_Cargar.Location = new System.Drawing.Point(453, 12);
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
            this.BT_HacerDocumentos.Location = new System.Drawing.Point(453, 50);
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
            this.DGV_DatosPaciente.Location = new System.Drawing.Point(12, 9);
            this.DGV_DatosPaciente.Name = "DGV_DatosPaciente";
            this.DGV_DatosPaciente.RowHeadersVisible = false;
            this.DGV_DatosPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_DatosPaciente.Size = new System.Drawing.Size(435, 388);
            this.DGV_DatosPaciente.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_DatosPaciente);
            this.Controls.Add(this.BT_HacerDocumentos);
            this.Controls.Add(this.BT_Cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Cargar;
        private System.Windows.Forms.Button BT_HacerDocumentos;
        private System.Windows.Forms.DataGridView DGV_DatosPaciente;
    }
}

