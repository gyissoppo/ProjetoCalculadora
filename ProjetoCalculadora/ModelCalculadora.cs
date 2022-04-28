using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    class ModelCalculadora
    {
        public ModelCalculadora()
        {
        }//fim do construtor
            public double Adicao(double num1, double num2)
            {
                return num1 + num2;
            }//fim adição

            public double Subtracao(double num1, double num2)
            {
                return num1 - num2;
            }//fim subtracao

            public double Multiplicacao(double num1, double num2)
            {
                return num1 * num2;
            }//fim multiplicacao

            public double Divisao(double num1, double num2)
            {
                if(num2 <= 0)
                {
                    return -1;
                }
                else
                {
                    return num1 / num2;
                }
            }//fim divisao

            public double Potencia(double bas, double expoente)
            {
                if(expoente == 1)
            {
                return bas;
            }else if(expoente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }
            }//fim expoente

            public double Radicaliza(double num1)
            {
            if (num1 <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(num1);
            }
            }//fim radicaliza
        
    }//fim da classe
}//fim do projeto
