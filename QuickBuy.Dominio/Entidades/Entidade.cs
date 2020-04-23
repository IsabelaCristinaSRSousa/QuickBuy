using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }

        private List<string> _mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        public void LimparMensagensValidacao()
        {
            _mensagemValidacao.Clear();
        }
        public void AdicionarCritica(string mensagem)
        {
            _mensagemValidacao.Add(mensagem);
        }
        public abstract void Validade();
        protected bool EhValido
        {
            get { return !_mensagemValidacao.Any(); }
        }

    }
}
