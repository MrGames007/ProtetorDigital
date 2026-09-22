namespace p2elvio.Forms
{
    partial class FrmBiblioteca
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
            label1 = new Label();
            BtnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(163, 142);
            label1.Name = "label1";
            label1.Size = new Size(402, 36);
            label1.TabIndex = 0;
            label1.Text = "Aparece pra todo mundo";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnVoltar
            // 
            BtnVoltar.AutoSize = true;
            BtnVoltar.Location = new Point(10, 9);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(82, 25);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(BtnVoltar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBiblioteca";
            Text = "FrmBiblioteca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnVoltar;
    }
}