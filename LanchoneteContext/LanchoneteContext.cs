global using Microsoft.Data.SqlClient;
using LanchoneteContext.entidades;

namespace LanchoneteContext;
public class LanchoneteContext {
	static private SqlConnection Conexao;
	static public Ingredientes Ingredientes;
	public LanchoneteContext() { }
}