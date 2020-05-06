namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CargarPPF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB_Grilla = new System.Windows.Forms.CheckBox();
            this.cB_Densidad = new System.Windows.Forms.CheckBox();
            this.cB_DosePerFr = new System.Windows.Forms.CheckBox();
            this.cB_TotalDose = new System.Windows.Forms.CheckBox();
            this.bT_Guardar = new System.Windows.Forms.Button();
            this.bT_Imprimir = new System.Windows.Forms.Button();
            this.bT_Finalizar = new System.Windows.Forms.Button();
            this.panel_Chequeo = new System.Windows.Forms.Panel();
            this.rtB_chequeos = new System.Windows.Forms.RichTextBox();
            this.L_nombrePPF = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Chequeo.SuspendLayout();
            this.SuspendLayout();
            // 
            // CargarPPF
            // 
            this.CargarPPF.Location = new System.Drawing.Point(21, 30);
            this.CargarPPF.Name = "CargarPPF";
            this.CargarPPF.Size = new System.Drawing.Size(124, 29);
            this.CargarPPF.TabIndex = 0;
            this.CargarPPF.Text = "Cargar .PPF";
            this.CargarPPF.UseVisualStyleBackColor = true;
            this.CargarPPF.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cB_Grilla);
            this.panel1.Controls.Add(this.cB_Densidad);
            this.panel1.Controls.Add(this.cB_DosePerFr);
            this.panel1.Controls.Add(this.cB_TotalDose);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 138);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cB_Grilla
            // 
            this.cB_Grilla.AutoSize = true;
            this.cB_Grilla.Location = new System.Drawing.Point(36, 90);
            this.cB_Grilla.Name = "cB_Grilla";
            this.cB_Grilla.Size = new System.Drawing.Size(102, 17);
            this.cB_Grilla.TabIndex = 3;
            this.cB_Grilla.Text = "Grilla de Cálculo";
            this.cB_Grilla.UseVisualStyleBackColor = true;
            // 
            // cB_Densidad
            // 
            this.cB_Densidad.AutoSize = true;
            this.cB_Densidad.Location = new System.Drawing.Point(36, 67);
            this.cB_Densidad.Name = "cB_Densidad";
            this.cB_Densidad.Size = new System.Drawing.Size(141, 17);
            this.cB_Densidad.TabIndex = 2;
            this.cB_Densidad.Text = "Corrección por densidad";
            this.cB_Densidad.UseVisualStyleBackColor = true;
            this.cB_Densidad.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cB_DosePerFr
            // 
            this.cB_DosePerFr.AutoSize = true;
            this.cB_DosePerFr.Location = new System.Drawing.Point(36, 44);
            this.cB_DosePerFr.Name = "cB_DosePerFr";
            this.cB_DosePerFr.Size = new System.Drawing.Size(148, 17);
            this.cB_DosePerFr.TabIndex = 1;
            this.cB_DosePerFr.Text = "Dosis por Fraccion (cGy): ";
            this.cB_DosePerFr.UseVisualStyleBackColor = true;
            // 
            // cB_TotalDose
            // 
            this.cB_TotalDose.AutoSize = true;
            this.cB_TotalDose.Location = new System.Drawing.Point(36, 21);
            this.cB_TotalDose.Name = "cB_TotalDose";
            this.cB_TotalDose.Size = new System.Drawing.Size(109, 17);
            this.cB_TotalDose.TabIndex = 0;
            this.cB_TotalDose.Text = "Dosis total (cGy): ";
            this.cB_TotalDose.UseVisualStyleBackColor = true;
            // 
            // bT_Guardar
            // 
            this.bT_Guardar.Location = new System.Drawing.Point(12, 415);
            this.bT_Guardar.Name = "bT_Guardar";
            this.bT_Guardar.Size = new System.Drawing.Size(75, 23);
            this.bT_Guardar.TabIndex = 2;
            this.bT_Guardar.Text = "Guardar";
            this.bT_Guardar.UseVisualStyleBackColor = true;
            // 
            // bT_Imprimir
            // 
            this.bT_Imprimir.Location = new System.Drawing.Point(93, 415);
            this.bT_Imprimir.Name = "bT_Imprimir";
            this.bT_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.bT_Imprimir.TabIndex = 3;
            this.bT_Imprimir.Text = "Imprimir";
            this.bT_Imprimir.UseVisualStyleBackColor = true;
            // 
            // bT_Finalizar
            // 
            this.bT_Finalizar.Location = new System.Drawing.Point(174, 415);
            this.bT_Finalizar.Name = "bT_Finalizar";
            this.bT_Finalizar.Size = new System.Drawing.Size(75, 23);
            this.bT_Finalizar.TabIndex = 4;
            this.bT_Finalizar.Text = "Finalizar";
            this.bT_Finalizar.UseVisualStyleBackColor = true;
            this.bT_Finalizar.Click += new System.EventHandler(this.bT_Finalizar_Click);
            // 
            // panel_Chequeo
            // 
            this.panel_Chequeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Chequeo.Controls.Add(this.rtB_chequeos);
            this.panel_Chequeo.Location = new System.Drawing.Point(12, 209);
            this.panel_Chequeo.Name = "panel_Chequeo";
            this.panel_Chequeo.Size = new System.Drawing.Size(232, 138);
            this.panel_Chequeo.TabIndex = 5;
            // 
            // rtB_chequeos
            // 
            this.rtB_chequeos.Location = new System.Drawing.Point(3, 3);
            this.rtB_chequeos.Name = "rtB_chequeos";
            this.rtB_chequeos.ReadOnly = true;
            this.rtB_chequeos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtB_chequeos.Size = new System.Drawing.Size(224, 130);
            this.rtB_chequeos.TabIndex = 0;
            this.rtB_chequeos.Text = "";
            // 
            // L_nombrePPF
            // 
            this.L_nombrePPF.AutoSize = true;
            this.L_nombrePPF.Location = new System.Drawing.Point(18, 9);
            this.L_nombrePPF.Name = "L_nombrePPF";
            this.L_nombrePPF.Size = new System.Drawing.Size(35, 13);
            this.L_nombrePPF.TabIndex = 4;
            this.L_nombrePPF.Text = "label1";
            this.L_nombrePPF.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.L_nombrePPF);
            this.Controls.Add(this.panel_Chequeo);
            this.Controls.Add(this.bT_Finalizar);
            this.Controls.Add(this.bT_Imprimir);
            this.Controls.Add(this.bT_Guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CargarPPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Chequeo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CargarPPF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cB_Densidad;
        private System.Windows.Forms.CheckBox cB_DosePerFr;
        private System.Windows.Forms.CheckBox cB_TotalDose;
        private System.Windows.Forms.CheckBox cB_Grilla;
        private System.Windows.Forms.Button bT_Guardar;
        private System.Windows.Forms.Button bT_Imprimir;
        private System.Windows.Forms.Button bT_Finalizar;
        private System.Windows.Forms.Panel panel_Chequeo;
        private System.Windows.Forms.RichTextBox rtB_chequeos;
        private System.Windows.Forms.Label L_nombrePPF;
    }
}

