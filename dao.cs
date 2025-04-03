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
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;


        public dao()

        {

            conexao = new MySqlConnection("server=localhost;Database=Tintcsharp;Uid=root;password=");

            try

            {

                conexao.Open();//tentando conectar com o banco 

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
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;
                contador++; //contar dados que seram preenchidos
            }

            leitura.Close();
        }// fim do prencher

        public int ConsultarPorCodigo(int cod)
        {

            PreencherVetor();
            i = 0;
            while (i < QuantidadeDeDados())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++;
            }//fim do while

            return -1;
        }
 
    


        public string retornarNome(int cod)
            {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return nome[posicao];
            }
            return "Codigo digitaado não é valido";
            }


        public string retornarTelefone(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return telefone[posicao];
            }
            return "Codigo digitaado não é valido";
            }


        public string retornarEndereco(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return endereco[posicao];
            }
            return "Codigo digitaado não é valido";
            }


        public int QuantidadeDeDados()
        {
            return contador;
        }//fim do método

        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update pessoa set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand (query, conexao);
            string resultado = sql.ExecuteNonQuery() +"Atualizado!";
            return resultado;
        }

        public string Excluir(int codigo)
        {
            string query = $"delete from pessoa where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Deletado!";
            return resultado;
        }



    }//fim da classe

}//fim do projeto
