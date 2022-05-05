using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menutabuadacpf.View.tabusada
{
    public partial class TelaTabuada : Form
    {
        public TelaTabuada()
        {
            InitializeComponent();
        }

        private void calculartabuada()
        {
            int numero = 0;

            numero =Convert.ToInt32(textBoxnum.Text);

            for (int i = 0; i < 10; i++)
            {
                listBoxresult.Items.Add(numero + " x " + i + "=" + i * numero);
            }



        }

        private void LimparTela()
        {
            listBoxresult.Items.Clear();
            textBoxnum.Clear();
            textBoxnum.Focus();
        }

        private void textBoxnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
           {
                LimparTela();
               calculartabuada();
           }

        }

        private void listBoxresult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
