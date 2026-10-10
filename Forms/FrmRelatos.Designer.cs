namespace ProtetorDigital.Forms
{
    partial class FrmRelatos
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
            lblLicoesAprendidas = new Label();
            lblRelato = new Label();
            lblVitima = new Label();
            lblFonte = new Label();
            lblTitulo = new Label();
            BtnRetornar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(378, 564);
            BtnVoltar.Margin = new Padding(3, 2, 3, 2);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(82, 22);
            BtnVoltar.TabIndex = 0;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnAvancar
            // 
            BtnAvancar.AutoSize = true;
            BtnAvancar.Location = new Point(664, 564);
            BtnAvancar.Margin = new Padding(3, 2, 3, 2);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(63, 25);
            BtnAvancar.TabIndex = 2;
            BtnAvancar.Text = "Avancar";
            BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblLicoesAprendidas);
            groupBox1.Controls.Add(lblRelato);
            groupBox1.Controls.Add(lblVitima);
            groupBox1.Controls.Add(lblFonte);
            groupBox1.Controls.Add(lblTitulo);
            groupBox1.Location = new Point(10, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 510);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblLicoesAprendidas
            // 
            lblLicoesAprendidas.AutoSize = true;
            lblLicoesAprendidas.Location = new Point(6, 394);
            lblLicoesAprendidas.Name = "lblLicoesAprendidas";
            lblLicoesAprendidas.Size = new Size(0, 15);
            lblLicoesAprendidas.TabIndex = 4;
            // 
            // lblRelato
            // 
            lblRelato.AutoSize = true;
            lblRelato.Location = new Point(0, 305);
            lblRelato.Name = "lblRelato";
            lblRelato.Size = new Size(0, 15);
            lblRelato.TabIndex = 3;
            // 
            // lblVitima
            // 
            lblVitima.AutoSize = true;
            lblVitima.Location = new Point(6, 193);
            lblVitima.Name = "lblVitima";
            lblVitima.Size = new Size(0, 15);
            lblVitima.TabIndex = 2;
            // 
            // lblFonte
            // 
            lblFonte.AutoSize = true;
            lblFonte.Location = new Point(6, 109);
            lblFonte.Name = "lblFonte";
            lblFonte.Size = new Size(0, 15);
            lblFonte.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(6, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 15);
            lblTitulo.TabIndex = 0;
            // 
            // BtnRetornar
            // 
            BtnRetornar.Location = new Point(10, 12);
            BtnRetornar.Name = "BtnRetornar";
            BtnRetornar.Size = new Size(75, 23);
            BtnRetornar.TabIndex = 4;
            BtnRetornar.Text = "Voltar";
            BtnRetornar.UseVisualStyleBackColor = true;
            BtnRetornar.Click += BtnRetornar_Click;
            // 
            // FrmRelatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 600);
            Controls.Add(BtnRetornar);
            Controls.Add(groupBox1);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRelatos";
            Text = "FrmRelatos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVoltar;
        private Button BtnAvancar;
        private GroupBox groupBox1;
        private Label lblVitima;
        private Label lblFonte;
        private Label lblTitulo;
        private Label lblLicoesAprendidas;
        private Label lblRelato;
        private Button BtnRetornar;
    }
}