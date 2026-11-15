namespace ProtetorDigital.Forms
{
    partial class FrmExGolpes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExGolpes));
            BtnAnterior = new Button();
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            pnlTopo = new TableLayoutPanel();
            pnlRodape = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblNomeGolpe = new Label();
            lblFuncionamento = new Label();
            lblTexto = new Label();
            lblSinaisAlerta = new Label();
            pnlTopo.SuspendLayout();
            pnlRodape.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAnterior
            // 
            BtnAnterior.AutoSize = true;
            BtnAnterior.BackColor = Color.FromArgb(0, 120, 215);
            BtnAnterior.Cursor = Cursors.Hand;
            BtnAnterior.FlatAppearance.BorderSize = 0;
            BtnAnterior.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnAnterior.FlatStyle = FlatStyle.Flat;
            BtnAnterior.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnAnterior.ForeColor = Color.White;
            BtnAnterior.Location = new Point(0, 6);
            BtnAnterior.Margin = new Padding(0);
            BtnAnterior.MinimumSize = new Size(190, 56);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Padding = new Padding(18, 8, 18, 8);
            BtnAnterior.Size = new Size(190, 56);
            BtnAnterior.TabIndex = 1;
            BtnAnterior.Text = "◀ Anterior";
            BtnAnterior.UseVisualStyleBackColor = false;
            // 
            // BtnAvancar
            // 
            BtnAvancar.AutoSize = true;
            BtnAvancar.BackColor = Color.FromArgb(0, 120, 215);
            BtnAvancar.Cursor = Cursors.Hand;
            BtnAvancar.FlatAppearance.BorderSize = 0;
            BtnAvancar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnAvancar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnAvancar.FlatStyle = FlatStyle.Flat;
            BtnAvancar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnAvancar.ForeColor = Color.White;
            BtnAvancar.Location = new Point(890, 6);
            BtnAvancar.Margin = new Padding(0);
            BtnAvancar.MinimumSize = new Size(190, 56);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Padding = new Padding(18, 8, 18, 8);
            BtnAvancar.Size = new Size(190, 56);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Avançar ▶";
            BtnAvancar.UseVisualStyleBackColor = false;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.AutoSize = true;
            BtnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(0, 10);
            BtnVoltar.Margin = new Padding(0);
            BtnVoltar.MinimumSize = new Size(190, 56);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Padding = new Padding(18, 8, 18, 8);
            BtnVoltar.Size = new Size(190, 56);
            BtnVoltar.TabIndex = 4;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // pnlTopo
            // 
            pnlTopo.AutoSize = true;
            pnlTopo.ColumnCount = 2;
            pnlTopo.ColumnStyles.Add(new ColumnStyle());
            pnlTopo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTopo.Controls.Add(BtnVoltar, 0, 0);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(18, 0);
            pnlTopo.Margin = new Padding(0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Padding = new Padding(0, 10, 0, 6);
            pnlTopo.RowCount = 1;
            pnlTopo.RowStyles.Add(new RowStyle());
            pnlTopo.Size = new Size(1080, 72);
            pnlTopo.TabIndex = 4;
            // 
            // pnlRodape
            // 
            pnlRodape.AutoSize = true;
            pnlRodape.ColumnCount = 3;
            pnlRodape.ColumnStyles.Add(new ColumnStyle());
            pnlRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlRodape.ColumnStyles.Add(new ColumnStyle());
            pnlRodape.Controls.Add(BtnAnterior, 0, 0);
            pnlRodape.Controls.Add(BtnAvancar, 2, 0);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(18, 544);
            pnlRodape.Margin = new Padding(0);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Padding = new Padding(0, 6, 0, 12);
            pnlRodape.RowCount = 1;
            pnlRodape.RowStyles.Add(new RowStyle());
            pnlRodape.Size = new Size(1080, 74);
            pnlRodape.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(lblNomeGolpe);
            flowLayoutPanel1.Controls.Add(lblFuncionamento);
            flowLayoutPanel1.Controls.Add(lblTexto);
            flowLayoutPanel1.Controls.Add(lblSinaisAlerta);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(18, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 16, 20, 16);
            flowLayoutPanel1.Size = new Size(1080, 618);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblNomeGolpe
            // 
            lblNomeGolpe.AutoSize = true;
            lblNomeGolpe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeGolpe.ForeColor = Color.FromArgb(0, 99, 177);
            lblNomeGolpe.Location = new Point(23, 16);
            lblNomeGolpe.Margin = new Padding(3, 0, 3, 14);
            lblNomeGolpe.Name = "lblNomeGolpe";
            lblNomeGolpe.Size = new Size(0, 45);
            lblNomeGolpe.TabIndex = 5;
            // 
            // lblFuncionamento
            // 
            lblFuncionamento.AutoSize = true;
            lblFuncionamento.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionamento.ForeColor = Color.FromArgb(33, 37, 41);
            lblFuncionamento.Location = new Point(23, 75);
            lblFuncionamento.Margin = new Padding(3, 0, 3, 26);
            lblFuncionamento.Name = "lblFuncionamento";
            lblFuncionamento.Size = new Size(0, 25);
            lblFuncionamento.TabIndex = 6;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.ForeColor = Color.FromArgb(220, 53, 69);
            lblTexto.Location = new Point(23, 126);
            lblTexto.Margin = new Padding(3, 0, 3, 8);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(225, 30);
            lblTexto.TabIndex = 7;
            lblTexto.Text = "⚠ Sinais de Alerta!!";
            // 
            // lblSinaisAlerta
            // 
            lblSinaisAlerta.AutoSize = true;
            lblSinaisAlerta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSinaisAlerta.ForeColor = Color.FromArgb(33, 37, 41);
            lblSinaisAlerta.Location = new Point(23, 164);
            lblSinaisAlerta.Name = "lblSinaisAlerta";
            lblSinaisAlerta.Size = new Size(0, 25);
            lblSinaisAlerta.TabIndex = 8;
            // 
            // FrmExGolpes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 618);
            Controls.Add(pnlTopo);
            Controls.Add(pnlRodape);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmExGolpes";
            Padding = new Padding(18, 0, 18, 0);
            Text = "Exemplos de Golpes";
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlRodape.ResumeLayout(false);
            pnlRodape.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnterior;
        private Button BtnAvancar;
        private Button BtnVoltar;
        private TableLayoutPanel pnlTopo;
        private TableLayoutPanel pnlRodape;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblNomeGolpe;
        private Label lblFuncionamento;
        private Label lblTexto;
        private Label lblSinaisAlerta;
    }
}