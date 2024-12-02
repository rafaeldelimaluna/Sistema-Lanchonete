using MySql.Data.MySqlClient;

namespace Models;

public abstract class EntidadeBase
{
    public abstract void SetValueInObjectWithDataReader(MySqlDataReader reader);
}