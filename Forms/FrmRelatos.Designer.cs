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
            // O Designer monta os controles de relato; FrmRelatos.cs preenche dados, links e navegação.
            BtnAnterior = new Button();
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            pnlTopo = new TableLayoutPanel();
            pnlRodape = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblFonte = new Label();
            lnkMateria = new LinkLabel();
            lblVitima = new Label();
            lblRelato = new Label();
            lblTexto = new Label();
            lblLicoesAprendidas = new Label();
            pnlTopo.SuspendLayout();
            pnlRodape.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            //
            // BtnAnterior
            //
            BtnAnterior.BackColor = Color.FromArgb(0, 120, 215);
            BtnAnterior.Cursor = Cursors.Hand;
            BtnAnterior.FlatAppearance.BorderSize = 0;
            BtnAnterior.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnAnterior.FlatStyle = FlatStyle.Flat;
            BtnAnterior.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnAnterior.ForeColor = Color.White;
            BtnAnterior.AutoEllipsis = false;
            BtnAnterior.AutoSize = true;
            BtnAnterior.AutoSizeMode = AutoSizeMode.GrowOnly;
            BtnAnterior.Margin = new Padding(0);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.MinimumSize = new Size(190, 56);
            BtnAnterior.Padding = new Padding(18, 8, 18, 8);
            BtnAnterior.TabIndex = 0;
            BtnAnterior.Text = "◀ Anterior";
            BtnAnterior.TextAlign = ContentAlignment.MiddleCenter;
            BtnAnterior.UseVisualStyleBackColor = false;
            BtnAnterior.Click += BtnAnterior_Click;
            //
            // BtnAvancar
            //
            BtnAvancar.BackColor = Color.FromArgb(0, 120, 215);
            BtnAvancar.Cursor = Cursors.Hand;
            BtnAvancar.FlatAppearance.BorderSize = 0;
            BtnAvancar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnAvancar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnAvancar.FlatStyle = FlatStyle.Flat;
            BtnAvancar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnAvancar.ForeColor = Color.White;
            BtnAvancar.AutoEllipsis = false;
            BtnAvancar.AutoSize = true;
            BtnAvancar.AutoSizeMode = AutoSizeMode.GrowOnly;
            BtnAvancar.Margin = new Padding(0);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.MinimumSize = new Size(190, 56);
            BtnAvancar.Padding = new Padding(18, 8, 18, 8);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Avançar ▶";
            BtnAvancar.TextAlign = ContentAlignment.MiddleCenter;
            BtnAvancar.UseVisualStyleBackColor = false;
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.AutoEllipsis = false;
            BtnVoltar.AutoSize = true;
            BtnVoltar.AutoSizeMode = AutoSizeMode.GrowOnly;
            BtnVoltar.Margin = new Padding(0);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.MinimumSize = new Size(190, 56);
            BtnVoltar.Padding = new Padding(18, 8, 18, 8);
            BtnVoltar.TabIndex = 11;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.TextAlign = ContentAlignment.MiddleCenter;
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            //
            // pnlTopo
            //
            pnlTopo.AutoSize = true;
            pnlTopo.ColumnCount = 2;
            pnlTopo.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            pnlTopo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTopo.Controls.Add(BtnVoltar, 0, 0);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(18, 0);
            pnlTopo.Margin = new Padding(0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Padding = new Padding(0, 10, 0, 6);
            pnlTopo.RowCount = 1;
            pnlTopo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlTopo.TabIndex = 4;
            //
            // pnlRodape
            //
            pnlRodape.AutoSize = true;
            pnlRodape.ColumnCount = 3;
            pnlRodape.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            pnlRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlRodape.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            pnlRodape.Controls.Add(BtnAnterior, 0, 0);
            pnlRodape.Controls.Add(BtnAvancar, 2, 0);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(18, 550);
            pnlRodape.Margin = new Padding(0);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Padding = new Padding(0, 6, 0, 12);
            pnlRodape.RowCount = 1;
            pnlRodape.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlRodape.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(lblTitulo);
            flowLayoutPanel1.Controls.Add(lblFonte);
            flowLayoutPanel1.Controls.Add(lnkMateria);
            flowLayoutPanel1.Controls.Add(lblVitima);
            flowLayoutPanel1.Controls.Add(lblRelato);
            flowLayoutPanel1.Controls.Add(lblTexto);
            flowLayoutPanel1.Controls.Add(lblLicoesAprendidas);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 16, 20, 16);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 99, 177);
            lblTitulo.Location = new Point(23, 16);
            lblTitulo.Margin = new Padding(3, 0, 3, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 45);
            lblTitulo.TabIndex = 5;
            // 
            // lblFonte
            // 
            lblFonte.AutoSize = true;
            lblFonte.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFonte.ForeColor = Color.FromArgb(90, 98, 106);
            lblFonte.Location = new Point(23, 67);
            lblFonte.Margin = new Padding(3, 0, 3, 18);
            lblFonte.Name = "lblFonte";
            lblFonte.Size = new Size(0, 21);
            lblFonte.TabIndex = 6;
            // 
            // lnkMateria
            // 
            lnkMateria.AutoSize = true;
            lnkMateria.Font = new Font("Segoe UI", 16F);
            lnkMateria.LinkColor = Color.FromArgb(11, 92, 173);
            lnkMateria.Location = new Point(23, 106);
            lnkMateria.Margin = new Padding(3, 0, 3, 8);
            lnkMateria.Name = "lnkMateria";
            lnkMateria.Size = new Size(239, 30);
            lnkMateria.TabIndex = 12;
            lnkMateria.TabStop = true;
            lnkMateria.Text = "Ler a matéria original ↗";
            lnkMateria.VisitedLinkColor = Color.FromArgb(111, 66, 193);
            lnkMateria.LinkClicked += LnkMateria_LinkClicked;
            // 
            // lblVitima
            // 
            lblVitima.AutoSize = true;
            lblVitima.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitima.ForeColor = Color.FromArgb(33, 37, 41);
            lblVitima.Location = new Point(23, 144);
            lblVitima.Margin = new Padding(3, 0, 3, 10);
            lblVitima.Name = "lblVitima";
            lblVitima.Size = new Size(0, 25);
            lblVitima.TabIndex = 7;
            // 
            // lblRelato
            // 
            lblRelato.AutoSize = true;
            lblRelato.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRelato.ForeColor = Color.FromArgb(33, 37, 41);
            lblRelato.Location = new Point(23, 179);
            lblRelato.Margin = new Padding(3, 0, 3, 26);
            lblRelato.Name = "lblRelato";
            lblRelato.Size = new Size(0, 25);
            lblRelato.TabIndex = 8;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.ForeColor = Color.FromArgb(33, 136, 56);
            lblTexto.Location = new Point(23, 230);
            lblTexto.Margin = new Padding(3, 0, 3, 8);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(201, 30);
            lblTexto.TabIndex = 9;
            lblTexto.Text = "Lições Aprendidas";
            // 
            // lblLicoesAprendidas
            // 
            lblLicoesAprendidas.AutoSize = true;
            lblLicoesAprendidas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicoesAprendidas.ForeColor = Color.FromArgb(33, 37, 41);
            lblLicoesAprendidas.Location = new Point(23, 268);
            lblLicoesAprendidas.Name = "lblLicoesAprendidas";
            lblLicoesAprendidas.Size = new Size(0, 25);
            lblLicoesAprendidas.TabIndex = 10;
            // 
            // FrmRelatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 618);
            Padding = new Padding(18, 0, 18, 0);
            Controls.Add(pnlTopo);
            Controls.Add(pnlRodape);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRelatos";
            Text = "Relatos";
            flowLayoutPanel1.BringToFront();
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlRodape.ResumeLayout(false);
            pnlRodape.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAnterior;
        private Button BtnAvancar;
        private Button BtnVoltar;
        private TableLayoutPanel pnlTopo;
        private TableLayoutPanel pnlRodape;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTitulo;
        private Label lblFonte;
        private Label lblVitima;
        private Label lblRelato;
        private Label lblTexto;
        private Label lblLicoesAprendidas;
        private LinkLabel lnkMateria;
    }
}
