using MySql.Data.MySqlClient;

namespace Models;

public class NivelAcesso:EntidadeBase
{
    public int Id { get; set; }
    public string Nome
    {
        get => _nome;
        set
        {
            if (value.Length > 30)
            {
                throw new Exception(
                    $"O 'NOME' na classe NivelAcesso, deve conter no máximo 30 caracteres. Comprimento de caracteres que houve tentativa de inserção:{value.Length}");
                    
            }
            _nome = value;
        }
    }

    public List<TiposAcesso> TiposAcessos { get; set; }= new List<TiposAcesso>();
    
    
    private string _nome = null!;

    public enum TiposAcesso
    {
        Pedidos,
        Produtos,
        Ingredientes,
        Estoque
    }

    public override void SetValueInObjectWithDataReader(MySqlDataReader reader)
    {
        Console.WriteLine("Esta classe não possui este método pela complexidade existente");        
    }
}
