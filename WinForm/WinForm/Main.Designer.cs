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
            this.LB_ppfs = new System.Windows.Forms.ListBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_Apellido = new System.Windows.Forms.Label();
            this.BT_NuevoTratamiento = new System.Windows.Forms.Button();
            this.BT_NuevaEtapa = new System.Windows.Forms.Button();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.L_ID = new System.Windows.Forms.Label();
            this.TV_tratamientos = new System.Windows.Forms.TreeView();
            this.GB_cargaPaciente = new System.Windows.Forms.GroupBox();
            this.GB_esquemaTratamiento = new System.Windows.Forms.GroupBox();
            this.GB_ChequeoAutomatico = new System.Windows.Forms.GroupBox();
            this.BT_RealizarChequeos = new System.Windows.Forms.Button();
            this.BT_VerProblemas = new System.Windows.Forms.Button();
            this.BT_FinalizarChequeos = new System.Windows.Forms.Button();
            this.BT_FinalizarEsquemaTratamiento = new System.Windows.Forms.Button();
            this.L_FallasChequeo = new System.Windows.Forms.Label();
            this.GB_IsosyPatMove = new System.Windows.Forms.GroupBox();
            this.DGV_Isos = new System.Windows.Forms.DataGridView();
            this.BT_FinalizarIsos = new System.Windows.Forms.Button();
            this.GB_ChequeoConformaciones = new System.Windows.Forms.GroupBox();
            this.BT_FinalizaChequeoConformaciones = new System.Windows.Forms.Button();
            this.L_conformaciones = new System.Windows.Forms.Label();
            this.BT_EnviarMLCaShaper = new System.Windows.Forms.Button();
            this.BT_AbrirKilosPb = new System.Windows.Forms.Button();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patMOve = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GB_cargaPaciente.SuspendLayout();
            this.GB_esquemaTratamiento.SuspendLayout();
            this.GB_ChequeoAutomatico.SuspendLayout();
            this.GB_IsosyPatMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Isos)).BeginInit();
            this.GB_ChequeoConformaciones.SuspendLayout();
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
            this.L_Nombre.Location = new System.Drawing.Point(12, 62);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(35, 13);
            this.L_Nombre.TabIndex = 4;
            this.L_Nombre.Text = "label2";
            // 
            // L_Apellido
            // 
            this.L_Apellido.AutoSize = true;
            this.L_Apellido.Location = new System.Drawing.Point(12, 93);
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
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(12, 124);
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
            this.GB_cargaPaciente.Controls.Add(this.L_ID);
            this.GB_cargaPaciente.Controls.Add(this.L_Nombre);
            this.GB_cargaPaciente.Controls.Add(this.L_Apellido);
            this.GB_cargaPaciente.Location = new System.Drawing.Point(12, 12);
            this.GB_cargaPaciente.Name = "GB_cargaPaciente";
            this.GB_cargaPaciente.Size = new System.Drawing.Size(144, 157);
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
            this.GB_esquemaTratamiento.Enabled = false;
            this.GB_esquemaTratamiento.Location = new System.Drawing.Point(162, 12);
            this.GB_esquemaTratamiento.Name = "GB_esquemaTratamiento";
            this.GB_esquemaTratamiento.Size = new System.Drawing.Size(564, 157);
            this.GB_esquemaTratamiento.TabIndex = 14;
            this.GB_esquemaTratamiento.TabStop = false;
            this.GB_esquemaTratamiento.Text = "2. Esquema de tratamiento";
            // 
            // GB_ChequeoAutomatico
            // 
            this.GB_ChequeoAutomatico.Controls.Add(this.L_FallasChequeo);
            this.GB_ChequeoAutomatico.Controls.Add(this.BT_FinalizarChequeos);
            this.GB_ChequeoAutomatico.Controls.Add(this.BT_VerProblemas);
            this.GB_ChequeoAutomatico.Controls.Add(this.BT_RealizarChequeos);
            this.GB_ChequeoAutomatico.Enabled = false;
            this.GB_ChequeoAutomatico.Location = new System.Drawing.Point(742, 12);
            this.GB_ChequeoAutomatico.Name = "GB_ChequeoAutomatico";
            this.GB_ChequeoAutomatico.Size = new System.Drawing.Size(169, 157);
            this.GB_ChequeoAutomatico.TabIndex = 15;
            this.GB_ChequeoAutomatico.TabStop = false;
            this.GB_ChequeoAutomatico.Text = "3. Chequeo automatico";
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
            this.BT_VerProblemas.Location = new System.Drawing.Point(33, 95);
            this.BT_VerProblemas.Name = "BT_VerProblemas";
            this.BT_VerProblemas.Size = new System.Drawing.Size(100, 25);
            this.BT_VerProblemas.TabIndex = 2;
            this.BT_VerProblemas.Text = "Ver problemas";
            this.BT_VerProblemas.UseVisualStyleBackColor = true;
            this.BT_VerProblemas.Click += new System.EventHandler(this.BT_VerProblemas_Click);
            // 
            // BT_FinalizarChequeos
            // 
            this.BT_FinalizarChequeos.Location = new System.Drawing.Point(33, 126);
            this.BT_FinalizarChequeos.Name = "BT_FinalizarChequeos";
            this.BT_FinalizarChequeos.Size = new System.Drawing.Size(100, 25);
            this.BT_FinalizarChequeos.TabIndex = 3;
            this.BT_FinalizarChequeos.Text = "Continuar";
            this.BT_FinalizarChequeos.UseVisualStyleBackColor = true;
            this.BT_FinalizarChequeos.Click += new System.EventHandler(this.BT_ContinuarChequeos_Click);
            // 
            // BT_FinalizarEsquemaTratamiento
            // 
            this.BT_FinalizarEsquemaTratamiento.Location = new System.Drawing.Point(243, 118);
            this.BT_FinalizarEsquemaTratamiento.Name = "BT_FinalizarEsquemaTratamiento";
            this.BT_FinalizarEsquemaTratamiento.Size = new System.Drawing.Size(107, 30);
            this.BT_FinalizarEsquemaTratamiento.TabIndex = 13;
            this.BT_FinalizarEsquemaTratamiento.Text = "Continuar";
            this.BT_FinalizarEsquemaTratamiento.UseVisualStyleBackColor = true;
            this.BT_FinalizarEsquemaTratamiento.Click += new System.EventHandler(this.BT_FinalizarEsquemaTratamiento_Click);
            // 
            // L_FallasChequeo
            // 
            this.L_FallasChequeo.AutoSize = true;
            this.L_FallasChequeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_FallasChequeo.Location = new System.Drawing.Point(6, 53);
            this.L_FallasChequeo.Name = "L_FallasChequeo";
            this.L_FallasChequeo.Size = new System.Drawing.Size(45, 16);
            this.L_FallasChequeo.TabIndex = 12;
            this.L_FallasChequeo.Text = "label2";
            this.L_FallasChequeo.Visible = false;
            // 
            // GB_IsosyPatMove
            // 
            this.GB_IsosyPatMove.Controls.Add(this.BT_FinalizarIsos);
            this.GB_IsosyPatMove.Controls.Add(this.DGV_Isos);
            this.GB_IsosyPatMove.Enabled = false;
            this.GB_IsosyPatMove.Location = new System.Drawing.Point(243, 192);
            this.GB_IsosyPatMove.Name = "GB_IsosyPatMove";
            this.GB_IsosyPatMove.Size = new System.Drawing.Size(632, 198);
            this.GB_IsosyPatMove.TabIndex = 16;
            this.GB_IsosyPatMove.TabStop = false;
            this.GB_IsosyPatMove.Text = "5. Isos y patMove";
            // 
            // DGV_Isos
            // 
            this.DGV_Isos.AllowUserToAddRows = false;
            this.DGV_Isos.AllowUserToDeleteRows = false;
            this.DGV_Isos.AllowUserToResizeColumns = false;
            this.DGV_Isos.AllowUserToResizeRows = false;
            this.DGV_Isos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Isos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tratamiento,
            this.Etapa,
            this.ppf,
            this.iso,
            this.patMOve});
            this.DGV_Isos.Location = new System.Drawing.Point(19, 19);
            this.DGV_Isos.MultiSelect = false;
            this.DGV_Isos.Name = "DGV_Isos";
            this.DGV_Isos.RowHeadersVisible = false;
            this.DGV_Isos.Size = new System.Drawing.Size(607, 137);
            this.DGV_Isos.TabIndex = 0;
            // 
            // BT_FinalizarIsos
            // 
            this.BT_FinalizarIsos.Location = new System.Drawing.Point(526, 162);
            this.BT_FinalizarIsos.Name = "BT_FinalizarIsos";
            this.BT_FinalizarIsos.Size = new System.Drawing.Size(100, 25);
            this.BT_FinalizarIsos.TabIndex = 13;
            this.BT_FinalizarIsos.Text = "Continuar";
            this.BT_FinalizarIsos.UseVisualStyleBackColor = true;
            this.BT_FinalizarIsos.Click += new System.EventHandler(this.BT_FinalizarIsos_Click);
            // 
            // GB_ChequeoConformaciones
            // 
            this.GB_ChequeoConformaciones.Controls.Add(this.BT_AbrirKilosPb);
            this.GB_ChequeoConformaciones.Controls.Add(this.BT_EnviarMLCaShaper);
            this.GB_ChequeoConformaciones.Controls.Add(this.L_conformaciones);
            this.GB_ChequeoConformaciones.Controls.Add(this.BT_FinalizaChequeoConformaciones);
            this.GB_ChequeoConformaciones.Enabled = false;
            this.GB_ChequeoConformaciones.Location = new System.Drawing.Point(12, 192);
            this.GB_ChequeoConformaciones.Name = "GB_ChequeoConformaciones";
            this.GB_ChequeoConformaciones.Size = new System.Drawing.Size(200, 198);
            this.GB_ChequeoConformaciones.TabIndex = 13;
            this.GB_ChequeoConformaciones.TabStop = false;
            this.GB_ChequeoConformaciones.Text = "4. Chequeo conformaciones";
            // 
            // BT_FinalizaChequeoConformaciones
            // 
            this.BT_FinalizaChequeoConformaciones.Location = new System.Drawing.Point(94, 162);
            this.BT_FinalizaChequeoConformaciones.Name = "BT_FinalizaChequeoConformaciones";
            this.BT_FinalizaChequeoConformaciones.Size = new System.Drawing.Size(100, 25);
            this.BT_FinalizaChequeoConformaciones.TabIndex = 14;
            this.BT_FinalizaChequeoConformaciones.Text = "Continuar";
            this.BT_FinalizaChequeoConformaciones.UseVisualStyleBackColor = true;
            this.BT_FinalizaChequeoConformaciones.Click += new System.EventHandler(this.BT_FinalizaChequeoConformaciones_Click);
            // 
            // L_conformaciones
            // 
            this.L_conformaciones.AutoSize = true;
            this.L_conformaciones.Location = new System.Drawing.Point(12, 36);
            this.L_conformaciones.Name = "L_conformaciones";
            this.L_conformaciones.Size = new System.Drawing.Size(35, 13);
            this.L_conformaciones.TabIndex = 12;
            this.L_conformaciones.Text = "label2";
            this.L_conformaciones.Visible = false;
            // 
            // BT_EnviarMLCaShaper
            // 
            this.BT_EnviarMLCaShaper.Location = new System.Drawing.Point(15, 85);
            this.BT_EnviarMLCaShaper.Name = "BT_EnviarMLCaShaper";
            this.BT_EnviarMLCaShaper.Size = new System.Drawing.Size(129, 25);
            this.BT_EnviarMLCaShaper.TabIndex = 15;
            this.BT_EnviarMLCaShaper.Text = "Enviar MLC a Shaper";
            this.BT_EnviarMLCaShaper.UseVisualStyleBackColor = true;
            // 
            // BT_AbrirKilosPb
            // 
            this.BT_AbrirKilosPb.Location = new System.Drawing.Point(15, 116);
            this.BT_AbrirKilosPb.Name = "BT_AbrirKilosPb";
            this.BT_AbrirKilosPb.Size = new System.Drawing.Size(129, 25);
            this.BT_AbrirKilosPb.TabIndex = 16;
            this.BT_AbrirKilosPb.Text = "Abrir KilosPb";
            this.BT_AbrirKilosPb.UseVisualStyleBackColor = true;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            // 
            // Etapa
            // 
            this.Etapa.HeaderText = "Et";
            this.Etapa.Name = "Etapa";
            this.Etapa.Width = 40;
            // 
            // ppf
            // 
            this.ppf.HeaderText = "ppf";
            this.ppf.Name = "ppf";
            this.ppf.Width = 170;
            // 
            // iso
            // 
            this.iso.HeaderText = "iso";
            this.iso.Name = "iso";
            this.iso.Width = 40;
            // 
            // patMOve
            // 
            this.patMOve.HeaderText = "patMove";
            this.patMOve.Name = "patMOve";
            this.patMOve.Width = 200;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 498);
            this.Controls.Add(this.GB_ChequeoConformaciones);
            this.Controls.Add(this.GB_IsosyPatMove);
            this.Controls.Add(this.GB_ChequeoAutomatico);
            this.Controls.Add(this.GB_esquemaTratamiento);
            this.Controls.Add(this.GB_cargaPaciente);
            this.Name = "Main";
            this.Text = "Main";
            this.GB_cargaPaciente.ResumeLayout(false);
            this.GB_cargaPaciente.PerformLayout();
            this.GB_esquemaTratamiento.ResumeLayout(false);
            this.GB_ChequeoAutomatico.ResumeLayout(false);
            this.GB_ChequeoAutomatico.PerformLayout();
            this.GB_IsosyPatMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Isos)).EndInit();
            this.GB_ChequeoConformaciones.ResumeLayout(false);
            this.GB_ChequeoConformaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_CargarPaciente;
        private System.Windows.Forms.ListBox LB_ppfs;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_Apellido;
        private System.Windows.Forms.Button BT_NuevoTratamiento;
        private System.Windows.Forms.Button BT_NuevaEtapa;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.TreeView TV_tratamientos;
        private System.Windows.Forms.GroupBox GB_cargaPaciente;
        private System.Windows.Forms.GroupBox GB_esquemaTratamiento;
        private System.Windows.Forms.GroupBox GB_ChequeoAutomatico;
        private System.Windows.Forms.Button BT_FinalizarChequeos;
        private System.Windows.Forms.Button BT_VerProblemas;
        private System.Windows.Forms.Button BT_RealizarChequeos;
        private System.Windows.Forms.Button BT_FinalizarEsquemaTratamiento;
        private System.Windows.Forms.Label L_FallasChequeo;
        private System.Windows.Forms.GroupBox GB_IsosyPatMove;
        private System.Windows.Forms.DataGridView DGV_Isos;
        private System.Windows.Forms.Button BT_FinalizarIsos;
        private System.Windows.Forms.GroupBox GB_ChequeoConformaciones;
        private System.Windows.Forms.Button BT_AbrirKilosPb;
        private System.Windows.Forms.Button BT_EnviarMLCaShaper;
        private System.Windows.Forms.Label L_conformaciones;
        private System.Windows.Forms.Button BT_FinalizaChequeoConformaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppf;
        private System.Windows.Forms.DataGridViewTextBoxColumn iso;
        private System.Windows.Forms.DataGridViewComboBoxColumn patMOve;
    }
}