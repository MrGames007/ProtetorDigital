namespace ProtetorDigital.Forms
{
    partial class FrmDicas
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
            BtnAvancar = new Button();
            BtnAnterior = new Button();
            BtnVoltar = new Button();
            pnlTopo = new TableLayoutPanel();
            pnlRodape = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblDescricao = new Label();
            label3 = new Label();
            lblPassos = new Label();
            pnlTopo.SuspendLayout();
            pnlRodape.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            BtnAvancar.TabIndex = 0;
            BtnAvancar.Text = "Avançar ▶";
            BtnAvancar.TextAlign = ContentAlignment.MiddleCenter;
            BtnAvancar.UseVisualStyleBackColor = false;
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
            BtnAnterior.TabIndex = 1;
            BtnAnterior.Text = "◀ Anterior";
            BtnAnterior.TextAlign = ContentAlignment.MiddleCenter;
            BtnAnterior.UseVisualStyleBackColor = false;
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
            BtnVoltar.TabIndex = 3;
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
            flowLayoutPanel1.Controls.Add(lblDescricao);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(lblPassos);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 16, 20, 16);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 99, 177);
            lblTitulo.Location = new Point(23, 16);
            lblTitulo.Margin = new Padding(3, 0, 3, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 45);
            lblTitulo.TabIndex = 4;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescricao.Location = new Point(23, 75);
            lblDescricao.Margin = new Padding(3, 0, 3, 26);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(0, 25);
            lblDescricao.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(33, 136, 56);
            label3.Location = new Point(23, 126);
            label3.Margin = new Padding(3, 0, 3, 8);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 6;
            label3.Text = "O que fazer?";
            // 
            // lblPassos
            // 
            lblPassos.AutoSize = true;
            lblPassos.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassos.ForeColor = Color.FromArgb(33, 37, 41);
            lblPassos.Location = new Point(23, 164);
            lblPassos.Name = "lblPassos";
            lblPassos.Size = new Size(0, 25);
            lblPassos.TabIndex = 7;
            // 
            // FrmDicas
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
            Name = "FrmDicas";
            Text = "Dicas";
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

        private Button BtnAvancar;
        private Button BtnAnterior;
        private Button BtnVoltar;
        private TableLayoutPanel pnlTopo;
        private TableLayoutPanel pnlRodape;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTitulo;
        private Label lblDescricao;
        private Label label3;
        private Label lblPassos;
    }
}