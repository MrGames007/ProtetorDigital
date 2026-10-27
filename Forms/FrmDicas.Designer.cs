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
            BtnVoltar = new Button();
            BtnRetornar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblDescricao = new Label();
            label3 = new Label();
            lblPassos = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            BtnAvancar.TabIndex = 0;
            BtnAvancar.Text = "Avançar ▶";
            BtnAvancar.UseVisualStyleBackColor = false;
            // 
            // BtnVoltar
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
            // BtnRetornar
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
            BtnRetornar.TabIndex = 3;
            BtnRetornar.Text = "◀ Voltar";
            BtnRetornar.UseVisualStyleBackColor = false;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(lblTitulo);
            flowLayoutPanel1.Controls.Add(lblDescricao);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(lblPassos);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(18, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 16, 20, 16);
            flowLayoutPanel1.Size = new Size(1080, 470);
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
            lblTitulo.MaximumSize = new Size(1000, 0);
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
            lblDescricao.MaximumSize = new Size(1000, 0);
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
            lblPassos.MaximumSize = new Size(1000, 0);
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
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BtnRetornar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAvancar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dicas";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAvancar;
        private Button BtnVoltar;
        private Button BtnRetornar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTitulo;
        private Label lblDescricao;
        private Label label3;
        private Label lblPassos;
    }
}