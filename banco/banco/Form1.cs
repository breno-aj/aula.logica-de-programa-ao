namespace banco
{
    public partial class Form1 : Form
    {
        double valorSaldo = 100; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            saldo telaSaldo = new saldo(valorSaldo);
            telaSaldo.ShowDialog();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            deposito telaDeposito = new deposito(valorSaldo);
            telaDeposito.ShowDialog();
        }

        private void bntSaque_Click(object sender, EventArgs e)
        {
            saque telasaque = new saque();
            telasaque.ShowDialog();
        }
    }
}
