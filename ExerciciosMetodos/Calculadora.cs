using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMetodos
{
    public class Calculadora
    {
        public static void Soma( double num1, double num2)
        {
            double resultado = num1 + num2;
            Console.WriteLine("A soma de {0} + {1} = {2}", num1, num2, resultado);
        }

        public static void Subtracao(double num1, double num2)
        {
            double resultado = num1 - num2;
            Console.WriteLine("A diferença entre {0} - {1} = {2}", num1, num2, resultado);
        }

        public static void Multiplicacao(double num1, double num2)
        {
            double resultado = num1 * num2;
            Console.WriteLine("O Produto de {0} x {1} = {2}", num1, num2, resultado);
        }

        public static void Divisao(double num1, double num2)
        {
            double resultado = num1 + num2;
            Console.WriteLine("O quociente de {0} / {1} = {2}", num1, num2, resultado);
        }
    }
}
