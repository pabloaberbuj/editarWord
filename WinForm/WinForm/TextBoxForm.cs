using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class TextBoxForm : Form
    {
        public string salida { get; set; }
        public TextBoxForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            salida = TB_llenar.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BT_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TB_llenar_TextChanged(object sender, EventArgs e)
        {
            BT_Aceptar.Visible = (TB_llenar.Text != "");
        }
    }
}
