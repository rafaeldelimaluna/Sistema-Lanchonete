using LanchoneteContext.CRUD;
using LanchoneteContext.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteContext.entidades;
public abstract class EntidadeAbstract
{
	public SqlConnection conexao;
	public abstract Getter Get { get; set; }
	public abstract Inserter Add{get; set;}
	public abstract required Updater Update { get; set; }
	public SqlConnection Conexao { set { conexao = value; } }

	}
