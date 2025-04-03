using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aplicativo
{
    public partial class Atualizar : Form
    {
        dao atu;
        public Atualizar()
        {
            atu = new dao();
            InitializeComponent();
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
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
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "telefone", telefone);
            atu.Atualizar(codigo, "endereco", endereco);
            MessageBox.Show("Atualizado com sucesso!");
            this.Close();


        }//fim fo botão atualizar
        private void voltar_Click(object sender, EventArgs e)
        {
            Form1 vol = new Form1();
            vol.ShowDialog();
        }//fim do voltar

        private void buscar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox2.Text = "Informe o codigo";
                textBox3.Text = "Informe o codigo";
                textBox4.Text = "Informe o codigo";
            }
            else
            {


                int codigo = Convert.ToInt32(textBox1.Text);

                textBox2.Text = atu.retornarNome(codigo);//preenchendo o campo nome
                textBox3.Text = atu.retornarTelefone(codigo);//preenchendo o campo nome
                textBox4.Text = atu.retornarEndereco(codigo);//preenchendo o campo nome

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
            }

        }//fim do botão buscar
    }
}
