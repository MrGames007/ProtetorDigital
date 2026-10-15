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
            BtnRetornar = new Button();
            lblNomeGolpe = new Label();
            lblFuncionamento = new Label();
            lblTexto = new Label();
            lblSinaisAlerta = new Label();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(210, 345);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(82, 22);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "Sair";
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
            // lblNomeGolpe
            // 
            lblNomeGolpe.AutoSize = true;
            lblNomeGolpe.Location = new Point(12, 76);
            lblNomeGolpe.Name = "lblNomeGolpe";
            lblNomeGolpe.Size = new Size(38, 15);
            lblNomeGolpe.TabIndex = 5;
            lblNomeGolpe.Text = "label1";
            // 
            // lblFuncionamento
            // 
            lblFuncionamento.AutoSize = true;
            lblFuncionamento.Location = new Point(12, 149);
            lblFuncionamento.Name = "lblFuncionamento";
            lblFuncionamento.Size = new Size(38, 15);
            lblFuncionamento.TabIndex = 6;
            lblFuncionamento.Text = "label1";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(12, 236);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(93, 15);
            lblTexto.TabIndex = 7;
            lblTexto.Text = "Sinais de Alerta!!";
            // 
            // lblSinaisAlerta
            // 
            lblSinaisAlerta.AutoSize = true;
            lblSinaisAlerta.Location = new Point(12, 272);
            lblSinaisAlerta.Name = "lblSinaisAlerta";
            lblSinaisAlerta.Size = new Size(38, 15);
            lblSinaisAlerta.TabIndex = 8;
            lblSinaisAlerta.Text = "label1";
            // 
            // FrmExGolpes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 380);
            Controls.Add(lblSinaisAlerta);
            Controls.Add(lblTexto);
            Controls.Add(lblFuncionamento);
            Controls.Add(lblNomeGolpe);
            Controls.Add(BtnRetornar);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmExGolpes";
            Text = "FrmExGolpes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnVoltar;
        private Button BtnAvancar;
        private Button BtnRetornar;
        private Label lblNomeGolpe;
        private Label lblFuncionamento;
        private Label lblTexto;
        private Label lblSinaisAlerta;
    }
}