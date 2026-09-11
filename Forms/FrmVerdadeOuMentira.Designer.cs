namespace p2elvio.Forms
{
    partial class FrmVerdadeOuMentira
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
            BtnVoltar = new Button();
            lblPergunta = new Label();
            BtnVerdade = new Button();
            BtnMentira = new Button();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(12, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(94, 29);
            BtnVoltar.TabIndex = 0;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Location = new Point(12, 57);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(0, 20);
            lblPergunta.TabIndex = 1;
            // 
            // BtnVerdade
            // 
            BtnVerdade.Location = new Point(129, 290);
            BtnVerdade.Name = "BtnVerdade";
            BtnVerdade.Size = new Size(194, 111);
            BtnVerdade.TabIndex = 2;
            BtnVerdade.Text = "Verdade";
            BtnVerdade.UseVisualStyleBackColor = true;
            BtnVerdade.Click += BtnVerdade_Click;
            // 
            // BtnMentira
            // 
            BtnMentira.Location = new Point(478, 290);
            BtnMentira.Name = "BtnMentira";
            BtnMentira.Size = new Size(194, 111);
            BtnMentira.TabIndex = 3;
            BtnMentira.Text = "Mentira";
            BtnMentira.UseVisualStyleBackColor = true;
            BtnMentira.Click += BtnMentira_Click;
            // 
            // FrmVerdadeOuMentira
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnMentira);
            Controls.Add(BtnVerdade);
            Controls.Add(lblPergunta);
            Controls.Add(BtnVoltar);
            Name = "FrmVerdadeOuMentira";
            Text = "FrmVerdadeOuMentira";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVoltar;
        private Label lblPergunta;
        private Button BtnVerdade;
        private Button BtnMentira;
    }
}