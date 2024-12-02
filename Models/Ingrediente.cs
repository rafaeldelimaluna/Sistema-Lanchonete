using MySql.Data.MySqlClient;

namespace Models;

public class Ingrediente:EntidadeBase   
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public DateTime DataValidadePadrao { get; set; }

    public override void SetValueInObjectWithDataReader(MySqlDataReader reader)
    {
        Id = reader.GetInt32("Id");
        Nome = reader.GetString("Nome");
        DataValidadePadrao = reader.GetDateTime("DataValidadePadrao");
    }
}