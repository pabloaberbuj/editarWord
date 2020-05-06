using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Media;
using Xceed.Words.NET;

namespace WinForm
{
    public partial class Main : Form
    {
        public string carpetaPaciente;
        public Paciente paciente = new Paciente();
        public string textoChequeos = "";
        public Main()
        {
            InitializeComponent();
            L_ID.Visible = false;
            L_Nombre.Visible = false;
            L_Apellido.Visible = false;
        }

        private void BT_CargarPaciente_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\Casa\source\repos\editarWordExtendido\Material";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                carpetaPaciente = dialog.FileName;
                llenarLB_PPFs(carpetaPaciente);
            }

        }

        private List<string> todosLosPPFs(string path)
        {
            return Directory.GetFiles(path, "*.ppf").ToList();
        }

        private List<string> todosLosPatMove(string path)
        {
            return Directory.GetFiles(path, "*.PatMove").ToList();
        }

        private void llenarLB_PPFs(string path)
        {
            LB_ppfs.DataSource = null;
            List<string> _todosLosPPfs = todosLosPPFs(path);
            if (_todosLosPPfs.Count()==0)
            {
                MessageBox.Show("No se encontraron archivos ppf en la carpeta indicada");
            }
            else
            {
                foreach (string ppf in _todosLosPPfs)
                {
                    LB_ppfs.Items.Add(Path.GetFileName(ppf));
                }
                crearPaciente(fullPath(LB_ppfs.Items[0].ToString()));
                GB_2esquemaTratamiento.Enabled = true;
            }
        }

        private void crearPaciente(string ppf)
        {
            paciente = paciente.crear(ppf);
            L_Apellido.Text = paciente.apellido;
            L_Nombre.Text = paciente.nombre;
            L_ID.Text = paciente.ID;
            L_ID.Visible = true;
            L_Nombre.Visible = true;
            L_Apellido.Visible = true;
        }

        private string fullPath(string nombreArchivo)
        {
            return carpetaPaciente + @"\" + nombreArchivo;
        }

        
        private void nuevoTratamiento(string nombreArchivo, string nombreTratamiento)
        {
            Tratamiento tratamiento = new Tratamiento();
            tratamiento.nombre = nombreTratamiento;
            tratamiento.planes = new List<Plan>();
            TreeNode tratamiento_node = new TreeNode();
            tratamiento_node.Text = tratamiento.nombre;
            tratamiento.nodo = tratamiento_node;
            agregarNuevoPlan(tratamiento);
            paciente.tratamientos.Add(tratamiento);
            visualizarArbol();
        }

        private void BT_NuevoTratamiento_Click(object sender, EventArgs e)
        {
            TextBoxForm nombreNuevoTto = new TextBoxForm(false, false, "Nombre de tratamiento");
            nombreNuevoTto.Text = "Nombre del tratamiento";
            nombreNuevoTto.ShowDialog();
            if (nombreNuevoTto.DialogResult == DialogResult.OK)
            {
                nuevoTratamiento(nombrePlanSeleccionado(), nombreNuevoTto.salida1);
                nombreNuevoTto.Close();

            }
        }

        private void BT_NuevaEtapa_Click(object sender, EventArgs e)
        {
            agregarNuevoPlan(tratamientoActual());

        }

        private string nombrePlanSeleccionado()
        {
            return fullPath(LB_ppfs.SelectedItem.ToString());
        }

        private void agregarNuevoPlan(Tratamiento tratamiento)
        {
            Plan plan = Extraer.extraerPlan(Extraer.cargar(nombrePlanSeleccionado()));
            TextBoxForm dosisTotalDia = new TextBoxForm(true, true, "Dosis Fracción", "Dosis plan", plan.dosisFraccion, plan.dosisTotal);
            dosisTotalDia.Text = "Dosis del plan seleccionado";
            dosisTotalDia.ShowDialog();
            if (dosisTotalDia.DialogResult == DialogResult.OK)
            {
                plan.dosisFraccion = Convert.ToDouble(dosisTotalDia.salida1);
                plan.dosisTotal = Convert.ToDouble(dosisTotalDia.salida2);
                tratamiento.planes.Add(plan);
                plan.pathPPF = nombrePlanSeleccionado();
                plan.etiquetaPPF = LB_ppfs.SelectedItem.ToString();
                plan.tratamiento = tratamiento;
                TreeNode plan_nodo = new TreeNode();
                plan.nodo = plan_nodo;
                plan.nodo.ToolTipText = plan.etiquetaPPF;
                tratamiento.nodo.Nodes.Add(plan_nodo);
                visualizarArbol();
            }
        }

        private Tratamiento tratamientoActual()
        {
            if (TV_tratamientos.SelectedNode != null)
            {
                TreeNode nodoTratamiento;
                if (TV_tratamientos.SelectedNode.Level == 0)
                {
                    nodoTratamiento = TV_tratamientos.SelectedNode;
                }
                else
                {
                    nodoTratamiento = TV_tratamientos.SelectedNode.Parent;
                }
                return paciente.tratamientos.Where(t => t.nodo == nodoTratamiento).First();
            }
            else
            {
                return paciente.tratamientos.Last();
            }

        }
        private void visualizarArbol()
        {
            TV_tratamientos.Nodes.Clear();
            foreach (Tratamiento tratamiento in paciente.tratamientos)
            {
                TV_tratamientos.Nodes.Add(tratamiento.nodo);
                tratamiento.nodo.Expand();

                if (tratamiento.planes.Count > 1)
                {
                    for (int i = 0; i < tratamiento.planes.Count; i++)
                    {
                        tratamiento.planes[i].nodo.Text = "Etapa " + (i + 1).ToString() + " (" + tratamiento.planes[i].dosisTotal + "/" + tratamiento.planes[i].dosisFraccion + ")";
                    }
                }
                else if (tratamiento.planes.Count==1)
                {
                    tratamiento.planes[0].nodo.Text = "Etapa única (" + tratamiento.planes[0].dosisTotal + "/" + tratamiento.planes[0].dosisFraccion + ")";
                }

            }
        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            if (TV_tratamientos.SelectedNode.Level == 0 && (MessageBox.Show("¿Seguro desea eliminar el tratamiento?", "Eliminar tratamiento", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                Tratamiento tratamiento = paciente.tratamientos.Where(t => t.nodo == TV_tratamientos.SelectedNode).First();
                paciente.tratamientos.Remove(tratamiento);
            }
            else if (TV_tratamientos.SelectedNode.Level == 1 && (MessageBox.Show("¿Seguro desea eliminar el plan?", "Eliminar plan", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                Tratamiento tratamiento = paciente.tratamientos.Where(t => t.nodo == TV_tratamientos.SelectedNode.Parent).First();
                Plan plan = tratamiento.planes.Where(p => p.nodo == TV_tratamientos.SelectedNode).First();
                tratamiento.planes.Remove(plan);
            }
            TV_tratamientos.Nodes.Remove(TV_tratamientos.SelectedNode);
            visualizarArbol();
        }

        private void BT_RealizarChequeos_Click(object sender, EventArgs e)
        {
            textoChequeos = "";
            foreach(Tratamiento tratamiento in paciente.tratamientos)
            {
                foreach (Plan plan in tratamiento.planes)
                {
                    Form1 chequeoPlan = new Form1(paciente,plan);
                    chequeoPlan.StartPosition = FormStartPosition.CenterParent;
                    chequeoPlan.ShowDialog();
                    
                }
            }
            if (textoChequeos!="")
            {
                L_FallasChequeo.Text = "Se han detectado posibles\nfallas en los planes";
                L_FallasChequeo.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show(textoChequeos);
            }
            else
            {
                L_FallasChequeo.Text = "Todo bien";
                L_FallasChequeo.ForeColor = System.Drawing.Color.Green;
            }
            L_FallasChequeo.Visible = true;
        }

        private void BT_VerProblemas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textoChequeos);
        }

        private void BT_FinalizarEsquemaTratamiento_Click(object sender, EventArgs e)
        {
            GB_3ChequeoAutomatico.Enabled = true;
            BT_RealizarChequeos_Click(sender, e);
        }

        private void cargarDGVIsos()
        {
            DGV_Isos.Rows.Clear();
            List<string> listapatMoves = new List<string>();
            List<string> _todosLosPatMove = todosLosPatMove(carpetaPaciente);
            if (_todosLosPatMove.Count()==0)
            {
                MessageBox.Show("No se encontraron archivos patMove en la carpeta indicada");
            }
            foreach (string patMove in todosLosPatMove(carpetaPaciente))
            {
                listapatMoves.Add(Path.GetFileNameWithoutExtension(patMove).ToLower());
            }
            listapatMoves.Add("iso=ref. No hay patMove");

            foreach (Tratamiento tratamiento in paciente.tratamientos)
            {
                for (int i=0;i<tratamiento.planes.Count;i++)
                {
                    foreach (Iso iso in tratamiento.planes[i].isos)
                    {
                        DGV_Isos.Rows.Add();
                        DataGridViewRow row = DGV_Isos.Rows[DGV_Isos.Rows.Count-1];
                        row.Cells[0].Value = tratamiento.nombre;
                        row.Cells[1].Value = i + 1;
                        row.Cells[2].Value = tratamiento.planes[i].etiquetaPPF;
                        row.Cells[3].Value = iso.ID;
                        ((DataGridViewComboBoxCell)row.Cells[4]).DataSource = listapatMoves;
                    }
                }
            }
        }

        private List<string> listaConformadores()
        {
            List<string> conformadores = new List<string>();
            foreach (Tratamiento tratamiento in paciente.tratamientos)
            {
                foreach (Plan plan in tratamiento.planes)
                {
                    foreach(Campo campo in plan.listaCampos)
                    {
                        if (campo.SldFile != "NONE")
                        {
                            conformadores.Add(campo.SldFile);
                        }
                    }
                }
            }
            return conformadores;
        }
        private void BT_ContinuarChequeos_Click(object sender, EventArgs e)
        {
            GB_4ChequeoConformaciones.Enabled = true;
            L_conformaciones.Text = "Hay " + listaConformadores().Count.ToString() + " campos conformados. \nEl equipo opera con (acá va MLC o Pb según)";
            L_conformaciones.Visible = true;
        }

        private void BT_FinalizarIsos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Isos.Rows)
            {
                string patMove = (string)((DataGridViewComboBoxCell)row.Cells[4]).Value;
                if ((string)row.Cells[4].Value != "iso=ref. No hay patMove")
                {
                    string tratamientoNombre = (string)row.Cells[0].Value;
                    string planPPF = (string)row.Cells[2].Value;
                    string isoID = (string)row.Cells[3].Value;

                    paciente.tratamientos.Where(t => t.nombre == tratamientoNombre).First().planes.Where(p => p.etiquetaPPF == planPPF).First().isos.Where(i => i.ID == isoID).First().patMove = patMove;
                }
            }
            GB_6ArmarCarpeta.Enabled = true;
            GB_7Finalizar.Enabled = true;
        }

        private void BT_FinalizaChequeoConformaciones_Click(object sender, EventArgs e)
        {
            GB_5IsosyPatMove.Enabled = true;
            cargarDGVIsos();
        }

        private void BT_BuscarPatMove_Click(object sender, EventArgs e)
        {
            cargarDGVIsos();
        }

        private void BT_ArmarCarpeta_Click(object sender, EventArgs e)
        {
            foreach (Tratamiento tratamiento in paciente.tratamientos)
            {
                FormArmarCarpetas armarCarpeta = new FormArmarCarpetas(paciente, tratamiento);
                armarCarpeta.ShowDialog();
            }
        }
    }
}