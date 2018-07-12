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
        Plan plan = new Plan();
        public Form1()
        {
            InitializeComponent();
            BT_HacerDocumentos.Enabled = false;
            TB_SetUp1Gantry.Text = "180";
            TB_SetUp2Gantry.Text = "270";
            TB_SetUp1Tam.Text = "10x10";
            TB_SetUp2Tam.Text = "10x10";
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
        }

        private void BT_CargarClick(object sender, EventArgs e)
        {
            CHB_DosImagenes3D.Checked = false;
            CHB_SinImagenesSetUp.Checked = false;
            L_ImagenesEsperadas.Visible = false;
            L_ImagenesEncontradas.Visible = false;
            RB_AmbosDocumentos.Checked = true;
            RB_SoloBEV.Checked = false;
            RB_SoloInforme.Checked = false;
            TB_ProfundidadesEfectivas.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Abrir archivo PPF";
            openFileDialog1.Filter = "Archivos ppf(.ppf)|*.ppf|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fid = Extraer.cargar(openFileDialog1.FileName);
                plan = Extraer.extraerPlan(fid);
                BT_HacerDocumentos.Enabled = true;
                cargarDGVdePan(plan);
                escribirLabels(plan);
                cargarListaImagenes(plan);
                GB_Imagenes.Enabled = true;
                GB_CamposSetUp.Enabled = true;
                GB_Documentos.Enabled = true;
                TB_ProfundidadesEfectivas.Enabled = true;
            }
        }

        private void cargarDGVdePan(Plan plan)
        {
            DGV_DatosPaciente.Rows.Clear();
            PropertyInfo[] propiedades = plan.GetType().GetProperties();
            DGV_DatosPaciente.ColumnCount = 2;
            foreach (PropertyInfo propiedad in propiedades)
            {
                Type tipo = propiedad.PropertyType;
                if (propiedad.Name == "apellidoNombre" || propiedad.Name == "numeroParametros")
                {

                }
                else if (tipo.Equals(typeof(string)))
                {
                    string[] fila = { propiedad.Name, (string)propiedad.GetValue(plan, null) };
                    DGV_DatosPaciente.Rows.Add(fila);
                }
                else if (tipo.Equals(typeof(Int32)))
                {
                    string[] fila = { propiedad.Name, propiedad.GetValue(plan, null).ToString() };
                    DGV_DatosPaciente.Rows.Add(fila);
                }
                else
                {
                }
            }
            DGV_DatosPaciente.AutoResizeColumns();
            celdaVacia();
            DGV_DatosPaciente.Columns[0].ReadOnly = true;
        }
        private void guardarDGVenPlan(Plan plan)
        {
            PropertyInfo[] propiedades = plan.GetType().GetProperties();
            Type tipoPlan = plan.GetType();
            foreach (DataGridViewRow fila in DGV_DatosPaciente.Rows)
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
                    else
                    {
                    }
                }
            }
        }

        private void BT_HacerDocumentos_Click(object sender, EventArgs e)
        {
            if (Chequear.numeroDeImagenes(imagenesEsperadas(plan), imagenesEncontradas(plan)))
            {
                if (!celdaVacia() || (celdaVacia() && MessageBox.Show("Hay datos sin completar ¿desea continuar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    try
                    {
                        guardarDGVenPlan(plan);
                        IO.crearCarpetas(plan.apellidoNombre, plan.ID);
                        if (imprimirBEV())
                        {
                            Word.crearArchivoBEV(plan, hayImagenesSetUp(), TB_SetUp1Gantry.Text, TB_SetUp2Gantry.Text, TB_SetUp1Tam.Text, TB_SetUp2Tam.Text, TB_ProfundidadesEfectivas.Text);
                        }
                        if (imprimirInforme())
                        {
                            Word.crearArchivoInforme(plan, hayDosImagenes3D(), hayImagenesSetUp(), imprimirBEV());
                        }
                        if (MessageBox.Show("Se generaron los documentos.\n¿Desea mover las imágenes?", "Mover Imágenes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            IO.moverImagenes(plan);
                            MessageBox.Show("Se movieron las imágenes");
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
                MessageBox.Show("El número de imágenes encontradas difiere del esperado");
            }
        }

        private void cargarListaImagenes(Plan plan)
        {
            LB_Imágenes.Items.Clear();
            List<string> listaImagenes = IO.obtenerImagenes(plan.apellido);
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
            return CHB_DosImagenes3D.Checked;
        }
        private int imagenesEncontradas(Plan plan)
        {
            return Word.cantidadDeImagenes(plan);
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
            }
            return aux;
        }

        private void escribirLabels(Plan plan)
        {
            L_ImagenesEsperadas.Text = imagenesEsperadas(plan).ToString();
            L_ImagenesEsperadas.Visible = true;
            L_ImagenesEncontradas.Text = imagenesEncontradas(plan).ToString();
            L_ImagenesEncontradas.Visible = true;
        }

        private void ActualizarNumeroImagenes(object sender, EventArgs e)
        {
            escribirLabels(plan);
            if (CHB_SinImagenesSetUp.Checked || RB_SoloInforme.Checked)
            {
                GB_CamposSetUp.Enabled = false;
            }
            else
            {
                GB_CamposSetUp.Enabled = true;
            }
        }

        private bool celdaVacia()
        {
            bool algoVacio = false;
            foreach (DataGridViewRow fila in DGV_DatosPaciente.Rows)
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
            celdaVacia();
        }
    }
}
