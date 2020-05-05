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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.BT_Eliminar.Location = new System.Drawing.Point(243, 108);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(107, 23);
            this.BT_Eliminar.TabIndex = 9;
            this.BT_Eliminar.Text = "Eliminar";
            this.BT_Eliminar.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_CargarPaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.L_ID);
            this.groupBox1.Controls.Add(this.L_Nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.L_Apellido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 157);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LB_ppfs);
            this.groupBox2.Controls.Add(this.BT_NuevoTratamiento);
            this.groupBox2.Controls.Add(this.TV_tratamientos);
            this.groupBox2.Controls.Add(this.BT_NuevaEtapa);
            this.groupBox2.Controls.Add(this.BT_Eliminar);
            this.groupBox2.Location = new System.Drawing.Point(195, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 157);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}