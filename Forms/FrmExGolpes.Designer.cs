namespace p2elvio.Forms
{
    partial class FrmExGolpes
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
            BtnAvancar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(714, 213);
            label1.TabIndex = 0;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(26, 29);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(94, 29);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnAvancar
            // 
            BtnAvancar.AutoSize = true;
            BtnAvancar.Location = new Point(345, 353);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(117, 30);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Próximo golpe";
            BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // FrmExGolpes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Controls.Add(label1);
            Name = "FrmExGolpes";
            Text = "FrmExGolpes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnVoltar;
        private Button BtnAvancar;
    }
}