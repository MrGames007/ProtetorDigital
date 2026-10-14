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
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTítulo = new Label();
            lblDescricao = new Label();
            lblPassos = new Label();
            BtnRetornar = new Button();
            groupBox1.SuspendLayout();
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
            BtnVoltar.BackColor = SystemColors.Highlight;
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(15, 556);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(160, 48);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "◀ Anterior";
            BtnVoltar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(248, 249, 250);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(15, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 483);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(lblTítulo);
            flowLayoutPanel1.Controls.Add(lblDescricao);
            flowLayoutPanel1.Controls.Add(lblPassos);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(12, 8, 12, 8);
            flowLayoutPanel1.Size = new Size(1080, 461);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblTítulo
            // 
            lblTítulo.AutoSize = true;
            lblTítulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTítulo.ForeColor = Color.FromArgb(0, 99, 177);
            lblTítulo.Location = new Point(15, 8);
            lblTítulo.Margin = new Padding(3, 0, 3, 14);
            lblTítulo.MaximumSize = new Size(690, 0);
            lblTítulo.Name = "lblTítulo";
            lblTítulo.Size = new Size(0, 37);
            lblTítulo.TabIndex = 0;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescricao.Location = new Point(15, 59);
            lblDescricao.Margin = new Padding(3, 0, 3, 18);
            lblDescricao.MaximumSize = new Size(690, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(0, 25);
            lblDescricao.TabIndex = 1;
            // 
            // lblPassos
            // 
            lblPassos.AutoSize = true;
            lblPassos.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassos.ForeColor = Color.FromArgb(33, 37, 41);
            lblPassos.Location = new Point(15, 102);
            lblPassos.MaximumSize = new Size(690, 0);
            lblPassos.Name = "lblPassos";
            lblPassos.Size = new Size(0, 25);
            lblPassos.TabIndex = 2;
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
            BtnRetornar.Size = new Size(160, 44);
            BtnRetornar.TabIndex = 3;
            BtnRetornar.Text = "◀ Voltar";
            BtnRetornar.UseVisualStyleBackColor = false;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // FrmDicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 618);
            Controls.Add(BtnRetornar);
            Controls.Add(groupBox1);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAvancar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dicas";
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAvancar;
        private Button BtnVoltar;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblPassos;
        private Label lblDescricao;
        private Label lblTítulo;
        private Button BtnRetornar;
    }
}