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
    public partial class saldo : Form
    {
        public saldo(double valorSaldo)
        {
            InitializeComponent();
            lblValor.Text = valorSaldo.ToString();
        }

        private void saldo_Load(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }
    }
}
