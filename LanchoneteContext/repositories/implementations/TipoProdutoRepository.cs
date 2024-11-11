using LanchoneteContext.repositories.interfaces;
using Models;

namespace LanchoneteContext.repositories.implementations;

public class TipoProdutoRepository:IBaseRepository<TipoProduto>
{
    private readonly Database.LanchoneteContext _db;
    public TipoProdutoRepository(Database.LanchoneteContext db)
    {
        _db = db;
    }
    public List<TipoProduto>? Get()
    {
        return _db.TipoProduto?.ToList();
    }

    public TipoProduto? Get(int id)
    {
        return _db.TipoProduto?.Find(id);
    }

    public void Update(TipoProduto entity)
    {
        _db.TipoProduto?.Update(entity);
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var obj = Get(id);
        if (obj != null)
            _db.TipoProduto?.Remove(obj);
    }

    public List<TipoProduto>? Find(TipoProduto obj)
    {
        return _db.TipoProduto?.Where(tp=>tp.Nome.Contains(obj.Nome)).ToList();
    }
}