using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteContext.CRUD
{
	public abstract class CrudBase
	{
		protected SqlConnection conexao;
		protected CrudBase(SqlConnection Conexao) {conexao = Conexao;}
	}
}
