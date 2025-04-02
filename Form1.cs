using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace aplicativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dao conexao = new dao();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }//fim do form load

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            excluir ex = new excluir();
            ex.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void atualizar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consultar con = new consultar();
            con.ShowDialog();
        }

        private void atualizar_Click_1(object sender, EventArgs e)
        {
            Atualizar at = new Atualizar();
            at.ShowDialog();
        }
        private void voltar_Click(object sender, EventArgs e)
        {
            Form1 vol = new Form1();
            vol.ShowDialog();
        }//fim do voltar

    }//fim da classe
}//fim do projeto
