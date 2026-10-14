namespace ProtetorDigital
{
    partial class FrmMenu
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
            label1 = new Label();
            BtnQuiz = new Button();
            BtnBiblioteca = new Button();
            BtnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = false;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.Size = new Size(957, 80);
            label1.TabIndex = 0;
            label1.Text = "Proteção Digital Aos Idosos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnQuiz
            // 
            BtnQuiz.BackColor = Color.FromArgb(0, 120, 215);
            BtnQuiz.Cursor = Cursors.Hand;
            BtnQuiz.FlatAppearance.BorderSize = 0;
            BtnQuiz.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnQuiz.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnQuiz.FlatStyle = FlatStyle.Flat;
            BtnQuiz.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuiz.ForeColor = Color.White;
            BtnQuiz.Location = new Point(288, 140);
            BtnQuiz.Name = "BtnQuiz";
            BtnQuiz.Size = new Size(380, 85);
            BtnQuiz.TabIndex = 1;
            BtnQuiz.Text = "Quiz";
            BtnQuiz.UseVisualStyleBackColor = false;
            BtnQuiz.Click += BtnQuiz_Click;
            // 
            // BtnBiblioteca
            // 
            BtnBiblioteca.BackColor = Color.FromArgb(0, 120, 215);
            BtnBiblioteca.Cursor = Cursors.Hand;
            BtnBiblioteca.FlatAppearance.BorderSize = 0;
            BtnBiblioteca.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnBiblioteca.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnBiblioteca.FlatStyle = FlatStyle.Flat;
            BtnBiblioteca.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBiblioteca.ForeColor = Color.White;
            BtnBiblioteca.Location = new Point(288, 245);
            BtnBiblioteca.Name = "BtnBiblioteca";
            BtnBiblioteca.Size = new Size(380, 85);
            BtnBiblioteca.TabIndex = 2;
            BtnBiblioteca.Text = "Biblioteca";
            BtnBiblioteca.UseVisualStyleBackColor = false;
            BtnBiblioteca.Click += BtnBiblioteca_Click;
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.FromArgb(220, 53, 69);
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(189, 45, 59);
            BtnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 38, 50);
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.White;
            BtnSair.Location = new Point(288, 365);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(380, 65);
            BtnSair.TabIndex = 3;
            BtnSair.Text = "◀ Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 505);
            Controls.Add(BtnSair);
            Controls.Add(BtnBiblioteca);
            Controls.Add(BtnQuiz);
            Controls.Add(label1);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proteção Digital Aos Idosos";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnQuiz;
        private Button BtnBiblioteca;
        private Button BtnSair;
    }
}