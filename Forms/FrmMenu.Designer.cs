namespace p2elvio
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            BtnQuiz = new Button();
            BtnSair = new Button();
            BtnVoM = new Button();
            BtnBiblioteca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 9);
            label1.Name = "label1";
            label1.Size = new Size(648, 65);
            label1.TabIndex = 0;
            label1.Text = "Proteção Digital Aos Idosos";
            label1.Click += label1_Click;
            // 
            // BtnQuiz
            // 
            BtnQuiz.AutoSize = true;
            BtnQuiz.BackColor = SystemColors.Highlight;
            BtnQuiz.Font = new Font("Lucida Sans Unicode", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnQuiz.ForeColor = SystemColors.ButtonHighlight;
            BtnQuiz.Location = new Point(265, 95);
            BtnQuiz.Margin = new Padding(3, 2, 3, 2);
            BtnQuiz.Name = "BtnQuiz";
            BtnQuiz.Size = new Size(287, 93);
            BtnQuiz.TabIndex = 1;
            BtnQuiz.Text = "Quiz";
            BtnQuiz.UseVisualStyleBackColor = false;
            BtnQuiz.Click += BtnQuiz_Click;
            // 
            // BtnSair
            // 
            BtnSair.AutoSize = true;
            BtnSair.BackColor = SystemColors.Highlight;
            BtnSair.Font = new Font("Lucida Sans Unicode", 21.75F);
            BtnSair.ForeColor = SystemColors.ButtonHighlight;
            BtnSair.Location = new Point(637, 284);
            BtnSair.Margin = new Padding(3, 2, 3, 2);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(188, 84);
            BtnSair.TabIndex = 5;
            BtnSair.Text = "◀ Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnVoM
            // 
            BtnVoM.AutoSize = true;
            BtnVoM.BackColor = SystemColors.Highlight;
            BtnVoM.Font = new Font("Lucida Sans Unicode", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVoM.ForeColor = SystemColors.ButtonHighlight;
            BtnVoM.Location = new Point(265, 205);
            BtnVoM.Margin = new Padding(3, 2, 3, 2);
            BtnVoM.Name = "BtnVoM";
            BtnVoM.Size = new Size(293, 60);
            BtnVoM.TabIndex = 6;
            BtnVoM.Text = "Verdade ou Golpe";
            BtnVoM.UseVisualStyleBackColor = false;
            BtnVoM.Click += BtnVoM_Click;
            // 
            // BtnBiblioteca
            // 
            BtnBiblioteca.AutoSize = true;
            BtnBiblioteca.BackColor = SystemColors.Highlight;
            BtnBiblioteca.Font = new Font("Lucida Sans Unicode", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBiblioteca.ForeColor = SystemColors.ButtonHighlight;
            BtnBiblioteca.Location = new Point(265, 284);
            BtnBiblioteca.Margin = new Padding(3, 2, 3, 2);
            BtnBiblioteca.Name = "BtnBiblioteca";
            BtnBiblioteca.Size = new Size(293, 75);
            BtnBiblioteca.TabIndex = 7;
            BtnBiblioteca.Text = "Biblioteca";
            BtnBiblioteca.UseVisualStyleBackColor = false;
            BtnBiblioteca.Click += BtnBiblioteca_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 379);
            Controls.Add(BtnBiblioteca);
            Controls.Add(BtnVoM);
            Controls.Add(BtnSair);
            Controls.Add(BtnQuiz);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnQuiz;
        private Button BtnSair;
        private Button BtnVoM;
        private Button BtnBiblioteca;
    }
}
