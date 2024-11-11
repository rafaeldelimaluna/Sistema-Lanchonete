namespace Models;

public class NivelAcesso
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public ICollection<TiposAcesso> TiposAcessos { get; set; } = null!;

    public enum TiposAcesso
    {
        Pedidos,
        Produtos,
        Ingredientes,
        Estoque
    }
}
