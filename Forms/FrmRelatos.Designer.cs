namespace ProtetorDigital.Forms
{
    partial class FrmRelatos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            BtnVoltar = new Button();
            BtnAvancar = new Button();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblFonte = new Label();
            lblVitima = new Label();
            lblRelato = new Label();
            lblLicoesAprendidas = new Label();
            BtnRetornar = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnVoltar.BackColor = SystemColors.Highlight;
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 38, 50);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(189, 45, 59);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(15, 555);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(160, 48);
            BtnVoltar.TabIndex = 0;
            BtnVoltar.Text = "◀ Anterior";
            BtnVoltar.UseVisualStyleBackColor = false;
            // 
            // BtnAvancar
            // 
            BtnAvancar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAvancar.BackColor = Color.FromArgb(0, 120, 215);
            BtnAvancar.Cursor = Cursors.Hand;
            BtnAvancar.FlatAppearance.BorderSize = 0;
            BtnAvancar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnAvancar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnAvancar.FlatStyle = FlatStyle.Flat;
            BtnAvancar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAvancar.ForeColor = Color.White;
            BtnAvancar.Location = new Point(941, 555);
            BtnAvancar.Margin = new Padding(3, 2, 3, 2);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(160, 48);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Avançar ▶";
            BtnAvancar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(248, 249, 250);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(15, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 480);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(lblTitulo);
            flowLayoutPanel1.Controls.Add(lblFonte);
            flowLayoutPanel1.Controls.Add(lblVitima);
            flowLayoutPanel1.Controls.Add(lblRelato);
            flowLayoutPanel1.Controls.Add(lblLicoesAprendidas);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(12, 8, 12, 8);
            flowLayoutPanel1.Size = new Size(1080, 458);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitulo.Location = new Point(15, 8);
            lblTitulo.Margin = new Padding(3, 0, 3, 12);
            lblTitulo.MaximumSize = new Size(1030, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 37);
            lblTitulo.TabIndex = 0;
            // 
            // lblFonte
            // 
            lblFonte.AutoSize = true;
            lblFonte.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFonte.ForeColor = Color.FromArgb(90, 98, 106);
            lblFonte.Location = new Point(15, 57);
            lblFonte.Margin = new Padding(3, 0, 3, 14);
            lblFonte.MaximumSize = new Size(1030, 0);
            lblFonte.Name = "lblFonte";
            lblFonte.Size = new Size(0, 20);
            lblFonte.TabIndex = 1;
            // 
            // lblVitima
            // 
            lblVitima.AutoSize = true;
            lblVitima.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitima.ForeColor = Color.FromArgb(0, 99, 177);
            lblVitima.Location = new Point(15, 91);
            lblVitima.Margin = new Padding(3, 0, 3, 14);
            lblVitima.MaximumSize = new Size(1030, 0);
            lblVitima.Name = "lblVitima";
            lblVitima.Size = new Size(0, 25);
            lblVitima.TabIndex = 2;
            // 
            // lblRelato
            // 
            lblRelato.AutoSize = true;
            lblRelato.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRelato.ForeColor = Color.FromArgb(33, 37, 41);
            lblRelato.Location = new Point(15, 130);
            lblRelato.Margin = new Padding(3, 0, 3, 18);
            lblRelato.MaximumSize = new Size(1030, 0);
            lblRelato.Name = "lblRelato";
            lblRelato.Size = new Size(0, 25);
            lblRelato.TabIndex = 3;
            // 
            // lblLicoesAprendidas
            // 
            lblLicoesAprendidas.AutoSize = true;
            lblLicoesAprendidas.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicoesAprendidas.ForeColor = Color.FromArgb(33, 136, 56);
            lblLicoesAprendidas.Location = new Point(15, 173);
            lblLicoesAprendidas.MaximumSize = new Size(1030, 0);
            lblLicoesAprendidas.Name = "lblLicoesAprendidas";
            lblLicoesAprendidas.Size = new Size(0, 25);
            lblLicoesAprendidas.TabIndex = 4;
            // 
            // BtnRetornar
            // 
            BtnRetornar.BackColor = Color.FromArgb(0, 120, 215);
            BtnRetornar.Cursor = Cursors.Hand;
            BtnRetornar.FlatAppearance.BorderSize = 0;
            BtnRetornar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnRetornar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnRetornar.FlatStyle = FlatStyle.Flat;
            BtnRetornar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRetornar.ForeColor = Color.White;
            BtnRetornar.Location = new Point(18, 11);
            BtnRetornar.Margin = new Padding(3, 2, 3, 2);
            BtnRetornar.Name = "BtnRetornar";
            BtnRetornar.Size = new Size(157, 44);
            BtnRetornar.TabIndex = 4;
            BtnRetornar.Text = "◀ Voltar";
            BtnRetornar.UseVisualStyleBackColor = false;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // FrmRelatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 618);
            Controls.Add(BtnRetornar);
            Controls.Add(groupBox1);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRelatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatos";
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVoltar;
        private Button BtnAvancar;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblVitima;
        private Label lblFonte;
        private Label lblTitulo;
        private Label lblLicoesAprendidas;
        private Label lblRelato;
        private Button BtnRetornar;
    }
}