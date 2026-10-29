using ProtetorDigital.Forms;

namespace ProtetorDigital
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnQuiz_Click(object sender, EventArgs e)
        {
            using var janela = new FrmQuiz();
            janela.ShowDialog(this);
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBiblioteca_Click(object sender, EventArgs e)
        {
            using var janela = new FrmBiblioteca();
            janela.ShowDialog(this);
        }

    }
}
