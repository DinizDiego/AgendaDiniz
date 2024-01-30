using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDiniz
{
    class ControlUsuario
    {
        private int opcao = 0;
        DAO conectar;
        public ControlUsuario()
        {
            //Instanciando variáveis. Determinando seus valores.
            ConsultarOpcao = 0;
            conectar = new DAO(); //Conectando ao BD
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.ConsultarOpcao; }
            set { this.opcao = value; }                 
        }//Fim do get set

        public void Menu()
        {
            Console.WriteLine("\n\n\nBem vindo!!!\n\n\n" +
                              "Escolha uma das opções abaixo:\n" +
                              "1. Primeira vez aqui? Efetue o cadastro!\n" +
                              "2. Login" +
                              "3. Sair");
            ConsultarOpcao = Convert.ToInt32(ConsultarOpcao);
        }//Fim do menu

        public void Cadastrar()
        {
            Console.WriteLine("Entre com seu email: ");
            string 

        }//FIm do método cadastrar

    }//Fim do método
}//Fim do projeto
