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
    public partial class Form1 : Form
    {
        Paciente paciente = new Paciente();
        
        
        int etapaNumero = 0;

        public Form1()
        {
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
            CB_NumeroDeEtapas.SelectedIndex = 0;
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

        }

        private void BT_CargarClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Abrir archivo PPF";
            openFileDialog1.Filter = "Archivos ppf(.ppf)|*.ppf|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fid = Extraer.cargar(openFileDialog1.FileName);
                if (etapaNumero<2)
                {
                    paciente = Extraer.extraerPaciente(fid);
                    cargarDGVdePaciente(paciente);
                }
                else
                {
                    if (!Chequear.paciente(paciente, Extraer.extraerPaciente(fid)))
                    {
                        MessageBox.Show("Los planes corresponden a diferentes pacientes","Error");
                    }
                }
                paciente.planes.Add(Extraer.extraerPlan(fid));
                if (numeroDeEtapas()==1)
                {
                    paciente.planes.Last().etapa = "1";
                }
                else
                {
                    paciente.planes.Last().etapa = etapaNumero.ToString();
                }
                BT_HacerDocumentos.Enabled = true;
                habilitarControles();
                inicializarSetUP();
                hayMasDeUnISO();
                cargarDGVdePan(paciente.planes.Last());
                escribirLabels(paciente.planes.Last(), paciente);
                cargarListaImagenes();
                GB_Imagenes.Enabled = true;
                GB_CamposSetUp.Enabled = true;
                GB_Documentos.Enabled = true;
                TB_ProfundidadesEfectivas.Enabled = true;
                if (numeroDeEtapas()==1)
                {
                    RB_AmbosDocumentos.Enabled = true;
                    RB_SoloBEV.Enabled = true;
                    RB_AmbosDocumentos.Checked = true;
                    RB_SoloInforme.Enabled = true;
                }
                if (numeroDeEtapas()>1)
                {
                    RB_AmbosDocumentos.Enabled = false;
                    RB_SoloBEV.Enabled = true;
                    RB_SoloBEV.Checked = true;
                    RB_SoloInforme.Enabled = false;
                }
            }
        }

        private void cargarDGVdePan(Plan plan)
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
            if (etapaNumero<2)
            {
                IO.crearCarpetas(paciente);
            }
            if (etapaNumero == 0)
            {
                unaEtapaBEVeInforme();
            }
            else if (etapaNumero <= paciente.numeroDeEtapas)
            {
                variasEtapasBEV(etapaNumero);
                etapaNumero++;
                if (etapaNumero > paciente.numeroDeEtapas)
                {
                    BT_Cargar.Enabled = false;
                    RB_AmbosDocumentos.Enabled = false;
                    RB_SoloBEV.Enabled = false;
                    RB_SoloInforme.Enabled = true;
                    RB_SoloInforme.Checked = true;
                }
            }
            else
            {
                variasEtapasInforme();
            }
        }

        private void crearBEV(int etapa)
        {
            Word.crearArchivoBEV(paciente, etapa, hayImagenesSetUp(), TB_SetUp1Gantry.Text, TB_SetUp2Gantry.Text, TB_SetUp1Tam.Text, TB_SetUp2Tam.Text, TB_ProfundidadesEfectivas.Text);
        }

        private void crearInforme()
        {
            paciente.cantidadTotalDeCampos(paciente);
            paciente.dosisTotalPaciente(paciente);
            Word.crearArchivoInforme(paciente, hayDosImagenes3D(), hayTresImagenes3D(), hayImagenesSetUp(), imprimirBEV());
            limpiarFormulario(this);
        }


        private void unaEtapaBEVeInforme()
        {
            if (Chequear.numeroDeImagenes(imagenesEsperadas(paciente.planes[0]), imagenesEncontradas(paciente)))
            {
                if (!celdasVacias() || (celdasVacias() && MessageBox.Show("Hay datos sin completar ¿desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    try
                    {
                        guardarDGVenPlan(paciente.planes[0]);
                        guardarDGVenPaciente(paciente);
                        if (imprimirBEV())
                        {
                            crearBEV(1);
                        }
                        if (imprimirInforme())
                        {
                            crearInforme();
                        }
                        IO.moverImagenes(paciente);
                        MessageBox.Show("Se generaron los documentos y se movieron las imágenes");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("El número de imágenes esperadas y las encontradas no coinciden.\nPor favor revisar e intentarlo nuevamente");
            }
        }



        private void variasEtapasBEV(int etapa)
        {
            if (Chequear.numeroDeImagenes(imagenesEsperadas(paciente.planes[etapa - 1]), imagenesEncontradas(paciente)))
            {
                if (!celdasVacias() || (celdasVacias() && MessageBox.Show("Hay datos sin completar ¿desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    try
                    {
                        guardarDGVenPaciente(paciente);
                        guardarDGVenPlan(paciente.planes[etapa-1]);
                        crearBEV(etapa);
                        IO.moverImagenes(paciente, etapa);
                        MessageBox.Show("Se generó el documento y se movieron las imágenes");
                        if (etapa<paciente.numeroDeEtapas)
                        {
                            BT_Cargar.Enabled = true;
                            BT_Cargar.Text = "Cargar PPF Etapa " + (etapa + 1).ToString();
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
                        }
                        
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
            }
            else
            {
                MessageBox.Show("El número de imágenes esperadas y las encontradas no coinciden.\nPor favor revisar e intentarlo nuevamente");
            }
        }

        private void variasEtapasInforme()
        {
            if (Chequear.numeroDeImagenes(imagenesEsperadas(paciente.planes.Last()), imagenesEncontradas(paciente)))
            {
                if (!celdasVacias() || (celdasVacias() && MessageBox.Show("Hay datos sin completar ¿desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    try
                    {
                        guardarDGVenPaciente(paciente);
                        crearInforme();
                        IO.moverImagenes(paciente, 0, true);
                        MessageBox.Show("Se generó el documento y se movieron las imágenes");
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
            }
            else
            {
                MessageBox.Show("El número de imágenes esperadas y las encontradas no coinciden.\nPor favor revisar e intentarlo nuevamente");
            }
        }

        private void cargarListaImagenes()
        {
            LB_Imágenes.Items.Clear();
            List<string> listaImagenes = IO.obtenerImagenes(paciente.apellido);
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
            paciente.numeroDeEtapas = CB_NumeroDeEtapas.SelectedIndex + 1;
            return CB_NumeroDeEtapas.SelectedIndex + 1;
        }

        private int imagenesEsperadas(Plan plan)
        {
            int aux = 0;
            if (imprimirBEV())
            {
                aux += plan.cantidadDeCampos;
                if (hayImagenesSetUp())
                {
                    aux += 2;
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
            if (paciente.planes!=null )//&& paciente.planes.Last().cantidadDeCampos > 0)
            {
                escribirLabels(paciente.planes.Last(), paciente);
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
            if (paciente.planes.Last().iso == "Hay más de un ISO")
            {
                MessageBox.Show("El plan tiene más de un iso");
                paciente.planes.Last().iso = null;
            }
        }

        private void CB_NumeroDeEtapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numeroDeEtapas()>1)
            {
                etapaNumero = 1;
                BT_Cargar.Text = "Cargar PPF etapa 1";
            }
            else
            {
                etapaNumero = 0;
                BT_Cargar.Text = "Cargar PPF";
            }
            
        }

        private void BT_ActualizarImagenes_Click(object sender, EventArgs e)
        {
            cargarListaImagenes();
            escribirLabels(paciente.planes.Last(), paciente);
        }

        private void BT_LimpiarFormulario_Click(object sender, EventArgs e)
        {
            limpiarFormulario(this);
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
                if (control.GetType()== typeof(DataGridView))
                {
                    ((DataGridView)control).Rows.Clear();
                }
                if (control.GetType()==typeof(ListBox))
                {
                    ((ListBox)control).Items.Clear();
                }
                if (control.GetType()==typeof(GroupBox))
                {
                    control.Enabled = false;
                    limpiarFormulario(control);
                }
            }
            CB_NumeroDeEtapas.Enabled = true;
            CB_NumeroDeEtapas.SelectedIndex = 0;
            BT_Cargar.Enabled = true;
            BT_LimpiarFormulario.Enabled = true;
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
            if (paciente.planes.Count>0 && paciente.planes.Last().equipo=="Córdoba")
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
    }
}
