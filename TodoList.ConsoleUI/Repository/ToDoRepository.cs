

using TodoList.ConsoleUI.Models;

namespace TodoList.ConsoleUI.Repository
{
    public sealed class ToDoRepository : BaseRepository, ITodoRepository
    {
        public Todo Add(Todo item)
        {
            Todos().Add(item);
            return item;
        }

        public Todo? Delete(int id)
        {
            Todo todo = GetById(id);
            Todos().Remove(todo);
            return todo;
        }

        public List<Todo> GetAll()
        {
            return Todos();
        }

        public List<Todo> GetAllByTitleContains(string title)
        {
            throw new NotImplementedException();
        }

        public Todo? GetById(int id)
        {
            Todo todo = Todos().SingleOrDefault(x => x.Id == id);
            return todo;
        }

        public Todo? Update(int id, Todo item)
        {
            Todo todo = Todos().FirstOrDefault(x => x.Id == id);
            Todos().Remove(todo);
            Todos().Add(item);
            return item;
        }
    }
}
