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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiblioteca));
            label1 = new Label();
            BtnVoltar = new Button();
            BtnDicas = new Button();
            BtnRelatos = new Button();
            BtnExGolpe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(140, 21);
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
            BtnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(105, 15);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(320, 80);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnDicas
            // 
            BtnDicas.BackColor = Color.Green;
            BtnDicas.FlatStyle = FlatStyle.Flat;
            BtnDicas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDicas.ForeColor = SystemColors.ButtonHighlight;
            BtnDicas.Location = new Point(105, 210);
            BtnDicas.Name = "BtnDicas";
            BtnDicas.Size = new Size(320, 80);
            BtnDicas.TabIndex = 2;
            BtnDicas.Text = "Dicas";
            BtnDicas.UseVisualStyleBackColor = false;
            BtnDicas.Click += BtnDicas_Click;
            // 
            // BtnRelatos
            // 
            BtnRelatos.BackColor = Color.Blue;
            BtnRelatos.FlatStyle = FlatStyle.Flat;
            BtnRelatos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRelatos.ForeColor = SystemColors.ButtonHighlight;
            BtnRelatos.Location = new Point(105, 305);
            BtnRelatos.Name = "BtnRelatos";
            BtnRelatos.Size = new Size(320, 80);
            BtnRelatos.TabIndex = 4;
            BtnRelatos.Text = "Relatos de casos";
            BtnRelatos.UseVisualStyleBackColor = false;
            BtnRelatos.Click += BtnRelatos_Click;
            // 
            // BtnExGolpe
            // 
            BtnExGolpe.BackColor = Color.Red;
            BtnExGolpe.FlatStyle = FlatStyle.Flat;
            BtnExGolpe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExGolpe.ForeColor = SystemColors.ButtonHighlight;
            BtnExGolpe.Location = new Point(105, 115);
            BtnExGolpe.Name = "BtnExGolpe";
            BtnExGolpe.Size = new Size(320, 80);
            BtnExGolpe.TabIndex = 5;
            BtnExGolpe.Text = "Exemplos de Golpes";
            BtnExGolpe.UseVisualStyleBackColor = false;
            BtnExGolpe.Click += BtnExGolpe_Click;
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(530, 410);
            Controls.Add(BtnExGolpe);
            Controls.Add(BtnRelatos);
            Controls.Add(BtnDicas);
            Controls.Add(BtnVoltar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBiblioteca";
            Text = "Biblioteca";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnVoltar;
        private Button BtnDicas;
        private Button BtnRelatos;
        private Button BtnExGolpe;
    }
}
