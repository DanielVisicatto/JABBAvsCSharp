using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropostoSetLinguagens.Entities
{
    internal class ComparatorNomeAnoCriacaoIde : IComparer<LinguagemFavorita>
    {
        public  int Compare(LinguagemFavorita? x, LinguagemFavorita y)
        {
            int nome = x.Nome.ToLower().CompareTo(y.Nome);
            int anoDeCriacao = x.AnoDeCriacao.CompareTo(y.AnoDeCriacao);
            if (nome != 0) return nome;
            if (anoDeCriacao != 0) return anoDeCriacao;
            return x.Ide.ToLower().CompareTo(y.Ide);
        }
    }
}
