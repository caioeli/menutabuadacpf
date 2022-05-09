using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menutabuadacpf.cpf
{
    public partial class TelaCPF : Form
    {
        public TelaCPF()
        {
            InitializeComponent();
        }

        private void TelaCPF_Load(object sender, EventArgs e)
        {

        }

        private void validar_cpf()
        {
            if (string.IsNullOrWhiteSpace(textBoxcpf.Text))
            {
                MessageBox.Show("Digite o seu CPF!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxcpf.Focus();
                textBoxcpf.SelectAll();
                return;
            }

            string cpfinformado = textBoxcpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "");


            if (cpfinformado.Length != 11)
            {
                labelvalidador.Text = "Digite o seu CPF Corretamente !";
                labelvalidador.ForeColor = Color.Red;
                textBoxcpf.Focus();
                textBoxcpf.SelectAll();
                return;
            }



            string cpf = cpfinformado.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;

            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }

            int dv1 = (int)(soma % 11);


            if (dv1 < 2)
            {
                dv1 = 0;
            } else
            {
                dv1 = 11 - dv1;
            }

            if (!cpfinformado.Substring(9, 1).Equals(dv1.ToString()))
            {
                labelvalidador.Text = "Digite o seu CPF Corretamente !";
                labelvalidador.ForeColor = Color.Red;
                return;

            }

            cpf = cpf + dv1.ToString();
            valorRef = 11;
            soma = 0;

            for (int i = 0; i <= 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }

            int dv2 = (int)(soma % 11);

            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }

            if (!cpfinformado.Substring(10, 1).Equals(dv2.ToString()))
            {
                labelvalidador.Text = "Informe um CPF válido";
                labelvalidador.ForeColor = Color.Red;
                return;
            }

            labelvalidador.Text = "CPF Válido";
            labelvalidador.ForeColor = Color.Green;

}


        private void button1_Click(object sender, EventArgs e)
        {
            validar_cpf();
        }
    }
}
