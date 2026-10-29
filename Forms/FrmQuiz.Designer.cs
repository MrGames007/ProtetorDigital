namespace ProtetorDigital.Forms
{
    partial class FrmQuiz
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
            lblPergunta = new Label();
            RBtnAlt1 = new RadioButton();
            RBtnAlt2 = new RadioButton();
            RBtnAlt3 = new RadioButton();
            RBtnAlt4 = new RadioButton();
            BtnVoltar = new Button();
            BtnConfirmar = new Button();
            lblProgresso = new Label();
            progressQuiz = new ProgressBar();
            pnlFeedback = new Panel();
            txtFeedback = new RichTextBox();
            pnlResultado = new Panel();
            txtResultado = new RichTextBox();
            pnlResultadoBotoes = new Panel();
            btnRefazer = new Button();
            btnVoltarMenu = new Button();
            SuspendLayout();
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPergunta.ForeColor = Color.FromArgb(33, 37, 41);
            lblPergunta.Location = new Point(15, 115);
            lblPergunta.MaximumSize = new Size(1170, 0);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(0, 30);
            lblPergunta.TabIndex = 0;
            // 
            // RBtnAlt1
            // 
            RBtnAlt1.AutoSize = true;
            RBtnAlt1.Cursor = Cursors.Hand;
            RBtnAlt1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt1.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt1.Location = new Point(15, 190);
            RBtnAlt1.Margin = new Padding(3, 6, 3, 6);
            RBtnAlt1.Name = "RBtnAlt1";
            RBtnAlt1.Size = new Size(14, 13);
            RBtnAlt1.TabIndex = 1;
            RBtnAlt1.TabStop = true;
            RBtnAlt1.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt2
            // 
            RBtnAlt2.AutoSize = true;
            RBtnAlt2.Cursor = Cursors.Hand;
            RBtnAlt2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt2.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt2.Location = new Point(15, 250);
            RBtnAlt2.Margin = new Padding(3, 6, 3, 6);
            RBtnAlt2.Name = "RBtnAlt2";
            RBtnAlt2.Size = new Size(14, 13);
            RBtnAlt2.TabIndex = 2;
            RBtnAlt2.TabStop = true;
            RBtnAlt2.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt3
            // 
            RBtnAlt3.AutoSize = true;
            RBtnAlt3.Cursor = Cursors.Hand;
            RBtnAlt3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt3.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt3.Location = new Point(15, 310);
            RBtnAlt3.Margin = new Padding(3, 6, 3, 6);
            RBtnAlt3.Name = "RBtnAlt3";
            RBtnAlt3.Size = new Size(14, 13);
            RBtnAlt3.TabIndex = 3;
            RBtnAlt3.TabStop = true;
            RBtnAlt3.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt4
            // 
            RBtnAlt4.AutoSize = true;
            RBtnAlt4.Cursor = Cursors.Hand;
            RBtnAlt4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt4.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt4.Location = new Point(15, 370);
            RBtnAlt4.Margin = new Padding(3, 6, 3, 6);
            RBtnAlt4.Name = "RBtnAlt4";
            RBtnAlt4.Size = new Size(14, 13);
            RBtnAlt4.TabIndex = 4;
            RBtnAlt4.TabStop = true;
            RBtnAlt4.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnVoltar.Location = new Point(15, 565);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(160, 44);
            BtnVoltar.TabIndex = 5;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirmar.BackColor = Color.FromArgb(40, 167, 69);
            BtnConfirmar.Cursor = Cursors.Hand;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 105, 43);
            BtnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmar.ForeColor = Color.White;
            BtnConfirmar.Location = new Point(835, 565);
            BtnConfirmar.Margin = new Padding(3, 2, 3, 2);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(150, 32);
            BtnConfirmar.TabIndex = 6;
            BtnConfirmar.Text = "Confirmar ✓";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // lblProgresso
            // 
            lblProgresso.AutoSize = true;
            lblProgresso.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgresso.Location = new Point(15, 75);
            lblProgresso.Name = "lblProgresso";
            lblProgresso.Size = new Size(0, 25);
            lblProgresso.TabIndex = 7;
            // 
            // progressQuiz
            // 
            progressQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressQuiz.Location = new Point(245, 77);
            progressQuiz.Name = "progressQuiz";
            progressQuiz.Size = new Size(825, 23);
            progressQuiz.TabIndex = 8;
            // 
            // pnlFeedback
            // 
            pnlFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFeedback.Controls.Add(txtFeedback);
            pnlFeedback.Location = new Point(15, 440);
            pnlFeedback.Name = "pnlFeedback";
            pnlFeedback.Padding = new Padding(8);
            pnlFeedback.Size = new Size(1070, 105);
            pnlFeedback.TabIndex = 9;
            pnlFeedback.Visible = false;
            // 
            // txtFeedback
            // 
            txtFeedback.BackColor = Color.White;
            txtFeedback.BorderStyle = BorderStyle.None;
            txtFeedback.Dock = DockStyle.Fill;
            txtFeedback.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFeedback.Location = new Point(8, 8);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.ReadOnly = true;
            txtFeedback.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtFeedback.Size = new Size(1054, 89);
            txtFeedback.TabIndex = 0;
            txtFeedback.Text = "";
            // 
            // pnlResultado
            // 
            pnlResultado.BackColor = Color.White;
            pnlResultado.Controls.Add(txtResultado);
            pnlResultado.Controls.Add(pnlResultadoBotoes);
            pnlResultado.Dock = DockStyle.Fill;
            pnlResultado.Location = new Point(0, 0);
            pnlResultado.Name = "pnlResultado";
            pnlResultado.Padding = new Padding(20);
            pnlResultado.Size = new Size(1100, 640);
            pnlResultado.TabIndex = 10;
            pnlResultado.Visible = false;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(20, 20);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtResultado.Size = new Size(1060, 515);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "";
            // 
            // pnlResultadoBotoes
            // 
            pnlResultadoBotoes.Controls.Add(btnVoltarMenu);
            pnlResultadoBotoes.Controls.Add(btnRefazer);
            pnlResultadoBotoes.Dock = DockStyle.Bottom;
            pnlResultadoBotoes.Location = new Point(20, 535);
            pnlResultadoBotoes.Name = "pnlResultadoBotoes";
            pnlResultadoBotoes.Size = new Size(1060, 85);
            pnlResultadoBotoes.TabIndex = 1;
            // 
            // btnRefazer
            // 
            btnRefazer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefazer.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefazer.Location = new Point(0, 10);
            btnRefazer.Name = "btnRefazer";
            btnRefazer.Size = new Size(200, 60);
            btnRefazer.TabIndex = 0;
            btnRefazer.Text = "Refazer";
            btnRefazer.UseVisualStyleBackColor = true;
            btnRefazer.Click += BtnRefazer_Click;
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltarMenu.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarMenu.Location = new Point(810, 10);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new Size(250, 60);
            btnVoltarMenu.TabIndex = 1;
            btnVoltarMenu.Text = "Voltar ao menu";
            btnVoltarMenu.UseVisualStyleBackColor = true;
            btnVoltarMenu.Click += BtnVoltarMenu_Click;
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 640);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnVoltar);
            Controls.Add(RBtnAlt4);
            Controls.Add(RBtnAlt3);
            Controls.Add(RBtnAlt2);
            Controls.Add(RBtnAlt1);
            Controls.Add(lblPergunta);
            Controls.Add(progressQuiz);
            Controls.Add(lblProgresso);
            Controls.Add(pnlFeedback);
            Controls.Add(pnlResultado);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPergunta;
        private RadioButton RBtnAlt1;
        private RadioButton RBtnAlt2;
        private RadioButton RBtnAlt3;
        private RadioButton RBtnAlt4;
        private Button BtnVoltar;
        private Button BtnConfirmar;
        private Label lblProgresso;
        private ProgressBar progressQuiz;
        private Panel pnlFeedback;
        private RichTextBox txtFeedback;
        private Panel pnlResultado;
        private RichTextBox txtResultado;
        private Panel pnlResultadoBotoes;
        private Button btnRefazer;
        private Button btnVoltarMenu;
    }
}