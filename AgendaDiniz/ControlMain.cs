using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDiniz
{
    class ControlMain
    {
        ControlUsuario usuario;
        public ControlMain()
        {
            usuario = new ControlUsuario();
        }//Fim do método

        public void operacao()
        {
            do
            {
                usuario.Menu();//Mostrar as opções de cadastro ou login para o usuário
                switch (usuario.ConsultarOpcao)
                {
                    case 1:



                }//Fim do escolha caso
            } while


        }//Fim do método


    }//Fim da classe
}//Fim do projeto
