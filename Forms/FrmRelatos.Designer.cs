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
            BtnRetorno = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblFonte = new Label();
            lblVitima = new Label();
            lblRelato = new Label();
            lblTexto = new Label();
            lblLicoesAprendidas = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnVoltar (relato anterior)
            // 
            BtnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(18, 556);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(160, 48);
            BtnVoltar.TabIndex = 0;
            BtnVoltar.Text = "◀ Anterior";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
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
            BtnAvancar.Location = new Point(941, 556);
            BtnAvancar.Margin = new Padding(3, 2, 3, 2);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(160, 48);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Avançar ▶";
            BtnAvancar.UseVisualStyleBackColor = false;
            // 
            // BtnRetorno (botão do topo)
            // 
            BtnRetorno.BackColor = Color.FromArgb(0, 120, 215);
            BtnRetorno.Cursor = Cursors.Hand;
            BtnRetorno.FlatAppearance.BorderSize = 0;
            BtnRetorno.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnRetorno.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnRetorno.FlatStyle = FlatStyle.Flat;
            BtnRetorno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRetorno.ForeColor = Color.White;
            BtnRetorno.Location = new Point(18, 11);
            BtnRetorno.Margin = new Padding(3, 2, 3, 2);
            BtnRetorno.Name = "BtnRetorno";
            BtnRetorno.Size = new Size(160, 44);
            BtnRetorno.TabIndex = 11;
            BtnRetorno.Text = "◀ Retornar";
            BtnRetorno.UseVisualStyleBackColor = false;
            BtnRetorno.Click += BtnRetorno_Click;
            // 
            // flowLayoutPanel1 (card de conteúdo)
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(lblTitulo);
            flowLayoutPanel1.Controls.Add(lblFonte);
            flowLayoutPanel1.Controls.Add(lblVitima);
            flowLayoutPanel1.Controls.Add(lblRelato);
            flowLayoutPanel1.Controls.Add(lblTexto);
            flowLayoutPanel1.Controls.Add(lblLicoesAprendidas);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(18, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 16, 20, 16);
            flowLayoutPanel1.Size = new Size(1080, 470);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 99, 177);
            lblTitulo.Margin = new Padding(3, 0, 3, 6);
            lblTitulo.MaximumSize = new Size(1000, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 45);
            lblTitulo.TabIndex = 5;
            // 
            // lblFonte
            // 
            lblFonte.AutoSize = true;
            lblFonte.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFonte.ForeColor = Color.FromArgb(90, 98, 106);
            lblFonte.Margin = new Padding(3, 0, 3, 18);
            lblFonte.MaximumSize = new Size(1000, 0);
            lblFonte.Name = "lblFonte";
            lblFonte.Size = new Size(0, 21);
            lblFonte.TabIndex = 6;
            // 
            // lblVitima
            // 
            lblVitima.AutoSize = true;
            lblVitima.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitima.ForeColor = Color.FromArgb(33, 37, 41);
            lblVitima.Margin = new Padding(3, 0, 3, 10);
            lblVitima.MaximumSize = new Size(1000, 0);
            lblVitima.Name = "lblVitima";
            lblVitima.Size = new Size(0, 25);
            lblVitima.TabIndex = 7;
            // 
            // lblRelato
            // 
            lblRelato.AutoSize = true;
            lblRelato.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRelato.ForeColor = Color.FromArgb(33, 37, 41);
            lblRelato.Margin = new Padding(3, 0, 3, 26);
            lblRelato.MaximumSize = new Size(1000, 0);
            lblRelato.Name = "lblRelato";
            lblRelato.Size = new Size(0, 25);
            lblRelato.TabIndex = 8;
            // 
            // lblTexto ("Lições Aprendidas")
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.ForeColor = Color.FromArgb(33, 136, 56);
            lblTexto.Margin = new Padding(3, 0, 3, 8);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(190, 30);
            lblTexto.TabIndex = 9;
            lblTexto.Text = "Lições Aprendidas";
            // 
            // lblLicoesAprendidas
            // 
            lblLicoesAprendidas.AutoSize = true;
            lblLicoesAprendidas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicoesAprendidas.ForeColor = Color.FromArgb(33, 37, 41);
            lblLicoesAprendidas.Margin = new Padding(3, 0, 3, 0);
            lblLicoesAprendidas.MaximumSize = new Size(1000, 0);
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
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BtnRetorno);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRelatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatos";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVoltar;
        private Button BtnAvancar;
        private Button BtnRetorno;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTitulo;
        private Label lblFonte;
        private Label lblVitima;
        private Label lblRelato;
        private Label lblTexto;
        private Label lblLicoesAprendidas;
    }
}