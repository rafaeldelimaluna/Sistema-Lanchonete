namespace Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Senha { get; set; } = null!;
    
    
    public int NivelAcessoId { get; set; }
    public NivelAcesso? NivelAcesso { get; set; }
}