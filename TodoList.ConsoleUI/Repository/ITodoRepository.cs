

using TodoList.ConsoleUI.Models;

namespace TodoList.ConsoleUI.Repository;

public interface ITodoRepository : IRepository<Todo,int>
{
    List<Todo> GetAllByTitleContains(string title);
}
