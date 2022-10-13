using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropostoSetLinguagens.Entities
{
    internal class ComparatorIde : IComparer<LinguagemFavorita>
    {
        public  int Compare(LinguagemFavorita? x, LinguagemFavorita y)
        {
            return x.Ide.ToLower().CompareTo(y.Ide);
        }        
    }
}
