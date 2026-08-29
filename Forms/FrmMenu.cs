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
    }
}
