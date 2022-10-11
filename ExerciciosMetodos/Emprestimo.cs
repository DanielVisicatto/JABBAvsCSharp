using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMetodos
{
    public class Emprestimo
    {
        public static int GetDuasParcelas()
        {
            return 2;
        }

        public static int GetTresParcelas()
        {
            return 3;
        }

        public static double GetTaxaDuasParcelas()
        {
            return .3;
        }

        public static double GetTaxaTresParcelas()
        {
            return .45;
        }

        public static void Calcular(double valor, int parcelas)
        {
            if(parcelas == 2)
            {
                double valorFinal = valor + valor * GetTaxaDuasParcelas();
                Console.WriteLine("Valor final do empréstimo para duas parcelas: R${0}", valorFinal);
            }
            else if(parcelas == 3)
            {
                double valorFinal = valor +valor * GetTaxaTresParcelas();
                Console.WriteLine("Valor final do empréstimo para três parcelas: R${0}", valorFinal);
            }
            else
            {
                Console.WriteLine("Quantidade de parcelas não aceitas!");
            }
        }
    }
}
