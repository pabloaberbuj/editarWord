﻿namespace WinForm
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
            this.GB_1cargaPaciente = new System.Windows.Forms.GroupBox();
            this.GB_2esquemaTratamiento = new System.Windows.Forms.GroupBox();
            this.BT_FinalizarEsquemaTratamiento = new System.Windows.Forms.Button();
            this.GB_3ChequeoAutomatico = new System.Windows.Forms.GroupBox();
            this.L_FallasChequeo = new System.Windows.Forms.Label();
            this.BT_FinalizarChequeos = new System.Windows.Forms.Button();
            this.BT_VerProblemas = new System.Windows.Forms.Button();
            this.BT_RealizarChequeos = new System.Windows.Forms.Button();
            this.GB_5IsosyPatMove = new System.Windows.Forms.GroupBox();
            this.BT_FinalizarIsos = new System.Windows.Forms.Button();
            this.DGV_Isos = new System.Windows.Forms.DataGridView();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patMOve = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GB_4ChequeoConformaciones = new System.Windows.Forms.GroupBox();
            this.BT_AbrirKilosPb = new System.Windows.Forms.Button();
            this.BT_EnviarMLCaShaper = new System.Windows.Forms.Button();
            this.L_conformaciones = new System.Windows.Forms.Label();
            this.BT_FinalizaChequeoConformaciones = new System.Windows.Forms.Button();
            this.BT_BuscarPatMove = new System.Windows.Forms.Button();
            this.GB_6ArmarCarpeta = new System.Windows.Forms.GroupBox();
            this.GB_7Finalizar = new System.Windows.Forms.GroupBox();
            this.BT_ArmarCarpeta = new System.Windows.Forms.Button();
            this.BT_ComprimirYEnviar = new System.Windows.Forms.Button();
            this.GB_1cargaPaciente.SuspendLayout();
            this.GB_2esquemaTratamiento.SuspendLayout();
            this.GB_3ChequeoAutomatico.SuspendLayout();
            this.GB_5IsosyPatMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Isos)).BeginInit();
            this.GB_4ChequeoConformaciones.SuspendLayout();
            this.GB_6ArmarCarpeta.SuspendLayout();
            this.GB_7Finalizar.SuspendLayout();
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
            // GB_1cargaPaciente
            // 
            this.GB_1cargaPaciente.Controls.Add(this.BT_CargarPaciente);
            this.GB_1cargaPaciente.Controls.Add(this.L_ID);
            this.GB_1cargaPaciente.Controls.Add(this.L_Nombre);
            this.GB_1cargaPaciente.Controls.Add(this.L_Apellido);
            this.GB_1cargaPaciente.Location = new System.Drawing.Point(12, 12);
            this.GB_1cargaPaciente.Name = "GB_1cargaPaciente";
            this.GB_1cargaPaciente.Size = new System.Drawing.Size(144, 157);
            this.GB_1cargaPaciente.TabIndex = 13;
            this.GB_1cargaPaciente.TabStop = false;
            this.GB_1cargaPaciente.Text = "1. Carga paciente";
            // 
            // GB_2esquemaTratamiento
            // 
            this.GB_2esquemaTratamiento.Controls.Add(this.BT_FinalizarEsquemaTratamiento);
            this.GB_2esquemaTratamiento.Controls.Add(this.LB_ppfs);
            this.GB_2esquemaTratamiento.Controls.Add(this.BT_NuevoTratamiento);
            this.GB_2esquemaTratamiento.Controls.Add(this.TV_tratamientos);
            this.GB_2esquemaTratamiento.Controls.Add(this.BT_NuevaEtapa);
            this.GB_2esquemaTratamiento.Controls.Add(this.BT_Eliminar);
            this.GB_2esquemaTratamiento.Enabled = false;
            this.GB_2esquemaTratamiento.Location = new System.Drawing.Point(162, 12);
            this.GB_2esquemaTratamiento.Name = "GB_2esquemaTratamiento";
            this.GB_2esquemaTratamiento.Size = new System.Drawing.Size(564, 157);
            this.GB_2esquemaTratamiento.TabIndex = 14;
            this.GB_2esquemaTratamiento.TabStop = false;
            this.GB_2esquemaTratamiento.Text = "2. Esquema de tratamiento";
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
            // GB_3ChequeoAutomatico
            // 
            this.GB_3ChequeoAutomatico.Controls.Add(this.L_FallasChequeo);
            this.GB_3ChequeoAutomatico.Controls.Add(this.BT_FinalizarChequeos);
            this.GB_3ChequeoAutomatico.Controls.Add(this.BT_VerProblemas);
            this.GB_3ChequeoAutomatico.Controls.Add(this.BT_RealizarChequeos);
            this.GB_3ChequeoAutomatico.Enabled = false;
            this.GB_3ChequeoAutomatico.Location = new System.Drawing.Point(742, 12);
            this.GB_3ChequeoAutomatico.Name = "GB_3ChequeoAutomatico";
            this.GB_3ChequeoAutomatico.Size = new System.Drawing.Size(169, 157);
            this.GB_3ChequeoAutomatico.TabIndex = 15;
            this.GB_3ChequeoAutomatico.TabStop = false;
            this.GB_3ChequeoAutomatico.Text = "3. Chequeo automatico";
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
            // GB_5IsosyPatMove
            // 
            this.GB_5IsosyPatMove.Controls.Add(this.BT_BuscarPatMove);
            this.GB_5IsosyPatMove.Controls.Add(this.BT_FinalizarIsos);
            this.GB_5IsosyPatMove.Controls.Add(this.DGV_Isos);
            this.GB_5IsosyPatMove.Enabled = false;
            this.GB_5IsosyPatMove.Location = new System.Drawing.Point(243, 192);
            this.GB_5IsosyPatMove.Name = "GB_5IsosyPatMove";
            this.GB_5IsosyPatMove.Size = new System.Drawing.Size(632, 198);
            this.GB_5IsosyPatMove.TabIndex = 16;
            this.GB_5IsosyPatMove.TabStop = false;
            this.GB_5IsosyPatMove.Text = "5. Isos y patMove";
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
            this.DGV_Isos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_Isos.Location = new System.Drawing.Point(19, 19);
            this.DGV_Isos.MultiSelect = false;
            this.DGV_Isos.Name = "DGV_Isos";
            this.DGV_Isos.RowHeadersVisible = false;
            this.DGV_Isos.Size = new System.Drawing.Size(607, 137);
            this.DGV_Isos.TabIndex = 0;
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
            // GB_4ChequeoConformaciones
            // 
            this.GB_4ChequeoConformaciones.Controls.Add(this.BT_AbrirKilosPb);
            this.GB_4ChequeoConformaciones.Controls.Add(this.BT_EnviarMLCaShaper);
            this.GB_4ChequeoConformaciones.Controls.Add(this.L_conformaciones);
            this.GB_4ChequeoConformaciones.Controls.Add(this.BT_FinalizaChequeoConformaciones);
            this.GB_4ChequeoConformaciones.Enabled = false;
            this.GB_4ChequeoConformaciones.Location = new System.Drawing.Point(12, 192);
            this.GB_4ChequeoConformaciones.Name = "GB_4ChequeoConformaciones";
            this.GB_4ChequeoConformaciones.Size = new System.Drawing.Size(200, 198);
            this.GB_4ChequeoConformaciones.TabIndex = 13;
            this.GB_4ChequeoConformaciones.TabStop = false;
            this.GB_4ChequeoConformaciones.Text = "4. Chequeo conformaciones";
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
            // BT_EnviarMLCaShaper
            // 
            this.BT_EnviarMLCaShaper.Location = new System.Drawing.Point(15, 85);
            this.BT_EnviarMLCaShaper.Name = "BT_EnviarMLCaShaper";
            this.BT_EnviarMLCaShaper.Size = new System.Drawing.Size(129, 25);
            this.BT_EnviarMLCaShaper.TabIndex = 15;
            this.BT_EnviarMLCaShaper.Text = "Enviar MLC a Shaper";
            this.BT_EnviarMLCaShaper.UseVisualStyleBackColor = true;
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
            // BT_BuscarPatMove
            // 
            this.BT_BuscarPatMove.Location = new System.Drawing.Point(19, 162);
            this.BT_BuscarPatMove.Name = "BT_BuscarPatMove";
            this.BT_BuscarPatMove.Size = new System.Drawing.Size(100, 25);
            this.BT_BuscarPatMove.TabIndex = 14;
            this.BT_BuscarPatMove.Text = "Buscar";
            this.BT_BuscarPatMove.UseVisualStyleBackColor = true;
            this.BT_BuscarPatMove.Click += new System.EventHandler(this.BT_BuscarPatMove_Click);
            // 
            // GB_6ArmarCarpeta
            // 
            this.GB_6ArmarCarpeta.Controls.Add(this.BT_ArmarCarpeta);
            this.GB_6ArmarCarpeta.Enabled = false;
            this.GB_6ArmarCarpeta.Location = new System.Drawing.Point(12, 397);
            this.GB_6ArmarCarpeta.Name = "GB_6ArmarCarpeta";
            this.GB_6ArmarCarpeta.Size = new System.Drawing.Size(200, 89);
            this.GB_6ArmarCarpeta.TabIndex = 17;
            this.GB_6ArmarCarpeta.TabStop = false;
            this.GB_6ArmarCarpeta.Text = "6. Armar BEVs e informe";
            // 
            // GB_7Finalizar
            // 
            this.GB_7Finalizar.Controls.Add(this.BT_ComprimirYEnviar);
            this.GB_7Finalizar.Enabled = false;
            this.GB_7Finalizar.Location = new System.Drawing.Point(243, 397);
            this.GB_7Finalizar.Name = "GB_7Finalizar";
            this.GB_7Finalizar.Size = new System.Drawing.Size(168, 85);
            this.GB_7Finalizar.TabIndex = 18;
            this.GB_7Finalizar.TabStop = false;
            this.GB_7Finalizar.Text = "7. Finalizar";
            // 
            // BT_ArmarCarpeta
            // 
            this.BT_ArmarCarpeta.Location = new System.Drawing.Point(34, 35);
            this.BT_ArmarCarpeta.Name = "BT_ArmarCarpeta";
            this.BT_ArmarCarpeta.Size = new System.Drawing.Size(129, 25);
            this.BT_ArmarCarpeta.TabIndex = 17;
            this.BT_ArmarCarpeta.Text = "Armar BEVs e informe";
            this.BT_ArmarCarpeta.UseVisualStyleBackColor = true;
            this.BT_ArmarCarpeta.Click += new System.EventHandler(this.BT_ArmarCarpeta_Click);
            // 
            // BT_ComprimirYEnviar
            // 
            this.BT_ComprimirYEnviar.Location = new System.Drawing.Point(30, 25);
            this.BT_ComprimirYEnviar.Name = "BT_ComprimirYEnviar";
            this.BT_ComprimirYEnviar.Size = new System.Drawing.Size(100, 44);
            this.BT_ComprimirYEnviar.TabIndex = 15;
            this.BT_ComprimirYEnviar.Text = "Comprimir y enviar archivos";
            this.BT_ComprimirYEnviar.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 498);
            this.Controls.Add(this.GB_7Finalizar);
            this.Controls.Add(this.GB_6ArmarCarpeta);
            this.Controls.Add(this.GB_4ChequeoConformaciones);
            this.Controls.Add(this.GB_5IsosyPatMove);
            this.Controls.Add(this.GB_3ChequeoAutomatico);
            this.Controls.Add(this.GB_2esquemaTratamiento);
            this.Controls.Add(this.GB_1cargaPaciente);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.GB_1cargaPaciente.ResumeLayout(false);
            this.GB_1cargaPaciente.PerformLayout();
            this.GB_2esquemaTratamiento.ResumeLayout(false);
            this.GB_3ChequeoAutomatico.ResumeLayout(false);
            this.GB_3ChequeoAutomatico.PerformLayout();
            this.GB_5IsosyPatMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Isos)).EndInit();
            this.GB_4ChequeoConformaciones.ResumeLayout(false);
            this.GB_4ChequeoConformaciones.PerformLayout();
            this.GB_6ArmarCarpeta.ResumeLayout(false);
            this.GB_7Finalizar.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox GB_1cargaPaciente;
        private System.Windows.Forms.GroupBox GB_2esquemaTratamiento;
        private System.Windows.Forms.GroupBox GB_3ChequeoAutomatico;
        private System.Windows.Forms.Button BT_FinalizarChequeos;
        private System.Windows.Forms.Button BT_VerProblemas;
        private System.Windows.Forms.Button BT_RealizarChequeos;
        private System.Windows.Forms.Button BT_FinalizarEsquemaTratamiento;
        private System.Windows.Forms.Label L_FallasChequeo;
        private System.Windows.Forms.GroupBox GB_5IsosyPatMove;
        private System.Windows.Forms.DataGridView DGV_Isos;
        private System.Windows.Forms.Button BT_FinalizarIsos;
        private System.Windows.Forms.GroupBox GB_4ChequeoConformaciones;
        private System.Windows.Forms.Button BT_AbrirKilosPb;
        private System.Windows.Forms.Button BT_EnviarMLCaShaper;
        private System.Windows.Forms.Label L_conformaciones;
        private System.Windows.Forms.Button BT_FinalizaChequeoConformaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppf;
        private System.Windows.Forms.DataGridViewTextBoxColumn iso;
        private System.Windows.Forms.DataGridViewComboBoxColumn patMOve;
        private System.Windows.Forms.Button BT_BuscarPatMove;
        private System.Windows.Forms.GroupBox GB_6ArmarCarpeta;
        private System.Windows.Forms.Button BT_ArmarCarpeta;
        private System.Windows.Forms.GroupBox GB_7Finalizar;
        private System.Windows.Forms.Button BT_ComprimirYEnviar;
    }
}