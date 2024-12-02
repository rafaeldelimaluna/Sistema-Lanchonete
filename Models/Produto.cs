using MySql.Data.MySqlClient;

namespace Models;

public class Produto:EntidadeBase
{
    private string _nome = null!;
    public int Id { get; set; }
    public string Nome
    {
        get => _nome;
        set
        {
            if (value.Length > 60)
            {
                throw new Exception(
                    $"Comrpimento de 'NOME' maior do que o suportado pelo banco de dados.\n Comprimento Máximo: 60\nComprimento da tentativa: {value.Length}");
            }
            _nome  = value;
        } }
    public double Preco { get; set; }

    public TipoProduto TipoProduto { get; set; } = TipoProduto.Indefinido;


    public override void SetValueInObjectWithDataReader(MySqlDataReader reader)
    {
        Id = reader.GetInt32("Id");
        Nome = reader.GetString("Nome");
        Preco = reader.GetFloat("Preco");
        TipoProduto = (TipoProduto)reader.GetInt32("TipoProduto");
    }
}