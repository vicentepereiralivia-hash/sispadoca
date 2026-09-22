namespace SisPadoca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Local = DateTime.Now;
            TssDataHora.Text = Local.ToString();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes CadClientes = new FrmClientes();
            CadClientes.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciação de objetos
            FrmProduto Cadproduto = new FrmProduto();
            Cadproduto.StartPosition = FormStartPosition.CenterScreen;
            //Cadproduto.WindowState = FormWindowState.Maximized;
            Cadproduto.ShowDialog();
        }
    }
}
