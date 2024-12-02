using System.Data.SqlClient;
using Models;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Formulario.DAO
{
	public abstract class DAOAbstract<T> where T : class
	{

		static private string LinhaConexao = "SERVER=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql";
		static private SqlConnection Conexao;
		private string insertQuery, selectQuery, searchQuery, deleteQuery, updateQuery, tableName;
		private bool connected = false;
		public DAOAbstract(string insertQuery, string selectQuery, string searchQuery, string updateQuery, string tableName)
		{
			if (!connected) { Conexao = new SqlConnection(LinhaConexao); }

			this.insertQuery = insertQuery;
			this.selectQuery = selectQuery;
			this.searchQuery = searchQuery;
			this.tableName = tableName;
			this.updateQuery = updateQuery;
			deleteQuery = $"DELETE FROM {tableName} WHERE Id=@Id";
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

		public abstract void Insert(T entidade);
		public abstract void Update(T entidade);
		public abstract DataTable Search(string valueToSearch);


		public void InsertAndUpdateDataTable(T entidade, ref DataGridView dt)
		{
			Insert(entidade);
			dt.DataSource = Get();
		}

		public void SearchAndUpdateDataTable(string ValueToSearch, ref DataGridView dt)
		{
			dt.DataSource = Search(ValueToSearch);
		}

		public void DeleteAndUpdateDataTable(int rowIndex, ref DataGridView dt)
		{
			Delete(rowIndex);
			dt.DataSource = Get();
		}
		public void UpdateAndUpdateDataTable(T entidade, ref DataGridView dt)
		{
			Update(entidade);
			dt.DataSource = Get();
		}
		public void Delete(int id)
		{
			Conexao.Open();
			SqlCommand comando = new SqlCommand(deleteQuery, Conexao);
			var idParameter = new SqlParameter("@Id", id);
			comando.Parameters.Add(idParameter);
			comando.ExecuteNonQuery();
			Conexao.Close();

		}
		protected DataTable executeSearch(SqlParameter parameter)
		{
			Conexao.Open();
			DataTable dt = new DataTable();

			SqlCommand comando = new SqlCommand(searchQuery, Conexao);
			comando.Parameters.Add(parameter);

			SqlDataReader reader = comando.ExecuteReader();
			dt.Load(reader);

			reader.Close();
			Conexao.Close();
			return dt;
		}

		protected void executeUpdate(SqlParameter[] parameters)
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
		public DataTable Get()
		{
			DataTable dt = new DataTable();
			Conexao.Open();

			SqlCommand comando = new SqlCommand(selectQuery, Conexao);


			SqlDataReader reader = comando.ExecuteReader();

			dt.Load(reader);

			reader.Close();
			Conexao.Close();
			return dt;
		}

		protected SqlDataReader GetFirst(string query, SqlParameter[] parameters)
		{
			/* Após utilizar o reader, terminar chamando o método Close() no objeto
             * e no DAO chamar o método estático Close()
             * 
             */
			Conexao.Open();
			SqlCommand comando = new SqlCommand(query, Conexao);
			foreach (SqlParameter parameter in parameters)
			{
				comando.Parameters.Add(parameter);
			}
			SqlDataReader reader = comando.ExecuteReader();
			return reader;
		}
		static public void CloseConexao()
		{
			Conexao.Close();
		}


	}
}