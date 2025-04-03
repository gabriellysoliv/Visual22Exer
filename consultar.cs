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
    public partial class consultar : Form
    {
        dao consul;
        public consultar()
        {
            consul = new dao();          
            InitializeComponent();
            ConfigurarDataGrid();//configura a estrutura da coluna
            NomeColunas();//Nomeia coluna
            AdicionarDados();//Visualiza dados
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim do telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim do endereço

        private void button1_Click(object sender, EventArgs e)
        {

        }//fim do botão cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botão voltar

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Codigo";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }//fim nomecolunas

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Não pode add linhas
            dataGridView1.AllowUserToDeleteRows = false;// não pode apagar linhas
            dataGridView1.AllowUserToResizeColumns = false; // Não pode reedimencionar colunas
            dataGridView1.AllowUserToResizeRows = false;// Não pode redimensionar as linhas

            dataGridView1.ColumnCount = 4;
        }

        public void AdicionarDados()
        {
            consul.PreencherVetor();//Preencher os vetores com os dados do banco
            for (int i = 0; i < consul.QuantidadeDeDados(); i++) 
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.nome[i], consul.telefone[i], consul.endereco[i]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
