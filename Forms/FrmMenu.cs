using p2elvio.Forms;

namespace p2elvio
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
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

        private void BtnVoM_Click(object sender, EventArgs e)
        {
            FrmVerdadeOuMentira terceiraJanela = new FrmVerdadeOuMentira(this);
            terceiraJanela.Show();
            this.Hide();
        }

        private void BtnBiblioteca_Click(object sender, EventArgs e)
        {
            FrmBiblioteca quartaJanela = new FrmBiblioteca(this);
            quartaJanela.Show();
            this.Hide();
        }
    }
}
