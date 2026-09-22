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
            BtnVoltar.BackColor = SystemColors.Highlight;
            BtnVoltar.Font = new Font("Lucida Sans Unicode", 21.75F);
            BtnVoltar.ForeColor = SystemColors.ButtonHighlight;
            BtnVoltar.Location = new Point(10, 9);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(166, 49);
            BtnVoltar.TabIndex = 0;
            BtnVoltar.Text = "◀ Voltar";
            BtnVoltar.UseVisualStyleBackColor = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Location = new Point(10, 43);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(0, 15);
            lblPergunta.TabIndex = 1;
            // 
            // BtnVerdade
            // 
            BtnVerdade.BackColor = Color.Lime;
            BtnVerdade.Font = new Font("Lucida Sans Unicode", 21.75F);
            BtnVerdade.Location = new Point(106, 116);
            BtnVerdade.Margin = new Padding(3, 2, 3, 2);
            BtnVerdade.Name = "BtnVerdade";
            BtnVerdade.Size = new Size(170, 83);
            BtnVerdade.TabIndex = 2;
            BtnVerdade.Text = "Verdade";
            BtnVerdade.UseVisualStyleBackColor = false;
            BtnVerdade.Click += BtnVerdade_Click;
            // 
            // BtnMentira
            // 
            BtnMentira.BackColor = Color.Red;
            BtnMentira.Font = new Font("Lucida Sans Unicode", 21.75F);
            BtnMentira.Location = new Point(401, 116);
            BtnMentira.Margin = new Padding(3, 2, 3, 2);
            BtnMentira.Name = "BtnMentira";
            BtnMentira.Size = new Size(170, 83);
            BtnMentira.TabIndex = 3;
            BtnMentira.Text = "Mentira";
            BtnMentira.UseVisualStyleBackColor = false;
            BtnMentira.Click += BtnMentira_Click;
            // 
            // FrmVerdadeOuMentira
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnMentira);
            Controls.Add(BtnVerdade);
            Controls.Add(lblPergunta);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
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