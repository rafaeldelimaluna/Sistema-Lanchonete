namespace Models;

public class Ingrediente
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public DateTime DataValidadePadrao { get; set; }
}