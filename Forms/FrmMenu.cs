using ProtetorDigital.Forms;

namespace ProtetorDigital
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            MinimumSize = new Size(800, 600);
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;

            var btnCreditos = new Button
            {
                Name = "BtnCreditos",
                Text = "Créditos",
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                BackColor = Color.FromArgb(15, 124, 138),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 16, FontStyle.Bold)
            };
            btnCreditos.FlatAppearance.BorderSize = 0;
            btnCreditos.Click += (_, _) =>
            {
                using var creditos = new FrmCreditos();
                creditos.ShowDialog(this);
            };

            Controls.Clear();
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                Padding = new Padding(80, 28, 80, 28)
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 22));
            for (var i = 1; i < 5; i++) layout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5f));
            label1.Dock = DockStyle.Fill;
            label1.Margin = new Padding(8);
            BtnQuiz.Dock = BtnBiblioteca.Dock = BtnSair.Dock = DockStyle.Fill;
            BtnQuiz.Margin = BtnBiblioteca.Margin = BtnSair.Margin = new Padding(8);
            layout.Controls.Add(label1, 0, 0);
            layout.Controls.Add(BtnQuiz, 0, 1);
            layout.Controls.Add(BtnBiblioteca, 0, 2);
            layout.Controls.Add(btnCreditos, 0, 3);
            layout.Controls.Add(BtnSair, 0, 4);
            Controls.Add(layout);
            ProtetorDigital.Services.Responsivo.Registrar(this, new Size(1000, 700));
        }

        private void BtnQuiz_Click(object sender, EventArgs e)
        {
            FrmQuiz segundaJanela = new FrmQuiz(this);
            segundaJanela.Show();
            this.Hide();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBiblioteca_Click(object sender, EventArgs e)
        {
            FrmBiblioteca quartaJanela = new FrmBiblioteca(this);
            quartaJanela.Show();
            this.Hide();
        }

    }
}
