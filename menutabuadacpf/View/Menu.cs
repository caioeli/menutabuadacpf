using menutabuadacpf.cpf;
using menutabuadacpf.View.tabusada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menutabuadacpf.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaTabuada tabuada = new TelaTabuada();

            tabuada.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCPF cpf = new TelaCPF();

            cpf.ShowDialog();
        }
    }
}
