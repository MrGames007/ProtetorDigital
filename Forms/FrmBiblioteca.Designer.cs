namespace ProtetorDigital.Forms
{
    partial class FrmBiblioteca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            BtnVoltar = new Button();
            livro1 = new Button();
            livro2 = new Button();
            livro3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(223, -23);
            label1.Name = "label1";
            label1.Size = new Size(295, 109);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Lucida Sans Unicode", 21.75F);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(12, 12);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(156, 54);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // livro1
            // 
            livro1.BackColor = Color.Green;
            livro1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            livro1.ForeColor = SystemColors.ButtonHighlight;
            livro1.Location = new Point(204, 101);
            livro1.Name = "livro1";
            livro1.Size = new Size(66, 151);
            livro1.TabIndex = 2;
            livro1.Text = "Dicas";
            livro1.UseVisualStyleBackColor = false;
            livro1.Click += button1_Click;
            // 
            // livro2
            // 
            livro2.BackColor = Color.Red;
            livro2.Font = new Font("Segoe UI", 14.25F);
            livro2.ForeColor = SystemColors.ButtonHighlight;
            livro2.Location = new Point(302, 101);
            livro2.Name = "livro2";
            livro2.Size = new Size(108, 151);
            livro2.TabIndex = 3;
            livro2.Text = "Exemplos de golpes";
            livro2.UseVisualStyleBackColor = false;
            // 
            // livro3
            // 
            livro3.BackColor = Color.Blue;
            livro3.Font = new Font("Segoe UI", 14.25F);
            livro3.ForeColor = SystemColors.ButtonHighlight;
            livro3.Location = new Point(433, 101);
            livro3.Name = "livro3";
            livro3.Size = new Size(85, 151);
            livro3.TabIndex = 4;
            livro3.Text = "Relatos de casos";
            livro3.UseVisualStyleBackColor = false;
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(livro3);
            Controls.Add(livro2);
            Controls.Add(livro1);
            Controls.Add(BtnVoltar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBiblioteca";
            Text = "FrmBiblioteca";
            Load += FrmBiblioteca_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnVoltar;
        private Button livro1;
        private Button livro2;
        private Button livro3;
    }
}
