using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteContext.CRUD;
	public class Inserter(SqlConnection Conexao):CrudBase(Conexao)
	{
	public string insertQuery;

	public void Entidade()
	{
	}

	protected void executeInsertion(SqlParameter[] parameters)
	{
		Conexao.Open();
		SqlCommand comando = new SqlCommand(insertQuery, Conexao);
		foreach (SqlParameter param in parameters)
		{
			comando.Parameters.Add(param);
		}
		comando.ExecuteNonQuery();
		Conexao.Close();
	}
}
