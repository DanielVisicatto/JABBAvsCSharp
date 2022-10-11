using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMetodos
{
    public class Mensagem
    {
        public static void ObterMensagem(int hora)
        {
            switch (hora)
            {
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    MensagemBomDia();
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    MensagemBoaTarde();
                    break;
                case 18:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                case 0:
                case 1:
                    case 2:
                    case 3:
                case 4:
                    MensagemBoaNoite();
                    break;
                    default: throw new ArgumentOutOfRangeException("Hora inválida!");
            }
        }

        public static void MensagemBomDia()
        {
            Console.WriteLine("Bom Dia!");
        }

        public static void MensagemBoaTarde()
        {
            Console.WriteLine("Boa Tarde!");
        }

        public static void MensagemBoaNoite()
        {
            Console.WriteLine("Boa Noite!");
        }
    }
}
