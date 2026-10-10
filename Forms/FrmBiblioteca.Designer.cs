namespace ProtetorDigital.Forms
{
    partial class FrmBiblioteca
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
            label1 = new Label();
            BtnVoltar = new Button();
            BtnDicas = new Button();
            BtnExGolpes = new Button();
            BtnRelatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(223, -23);
            label1.Name = "label1";
            label1.Size = new Size(295, 109);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Lucida Sans Unicode", 21.75F);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(12, 12);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(156, 54);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnDicas
            // 
            BtnDicas.BackColor = Color.Green;
            BtnDicas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDicas.ForeColor = SystemColors.ButtonHighlight;
            BtnDicas.Location = new Point(204, 101);
            BtnDicas.Name = "BtnDicas";
            BtnDicas.Size = new Size(66, 151);
            BtnDicas.TabIndex = 2;
            BtnDicas.Text = "Dicas";
            BtnDicas.UseVisualStyleBackColor = false;
            BtnDicas.Click += BtnDicas_Click;
            // 
            // BtnExGolpes
            // 
            BtnExGolpes.BackColor = Color.Red;
            BtnExGolpes.Font = new Font("Segoe UI", 14.25F);
            BtnExGolpes.ForeColor = SystemColors.ButtonHighlight;
            BtnExGolpes.Location = new Point(302, 101);
            BtnExGolpes.Name = "BtnExGolpes";
            BtnExGolpes.Size = new Size(108, 151);
            BtnExGolpes.TabIndex = 3;
            BtnExGolpes.Text = "Exemplos de golpes";
            BtnExGolpes.UseVisualStyleBackColor = false;
            BtnExGolpes.Click += BtnExGolpes_Click;
            // 
            // BtnRelatos
            // 
            BtnRelatos.BackColor = Color.Blue;
            BtnRelatos.Font = new Font("Segoe UI", 14.25F);
            BtnRelatos.ForeColor = SystemColors.ButtonHighlight;
            BtnRelatos.Location = new Point(433, 101);
            BtnRelatos.Name = "BtnRelatos";
            BtnRelatos.Size = new Size(85, 151);
            BtnRelatos.TabIndex = 4;
            BtnRelatos.Text = "Relatos de casos";
            BtnRelatos.UseVisualStyleBackColor = false;
            BtnRelatos.Click += BtnRelatos_Click;
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(692, 387);
            Controls.Add(BtnRelatos);
            Controls.Add(BtnExGolpes);
            Controls.Add(BtnDicas);
            Controls.Add(BtnVoltar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBiblioteca";
            Text = "FrmBiblioteca";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnVoltar;
        private Button BtnDicas;
        private Button BtnExGolpes;
        private Button BtnRelatos;
    }
}
