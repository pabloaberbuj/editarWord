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
        public string salida1 { get; set; }
        public string salida2 { get; set; }
        bool usaDosTextBox = false;
        public TextBoxForm(bool _usaDosTextBox, string texto1, string texto2="")
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            TB_llenar1.Focus();
            Label1.Text = texto1;
            usaDosTextBox = _usaDosTextBox;
            if (usaDosTextBox)
            {
                label2.Visible = true;
                TB_llenar2.Visible = true;
                label2.Text = texto2;
            }

        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            salida1 = TB_llenar1.Text;
            if (usaDosTextBox)
            {
                salida2 = TB_llenar2.Text;
            }
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
            BT_Aceptar.Visible = (TB_llenar1.Text != "");
        }
    }
}
