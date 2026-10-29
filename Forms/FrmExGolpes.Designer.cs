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
            BtnVoltar = new Button();
            BtnAvancar = new Button();
            BtnRetornar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblNomeGolpe = new Label();
            lblFuncionamento = new Label();
            lblTexto = new Label();
            lblSinaisAlerta = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnVoltar (golpe anterior)
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
            BtnVoltar.TabIndex = 1;
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
            BtnAvancar.Location = new Point(941, 556);
            BtnAvancar.Margin = new Padding(3, 2, 3, 2);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(160, 48);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Avançar ▶";
            BtnAvancar.UseVisualStyleBackColor = false;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnRetornar (botão do topo)
            // 
            BtnRetornar.BackColor = Color.FromArgb(0, 120, 215);
            BtnRetornar.Cursor = Cursors.Hand;
            BtnRetornar.FlatAppearance.BorderSize = 0;
            BtnRetornar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnRetornar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnRetornar.FlatStyle = FlatStyle.Flat;
            BtnRetornar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRetornar.ForeColor = Color.White;
            BtnRetornar.Location = new Point(18, 11);
            BtnRetornar.Margin = new Padding(3, 2, 3, 2);
            BtnRetornar.Name = "BtnRetornar";
            BtnRetornar.Size = new Size(160, 44);
            BtnRetornar.TabIndex = 4;
            BtnRetornar.Text = "◀ Retornar";
            BtnRetornar.UseVisualStyleBackColor = false;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // flowLayoutPanel1 (card de conteúdo)
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(lblNomeGolpe);
            flowLayoutPanel1.Controls.Add(lblFuncionamento);
            flowLayoutPanel1.Controls.Add(lblTexto);
            flowLayoutPanel1.Controls.Add(lblSinaisAlerta);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(18, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 16, 20, 16);
            flowLayoutPanel1.Size = new Size(1080, 470);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblNomeGolpe
            // 
            lblNomeGolpe.AutoSize = true;
            lblNomeGolpe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeGolpe.ForeColor = Color.FromArgb(0, 99, 177);
            lblNomeGolpe.Margin = new Padding(3, 0, 3, 14);
            lblNomeGolpe.MaximumSize = new Size(1000, 0);
            lblNomeGolpe.Name = "lblNomeGolpe";
            lblNomeGolpe.Size = new Size(0, 45);
            lblNomeGolpe.TabIndex = 5;
            // 
            // lblFuncionamento
            // 
            lblFuncionamento.AutoSize = true;
            lblFuncionamento.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionamento.ForeColor = Color.FromArgb(33, 37, 41);
            lblFuncionamento.Margin = new Padding(3, 0, 3, 26);
            lblFuncionamento.MaximumSize = new Size(1000, 0);
            lblFuncionamento.Name = "lblFuncionamento";
            lblFuncionamento.Size = new Size(0, 25);
            lblFuncionamento.TabIndex = 6;
            // 
            // lblTexto ("Sinais de Alerta")
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.ForeColor = Color.FromArgb(220, 53, 69);
            lblTexto.Margin = new Padding(3, 0, 3, 8);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(212, 30);
            lblTexto.TabIndex = 7;
            lblTexto.Text = "⚠ Sinais de Alerta!!";
            // 
            // lblSinaisAlerta
            // 
            lblSinaisAlerta.AutoSize = true;
            lblSinaisAlerta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSinaisAlerta.ForeColor = Color.FromArgb(33, 37, 41);
            lblSinaisAlerta.Margin = new Padding(3, 0, 3, 0);
            lblSinaisAlerta.MaximumSize = new Size(1000, 0);
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
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BtnRetornar);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmExGolpes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exemplos de Golpes";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVoltar;
        private Button BtnAvancar;
        private Button BtnRetornar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblNomeGolpe;
        private Label lblFuncionamento;
        private Label lblTexto;
        private Label lblSinaisAlerta;
    }
}