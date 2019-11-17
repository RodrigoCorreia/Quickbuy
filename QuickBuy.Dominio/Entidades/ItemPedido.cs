namespace QuickBuy.Dominio.Entidades
{
	public class ItemPedido : Entidade
	{
		public int Id { get; set; }
		public int ProdutoId { get; set; }
		public int Quantidade { get; set; }

		public override void Validate()
		{
			if (ProdutoId == 0)
				AdicionarMensagemValidacao("Crítica - Não foi identificado qual a referencia.");
			if (Quantidade == 0)
				AdicionarMensagemValidacao("Crítica - Quantidade não foi informado.");
		}
	}
}
