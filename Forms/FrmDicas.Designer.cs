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
            lblTitulo = new Label();
            lblDescricao = new Label();
            label3 = new Label();
            lblPassos = new Label();
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(18, 127);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "label1";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(18, 211);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(38, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 342);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "O que fazer?";
            // 
            // lblPassos
            // 
            lblPassos.AutoSize = true;
            lblPassos.Location = new Point(18, 379);
            lblPassos.Name = "lblPassos";
            lblPassos.Size = new Size(38, 15);
            lblPassos.TabIndex = 7;
            lblPassos.Text = "label4";
            // 
            // FrmDicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 618);
            Controls.Add(lblPassos);
            Controls.Add(label3);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Controls.Add(BtnRetornar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAvancar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dicas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAvancar;
        private Button BtnVoltar;
        private Button BtnRetornar;
        private Label lblTitulo;
        private Label lblDescricao;
        private Label label3;
        private Label lblPassos;
    }
}