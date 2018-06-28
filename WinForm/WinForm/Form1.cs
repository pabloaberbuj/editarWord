using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xceed.Words.NET;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        Plan plan = new Plan();
        public Form1()
        {
            InitializeComponent();
            BT_HacerDocumentos.Enabled = false;
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
                cargarPropiedades(plan);
            }
        }



        private void cargarPropiedad(TextBox tb, string propiedad)
        {
            tb.Text = propiedad;
        }
        private void cargarPropiedad(TextBox tb, double propiedad)
        {
            tb.Text = propiedad.ToString();
        }
        private void cargarPropiedad(TextBox tb, int propiedad)
        {
            tb.Text = propiedad.ToString();
        }

        private void guardarPropiedad(TextBox tb, string propiedad)
        {
            propiedad = tb.Text;
        }

        private void guardarPropiedad(TextBox tb, double propiedad)
        {
            propiedad = Convert.ToDouble(tb.Text);
        }

        private void guardarPropiedad(TextBox tb, int propiedad)
        {
            propiedad = Convert.ToInt32(tb.Text);
        }

        private void cargarPropiedades(Plan plan)
        {
            cargarPropiedad(TB_CantidadDeCampos, plan.cantidadDeCampos);
            cargarPropiedad(TB_DosisFraccion, plan.dosisFraccion);
            cargarPropiedad(TB_DosisTotal, plan.dosisTotal);
            cargarPropiedad(TB_Equipo, plan.equipo);
            //cargarPropiedad(TB_Etapa,)
            cargarPropiedad(TB_ID, plan.ID);
            //cargarPropiedad(TB_ISO,)
            cargarPropiedad(TB_Modalidad, plan.modalidad);
            cargarPropiedad(TB_Nombre, plan.nombre[0]+", " + plan.nombre[1]);
            //cargarPropiedad(TB_Patología)
        }

        private void guardarPropiedades(Plan plan)
        {
            guardarPropiedad(TB_CantidadDeCampos, plan.cantidadDeCampos);
            guardarPropiedad(TB_DosisFraccion, plan.dosisFraccion);
            guardarPropiedad(TB_DosisTotal, plan.dosisTotal);
            guardarPropiedad(TB_Equipo, plan.equipo);
            guardarPropiedad(TB_Etapa, plan.etapa);
            guardarPropiedad(TB_ID, plan.ID);
            guardarPropiedad(TB_ISO, plan.iso);
            guardarPropiedad(TB_Modalidad, plan.modalidad);
            guardarPropiedad(TB_Nombre, plan.nombre[0] + ", " + plan.nombre[1]);
            guardarPropiedad(TB_Patología, plan.patologia);
        }

        private void BT_HacerDocumentos_Click(object sender, EventArgs e)
        {
            guardarPropiedades(plan);
            IO.crearCarpeta(plan.nombre[0] + ", " + plan.nombre[1], plan.ID);
            Word.crearArchivoBEV(plan);
            Word.crearArchivoInforme(plan);
        }
    }
}
