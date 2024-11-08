namespace Models;

public class Produtos
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public float Preco { get; set; }
    public int TipoProdutoId { get; set; }

    public TipoProduto? TipoProduto { get; set; }
}