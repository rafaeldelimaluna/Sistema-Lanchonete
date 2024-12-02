using MySql.Data.MySqlClient;

namespace Models;

public class Usuario:EntidadeBase
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Senha { get; set; } = null!;

    public NivelAcesso? NivelAcesso { get; set; }
    public override void SetValueInObjectWithDataReader(MySqlDataReader reader)
    {
        Id = reader.GetInt32("Id");
        Nome = reader.GetString("Nome");
        Senha = reader.GetString("Senha");
        
    }
}