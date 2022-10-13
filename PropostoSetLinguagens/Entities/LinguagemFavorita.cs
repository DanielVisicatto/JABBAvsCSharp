using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropostoSetLinguagens.Entities
{
    internal class LinguagemFavorita : IComparable <LinguagemFavorita>
    {
        public string Nome { get; set; }
        public int AnoDeCriacao { get; set; }
        public string Ide { get; set; }

        public LinguagemFavorita(string nome, int anoDeCriacao, string ide)
        {
            Nome = nome;
            AnoDeCriacao = anoDeCriacao;
            Ide = ide;
        }

        public override string ToString()
        {
            return $"{{{nameof(Nome)}= {Nome}, {nameof(AnoDeCriacao)}= {AnoDeCriacao.ToString()}, {nameof(Ide)}= {Ide}}}";
        }

        

        public override bool Equals(Object obj)
        {
            if (this == obj) return true;
            if (obj == null || obj.GetType() != obj.GetType()) return false;
            LinguagemFavorita that = (LinguagemFavorita)obj;
            return Nome.Equals(that.Nome);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(LinguagemFavorita? other)
        {
            return this.Nome.CompareTo(other.Nome);
        }
    }
}
