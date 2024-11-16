using LanchoneteContext.CRUD;
using System.Data;


namespace LanchoneteContext.interfaces
{
	internal class Getter(SqlConnection Conexao) : CrudBase(Conexao)
	{
		public string selectQuery { get; set; } = "";

		public DataTable All()
		{
			DataTable dt = new DataTable();
			conexao.Open();

			SqlCommand comando = new SqlCommand(selectQuery, conexao);


			SqlDataReader reader = comando.ExecuteReader();

			dt.Load(reader);

			reader.Close();
			conexao.Close();
			return dt;
		}

		protected SqlDataReader First(string query, SqlParameter[] parameters)
		{
			/* Após utilizar o reader, terminar chamando o método Close() no objeto
             * e no DAO chamar o método estático Close()
             * 
             */
			conexao.Open();
			SqlCommand comando = new SqlCommand(query, conexao);
			foreach (SqlParameter parameter in parameters)
			{
				comando.Parameters.Add(parameter);
			}
			SqlDataReader reader = comando.ExecuteReader();
			return reader;
		}
	}
}
