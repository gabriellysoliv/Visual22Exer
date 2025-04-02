using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativo
{
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa endereço

        private void button1_Click(object sender, EventArgs e)
        {

        }//fim fo botão atualizar
        private void voltar_Click(object sender, EventArgs e)
        {
            Form1 vol = new Form1();
            vol.ShowDialog();
        }//fim do voltar

    }
}
