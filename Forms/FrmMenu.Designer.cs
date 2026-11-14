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
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(0, 19);
            label1.Name = "label1";
            label1.Size = new Size(837, 60);
            label1.TabIndex = 0;
            label1.Text = "Proteção Digital Aos Idosos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnQuiz
            // 
            BtnQuiz.BackColor = Color.FromArgb(0, 120, 215);
            BtnQuiz.Cursor = Cursors.Hand;
            BtnQuiz.FlatAppearance.BorderSize = 0;
            BtnQuiz.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnQuiz.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnQuiz.FlatStyle = FlatStyle.Flat;
            BtnQuiz.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuiz.ForeColor = Color.White;
            BtnQuiz.Location = new Point(252, 105);
            BtnQuiz.Margin = new Padding(3, 2, 3, 2);
            BtnQuiz.Name = "BtnQuiz";
            BtnQuiz.Size = new Size(332, 64);
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
            BtnBiblioteca.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnBiblioteca.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnBiblioteca.FlatStyle = FlatStyle.Flat;
            BtnBiblioteca.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBiblioteca.ForeColor = Color.White;
            BtnBiblioteca.Location = new Point(252, 184);
            BtnBiblioteca.Margin = new Padding(3, 2, 3, 2);
            BtnBiblioteca.Name = "BtnBiblioteca";
            BtnBiblioteca.Size = new Size(332, 64);
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
            BtnSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 38, 50);
            BtnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(189, 45, 59);
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.White;
            BtnSair.Location = new Point(252, 274);
            BtnSair.Margin = new Padding(3, 2, 3, 2);
            BtnSair.Name = "BtnSair";
            BtnSair.RightToLeft = RightToLeft.Yes;
            BtnSair.Size = new Size(332, 49);
            BtnSair.TabIndex = 3;
            BtnSair.Text = "Fechar";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(837, 379);
            Controls.Add(BtnSair);
            Controls.Add(BtnBiblioteca);
            Controls.Add(BtnQuiz);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
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