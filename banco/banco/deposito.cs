using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class deposito : Form
    {
        double saldoD;
        public deposito(double valorSaldo)
        {
            InitializeComponent();
            saldoD = valorSaldo;

        }

        private void deposito_Load(object sender, EventArgs e)
        {

        }

        private void bntDeposito_Click(object sender, EventArgs e)
        {
            double valorD = Convert.ToDouble(tbxvalorD.Text);
            saldoD = saldoD + valorD;
        }
    }
}
