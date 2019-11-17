
namespace QuickBuy.Dominio.Entidades
{
	public class Produto : Entidade
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public decimal Preco { get; set; }

		public override void Validate()
		{
			if (Id == 0)
				AdicionarMensagemValidacao("Crítica - Não foi identificado qual a referencia.");
			if (string.IsNullOrEmpty(Nome))
				AdicionarMensagemValidacao("Crítica - Nome não foi informado.");
		}
	}
}
