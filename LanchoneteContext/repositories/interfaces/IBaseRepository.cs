namespace LanchoneteContext.repositories.interfaces;

public interface IBaseRepository<T> where T : class
{
    List<T>? Get();
    T? Get(int id);
    List<T>? Find(T obj);

    void Update(T entity);
    void Delete(int id);
}