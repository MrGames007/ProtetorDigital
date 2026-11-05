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
            tlpBiblioteca = new TableLayoutPanel();
            tlpBiblioteca.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 8);
            label1.Margin = new Padding(8);
            label1.Name = "label1";
            label1.Size = new Size(704, 117);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.FromArgb(15, 124, 138);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.Dock = DockStyle.Fill;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(248, 591);
            BtnVoltar.Margin = new Padding(8);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(704, 101);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnDicas
            // 
            BtnDicas.BackColor = Color.FromArgb(25, 135, 84);
            BtnDicas.Dock = DockStyle.Fill;
            BtnDicas.FlatStyle = FlatStyle.Flat;
            BtnDicas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDicas.ForeColor = SystemColors.ButtonHighlight;
            BtnDicas.Location = new Point(248, 291);
            BtnDicas.Margin = new Padding(8);
            BtnDicas.Name = "BtnDicas";
            BtnDicas.Size = new Size(704, 134);
            BtnDicas.TabIndex = 2;
            BtnDicas.Text = "Dicas";
            BtnDicas.UseVisualStyleBackColor = false;
            BtnDicas.Click += BtnDicas_Click;
            // 
            // BtnRelatos
            // 
            BtnRelatos.BackColor = Color.FromArgb(0, 120, 215);
            BtnRelatos.Dock = DockStyle.Fill;
            BtnRelatos.FlatStyle = FlatStyle.Flat;
            BtnRelatos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            BtnRelatos.ForeColor = SystemColors.ButtonHighlight;
            BtnRelatos.Location = new Point(248, 441);
            BtnRelatos.Margin = new Padding(8);
            BtnRelatos.Name = "BtnRelatos";
            BtnRelatos.Size = new Size(704, 134);
            BtnRelatos.TabIndex = 4;
            BtnRelatos.Text = "Relatos de casos";
            BtnRelatos.UseVisualStyleBackColor = false;
            BtnRelatos.Click += BtnRelatos_Click;
            // 
            // BtnExGolpe
            // 
            BtnExGolpe.BackColor = Color.FromArgb(220, 53, 69);
            BtnExGolpe.Dock = DockStyle.Fill;
            BtnExGolpe.FlatStyle = FlatStyle.Flat;
            BtnExGolpe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            BtnExGolpe.ForeColor = SystemColors.ButtonHighlight;
            BtnExGolpe.Location = new Point(248, 141);
            BtnExGolpe.Margin = new Padding(8);
            BtnExGolpe.Name = "BtnExGolpe";
            BtnExGolpe.Size = new Size(704, 134);
            BtnExGolpe.TabIndex = 5;
            BtnExGolpe.Text = "Exemplos de Golpes";
            BtnExGolpe.UseVisualStyleBackColor = false;
            BtnExGolpe.Click += BtnExGolpe_Click;
            // 
            // tlpBiblioteca
            // 
            tlpBiblioteca.BackColor = Color.Transparent;
            tlpBiblioteca.ColumnCount = 3;
            tlpBiblioteca.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBiblioteca.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpBiblioteca.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBiblioteca.Controls.Add(label1, 1, 0);
            tlpBiblioteca.Controls.Add(BtnExGolpe, 1, 1);
            tlpBiblioteca.Controls.Add(BtnDicas, 1, 2);
            tlpBiblioteca.Controls.Add(BtnRelatos, 1, 3);
            tlpBiblioteca.Controls.Add(BtnVoltar, 1, 4);
            tlpBiblioteca.Dock = DockStyle.Fill;
            tlpBiblioteca.Location = new Point(0, 0);
            tlpBiblioteca.Name = "tlpBiblioteca";
            tlpBiblioteca.RowCount = 5;
            tlpBiblioteca.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpBiblioteca.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpBiblioteca.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpBiblioteca.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpBiblioteca.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tlpBiblioteca.Size = new Size(1201, 700);
            tlpBiblioteca.TabIndex = 0;
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1201, 700);
            Controls.Add(tlpBiblioteca);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBiblioteca";
            Text = "Biblioteca";
            tlpBiblioteca.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnVoltar;
        private Button BtnDicas;
        private Button BtnRelatos;
        private Button BtnExGolpe;
        private TableLayoutPanel tlpBiblioteca;
    }
}
