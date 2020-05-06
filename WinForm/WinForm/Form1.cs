using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        Paciente paciente = new Paciente();
        Plan planMain = new Plan();
        //Dictionary<string, string> Diccionario = Equipos.diccionario();


        //int etapaNumero = 0;
        //int indiceLabelDocCreados = 0;
        bool Dosis_Checked = false;
        bool Gral_Checked = false;

        public Form1(Paciente _paciente, Plan _plan)
        {
            InitializeComponent();
            paciente = _paciente;
            planMain = _plan;
            ResetearValores();
            this.Text = "Chequeo de Plan: " + planMain.etiquetaPPF;
            L_nombrePPF.Text = planMain.etiquetaPPF;
            L_nombrePPF.Visible = true;
            if (planMain.equipo != "-1")
            {

                // Hago chequeos de Dosis
                Dosis_Checked = Chequeo_Dosis(planMain);
                if (Dosis_Checked)
                {
                    panel_Chequeo.Visible = true;
                    rtB_chequeos.Visible = true;
                    Gral_Checked = Chequeo_Gral(planMain);
                    bT_Guardar.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("El .RSD utilizado no corresponde a un equipo habilitado", "Error RSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetearValores();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Abrir archivo PPF";
            openFileDialog1.Filter = "Archivos ppf(.ppf)|*.ppf|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fid = Extraer.cargar(openFileDialog1.FileName);
                //limpiarLabelsDocCreado();
                paciente = Extraer.extraerPaciente(fid);
                Plan plan = Extraer.extraerPlan(fid);
                this.Text = "Chequeo de Plan: " + paciente.apellidoNombre + plan.etiquetaPPF;

                // Como primer chequeo reviso haber encontrado el Equipo.
                if (plan.equipo != "-1")
                {

                    // Hago chequeos de Dosis
                    Dosis_Checked = Chequeo_Dosis(plan);
                    if (Dosis_Checked)
                    {
                        panel_Chequeo.Visible = true;
                        rtB_chequeos.Visible = true;
                        Gral_Checked = Chequeo_Gral(plan);
                        bT_Guardar.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("El .RSD utilizado no corresponde a un equipo habilitado", "Error RSD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // cargarDGVdePaciente(paciente);
            }                     
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Chequear.archivoConfiguracion())
            {
                MessageBox.Show("No se encuentra el archivo Configuración.txt. El programa se cerrará");
                this.Close();
            }
          /*  else
            {
                if (!Chequear.directorioExport())
                {
                    MessageBox.Show("No se encuentra la carpeta Export en la dirección indicada.\nRevise el archivo Configuracion.txt");
                    this.Close();
                }
            }*/
            if (!Chequear.archivoEquipos())
            {
                MessageBox.Show("No se encuentra el archivo Equipos.txt. El programa se cerrará");
                this.Close();
            }
           
        }
        public bool Chequeo_Dosis(Plan plan)
        {
            bool Ok = true;
            cB_TotalDose.Text = String.Concat(cB_TotalDose.Text, plan.dosisTotal.ToString());
            cB_DosePerFr.Text = String.Concat(cB_DosePerFr.Text, plan.dosisFraccion.ToString());
            if(plan.dosisFraccion<100)
                MessageBox.Show("El valor de dosis por fracción es sospechosamente bajo", "Warning DosePerFraction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (plan.DensCorrection == "ON")
                cB_Densidad.Checked = true;
            else
                Ok = false;
            if (plan.DoseMode == " Convolution - Pencil Beam 8x8mm")
                cB_Grilla.Checked = true;
            else
                Ok = false;
            return Ok;
        }
        public bool Chequeo_Gral(Plan plan)
        {
            bool Ok = false;
            rtB_chequeos.Font = new Font(rtB_chequeos.Font, FontStyle.Bold);            
            rtB_chequeos.AppendText("Diferencia absoluta entre Angulos" + Environment.NewLine);
            //tB_chequeos.Font = new Font(tB_chequeos.Font, FontStyle.Regular);
            foreach (Campo c1 in plan.listaCampos)
            {
                foreach (Campo c2 in plan.listaCampos)
                {
                    if (c2.numero > c1.numero)
                    {
                        double Delta_cam = Math.Abs(Double.Parse(c1.camilla) - Double.Parse(c2.camilla));
                        if ((5 > Delta_cam) & (Delta_cam > 0))
                        {
                            rtB_chequeos.AppendText("Campo " + c1.numero.ToString() + " y Campo " + c2.numero.ToString() + " Tienen menos de 5º de diferencia" + Environment.NewLine);

                        }
                    }
                     //   tB_chequeos.AppendText("Hola" + Environment.NewLine);
                    //tB_chequeos.AppendText("Mundo" + Environment.NewLine);
                }
            }

            return Ok;

        }
        public void ResetearValores()
        {
            bT_Guardar.Enabled = false;
            bT_Imprimir.Enabled = false;
            cB_TotalDose.Checked = false;
            cB_DosePerFr.Checked = false;
            cB_Densidad.Checked = false;
            cB_Grilla.Checked = false;
            panel_Chequeo.Visible = false;
            rtB_chequeos.Visible = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bT_Finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
