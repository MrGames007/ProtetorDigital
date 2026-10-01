namespace ProtetorDigital.Forms
{
    partial class FrmDicas
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
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            lblDica = new Label();
            SuspendLayout();
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(351, 385);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(94, 29);
            BtnAvancar.TabIndex = 0;
            BtnAvancar.Text = "Avançar";
            BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(30, 19);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(94, 29);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblDica
            // 
            lblDica.BackColor = SystemColors.ControlDark;
            lblDica.ForeColor = SystemColors.ControlText;
            lblDica.Location = new Point(12, 80);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(776, 264);
            lblDica.TabIndex = 2;
            // 
            // FrmDicas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDica);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAvancar);
            Name = "FrmDicas";
            Text = "FrmDicas";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAvancar;
        private Button BtnVoltar;
        private Label lblDica;
    }
}