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
        bool hayChequeoDosis = false;
        double dosisDiaPPF = double.NaN;
        double dosisTotalPPF = double.NaN;
        public TextBoxForm(bool _usaDosTextBox, bool _hayChequeoDosis, string texto1, string texto2="", double _dosisDiaPPF=double.NaN, double _dosisTotalPPF=double.NaN)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            TB_llenar1.Focus();
            Label1.Text = texto1;
            usaDosTextBox = _usaDosTextBox;
            hayChequeoDosis = _hayChequeoDosis;
            dosisDiaPPF = _dosisDiaPPF;
            dosisTotalPPF = _dosisTotalPPF;
            if (usaDosTextBox)
            {
                label2.Visible = true;
                TB_llenar2.Visible = true;
                label2.Text = texto2;
            }
            else
            {
                Size = new Size(Size.Width, Size.Height - 57);
                BT_Aceptar.Location = new Point(BT_Aceptar.Location.X,BT_Aceptar.Location.Y - 57);
                BT_Cancelar.Location = new Point(BT_Cancelar.Location.X, BT_Cancelar.Location.Y - 57);

            }

        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            salida1 = TB_llenar1.Text;
            if (usaDosTextBox)
            {
                salida2 = TB_llenar2.Text;
            }
            if (hayChequeoDosis)
            {
                if (Convert.ToDouble(salida1)!= dosisDiaPPF)
                {
                    MessageBox.Show("El valor de dosis día ingresado no coincide con el del PPF\nRevisar e ingresarlo nuevamente");
                }
                else if (Convert.ToDouble(salida2) != dosisTotalPPF)
                {
                    MessageBox.Show("El valor de dosis total ingresado no coincide con el del PPF\nRevisar e ingresarlo nuevamente");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
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
