using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace aplicativo { 


class dao

    {

        public MySqlConnection conexao;
        public int[] codigo;
        public string[]nome;
        public string[] telefone;
        public string[]endereco;
        public int i ;


        public dao()

        {

            conexao = new MySqlConnection("server=localhost;Database=Tintcsharp;Uid=root;password=");

            try

            {

                conexao.Open();//tentando conectar com o banco 

                MessageBox.Show("Conectado");

            }
            catch (Exception erro)

            {
                MessageBox.Show("Algo deu errado!\n\n\n" + erro);
            }

        }

    public string inserir(int codigo, string nome, string telefone, string endereco)

        {
            string inserir = $"Insert into pessoa(codigo,nome,telefone,endereco) values('{codigo}', '{nome}', '{telefone}', '{endereco}')";
            MySqlCommand sqlCommand = new MySqlCommand(inserir, conexao);
            string resultado = sqlCommand.ExecuteNonQuery() + "Executado!";
            return resultado;


        }//fim do metodo inserir

        public void PreencherVetor()
        {
            string query = "select * from pessoa";
            // Instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            // prepara comando para o banco

            MySqlCommand sql = new MySqlCommand(query, conexao);
            //chamar leitor do banco de dados
            MySqlDataReader leitura = sql.ExecuteReader();
            i = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;
            }

            leitura.Close();
        }// fim do prencher




    }//fim da classe

}//fim do projeto
