

using TodoList.ConsoleUI.Models;

namespace TodoList.ConsoleUI.Repository
{
    public sealed class ToDoRepository : BaseRepository, ITodoRepository
    {
        public Todo Add(Todo item)
        {
            throw new NotImplementedException();
        }

        public Todo? Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllByTitleContains(string title)
        {
            throw new NotImplementedException();
        }

        public Todo? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Todo? Update(Todo item)
        {
            throw new NotImplementedException();
        }
    }
}
