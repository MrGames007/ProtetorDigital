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
            BtnRetornar = new Button();
            lblTitulo = new Label();
            lblFonte = new Label();
            lblTexto = new Label();
            lblLicoesAprendidas = new Label();
            lblRelato = new Label();
            lblVitima = new Label();
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
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(18, 101);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "label1";
            // 
            // lblFonte
            // 
            lblFonte.AutoSize = true;
            lblFonte.Location = new Point(18, 165);
            lblFonte.Name = "lblFonte";
            lblFonte.Size = new Size(38, 15);
            lblFonte.TabIndex = 6;
            lblFonte.Text = "label1";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(18, 371);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(103, 15);
            lblTexto.TabIndex = 9;
            lblTexto.Text = "Lições Aprendidas";
            // 
            // lblLicoesAprendidas
            // 
            lblLicoesAprendidas.AutoSize = true;
            lblLicoesAprendidas.Location = new Point(18, 429);
            lblLicoesAprendidas.Name = "lblLicoesAprendidas";
            lblLicoesAprendidas.Size = new Size(38, 15);
            lblLicoesAprendidas.TabIndex = 10;
            lblLicoesAprendidas.Text = "label1";
            // 
            // lblRelato
            // 
            lblRelato.AutoSize = true;
            lblRelato.Location = new Point(18, 287);
            lblRelato.Name = "lblRelato";
            lblRelato.Size = new Size(38, 15);
            lblRelato.TabIndex = 8;
            lblRelato.Text = "label1";
            // 
            // lblVitima
            // 
            lblVitima.AutoSize = true;
            lblVitima.Location = new Point(18, 229);
            lblVitima.Name = "lblVitima";
            lblVitima.Size = new Size(38, 15);
            lblVitima.TabIndex = 7;
            lblVitima.Text = "label1";
            // 
            // FrmRelatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 618);
            Controls.Add(lblLicoesAprendidas);
            Controls.Add(lblTexto);
            Controls.Add(lblRelato);
            Controls.Add(lblVitima);
            Controls.Add(lblFonte);
            Controls.Add(lblTitulo);
            Controls.Add(BtnRetornar);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRelatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVoltar;
        private Button BtnAvancar;
        private Button BtnRetornar;
        private Label lblTitulo;
        private Label lblFonte;
        private Label lblTexto;
        private Label lblLicoesAprendidas;
        private Label lblRelato;
        private Label lblVitima;
    }
}