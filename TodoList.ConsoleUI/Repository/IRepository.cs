

using TodoList.ConsoleUI.Models;

namespace TodoList.ConsoleUI.Repository;

public interface IRepository<TEntity,TId>
    where TEntity : Entity<TId> , new()
{
    public List<TEntity> GetAll();
    TEntity? GetById(TId id);
    TEntity Add(TEntity item);
    TEntity? Update(TId id,TEntity item);
    TEntity? Delete(TId id);
}
