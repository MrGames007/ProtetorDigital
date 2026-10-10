namespace ProtetorDigital.Forms
{
    partial class FrmDicas
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
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            groupBox1 = new GroupBox();
            lblPassos = new Label();
            lblDescricao = new Label();
            lblTítulo = new Label();
            BtnRetornar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(438, 383);
            BtnAvancar.Margin = new Padding(3, 2, 3, 2);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(82, 22);
            BtnAvancar.TabIndex = 0;
            BtnAvancar.Text = "Avançar";
            BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(270, 383);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(82, 22);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPassos);
            groupBox1.Controls.Add(lblDescricao);
            groupBox1.Controls.Add(lblTítulo);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 328);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // lblPassos
            // 
            lblPassos.AutoSize = true;
            lblPassos.Location = new Point(14, 183);
            lblPassos.Name = "lblPassos";
            lblPassos.Size = new Size(0, 15);
            lblPassos.TabIndex = 2;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 88);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(0, 15);
            lblDescricao.TabIndex = 1;
            // 
            // lblTítulo
            // 
            lblTítulo.AutoSize = true;
            lblTítulo.Location = new Point(12, 21);
            lblTítulo.Name = "lblTítulo";
            lblTítulo.Size = new Size(0, 15);
            lblTítulo.TabIndex = 0;
            // 
            // BtnRetornar
            // 
            BtnRetornar.Location = new Point(12, 12);
            BtnRetornar.Name = "BtnRetornar";
            BtnRetornar.Size = new Size(75, 23);
            BtnRetornar.TabIndex = 3;
            BtnRetornar.Text = "Voltar";
            BtnRetornar.UseVisualStyleBackColor = true;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // FrmDicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 425);
            Controls.Add(BtnRetornar);
            Controls.Add(groupBox1);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAvancar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDicas";
            Text = "FrmDicas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAvancar;
        private Button BtnVoltar;
        private GroupBox groupBox1;
        private Label lblPassos;
        private Label lblDescricao;
        private Label lblTítulo;
        private Button BtnRetornar;
    }
}