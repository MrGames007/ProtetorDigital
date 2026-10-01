namespace ProtetorDigital.Forms
{
    partial class FrmRelatos
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
            BtnVoltar = new Button();
            lblRelato = new Label();
            BtnAvancar = new Button();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(12, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(94, 29);
            BtnVoltar.TabIndex = 0;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblRelato
            // 
            lblRelato.BackColor = SystemColors.ControlDark;
            lblRelato.Location = new Point(13, 70);
            lblRelato.Name = "lblRelato";
            lblRelato.Size = new Size(1379, 477);
            lblRelato.TabIndex = 1;
            // 
            // BtnAvancar
            // 
            BtnAvancar.AutoSize = true;
            BtnAvancar.Location = new Point(616, 632);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(72, 30);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Avancar";
            BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // FrmRelatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 760);
            Controls.Add(BtnAvancar);
            Controls.Add(lblRelato);
            Controls.Add(BtnVoltar);
            Name = "FrmRelatos";
            Text = "FrmRelatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVoltar;
        private Label lblRelato;
        private Button BtnAvancar;
    }
}