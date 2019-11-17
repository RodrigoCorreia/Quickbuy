using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
	public abstract class Entidade
	{
	
		public List<string> _mensagensValidacao { get; set; }
		private List<string> MensagemValidacao
		{
				get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
		}

		protected void AdicionarMensagemValidacao(string pMensagem)
		{
			MensagemValidacao.Add(pMensagem);
		}

		protected void LimparMensagensValidacao()
		{
			MensagemValidacao.Clear();
		}

		public abstract void Validate();
		protected bool EhValidado
		{
			get { return !MensagemValidacao.Any(); }
		}
	}
}
