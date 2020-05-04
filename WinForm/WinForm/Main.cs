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

namespace WinForm
{
    public partial class Main : Form
    {
        public string carpetaPaciente;
        public Paciente paciente = new Paciente();
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
            tratamiento.planes.Add(Extraer.extraerPlan(Extraer.cargar(fullPath(nombreArchivo))));
        }
    }
}