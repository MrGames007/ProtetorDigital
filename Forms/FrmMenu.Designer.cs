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
            BtnBiblioteca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 12);
            label1.Name = "label1";
            label1.Size = new Size(811, 81);
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
            BtnQuiz.Location = new Point(303, 127);
            BtnQuiz.Name = "BtnQuiz";
            BtnQuiz.Size = new Size(328, 124);
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
            BtnSair.Location = new Point(728, 379);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(215, 112);
            BtnSair.TabIndex = 5;
            BtnSair.Text = "◀ Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnBiblioteca
            // 
            BtnBiblioteca.AutoSize = true;
            BtnBiblioteca.BackColor = SystemColors.Highlight;
            BtnBiblioteca.Font = new Font("Lucida Sans Unicode", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBiblioteca.ForeColor = SystemColors.ButtonHighlight;
            BtnBiblioteca.Location = new Point(303, 379);
            BtnBiblioteca.Name = "BtnBiblioteca";
            BtnBiblioteca.Size = new Size(335, 100);
            BtnBiblioteca.TabIndex = 7;
            BtnBiblioteca.Text = "Biblioteca";
            BtnBiblioteca.UseVisualStyleBackColor = false;
            BtnBiblioteca.Click += BtnBiblioteca_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 505);
            Controls.Add(BtnBiblioteca);
            Controls.Add(BtnSair);
            Controls.Add(BtnQuiz);
            Controls.Add(label1);
            Name = "FrmMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnQuiz;
        private Button BtnSair;
        private Button BtnBiblioteca;
    }
}
