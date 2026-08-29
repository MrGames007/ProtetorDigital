namespace p2elvio.Forms
{
    partial class FrmQuiz
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
            lblPergunta = new Label();
            RBtnAlt1 = new RadioButton();
            RBtnAlt2 = new RadioButton();
            RBtnAlt3 = new RadioButton();
            RBtnAlt4 = new RadioButton();
            BtnVoltar = new Button();
            BtnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(12, 56);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(0, 31);
            lblPergunta.TabIndex = 0;
            // 
            // RBtnAlt1
            // 
            RBtnAlt1.AutoSize = true;
            RBtnAlt1.Font = new Font("Segoe UI", 16.2F);
            RBtnAlt1.Location = new Point(12, 255);
            RBtnAlt1.Name = "RBtnAlt1";
            RBtnAlt1.Size = new Size(17, 16);
            RBtnAlt1.TabIndex = 1;
            RBtnAlt1.TabStop = true;
            RBtnAlt1.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt2
            // 
            RBtnAlt2.AutoSize = true;
            RBtnAlt2.Font = new Font("Segoe UI", 16.2F);
            RBtnAlt2.Location = new Point(12, 294);
            RBtnAlt2.Name = "RBtnAlt2";
            RBtnAlt2.Size = new Size(17, 16);
            RBtnAlt2.TabIndex = 2;
            RBtnAlt2.TabStop = true;
            RBtnAlt2.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt3
            // 
            RBtnAlt3.AutoSize = true;
            RBtnAlt3.Font = new Font("Segoe UI", 16.2F);
            RBtnAlt3.Location = new Point(12, 337);
            RBtnAlt3.Name = "RBtnAlt3";
            RBtnAlt3.Size = new Size(17, 16);
            RBtnAlt3.TabIndex = 3;
            RBtnAlt3.TabStop = true;
            RBtnAlt3.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt4
            // 
            RBtnAlt4.AutoSize = true;
            RBtnAlt4.Font = new Font("Segoe UI", 16.2F);
            RBtnAlt4.Location = new Point(12, 388);
            RBtnAlt4.Name = "RBtnAlt4";
            RBtnAlt4.Size = new Size(17, 16);
            RBtnAlt4.TabIndex = 4;
            RBtnAlt4.TabStop = true;
            RBtnAlt4.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(12, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(94, 29);
            BtnVoltar.TabIndex = 5;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(694, 12);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(94, 29);
            BtnConfirmar.TabIndex = 6;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnVoltar);
            Controls.Add(RBtnAlt4);
            Controls.Add(RBtnAlt3);
            Controls.Add(RBtnAlt2);
            Controls.Add(RBtnAlt1);
            Controls.Add(lblPergunta);
            Name = "FrmQuiz";
            Text = "FrmQuiz";
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
    }
}