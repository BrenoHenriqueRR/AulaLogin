using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbgener_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninserir(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nome: " + txbnome.Text +
                "Profissâo: " + txbjob.Text +
                "Email: " + txbemail.Text +
                "CPF: " + mtbCPF.Text +
                "Gênero: " + cmbgener.Text,
                "CADASTRO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                 );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbnome.Clear();
            txbjob.Clear();
            txbemail.Clear();
            mtbCPF.Clear();
            cmbgener.ResetText();
        }
    }
}

