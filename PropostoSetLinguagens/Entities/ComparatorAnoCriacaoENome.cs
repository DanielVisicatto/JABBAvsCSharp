using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropostoSetLinguagens.Entities
{
    internal class ComparatorAnoCriacaoENome : IComparer<LinguagemFavorita>
    {
        public  int Compare(LinguagemFavorita lf1, LinguagemFavorita lf2)
        {
            int anoDeCriacao = lf1.AnoDeCriacao.CompareTo(lf2.AnoDeCriacao);
            if(anoDeCriacao != 0)
                return anoDeCriacao;
            return lf1.Nome.CompareTo(lf2.Nome);
        }
    }
}
