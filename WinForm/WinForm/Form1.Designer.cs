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
            this.GB_CamposSetUp = new System.Windows.Forms.GroupBox();
            this.TB_SetUp2Tam = new System.Windows.Forms.TextBox();
            this.TB_SetUp2Gantry = new System.Windows.Forms.TextBox();
            this.TB_SetUp1Tam = new System.Windows.Forms.TextBox();
            this.TB_SetUp1Gantry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_AmbosDocumentos = new System.Windows.Forms.RadioButton();
            this.RB_SoloBEV = new System.Windows.Forms.RadioButton();
            this.RB_SoloInforme = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CHB_DosImagenes3D = new System.Windows.Forms.CheckBox();
            this.CHB_SinImagenesSetUp = new System.Windows.Forms.CheckBox();
            this.L_ImagenesEncontradas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_ImagenesEsperadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Imágenes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).BeginInit();
            this.GB_CamposSetUp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Cargar
            // 
            this.BT_Cargar.Location = new System.Drawing.Point(12, 12);
            this.BT_Cargar.Name = "BT_Cargar";
            this.BT_Cargar.Size = new System.Drawing.Size(97, 23);
            this.BT_Cargar.TabIndex = 0;
            this.BT_Cargar.Text = "Cargar PPF";
            this.BT_Cargar.UseVisualStyleBackColor = true;
            this.BT_Cargar.Click += new System.EventHandler(this.BT_CargarClick);
            // 
            // BT_HacerDocumentos
            // 
            this.BT_HacerDocumentos.Enabled = false;
            this.BT_HacerDocumentos.Location = new System.Drawing.Point(15, 89);
            this.BT_HacerDocumentos.Name = "BT_HacerDocumentos";
            this.BT_HacerDocumentos.Size = new System.Drawing.Size(144, 23);
            this.BT_HacerDocumentos.TabIndex = 21;
            this.BT_HacerDocumentos.Text = "Crear Documentos";
            this.BT_HacerDocumentos.UseVisualStyleBackColor = true;
            this.BT_HacerDocumentos.Click += new System.EventHandler(this.BT_HacerDocumentos_Click);
            // 
            // DGV_DatosPaciente
            // 
            this.DGV_DatosPaciente.AllowUserToAddRows = false;
            this.DGV_DatosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DatosPaciente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_DatosPaciente.Location = new System.Drawing.Point(400, 12);
            this.DGV_DatosPaciente.Name = "DGV_DatosPaciente";
            this.DGV_DatosPaciente.RowHeadersVisible = false;
            this.DGV_DatosPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_DatosPaciente.Size = new System.Drawing.Size(200, 323);
            this.DGV_DatosPaciente.TabIndex = 22;
            this.DGV_DatosPaciente.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DatosPaciente_CellLeave);
            this.DGV_DatosPaciente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DatosPaciente_CellLeave);
            // 
            // GB_CamposSetUp
            // 
            this.GB_CamposSetUp.Controls.Add(this.TB_SetUp2Tam);
            this.GB_CamposSetUp.Controls.Add(this.TB_SetUp2Gantry);
            this.GB_CamposSetUp.Controls.Add(this.TB_SetUp1Tam);
            this.GB_CamposSetUp.Controls.Add(this.TB_SetUp1Gantry);
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
            // TB_SetUp2Tam
            // 
            this.TB_SetUp2Tam.Location = new System.Drawing.Point(173, 60);
            this.TB_SetUp2Tam.Name = "TB_SetUp2Tam";
            this.TB_SetUp2Tam.Size = new System.Drawing.Size(59, 20);
            this.TB_SetUp2Tam.TabIndex = 44;
            // 
            // TB_SetUp2Gantry
            // 
            this.TB_SetUp2Gantry.Location = new System.Drawing.Point(108, 60);
            this.TB_SetUp2Gantry.Name = "TB_SetUp2Gantry";
            this.TB_SetUp2Gantry.Size = new System.Drawing.Size(59, 20);
            this.TB_SetUp2Gantry.TabIndex = 43;
            // 
            // TB_SetUp1Tam
            // 
            this.TB_SetUp1Tam.Location = new System.Drawing.Point(173, 36);
            this.TB_SetUp1Tam.Name = "TB_SetUp1Tam";
            this.TB_SetUp1Tam.Size = new System.Drawing.Size(59, 20);
            this.TB_SetUp1Tam.TabIndex = 42;
            // 
            // TB_SetUp1Gantry
            // 
            this.TB_SetUp1Gantry.Location = new System.Drawing.Point(108, 36);
            this.TB_SetUp1Gantry.Name = "TB_SetUp1Gantry";
            this.TB_SetUp1Gantry.Size = new System.Drawing.Size(59, 20);
            this.TB_SetUp1Gantry.TabIndex = 41;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_SoloInforme);
            this.groupBox1.Controls.Add(this.RB_SoloBEV);
            this.groupBox1.Controls.Add(this.RB_AmbosDocumentos);
            this.groupBox1.Controls.Add(this.BT_HacerDocumentos);
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 124);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos";
            // 
            // RB_AmbosDocumentos
            // 
            this.RB_AmbosDocumentos.AutoSize = true;
            this.RB_AmbosDocumentos.Location = new System.Drawing.Point(15, 20);
            this.RB_AmbosDocumentos.Name = "RB_AmbosDocumentos";
            this.RB_AmbosDocumentos.Size = new System.Drawing.Size(145, 17);
            this.RB_AmbosDocumentos.TabIndex = 22;
            this.RB_AmbosDocumentos.TabStop = true;
            this.RB_AmbosDocumentos.Text = "Crear ambos documentos";
            this.RB_AmbosDocumentos.UseVisualStyleBackColor = true;
            this.RB_AmbosDocumentos.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // RB_SoloBEV
            // 
            this.RB_SoloBEV.AutoSize = true;
            this.RB_SoloBEV.Location = new System.Drawing.Point(15, 43);
            this.RB_SoloBEV.Name = "RB_SoloBEV";
            this.RB_SoloBEV.Size = new System.Drawing.Size(96, 17);
            this.RB_SoloBEV.TabIndex = 23;
            this.RB_SoloBEV.TabStop = true;
            this.RB_SoloBEV.Text = "Crear sólo BEV";
            this.RB_SoloBEV.UseVisualStyleBackColor = true;
            this.RB_SoloBEV.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // RB_SoloInforme
            // 
            this.RB_SoloInforme.AutoSize = true;
            this.RB_SoloInforme.Location = new System.Drawing.Point(15, 66);
            this.RB_SoloInforme.Name = "RB_SoloInforme";
            this.RB_SoloInforme.Size = new System.Drawing.Size(110, 17);
            this.RB_SoloInforme.TabIndex = 24;
            this.RB_SoloInforme.TabStop = true;
            this.RB_SoloInforme.Text = "Crear sólo Informe";
            this.RB_SoloInforme.UseVisualStyleBackColor = true;
            this.RB_SoloInforme.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LB_Imágenes);
            this.groupBox2.Controls.Add(this.CHB_DosImagenes3D);
            this.groupBox2.Controls.Add(this.CHB_SinImagenesSetUp);
            this.groupBox2.Controls.Add(this.L_ImagenesEncontradas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.L_ImagenesEsperadas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 179);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imágenes";
            // 
            // CHB_DosImagenes3D
            // 
            this.CHB_DosImagenes3D.AutoSize = true;
            this.CHB_DosImagenes3D.Location = new System.Drawing.Point(13, 42);
            this.CHB_DosImagenes3D.Name = "CHB_DosImagenes3D";
            this.CHB_DosImagenes3D.Size = new System.Drawing.Size(130, 17);
            this.CHB_DosImagenes3D.TabIndex = 34;
            this.CHB_DosImagenes3D.Text = "Hay dos imágenes 3D";
            this.CHB_DosImagenes3D.UseVisualStyleBackColor = true;
            this.CHB_DosImagenes3D.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // CHB_SinImagenesSetUp
            // 
            this.CHB_SinImagenesSetUp.AutoSize = true;
            this.CHB_SinImagenesSetUp.Location = new System.Drawing.Point(13, 19);
            this.CHB_SinImagenesSetUp.Name = "CHB_SinImagenesSetUp";
            this.CHB_SinImagenesSetUp.Size = new System.Drawing.Size(154, 17);
            this.CHB_SinImagenesSetUp.TabIndex = 33;
            this.CHB_SinImagenesSetUp.Text = "No hay imágenes de setUp";
            this.CHB_SinImagenesSetUp.UseVisualStyleBackColor = true;
            this.CHB_SinImagenesSetUp.CheckedChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // L_ImagenesEncontradas
            // 
            this.L_ImagenesEncontradas.AutoSize = true;
            this.L_ImagenesEncontradas.Location = new System.Drawing.Point(134, 97);
            this.L_ImagenesEncontradas.Name = "L_ImagenesEncontradas";
            this.L_ImagenesEncontradas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEncontradas.TabIndex = 32;
            this.L_ImagenesEncontradas.Text = "label4";
            this.L_ImagenesEncontradas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Imagenes encontradas";
            // 
            // L_ImagenesEsperadas
            // 
            this.L_ImagenesEsperadas.AutoSize = true;
            this.L_ImagenesEsperadas.Location = new System.Drawing.Point(134, 75);
            this.L_ImagenesEsperadas.Name = "L_ImagenesEsperadas";
            this.L_ImagenesEsperadas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEsperadas.TabIndex = 30;
            this.L_ImagenesEsperadas.Text = "label2";
            this.L_ImagenesEsperadas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Imagenes esperadas";
            // 
            // LB_Imágenes
            // 
            this.LB_Imágenes.FormattingEnabled = true;
            this.LB_Imágenes.Location = new System.Drawing.Point(206, 19);
            this.LB_Imágenes.Name = "LB_Imágenes";
            this.LB_Imágenes.Size = new System.Drawing.Size(136, 147);
            this.LB_Imágenes.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_CamposSetUp);
            this.Controls.Add(this.DGV_DatosPaciente);
            this.Controls.Add(this.BT_Cargar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).EndInit();
            this.GB_CamposSetUp.ResumeLayout(false);
            this.GB_CamposSetUp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Cargar;
        private System.Windows.Forms.Button BT_HacerDocumentos;
        private System.Windows.Forms.DataGridView DGV_DatosPaciente;
        private System.Windows.Forms.GroupBox GB_CamposSetUp;
        private System.Windows.Forms.TextBox TB_SetUp2Tam;
        private System.Windows.Forms.TextBox TB_SetUp2Gantry;
        private System.Windows.Forms.TextBox TB_SetUp1Tam;
        private System.Windows.Forms.TextBox TB_SetUp1Gantry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_SoloInforme;
        private System.Windows.Forms.RadioButton RB_SoloBEV;
        private System.Windows.Forms.RadioButton RB_AmbosDocumentos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LB_Imágenes;
        private System.Windows.Forms.CheckBox CHB_DosImagenes3D;
        private System.Windows.Forms.CheckBox CHB_SinImagenesSetUp;
        private System.Windows.Forms.Label L_ImagenesEncontradas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_ImagenesEsperadas;
        private System.Windows.Forms.Label label1;
    }
}

