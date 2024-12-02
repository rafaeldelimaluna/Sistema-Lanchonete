using LanchoneteContext.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteContext.interfaces;
public class Updater(SqlConnection Conexao) : CrudBase(Conexao)
{
	public required string updateQuery;

	public void Entidade(SqlParameter[] parameters)
	{
		Conexao.Open();
		SqlCommand comando = new SqlCommand(updateQuery, Conexao);
		foreach (SqlParameter param in parameters)
		{
			comando.Parameters.Add(param);
		}
		comando.ExecuteNonQuery();
		Conexao.Close();
	}
}
