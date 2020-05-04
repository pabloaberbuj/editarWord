namespace WinForm
{
    partial class TextBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Aceptar = new System.Windows.Forms.Button();
            this.TB_llenar1 = new System.Windows.Forms.TextBox();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.TB_llenar2 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Aceptar
            // 
            this.BT_Aceptar.Location = new System.Drawing.Point(34, 121);
            this.BT_Aceptar.Name = "BT_Aceptar";
            this.BT_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BT_Aceptar.TabIndex = 0;
            this.BT_Aceptar.Text = "Aceptar";
            this.BT_Aceptar.UseVisualStyleBackColor = true;
            this.BT_Aceptar.Click += new System.EventHandler(this.BT_Aceptar_Click);
            // 
            // TB_llenar1
            // 
            this.TB_llenar1.Location = new System.Drawing.Point(34, 25);
            this.TB_llenar1.Name = "TB_llenar1";
            this.TB_llenar1.Size = new System.Drawing.Size(207, 20);
            this.TB_llenar1.TabIndex = 1;
            this.TB_llenar1.TextChanged += new System.EventHandler(this.TB_llenar_TextChanged);
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancelar.Location = new System.Drawing.Point(166, 121);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancelar.TabIndex = 2;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.UseVisualStyleBackColor = true;
            this.BT_Cancelar.Click += new System.EventHandler(this.BT_Cancelar_Click);
            // 
            // TB_llenar2
            // 
            this.TB_llenar2.Location = new System.Drawing.Point(34, 85);
            this.TB_llenar2.Name = "TB_llenar2";
            this.TB_llenar2.Size = new System.Drawing.Size(207, 20);
            this.TB_llenar2.TabIndex = 3;
            this.TB_llenar2.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // TextBoxForm
            // 
            this.AcceptButton = this.BT_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BT_Cancelar;
            this.ClientSize = new System.Drawing.Size(274, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TB_llenar2);
            this.Controls.Add(this.BT_Cancelar);
            this.Controls.Add(this.TB_llenar1);
            this.Controls.Add(this.BT_Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TextBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBoxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Aceptar;
        private System.Windows.Forms.TextBox TB_llenar1;
        private System.Windows.Forms.Button BT_Cancelar;
        private System.Windows.Forms.TextBox TB_llenar2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
    }
}