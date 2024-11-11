using LanchoneteContext.repositories.interfaces;
using Models;

namespace LanchoneteContext.repositories.implementations;

public class IngredientesRepository:IBaseRepository<Ingrediente>
{
    private readonly LanchoneteContext _db;
    public IngredientesRepository(LanchoneteContext db)
    {
        _db = db;
    }
    
    public List<Ingrediente>? Get()
    {
        return _db.Ingredientes?.ToList();
    }

    public Ingrediente? Get(int id)
    {
        return _db.Ingredientes?.FirstOrDefault(i => i.Id == id);
    }

    public void Update(Ingrediente entity)
    {
        _db.Ingredientes?.Update(entity);
    }

    public void Delete(int id)
    {
        var ingrediente = Get(id);
        if (ingrediente != null)
            _db.Ingredientes?.Remove(ingrediente);
    }

    public List<Ingrediente>? Find(Ingrediente obj)
    {
        return _db.Ingredientes?.Where(i => i.Nome.Contains(obj.Nome)).ToList();
    }
}