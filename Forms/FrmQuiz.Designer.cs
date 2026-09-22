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
            button1 = new Button();
            SuspendLayout();
            // 
            // lblPergunta
            // 
             lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPergunta.ForeColor = Color.FromArgb(33, 37, 41);
            lblPergunta.Location = new Point(15, 75);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(0, 25);
            lblPergunta.TabIndex = 0;
            // 
            // RBtnAlt1
            // 
            RBtnAlt1.AutoSize = true;
            RBtnAlt1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt1.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt1.Location = new Point(15, 130);
            RBtnAlt1.Margin = new Padding(3, 4, 3, 4);
            RBtnAlt1.Name = "RBtnAlt1";
            RBtnAlt1.Size = new Size(20, 24);
            RBtnAlt1.TabIndex = 1;
            RBtnAlt1.TabStop = true;
            RBtnAlt1.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt2
            // 
            RBtnAlt2.AutoSize = true;
            RBtnAlt2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt2.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt2.Location = new Point(15, 164);
            RBtnAlt2.Margin = new Padding(3, 4, 3, 4);
            RBtnAlt2.Name = "RBtnAlt2";
            RBtnAlt2.Size = new Size(20, 24);
            RBtnAlt2.TabIndex = 2;
            RBtnAlt2.TabStop = true;
            RBtnAlt2.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt3
            // 
            RBtnAlt3.AutoSize = true;
            RBtnAlt3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt3.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt3.Location = new Point(15, 198);
            RBtnAlt3.Margin = new Padding(3, 4, 3, 4);
            RBtnAlt3.Name = "RBtnAlt3";
            RBtnAlt3.Size = new Size(20, 24);
            RBtnAlt3.TabIndex = 3;
            RBtnAlt3.TabStop = true;
            RBtnAlt3.UseVisualStyleBackColor = true;
            // 
            // RBtnAlt4
            // 
            RBtnAlt4.AutoSize = true;
            RBtnAlt4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBtnAlt4.ForeColor = Color.FromArgb(50, 50, 50);
            RBtnAlt4.Location = new Point(15, 232);
            RBtnAlt4.Margin = new Padding(3, 4, 3, 4);
            RBtnAlt4.Name = "RBtnAlt4";
            RBtnAlt4.Size = new Size(20, 24);
            RBtnAlt4.TabIndex = 4;
            RBtnAlt4.TabStop = true;
            RBtnAlt4.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.FromArgb(0, 120, 215);
            BtnVoltar.Cursor = Cursors.Hand;
            BtnVoltar.FlatAppearance.BorderSize = 0;
            BtnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 99, 177);
            BtnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 145);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVoltar.ForeColor = Color.White;
            BtnVoltar.Location = new Point(15, 15);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(90, 32);
            BtnVoltar.TabIndex = 5;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.BackColor = Color.FromArgb(40, 167, 69);
            BtnConfirmar.Cursor = Cursors.Hand;
            BtnConfirmar.FlatAppearance.BorderSize = 0;
            BtnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            BtnConfirmar.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 105, 43);
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmar.ForeColor = Color.White;
            BtnConfirmar.Location = new Point(521, 15);
            BtnConfirmar.Margin = new Padding(3, 2, 3, 2);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(150, 32);
            BtnConfirmar.TabIndex = 6;
            BtnConfirmar.Text = "Confirmar ✓";
            BtnConfirmar.UseVisualStyleBackColor = false;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnVoltar);
            Controls.Add(RBtnAlt4);
            Controls.Add(RBtnAlt3);
            Controls.Add(RBtnAlt2);
            Controls.Add(RBtnAlt1);
            Controls.Add(lblPergunta);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button1;
    }
}