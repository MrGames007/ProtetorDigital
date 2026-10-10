namespace ProtetorDigital.Forms
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
            BtnVoltar = new Button();
            BtnAvancar = new Button();
            groupBox1 = new GroupBox();
            lblSinaisAlerta = new Label();
            lblFuncionamento = new Label();
            lbl = new Label();
            BtnRetornar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(210, 345);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(82, 22);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnAvancar
            // 
            BtnAvancar.AutoSize = true;
            BtnAvancar.Location = new Point(446, 345);
            BtnAvancar.Margin = new Padding(3, 2, 3, 2);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(102, 25);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Próximo golpe";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSinaisAlerta);
            groupBox1.Controls.Add(lblFuncionamento);
            groupBox1.Controls.Add(lbl);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(718, 290);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblSinaisAlerta
            // 
            lblSinaisAlerta.AutoSize = true;
            lblSinaisAlerta.Location = new Point(11, 138);
            lblSinaisAlerta.Name = "lblSinaisAlerta";
            lblSinaisAlerta.Size = new Size(0, 15);
            lblSinaisAlerta.TabIndex = 2;
            // 
            // lblFuncionamento
            // 
            lblFuncionamento.AutoSize = true;
            lblFuncionamento.Location = new Point(11, 67);
            lblFuncionamento.Name = "lblFuncionamento";
            lblFuncionamento.Size = new Size(0, 15);
            lblFuncionamento.TabIndex = 1;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(11, 19);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 15);
            lbl.TabIndex = 0;
            // 
            // BtnRetornar
            // 
            BtnRetornar.Location = new Point(12, 12);
            BtnRetornar.Name = "BtnRetornar";
            BtnRetornar.Size = new Size(75, 23);
            BtnRetornar.TabIndex = 4;
            BtnRetornar.Text = "Voltar";
            BtnRetornar.UseVisualStyleBackColor = true;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // FrmExGolpes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 380);
            Controls.Add(BtnRetornar);
            Controls.Add(groupBox1);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmExGolpes";
            Text = "FrmExGolpes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnVoltar;
        private Button BtnAvancar;
        private GroupBox groupBox1;
        private Label lblFuncionamento;
        private Label lbl;
        private Label lblSinaisAlerta;
        private Button BtnRetornar;
    }
}