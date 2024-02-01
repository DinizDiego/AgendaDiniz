using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AgendaDiniz
{
    class DAO
    {
        public MySqlConnection conexao;//Conectar ao banco de dados
        public string[] login;
        public string[] senha;
        public int i;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=agendaDiniz;Uid=root;Password=");
            try
            {
                conexao.Open();//Abre a conexão com o BD
                Console.WriteLine("Conectado com sucesso!!");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                conexao.Close();//Fechandop a conexão com o BD
            }//Fim tryCatch

            i = 0;
        }//Fim do método

        //Método inserir

        public void inserir(string login, string senha)
        {

        }//Fim do método

    }//Fim da classe
}//Fim do projeto
