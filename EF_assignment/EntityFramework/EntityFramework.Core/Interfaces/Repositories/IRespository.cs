namespace EntityFramework.Core.Interfaces.Repositories;

public interface IRepository<T> where T:class
{
    int Insert(T obj);
    int DeleteById(int id);
    int Update(int id, T obj);
    T? GetById(int id);
    IEnumerable<T> GetAll();
}