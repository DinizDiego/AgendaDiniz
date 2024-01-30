using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDiniz
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlUsuario usuario = new ControlUsuario();//Conectando a control e a model
            usuario.operacao();                                                          
            Console.ReadLine();//Manter o prompt aberto
        }//Fim do método
    }//Fim da classe
}//Fim do Projeto

