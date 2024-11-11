using LanchoneteContext.repositories.interfaces;
using Models;

namespace LanchoneteContext.repositories.implementations;

public class ProdutoRepository:IBaseRepository<Produto>
{
    private readonly Database.LanchoneteContext _db;

    public ProdutoRepository(Database.LanchoneteContext db)
    {
        _db = db;
    }

    public List<Produto>? Get()
    {
        return _db.Produtos?.ToList();
    }

    public Produto? Get(int id)
    {
        return _db.Produtos?.Find(id);
    }

    public List<Produto>? Find(Produto obj)
    {
        return _db.Produtos?.Where(p=> p.Nome.Contains(obj.Nome) ).ToList();
    }

    public void Update(Produto entity)
    {
        _db.Produtos?.Update(entity);
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var obj = Get(id);
        if (obj != null)
            _db.Produtos?.Remove(obj);
    }
}