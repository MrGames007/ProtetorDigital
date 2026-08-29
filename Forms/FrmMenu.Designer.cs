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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(490, 81);
            label1.TabIndex = 0;
            label1.Text = "Proteção Digital";
            // 
            // BtnQuiz
            // 
            BtnQuiz.Location = new Point(288, 102);
            BtnQuiz.Name = "BtnQuiz";
            BtnQuiz.Size = new Size(188, 299);
            BtnQuiz.TabIndex = 1;
            BtnQuiz.Text = "Quiz";
            BtnQuiz.UseVisualStyleBackColor = true;
            BtnQuiz.Click += BtnQuiz_Click;
            // 
            // BtnSair
            // 
            BtnSair.AutoSize = true;
            BtnSair.Location = new Point(534, 310);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(254, 128);
            BtnSair.TabIndex = 5;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
