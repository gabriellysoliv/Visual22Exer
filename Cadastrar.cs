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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Form1 vol = new Form1();
            vol.ShowDialog();
        }//fim do voltar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa telefona

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa endereço

        private void button1_Click(object sender, EventArgs e)
        {
            dao Inserir = new dao();
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            //chamando modo inserir 
            MessageBox.Show(Inserir.inserir(codigo,
                nome,
                telefone,
                endereco));
            this.Close();

        }
    }
}
