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
            L_ImagenesEsperadas.Visible = false;
            L_ImagenesEncontradas.Visible = false;


        }

        private void BT_CargarClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos ppf(.ppf)|*.ppf|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fid = Extraer.cargar(openFileDialog1.FileName);
                plan = Extraer.extraerPlan(fid);
                BT_HacerDocumentos.Enabled = true;
                cargarDGVdePan(plan);
                escribirLabels(plan);
            }
        }

        private void cargarDGVdePan(Plan plan)
        {
            PropertyInfo[] propiedades = plan.GetType().GetProperties();
            DGV_DatosPaciente.ColumnCount = 2;
            foreach (PropertyInfo propiedad in propiedades)
            {
                Type tipo = propiedad.PropertyType;
                if (propiedad.Name=="apellidoNombre"|| propiedad.Name == "numeroParametros" )
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
        }
        private void guardarDGVenPlan(Plan plan)
        {
            PropertyInfo[] propiedades = plan.GetType().GetProperties();
            Type tipoPlan = plan.GetType();
            foreach (DataGridViewRow fila in DGV_DatosPaciente.Rows)
            {
                if (fila.Cells[1].Value!=null)
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
            guardarDGVenPlan(plan);
            IO.crearCarpeta(plan.apellidoNombre, plan.ID);
            Word.crearArchivoBEV(plan,hayImagenesSetUp());
            Word.crearArchivoInforme(plan,hayDosImagenes3D());
        }

        private bool hayImagenesSetUp()
        {
            return !CHB_SinImagenesSetUp.Checked;
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
            int aux = plan.cantidadDeCampos+5;
            if (hayImagenesSetUp())
            {
                aux += 2;
            }
            if(hayDosImagenes3D())
            {
                aux += 1;
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
        }
    }
}
