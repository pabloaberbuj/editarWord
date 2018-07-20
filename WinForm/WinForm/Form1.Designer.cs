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
            this.DGV_DatosPlan = new System.Windows.Forms.DataGridView();
            this.GB_CamposSetUp = new System.Windows.Forms.GroupBox();
            this.TB_SetUp2Tam = new System.Windows.Forms.TextBox();
            this.TB_SetUp2Gantry = new System.Windows.Forms.TextBox();
            this.TB_SetUp1Tam = new System.Windows.Forms.TextBox();
            this.TB_SetUp1Gantry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_Documentos = new System.Windows.Forms.GroupBox();
            this.RB_SoloInforme = new System.Windows.Forms.RadioButton();
            this.RB_SoloBEV = new System.Windows.Forms.RadioButton();
            this.RB_AmbosDocumentos = new System.Windows.Forms.RadioButton();
            this.GB_Imagenes = new System.Windows.Forms.GroupBox();
            this.CB_Imagenes3D = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BT_ActualizarImagenes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_Imágenes = new System.Windows.Forms.ListBox();
            this.CHB_SinImagenesSetUp = new System.Windows.Forms.CheckBox();
            this.L_ImagenesEncontradas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_ImagenesEsperadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ProfundidadesEfectivas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DGV_DatosPaciente = new System.Windows.Forms.DataGridView();
            this.CB_NumeroDeEtapas = new System.Windows.Forms.ComboBox();
            this.L_NumeroDeEtapas = new System.Windows.Forms.Label();
            this.BT_LimpiarFormulario = new System.Windows.Forms.Button();
            this.GB_DocumentosCreados = new System.Windows.Forms.GroupBox();
            this.L_DocCreado1 = new System.Windows.Forms.Label();
            this.L_DocCreado2 = new System.Windows.Forms.Label();
            this.L_DocCreado3 = new System.Windows.Forms.Label();
            this.L_DocCreado4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPlan)).BeginInit();
            this.GB_CamposSetUp.SuspendLayout();
            this.GB_Documentos.SuspendLayout();
            this.GB_Imagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).BeginInit();
            this.GB_DocumentosCreados.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Cargar
            // 
            this.BT_Cargar.Location = new System.Drawing.Point(9, 40);
            this.BT_Cargar.Name = "BT_Cargar";
            this.BT_Cargar.Size = new System.Drawing.Size(148, 23);
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
            this.BT_HacerDocumentos.Size = new System.Drawing.Size(144, 35);
            this.BT_HacerDocumentos.TabIndex = 21;
            this.BT_HacerDocumentos.Text = "Crear Documentos";
            this.BT_HacerDocumentos.UseVisualStyleBackColor = true;
            this.BT_HacerDocumentos.Click += new System.EventHandler(this.BT_HacerDocumentos_Click);
            // 
            // DGV_DatosPlan
            // 
            this.DGV_DatosPlan.AllowUserToAddRows = false;
            this.DGV_DatosPlan.AllowUserToDeleteRows = false;
            this.DGV_DatosPlan.AllowUserToResizeColumns = false;
            this.DGV_DatosPlan.AllowUserToResizeRows = false;
            this.DGV_DatosPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DatosPlan.ColumnHeadersVisible = false;
            this.DGV_DatosPlan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_DatosPlan.Location = new System.Drawing.Point(400, 161);
            this.DGV_DatosPlan.Name = "DGV_DatosPlan";
            this.DGV_DatosPlan.RowHeadersVisible = false;
            this.DGV_DatosPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_DatosPlan.Size = new System.Drawing.Size(227, 197);
            this.DGV_DatosPlan.TabIndex = 22;
            this.DGV_DatosPlan.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DatosPaciente_CellLeave);
            this.DGV_DatosPlan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DatosPaciente_CellLeave);
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
            this.GB_CamposSetUp.Location = new System.Drawing.Point(3, 78);
            this.GB_CamposSetUp.Name = "GB_CamposSetUp";
            this.GB_CamposSetUp.Size = new System.Drawing.Size(242, 100);
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
            // GB_Documentos
            // 
            this.GB_Documentos.Controls.Add(this.RB_SoloInforme);
            this.GB_Documentos.Controls.Add(this.RB_SoloBEV);
            this.GB_Documentos.Controls.Add(this.RB_AmbosDocumentos);
            this.GB_Documentos.Controls.Add(this.BT_HacerDocumentos);
            this.GB_Documentos.Location = new System.Drawing.Point(439, 376);
            this.GB_Documentos.Name = "GB_Documentos";
            this.GB_Documentos.Size = new System.Drawing.Size(188, 133);
            this.GB_Documentos.TabIndex = 38;
            this.GB_Documentos.TabStop = false;
            this.GB_Documentos.Text = "Documentos";
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
            // GB_Imagenes
            // 
            this.GB_Imagenes.Controls.Add(this.CB_Imagenes3D);
            this.GB_Imagenes.Controls.Add(this.label9);
            this.GB_Imagenes.Controls.Add(this.BT_ActualizarImagenes);
            this.GB_Imagenes.Controls.Add(this.label7);
            this.GB_Imagenes.Controls.Add(this.LB_Imágenes);
            this.GB_Imagenes.Controls.Add(this.CHB_SinImagenesSetUp);
            this.GB_Imagenes.Controls.Add(this.L_ImagenesEncontradas);
            this.GB_Imagenes.Controls.Add(this.label3);
            this.GB_Imagenes.Controls.Add(this.L_ImagenesEsperadas);
            this.GB_Imagenes.Controls.Add(this.label1);
            this.GB_Imagenes.Location = new System.Drawing.Point(3, 193);
            this.GB_Imagenes.Name = "GB_Imagenes";
            this.GB_Imagenes.Size = new System.Drawing.Size(382, 180);
            this.GB_Imagenes.TabIndex = 40;
            this.GB_Imagenes.TabStop = false;
            this.GB_Imagenes.Text = "Imágenes";
            // 
            // CB_Imagenes3D
            // 
            this.CB_Imagenes3D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Imagenes3D.FormattingEnabled = true;
            this.CB_Imagenes3D.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CB_Imagenes3D.Location = new System.Drawing.Point(85, 46);
            this.CB_Imagenes3D.Name = "CB_Imagenes3D";
            this.CB_Imagenes3D.Size = new System.Drawing.Size(68, 21);
            this.CB_Imagenes3D.TabIndex = 48;
            this.CB_Imagenes3D.SelectedIndexChanged += new System.EventHandler(this.ActualizarNumeroImagenes);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Imagenes 3D:";
            // 
            // BT_ActualizarImagenes
            // 
            this.BT_ActualizarImagenes.Location = new System.Drawing.Point(206, 152);
            this.BT_ActualizarImagenes.Name = "BT_ActualizarImagenes";
            this.BT_ActualizarImagenes.Size = new System.Drawing.Size(93, 22);
            this.BT_ActualizarImagenes.TabIndex = 46;
            this.BT_ActualizarImagenes.Text = "Actualizar";
            this.BT_ActualizarImagenes.UseVisualStyleBackColor = true;
            this.BT_ActualizarImagenes.Click += new System.EventHandler(this.BT_ActualizarImagenes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Lista imágenes (chequear)";
            // 
            // LB_Imágenes
            // 
            this.LB_Imágenes.FormattingEnabled = true;
            this.LB_Imágenes.HorizontalScrollbar = true;
            this.LB_Imágenes.Location = new System.Drawing.Point(206, 32);
            this.LB_Imágenes.Name = "LB_Imágenes";
            this.LB_Imágenes.Size = new System.Drawing.Size(170, 108);
            this.LB_Imágenes.TabIndex = 40;
            // 
            // CHB_SinImagenesSetUp
            // 
            this.CHB_SinImagenesSetUp.AutoSize = true;
            this.CHB_SinImagenesSetUp.Location = new System.Drawing.Point(9, 19);
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
            this.L_ImagenesEncontradas.Location = new System.Drawing.Point(130, 116);
            this.L_ImagenesEncontradas.Name = "L_ImagenesEncontradas";
            this.L_ImagenesEncontradas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEncontradas.TabIndex = 32;
            this.L_ImagenesEncontradas.Text = "label4";
            this.L_ImagenesEncontradas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Imagenes encontradas";
            // 
            // L_ImagenesEsperadas
            // 
            this.L_ImagenesEsperadas.AutoSize = true;
            this.L_ImagenesEsperadas.Location = new System.Drawing.Point(130, 94);
            this.L_ImagenesEsperadas.Name = "L_ImagenesEsperadas";
            this.L_ImagenesEsperadas.Size = new System.Drawing.Size(35, 13);
            this.L_ImagenesEsperadas.TabIndex = 30;
            this.L_ImagenesEsperadas.Text = "label2";
            this.L_ImagenesEsperadas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Imagenes esperadas";
            // 
            // TB_ProfundidadesEfectivas
            // 
            this.TB_ProfundidadesEfectivas.Location = new System.Drawing.Point(3, 397);
            this.TB_ProfundidadesEfectivas.Multiline = true;
            this.TB_ProfundidadesEfectivas.Name = "TB_ProfundidadesEfectivas";
            this.TB_ProfundidadesEfectivas.Size = new System.Drawing.Size(275, 103);
            this.TB_ProfundidadesEfectivas.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Profundidades efectivas";
            // 
            // DGV_DatosPaciente
            // 
            this.DGV_DatosPaciente.AllowUserToAddRows = false;
            this.DGV_DatosPaciente.AllowUserToDeleteRows = false;
            this.DGV_DatosPaciente.AllowUserToResizeColumns = false;
            this.DGV_DatosPaciente.AllowUserToResizeRows = false;
            this.DGV_DatosPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DatosPaciente.ColumnHeadersVisible = false;
            this.DGV_DatosPaciente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_DatosPaciente.Location = new System.Drawing.Point(400, 12);
            this.DGV_DatosPaciente.Name = "DGV_DatosPaciente";
            this.DGV_DatosPaciente.RowHeadersVisible = false;
            this.DGV_DatosPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_DatosPaciente.Size = new System.Drawing.Size(227, 127);
            this.DGV_DatosPaciente.TabIndex = 43;
            this.DGV_DatosPaciente.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DatosPaciente_CellLeave);
            this.DGV_DatosPaciente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DatosPaciente_CellLeave);
            // 
            // CB_NumeroDeEtapas
            // 
            this.CB_NumeroDeEtapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NumeroDeEtapas.FormattingEnabled = true;
            this.CB_NumeroDeEtapas.Items.AddRange(new object[] {
            "1 etapa",
            "2 etapas",
            "3 etapas"});
            this.CB_NumeroDeEtapas.Location = new System.Drawing.Point(103, 6);
            this.CB_NumeroDeEtapas.Name = "CB_NumeroDeEtapas";
            this.CB_NumeroDeEtapas.Size = new System.Drawing.Size(121, 21);
            this.CB_NumeroDeEtapas.TabIndex = 44;
            this.CB_NumeroDeEtapas.SelectedIndexChanged += new System.EventHandler(this.CB_NumeroDeEtapas_SelectedIndexChanged);
            // 
            // L_NumeroDeEtapas
            // 
            this.L_NumeroDeEtapas.AutoSize = true;
            this.L_NumeroDeEtapas.Location = new System.Drawing.Point(6, 9);
            this.L_NumeroDeEtapas.Name = "L_NumeroDeEtapas";
            this.L_NumeroDeEtapas.Size = new System.Drawing.Size(94, 13);
            this.L_NumeroDeEtapas.TabIndex = 45;
            this.L_NumeroDeEtapas.Text = "Número de etapas";
            // 
            // BT_LimpiarFormulario
            // 
            this.BT_LimpiarFormulario.Location = new System.Drawing.Point(292, 478);
            this.BT_LimpiarFormulario.Name = "BT_LimpiarFormulario";
            this.BT_LimpiarFormulario.Size = new System.Drawing.Size(93, 22);
            this.BT_LimpiarFormulario.TabIndex = 47;
            this.BT_LimpiarFormulario.Text = "Reiniciar";
            this.BT_LimpiarFormulario.UseVisualStyleBackColor = true;
            this.BT_LimpiarFormulario.Click += new System.EventHandler(this.BT_LimpiarFormulario_Click);
            // 
            // GB_DocumentosCreados
            // 
            this.GB_DocumentosCreados.Controls.Add(this.L_DocCreado4);
            this.GB_DocumentosCreados.Controls.Add(this.L_DocCreado3);
            this.GB_DocumentosCreados.Controls.Add(this.L_DocCreado2);
            this.GB_DocumentosCreados.Controls.Add(this.L_DocCreado1);
            this.GB_DocumentosCreados.Location = new System.Drawing.Point(252, 12);
            this.GB_DocumentosCreados.Name = "GB_DocumentosCreados";
            this.GB_DocumentosCreados.Size = new System.Drawing.Size(142, 146);
            this.GB_DocumentosCreados.TabIndex = 48;
            this.GB_DocumentosCreados.TabStop = false;
            this.GB_DocumentosCreados.Text = "Documentos creados";
            // 
            // L_DocCreado1
            // 
            this.L_DocCreado1.AutoSize = true;
            this.L_DocCreado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DocCreado1.ForeColor = System.Drawing.Color.Green;
            this.L_DocCreado1.Location = new System.Drawing.Point(27, 28);
            this.L_DocCreado1.Name = "L_DocCreado1";
            this.L_DocCreado1.Size = new System.Drawing.Size(77, 13);
            this.L_DocCreado1.TabIndex = 39;
            this.L_DocCreado1.Text = "DocCreado1";
            this.L_DocCreado1.Visible = false;
            // 
            // L_DocCreado2
            // 
            this.L_DocCreado2.AutoSize = true;
            this.L_DocCreado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DocCreado2.ForeColor = System.Drawing.Color.Green;
            this.L_DocCreado2.Location = new System.Drawing.Point(27, 53);
            this.L_DocCreado2.Name = "L_DocCreado2";
            this.L_DocCreado2.Size = new System.Drawing.Size(77, 13);
            this.L_DocCreado2.TabIndex = 40;
            this.L_DocCreado2.Text = "DocCreado2";
            this.L_DocCreado2.Visible = false;
            // 
            // L_DocCreado3
            // 
            this.L_DocCreado3.AutoSize = true;
            this.L_DocCreado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DocCreado3.ForeColor = System.Drawing.Color.Green;
            this.L_DocCreado3.Location = new System.Drawing.Point(27, 76);
            this.L_DocCreado3.Name = "L_DocCreado3";
            this.L_DocCreado3.Size = new System.Drawing.Size(77, 13);
            this.L_DocCreado3.TabIndex = 41;
            this.L_DocCreado3.Text = "DocCreado3";
            this.L_DocCreado3.Visible = false;
            // 
            // L_DocCreado4
            // 
            this.L_DocCreado4.AutoSize = true;
            this.L_DocCreado4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DocCreado4.ForeColor = System.Drawing.Color.Green;
            this.L_DocCreado4.Location = new System.Drawing.Point(27, 100);
            this.L_DocCreado4.Name = "L_DocCreado4";
            this.L_DocCreado4.Size = new System.Drawing.Size(77, 13);
            this.L_DocCreado4.TabIndex = 42;
            this.L_DocCreado4.Text = "DocCreado4";
            this.L_DocCreado4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 510);
            this.Controls.Add(this.GB_DocumentosCreados);
            this.Controls.Add(this.BT_LimpiarFormulario);
            this.Controls.Add(this.L_NumeroDeEtapas);
            this.Controls.Add(this.CB_NumeroDeEtapas);
            this.Controls.Add(this.DGV_DatosPaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_ProfundidadesEfectivas);
            this.Controls.Add(this.GB_Imagenes);
            this.Controls.Add(this.GB_Documentos);
            this.Controls.Add(this.GB_CamposSetUp);
            this.Controls.Add(this.DGV_DatosPlan);
            this.Controls.Add(this.BT_Cargar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armado de carpetas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPlan)).EndInit();
            this.GB_CamposSetUp.ResumeLayout(false);
            this.GB_CamposSetUp.PerformLayout();
            this.GB_Documentos.ResumeLayout(false);
            this.GB_Documentos.PerformLayout();
            this.GB_Imagenes.ResumeLayout(false);
            this.GB_Imagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DatosPaciente)).EndInit();
            this.GB_DocumentosCreados.ResumeLayout(false);
            this.GB_DocumentosCreados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Cargar;
        private System.Windows.Forms.Button BT_HacerDocumentos;
        private System.Windows.Forms.DataGridView DGV_DatosPlan;
        private System.Windows.Forms.GroupBox GB_CamposSetUp;
        private System.Windows.Forms.TextBox TB_SetUp2Tam;
        private System.Windows.Forms.TextBox TB_SetUp2Gantry;
        private System.Windows.Forms.TextBox TB_SetUp1Tam;
        private System.Windows.Forms.TextBox TB_SetUp1Gantry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GB_Documentos;
        private System.Windows.Forms.RadioButton RB_SoloInforme;
        private System.Windows.Forms.RadioButton RB_SoloBEV;
        private System.Windows.Forms.RadioButton RB_AmbosDocumentos;
        private System.Windows.Forms.GroupBox GB_Imagenes;
        private System.Windows.Forms.ListBox LB_Imágenes;
        private System.Windows.Forms.CheckBox CHB_SinImagenesSetUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_ProfundidadesEfectivas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label L_ImagenesEncontradas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_ImagenesEsperadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_DatosPaciente;
        private System.Windows.Forms.ComboBox CB_NumeroDeEtapas;
        private System.Windows.Forms.Label L_NumeroDeEtapas;
        private System.Windows.Forms.Button BT_ActualizarImagenes;
        private System.Windows.Forms.Button BT_LimpiarFormulario;
        private System.Windows.Forms.ComboBox CB_Imagenes3D;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GB_DocumentosCreados;
        private System.Windows.Forms.Label L_DocCreado4;
        private System.Windows.Forms.Label L_DocCreado3;
        private System.Windows.Forms.Label L_DocCreado2;
        private System.Windows.Forms.Label L_DocCreado1;
    }
}

