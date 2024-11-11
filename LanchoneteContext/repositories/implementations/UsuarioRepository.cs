using LanchoneteContext.repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace LanchoneteContext.repositories.implementations;

public class UsuarioRepository(Database.LanchoneteContext db) : IUsuarioRepository
{
    private readonly Database.LanchoneteContext _db = db;

    public List<Usuario>? Get()
    {
        return _db.Usuarios?.ToList();
    }

    public Usuario? Get(int id)
    {
        return _db.Usuarios?.FirstOrDefault(u => u.Id == id);
    }

    public void Update(Usuario entity)
    {
        _db.Usuarios?.Remove(entity);
        _db.Usuarios?.Add(entity);
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        _db.Usuarios?.Where(u=>u.Id==id).ExecuteDelete();
    }

    public List<Usuario>? Find(Usuario entity)
    {
        return _db.Usuarios?.Where(u => u.Nome.Contains(entity.Nome)).ToList();
    }


}