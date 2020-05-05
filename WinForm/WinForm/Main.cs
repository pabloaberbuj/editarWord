using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Media;

namespace WinForm
{
    public partial class Main : Form
    {
        public string carpetaPaciente;
        public Paciente paciente = new Paciente();
        public Tratamiento tratamientoActual;
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
            dialog.InitialDirectory = @"C:\Users\Casa\source\repos\editarWordExtendido\WinForm\WinForm";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                carpetaPaciente = dialog.FileName;
                llenarLB_PPFs(carpetaPaciente);
                crearPaciente(fullPath(LB_ppfs.Items[0].ToString()));
            }

        }

        private List<string> todosLosPPFs(string path)
        {
            return Directory.GetFiles(path, "*.ppf").ToList();
        }

        private void llenarLB_PPFs(string path)
        {
            LB_ppfs.DataSource = null;
            List<string> _todosLosPPfs = todosLosPPFs(path);
            foreach (string ppf in _todosLosPPfs)
            {
                LB_ppfs.Items.Add(Path.GetFileName(ppf));
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
            tratamientoActual = tratamiento;
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
            agregarNuevoPlan(tratamientoActual);

        }

        private string nombrePlanSeleccionado()
        {
            return fullPath(LB_ppfs.SelectedItem.ToString());
        }

        private void agregarNuevoPlan(Tratamiento tratamiento)
        {
            Plan plan = Extraer.extraerPlan(Extraer.cargar(nombrePlanSeleccionado()));
            TextBoxForm dosisTotalDia = new TextBoxForm(true, true, "Dosis Fracción", "Dosis plan", Convert.ToDouble(plan.dosisFraccion));
            dosisTotalDia.Text = "Dosis del plan seleccionado";
            dosisTotalDia.ShowDialog();
            if (dosisTotalDia.DialogResult == DialogResult.OK)
            {
                plan.dosisFraccion = dosisTotalDia.salida1;
                plan.dosisTotal = dosisTotalDia.salida2;
                tratamiento.planes.Add(plan);
                plan.pathPPF = nombrePlanSeleccionado();
                plan.etiquetaPPF = LB_ppfs.SelectedItem.ToString();
                TreeNode plan_nodo = new TreeNode();
                plan.nodo = plan_nodo;
                plan.nodo.Text = "Etapa única (" + tratamiento.planes[0].dosisTotal + "/" + plan.dosisFraccion + ")";
                plan.nodo.ToolTipText = plan.etiquetaPPF;
                tratamiento.nodo.Nodes.Add(plan_nodo);
                visualizarArbol();
                dosisTotalDia.Close();
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

            }
        }
    }
}