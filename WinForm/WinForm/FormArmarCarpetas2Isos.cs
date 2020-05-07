using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xceed.Words.NET;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WinForm
{
    public partial class FormArmarCarpetas2Isos : Form
    {
        Paciente paciente = new Paciente();
        Tratamiento tratamiento = new Tratamiento();
        Plan etapa = new Plan();
        List<Label> docCreados = new List<Label>();
        Dictionary<string, string> Diccionario = Equipos.diccionario();


        int etapaNumero = 1;
        int indiceLabelDocCreados = 0;

        public FormArmarCarpetas2Isos(Paciente _paciente, Tratamiento _tratamiento)
        {
            paciente = _paciente;
            tratamiento = _tratamiento;
            InitializeComponent();
            BT_HacerDocumentos.Enabled = false;
            RB_AmbosDocumentos.Checked = true;
            RB_SoloBEV.Checked = false;
            RB_SoloInforme.Checked = false;
            L_ImagenesEsperadas.Visible = false;
            L_ImagenesEncontradas.Visible = false;
            LB_Imágenes.Items.Clear();
            GB_Imagenes.Enabled = false;
            GB_CamposSetUp.Enabled = false;
            GB_Documentos.Enabled = false;
            TB_ProfundidadesEfectivas.Enabled = false;
            CB_NumeroDeEtapas.SelectedIndex = tratamiento.planes.Count - 1;
            CB_NumeroDeEtapas.Enabled = false;
            limpiarLabelsDocCreado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Chequear.archivoConfiguracion())
            {
                MessageBox.Show("No se encuentra el archivo Configuración.txt. El programa se cerrará");
                this.Close();
            }
            else
            {
                if (!Chequear.directorioExport())
                {
                    MessageBox.Show("No se encuentra la carpeta Export en la dirección indicada.\nRevise el archivo Configuracion.txt");
                    this.Close();
                }
            }
            if (!Chequear.archivoEquipos())
            {
                MessageBox.Show("No se encuentra el archivo Equipos.txt. El programa se cerrará");
                this.Close();
            }
            docCreados.Add(L_DocCreado1);
            docCreados.Add(L_DocCreado2);
            docCreados.Add(L_DocCreado3);
            docCreados.Add(L_DocCreado4);
            iniciarEtapa();
        }

        private void BT_CargarClick(object sender, EventArgs e)
        {

        }

        private void iniciarEtapa()
        {
            etapa = tratamiento.planes[etapaNumero-1];
            
            this.Text = "Armado de carpetas " + paciente.apellidoNombre + "-" + tratamiento.nombre + " etapa "+ (etapaNumero).ToString();
            cargarDGVdePaciente(paciente);
            BT_HacerDocumentos.Enabled = true;
            habilitarControles();
            inicializarSetUP();
            //hayMasDeUnISO();

            cargarDGVdePlan(etapa);
            escribirLabels(etapa, paciente);
            cargarListaImagenes();
            GB_Imagenes.Enabled = true;
            GB_CamposSetUp.Enabled = true;
            GB_Documentos.Enabled = true;
            TB_ProfundidadesEfectivas.Enabled = true;
            if (numeroDeEtapas() == 1)
            {
                RB_AmbosDocumentos.Enabled = true;
                RB_SoloBEV.Enabled = true;
                RB_AmbosDocumentos.Checked = true;
                RB_SoloInforme.Enabled = true;
                escribirLabelDocCreado("...en proceso BEV" + agregarIsosALabel(etapa), indiceLabelDocCreados, true);
            }
            if (numeroDeEtapas() > 1)
            {
                RB_AmbosDocumentos.Enabled = false;
                RB_SoloBEV.Enabled = true;
                RB_SoloBEV.Checked = true;
                RB_SoloInforme.Enabled = false;
                escribirLabelDocCreado("...en proceso BEV etapa " + etapaNumero.ToString() + agregarIsosALabel(etapa), indiceLabelDocCreados, true);
            }

        }
        private void cargarDGVdePlan(Plan plan)
        {
            DGV_DatosPlan.Rows.Clear();
            PropertyInfo[] propiedades = plan.GetType().GetProperties();
            DGV_DatosPlan.ColumnCount = 2;
            foreach (PropertyInfo propiedad in propiedades)
            {
                Type tipo = propiedad.PropertyType;
                if (propiedad.Name == "numeroParametros")
                {

                }
                else if (tipo.Equals(typeof(string)))
                {
                    string[] fila = { propiedad.Name, (string)propiedad.GetValue(plan, null) };
                    DGV_DatosPlan.Rows.Add(fila);
                }
                else if (tipo.Equals(typeof(Int32)))
                {
                    string[] fila = { propiedad.Name, propiedad.GetValue(plan, null).ToString() };
                    DGV_DatosPlan.Rows.Add(fila);
                }
                else
                {
                }
            }
            DGV_DatosPlan.AutoResizeColumns();
            celdaVacia(DGV_DatosPlan);
            DGV_DatosPlan.Columns[0].ReadOnly = true;
        }

        private void cargarDGVdePaciente(Paciente paciente)
        {
            DGV_DatosPaciente.Rows.Clear();
            PropertyInfo[] propiedades = paciente.GetType().GetProperties();
            DGV_DatosPaciente.ColumnCount = 2;
            foreach (PropertyInfo propiedad in propiedades)
            {
                Type tipo = propiedad.PropertyType;
                if (propiedad.Name == "apellidoNombre")
                {

                }
                else if (tipo.Equals(typeof(string)))
                {
                    string[] fila = { propiedad.Name, (string)propiedad.GetValue(paciente, null) };
                    DGV_DatosPaciente.Rows.Add(fila);
                }
                else
                {
                }
            }
            DGV_DatosPaciente.AutoResizeColumns();
            celdaVacia(DGV_DatosPaciente);
            DGV_DatosPaciente.Columns[0].ReadOnly = true;
        }

        private void guardarDGVenPlan(Plan plan)
        {
            PropertyInfo[] propiedades = plan.GetType().GetProperties();
            Type tipoPlan = plan.GetType();
            foreach (DataGridViewRow fila in DGV_DatosPlan.Rows)
            {
                if (fila.Cells[1].Value != null)
                {
                    PropertyInfo propiedad = tipoPlan.GetProperty(fila.Cells[0].Value.ToString());

                    Type tipoProp = propiedad.PropertyType;
                    if (tipoProp.Equals(typeof(string)))
                    {
                        propiedad.SetValue(plan, fila.Cells[1].Value.ToString(), null);
                    }
                    else if (tipoProp.Equals(typeof(int)))
                    {
                        propiedad.SetValue(plan, Convert.ToInt32(fila.Cells[1].Value), null);
                    }
                }
            }
        }

        private void guardarDGVenPaciente(Paciente paciente)
        {
            PropertyInfo[] propiedades = paciente.GetType().GetProperties();
            Type tipoPaciente = paciente.GetType();
            foreach (DataGridViewRow fila in DGV_DatosPaciente.Rows)
            {
                if (fila.Cells[1].Value != null)
                {
                    PropertyInfo propiedad = tipoPaciente.GetProperty(fila.Cells[0].Value.ToString());

                    Type tipoProp = propiedad.PropertyType;
                    if (tipoProp.Equals(typeof(string)))
                    {
                        propiedad.SetValue(paciente, fila.Cells[1].Value.ToString(), null);
                    }
                }
            }
        }

        private void BT_HacerDocumentos_Click(object sender, EventArgs e)
        {
            if (Chequear.numeroDeImagenes(imagenesEsperadas(etapa), imagenesEncontradas(paciente)))
            {
                if (!celdasVacias() || (celdasVacias() && MessageBox.Show("Hay datos sin completar ¿desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    if (etapaNumero ==1)
                    {
                        IO.crearCarpetas(paciente, tratamiento);
                    }
                    if (tratamiento.planes.Count()== 1)
                    {
                        unaEtapaBEVeInforme();
                    }
                    else if (etapaNumero <= tratamiento.planes.Count())
                    {
                        variasEtapasBEV(etapaNumero);
                        if (etapaNumero == tratamiento.planes.Count())
                        {
                            etapaNumero++;
                            BT_Cargar.Enabled = false;
                            RB_AmbosDocumentos.Enabled = false;
                            RB_SoloBEV.Enabled = false;
                            RB_SoloInforme.Enabled = true;
                            RB_SoloInforme.Checked = true;
                        }
                        
                        else
                        {
                            etapaNumero++;
                            iniciarEtapa();
                        }
                    }
                    else
                    {
                        escribirLabelDocCreado("...en proceso informe", indiceLabelDocCreados, true);
                        variasEtapasInforme();
                    }
                }
            }
            else
            {
                MessageBox.Show("El número de imágenes esperadas y las encontradas no coinciden.\nPor favor revisar e intentarlo nuevamente");
            }
        }

        private void crearBEV(int etapa)
        {
            Word.crearArchivoBEV(paciente, tratamiento, etapa, hayImagenesSetUp(), TB_SetUp1Gantry.Text, TB_SetUp2Gantry.Text, TB_SetUp1Tam.Text, TB_SetUp2Tam.Text, TB_ProfundidadesEfectivas.Text);
        }

        private void crearInforme()
        {
            Word.crearArchivoInforme(paciente, tratamiento, hayDosImagenes3D(), hayTresImagenes3D(), hayImagenesSetUp(), imprimirBEV());
            limpiarFormulario(this);
        }


        private void unaEtapaBEVeInforme()
        {
            try
            {
                guardarDGVenPlan(tratamiento.planes[0]);
                guardarDGVenPaciente(paciente);
                if (imprimirBEV())
                {
                    crearBEV(1);
                    escribirLabelDocCreado("BEV" + agregarIsosALabel(etapa), indiceLabelDocCreados,false);
                }
                if (imprimirInforme())
                {
                    crearInforme();
                    escribirLabelDocCreado("Informe", indiceLabelDocCreados,false);
                }
                IO.moverImagenes(paciente);
                MessageBox.Show("Se generaron los documentos y se movieron las imágenes");
            }
            catch (Exception)
            {
                throw;
            }


        }



        private void variasEtapasBEV(int numEtapa)
        {
            try
            {
                //guardarDGVenPaciente(paciente);
                //guardarDGVenPlan(etapa);
                crearBEV(numEtapa);
                IO.moverImagenes(paciente, numEtapa);
                string texto = "Se generó el documento y se movieron las imágenes";
                if (numEtapa<tratamiento.planes.Count())
                {
                    texto += "\nSe procederá automáticamente a la siguiente etapa";
                }
                MessageBox.Show(texto);
                escribirLabelDocCreado("BEV etapa " + numEtapa.ToString() + agregarIsosALabel(etapa), indiceLabelDocCreados,false);
                if (numEtapa < tratamiento.planes.Count())
                {
                    //BT_Cargar.Enabled = true;
                    //BT_Cargar.Text = "Cargar PPF Etapa " + (etapa + 1).ToString();
                    BT_HacerDocumentos.Enabled = false;
                    L_ImagenesEsperadas.Visible = false;
                    L_ImagenesEncontradas.Visible = false;
                    LB_Imágenes.Items.Clear();
                    GB_Imagenes.Enabled = false;
                    GB_CamposSetUp.Enabled = false;
                    GB_Documentos.Enabled = false;
                    TB_ProfundidadesEfectivas.Enabled = false;
                }
                else
                {
                    BT_Cargar.Enabled = false;
                    RB_SoloInforme.Checked = true;
                    RB_SoloBEV.Enabled = false;
                    RB_SoloInforme.Enabled = true;
                    RB_AmbosDocumentos.Enabled = true;
                    DGV_DatosPlan.Enabled = false;
                    MessageBox.Show("Una vez exportadas las imágenes para el informe presione aceptar y luego Crear Documentos");
                    cargarListaImagenes();
                    escribirLabels(tratamiento.planes.Last(), paciente);

                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        private void variasEtapasInforme()
        {
            try
            {
                guardarDGVenPaciente(paciente);
                crearInforme();
                IO.moverImagenes(paciente, 0, true);
                MessageBox.Show("Se generó el documento y se movieron las imágenes");
                escribirLabelDocCreado("Informe", indiceLabelDocCreados,false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cargarListaImagenes()
        {
            LB_Imágenes.Items.Clear();
            List<string> listaImagenes = IO.obtenerImagenes(paciente);
            foreach (string imagen in listaImagenes)
            {
                LB_Imágenes.Items.Add(Path.GetFileName(imagen));
            }
        }
        private bool hayImagenesSetUp()
        {
            return (!CHB_SinImagenesSetUp.Checked && !RB_SoloInforme.Checked);
        }

        private bool imprimirBEV()
        {
            return (RB_AmbosDocumentos.Checked || RB_SoloBEV.Checked);
        }

        private bool imprimirInforme()
        {
            return (RB_AmbosDocumentos.Checked || RB_SoloInforme.Checked);
        }

        private bool hayDosImagenes3D()
        {
            return CB_Imagenes3D.SelectedIndex == 1;
        }
        private bool hayTresImagenes3D()
        {
            return CB_Imagenes3D.SelectedIndex == 2;
        }
        private int imagenesEncontradas(Paciente paciente)
        {
            return Word.cantidadDeImagenes(paciente);
        }

        private int numeroDeEtapas()
        {
            //paciente.numeroDeEtapas = CB_NumeroDeEtapas.SelectedIndex + 1;
            //return CB_NumeroDeEtapas.SelectedIndex + 1;
            return tratamiento.planes.Count();
        }

        private int imagenesEsperadas(Plan plan)
        {
            int aux = 0;
            if (imprimirBEV())
            {
                foreach (Iso iso in plan.isos)
                {
                    aux += iso.camposConEsteIso(plan).Count();
                    if (hayImagenesSetUp())
                    {
                        aux += 2;
                    }
                }
            }
            if (imprimirInforme())
            {
                aux += 5;
                if (hayDosImagenes3D())
                {
                    aux += 1;
                }
                else if (hayTresImagenes3D())
                {
                    aux += 2;
                }
            }
            return aux;
        }


        
        private void escribirLabels(Plan plan, Paciente paciente)
        {
            L_ImagenesEsperadas.Text = imagenesEsperadas(plan).ToString();
            L_ImagenesEsperadas.Visible = true;
            L_ImagenesEncontradas.Text = imagenesEncontradas(paciente).ToString();
            L_ImagenesEncontradas.Visible = true;
        }

        private void ActualizarNumeroImagenes(object sender, EventArgs e)
        {
            if (tratamiento.planes != null)//&& paciente.planes.Last().cantidadDeCampos > 0)
            {
                escribirLabels(tratamiento.planes.Last(), paciente);
                if (CHB_SinImagenesSetUp.Checked || RB_SoloInforme.Checked)
                {
                    GB_CamposSetUp.Enabled = false;
                }
                else
                {
                    GB_CamposSetUp.Enabled = true;
                }
            }
        }

        private bool celdasVacias()
        {
            return celdaVacia(DGV_DatosPaciente) || celdaVacia(DGV_DatosPlan);
        }
        private bool celdaVacia(DataGridView dgv)
        {
            bool algoVacio = false;
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells[1].Value == null)
                {
                    fila.Cells[1].Style.BackColor = Color.OrangeRed;
                    algoVacio = true;
                }
                else
                {
                    fila.Cells[1].Style.BackColor = DefaultBackColor;
                }
            }
            return algoVacio;
        }

        private void DGV_DatosPaciente_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            celdaVacia(DGV_DatosPaciente);
            celdaVacia(DGV_DatosPlan);
        }


        private void hayMasDeUnISO()
        {
            if (tratamiento.planes.Last().iso == "Hay más de un ISO")
            {
                MessageBox.Show("El plan tiene más de un iso");
                tratamiento.planes.Last().iso = null;
            }
        }

        private void CB_NumeroDeEtapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (numeroDeEtapas() > 1)
            {
                etapaNumero = 1;
                BT_Cargar.Text = "Cargar PPF etapa 1";
            }
            else
            {
                etapaNumero = 0;
                BT_Cargar.Text = "Cargar PPF";
            }*/

        }

        private void BT_ActualizarImagenes_Click(object sender, EventArgs e)
        {
            cargarListaImagenes();
            escribirLabels(tratamiento.planes.Last(), paciente);
        }

        private void BT_LimpiarFormulario_Click(object sender, EventArgs e)
        {
            limpiarFormulario(this);
            this.Text = "Armado de carpetas";
        }
        private void limpiarFormulario(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                /* if (control.GetType()!=typeof(Label))
                 {
                //     control.Enabled = false;
                 }*/
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)control).Checked = false;
                }
                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
                if (control.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)control).Rows.Clear();
                }
                if (control.GetType() == typeof(ListBox))
                {
                    ((ListBox)control).Items.Clear();
                }
                if (control.GetType() == typeof(GroupBox))
                {
                    control.Enabled = false;
                    limpiarFormulario(control);
                }
            }
            CB_NumeroDeEtapas.Enabled = true;
            CB_NumeroDeEtapas.SelectedIndex = 0;
            BT_Cargar.Enabled = true;
            BT_LimpiarFormulario.Enabled = true;
            GB_DocumentosCreados.Enabled = true;
        }
        private void habilitarControles()
        {
            GB_CamposSetUp.Enabled = true;
            GB_Imagenes.Enabled = true;
            GB_Documentos.Enabled = true;
            CB_NumeroDeEtapas.Enabled = false;
            CB_Imagenes3D.SelectedIndex = 0;
            CHB_SinImagenesSetUp.Checked = false;
            L_ImagenesEsperadas.Visible = false;
            L_ImagenesEncontradas.Visible = false;
            RB_AmbosDocumentos.Checked = true;
            RB_SoloBEV.Checked = false;
            RB_SoloInforme.Checked = false;
            TB_ProfundidadesEfectivas.Clear();
        }

        private void inicializarSetUP()
        {
            if (tratamiento.planes.Count > 0 && tratamiento.planes.Last().equipo == "Córdoba")
            {
                TB_SetUp1Gantry.Text = "0";
            }
            else
            {
                TB_SetUp1Gantry.Text = "180";
            }
            TB_SetUp2Gantry.Text = "270";
            TB_SetUp1Tam.Text = "10x10";
            TB_SetUp2Tam.Text = "10x10";
        }

        private void escribirLabelDocCreado(string texto, int indice, bool enProceso)
        {
            docCreados[indice].Text = texto;
            docCreados[indice].Visible = true;
            if (enProceso)
            {
                docCreados[indice].ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                docCreados[indice].ForeColor = System.Drawing.Color.Green;
                indiceLabelDocCreados++;
            }
            
        }

        private void limpiarLabelsDocCreado()
        {
            foreach (Label label in docCreados)
            {
                label.Text = "";
                label.Visible = false;
            }
            indiceLabelDocCreados = 0;
        }

        private string agregarIsosALabel(Plan etapa)
        {
            string texto = "";
            if (etapa.isos.Count > 1)
            {
                texto += " (";
                foreach (Iso iso in etapa.isos)
                {
                    texto += iso.ID + " ";
                }
                texto = texto.Remove(texto.Length - 1);
                texto += ")";
            }
            return texto;
        }
    }
}
