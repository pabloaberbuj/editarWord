namespace WinForm
{
    partial class Main
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
            this.BT_CargarPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_ppfs = new System.Windows.Forms.ListBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_Apellido = new System.Windows.Forms.Label();
            this.BT_NuevoTratamiento = new System.Windows.Forms.Button();
            this.BT_NuevaEtapa = new System.Windows.Forms.Button();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.TV_tratamientos = new System.Windows.Forms.TreeView();
            this.GB_cargaPaciente = new System.Windows.Forms.GroupBox();
            this.GB_esquemaTratamiento = new System.Windows.Forms.GroupBox();
            this.GB_ChequeoDeLosPlanes = new System.Windows.Forms.GroupBox();
            this.BT_RealizarChequeos = new System.Windows.Forms.Button();
            this.BT_VerProblemas = new System.Windows.Forms.Button();
            this.BT_ContinuarChequeos = new System.Windows.Forms.Button();
            this.BT_FinalizarEsquemaTratamiento = new System.Windows.Forms.Button();
            this.L_FallasChequeo = new System.Windows.Forms.Label();
            this.GB_cargaPaciente.SuspendLayout();
            this.GB_esquemaTratamiento.SuspendLayout();
            this.GB_ChequeoDeLosPlanes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_CargarPaciente
            // 
            this.BT_CargarPaciente.Location = new System.Drawing.Point(15, 19);
            this.BT_CargarPaciente.Name = "BT_CargarPaciente";
            this.BT_CargarPaciente.Size = new System.Drawing.Size(100, 25);
            this.BT_CargarPaciente.TabIndex = 0;
            this.BT_CargarPaciente.Text = "Cargar paciente";
            this.BT_CargarPaciente.UseVisualStyleBackColor = true;
            this.BT_CargarPaciente.Click += new System.EventHandler(this.BT_CargarPaciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // LB_ppfs
            // 
            this.LB_ppfs.FormattingEnabled = true;
            this.LB_ppfs.HorizontalScrollbar = true;
            this.LB_ppfs.Location = new System.Drawing.Point(10, 17);
            this.LB_ppfs.Name = "LB_ppfs";
            this.LB_ppfs.ScrollAlwaysVisible = true;
            this.LB_ppfs.Size = new System.Drawing.Size(227, 134);
            this.LB_ppfs.TabIndex = 3;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Location = new System.Drawing.Point(80, 63);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(35, 13);
            this.L_Nombre.TabIndex = 4;
            this.L_Nombre.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // L_Apellido
            // 
            this.L_Apellido.AutoSize = true;
            this.L_Apellido.Location = new System.Drawing.Point(80, 94);
            this.L_Apellido.Name = "L_Apellido";
            this.L_Apellido.Size = new System.Drawing.Size(35, 13);
            this.L_Apellido.TabIndex = 6;
            this.L_Apellido.Text = "label4";
            // 
            // BT_NuevoTratamiento
            // 
            this.BT_NuevoTratamiento.Location = new System.Drawing.Point(243, 19);
            this.BT_NuevoTratamiento.Name = "BT_NuevoTratamiento";
            this.BT_NuevoTratamiento.Size = new System.Drawing.Size(107, 23);
            this.BT_NuevoTratamiento.TabIndex = 7;
            this.BT_NuevoTratamiento.Text = "Nuevo Tratamiento";
            this.BT_NuevoTratamiento.UseVisualStyleBackColor = true;
            this.BT_NuevoTratamiento.Click += new System.EventHandler(this.BT_NuevoTratamiento_Click);
            // 
            // BT_NuevaEtapa
            // 
            this.BT_NuevaEtapa.Location = new System.Drawing.Point(243, 46);
            this.BT_NuevaEtapa.Name = "BT_NuevaEtapa";
            this.BT_NuevaEtapa.Size = new System.Drawing.Size(107, 23);
            this.BT_NuevaEtapa.TabIndex = 8;
            this.BT_NuevaEtapa.Text = "Nueva Etapa";
            this.BT_NuevaEtapa.UseVisualStyleBackColor = true;
            this.BT_NuevaEtapa.Click += new System.EventHandler(this.BT_NuevaEtapa_Click);
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.Location = new System.Drawing.Point(243, 89);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(107, 23);
            this.BT_Eliminar.TabIndex = 9;
            this.BT_Eliminar.Text = "Eliminar";
            this.BT_Eliminar.UseVisualStyleBackColor = true;
            this.BT_Eliminar.Click += new System.EventHandler(this.BT_Eliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(80, 125);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(35, 13);
            this.L_ID.TabIndex = 11;
            this.L_ID.Text = "label6";
            // 
            // TV_tratamientos
            // 
            this.TV_tratamientos.Location = new System.Drawing.Point(351, 17);
            this.TV_tratamientos.Name = "TV_tratamientos";
            this.TV_tratamientos.ShowNodeToolTips = true;
            this.TV_tratamientos.Size = new System.Drawing.Size(207, 134);
            this.TV_tratamientos.TabIndex = 12;
            // 
            // GB_cargaPaciente
            // 
            this.GB_cargaPaciente.Controls.Add(this.BT_CargarPaciente);
            this.GB_cargaPaciente.Controls.Add(this.label1);
            this.GB_cargaPaciente.Controls.Add(this.L_ID);
            this.GB_cargaPaciente.Controls.Add(this.L_Nombre);
            this.GB_cargaPaciente.Controls.Add(this.label5);
            this.GB_cargaPaciente.Controls.Add(this.label3);
            this.GB_cargaPaciente.Controls.Add(this.L_Apellido);
            this.GB_cargaPaciente.Location = new System.Drawing.Point(12, 12);
            this.GB_cargaPaciente.Name = "GB_cargaPaciente";
            this.GB_cargaPaciente.Size = new System.Drawing.Size(177, 157);
            this.GB_cargaPaciente.TabIndex = 13;
            this.GB_cargaPaciente.TabStop = false;
            this.GB_cargaPaciente.Text = "1. Carga paciente";
            // 
            // GB_esquemaTratamiento
            // 
            this.GB_esquemaTratamiento.Controls.Add(this.BT_FinalizarEsquemaTratamiento);
            this.GB_esquemaTratamiento.Controls.Add(this.LB_ppfs);
            this.GB_esquemaTratamiento.Controls.Add(this.BT_NuevoTratamiento);
            this.GB_esquemaTratamiento.Controls.Add(this.TV_tratamientos);
            this.GB_esquemaTratamiento.Controls.Add(this.BT_NuevaEtapa);
            this.GB_esquemaTratamiento.Controls.Add(this.BT_Eliminar);
            this.GB_esquemaTratamiento.Location = new System.Drawing.Point(195, 12);
            this.GB_esquemaTratamiento.Name = "GB_esquemaTratamiento";
            this.GB_esquemaTratamiento.Size = new System.Drawing.Size(564, 157);
            this.GB_esquemaTratamiento.TabIndex = 14;
            this.GB_esquemaTratamiento.TabStop = false;
            this.GB_esquemaTratamiento.Text = "2. Esquema de tratamiento";
            // 
            // GB_ChequeoDeLosPlanes
            // 
            this.GB_ChequeoDeLosPlanes.Controls.Add(this.L_FallasChequeo);
            this.GB_ChequeoDeLosPlanes.Controls.Add(this.BT_ContinuarChequeos);
            this.GB_ChequeoDeLosPlanes.Controls.Add(this.BT_VerProblemas);
            this.GB_ChequeoDeLosPlanes.Controls.Add(this.BT_RealizarChequeos);
            this.GB_ChequeoDeLosPlanes.Location = new System.Drawing.Point(12, 186);
            this.GB_ChequeoDeLosPlanes.Name = "GB_ChequeoDeLosPlanes";
            this.GB_ChequeoDeLosPlanes.Size = new System.Drawing.Size(177, 166);
            this.GB_ChequeoDeLosPlanes.TabIndex = 15;
            this.GB_ChequeoDeLosPlanes.TabStop = false;
            this.GB_ChequeoDeLosPlanes.Text = "3. Chequeo de los planes";
            // 
            // BT_RealizarChequeos
            // 
            this.BT_RealizarChequeos.Location = new System.Drawing.Point(33, 19);
            this.BT_RealizarChequeos.Name = "BT_RealizarChequeos";
            this.BT_RealizarChequeos.Size = new System.Drawing.Size(100, 25);
            this.BT_RealizarChequeos.TabIndex = 1;
            this.BT_RealizarChequeos.Text = "Chequear";
            this.BT_RealizarChequeos.UseVisualStyleBackColor = true;
            this.BT_RealizarChequeos.Click += new System.EventHandler(this.BT_RealizarChequeos_Click);
            // 
            // BT_VerProblemas
            // 
            this.BT_VerProblemas.Location = new System.Drawing.Point(33, 100);
            this.BT_VerProblemas.Name = "BT_VerProblemas";
            this.BT_VerProblemas.Size = new System.Drawing.Size(100, 25);
            this.BT_VerProblemas.TabIndex = 2;
            this.BT_VerProblemas.Text = "Ver problemas";
            this.BT_VerProblemas.UseVisualStyleBackColor = true;
            this.BT_VerProblemas.Click += new System.EventHandler(this.BT_VerProblemas_Click);
            // 
            // BT_ContinuarChequeos
            // 
            this.BT_ContinuarChequeos.Location = new System.Drawing.Point(33, 131);
            this.BT_ContinuarChequeos.Name = "BT_ContinuarChequeos";
            this.BT_ContinuarChequeos.Size = new System.Drawing.Size(100, 25);
            this.BT_ContinuarChequeos.TabIndex = 3;
            this.BT_ContinuarChequeos.Text = "Continuar";
            this.BT_ContinuarChequeos.UseVisualStyleBackColor = true;
            // 
            // BT_FinalizarEsquemaTratamiento
            // 
            this.BT_FinalizarEsquemaTratamiento.Location = new System.Drawing.Point(243, 118);
            this.BT_FinalizarEsquemaTratamiento.Name = "BT_FinalizarEsquemaTratamiento";
            this.BT_FinalizarEsquemaTratamiento.Size = new System.Drawing.Size(107, 30);
            this.BT_FinalizarEsquemaTratamiento.TabIndex = 13;
            this.BT_FinalizarEsquemaTratamiento.Text = "Finalizar";
            this.BT_FinalizarEsquemaTratamiento.UseVisualStyleBackColor = true;
            // 
            // L_FallasChequeo
            // 
            this.L_FallasChequeo.AutoSize = true;
            this.L_FallasChequeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_FallasChequeo.Location = new System.Drawing.Point(6, 59);
            this.L_FallasChequeo.Name = "L_FallasChequeo";
            this.L_FallasChequeo.Size = new System.Drawing.Size(45, 16);
            this.L_FallasChequeo.TabIndex = 12;
            this.L_FallasChequeo.Text = "label2";
            this.L_FallasChequeo.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.GB_ChequeoDeLosPlanes);
            this.Controls.Add(this.GB_esquemaTratamiento);
            this.Controls.Add(this.GB_cargaPaciente);
            this.Name = "Main";
            this.Text = "Main";
            this.GB_cargaPaciente.ResumeLayout(false);
            this.GB_cargaPaciente.PerformLayout();
            this.GB_esquemaTratamiento.ResumeLayout(false);
            this.GB_ChequeoDeLosPlanes.ResumeLayout(false);
            this.GB_ChequeoDeLosPlanes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_CargarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_ppfs;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_Apellido;
        private System.Windows.Forms.Button BT_NuevoTratamiento;
        private System.Windows.Forms.Button BT_NuevaEtapa;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.TreeView TV_tratamientos;
        private System.Windows.Forms.GroupBox GB_cargaPaciente;
        private System.Windows.Forms.GroupBox GB_esquemaTratamiento;
        private System.Windows.Forms.GroupBox GB_ChequeoDeLosPlanes;
        private System.Windows.Forms.Button BT_ContinuarChequeos;
        private System.Windows.Forms.Button BT_VerProblemas;
        private System.Windows.Forms.Button BT_RealizarChequeos;
        private System.Windows.Forms.Button BT_FinalizarEsquemaTratamiento;
        private System.Windows.Forms.Label L_FallasChequeo;
    }
}