

using TodoList.ConsoleUI.Models;
using TodoList.ConsoleUI.Repository;

namespace TodoList.ConsoleUI.Service;

public class TodoService
{
    ToDoRepository todoRepository = new ToDoRepository();

    public void GetAll()
    {
        List<Todo> todos = new List<Todo>();
        todos.ForEach(x => Console.WriteLine(x));
    }

    public void GetById(int id)
    {
        Todo todo = todoRepository.GetById(id);
        Console.WriteLine(todo);
    }

    public void Add(Todo todo)
    {
        Todo newTodo = todoRepository.Add(todo);
        Console.WriteLine(newTodo);
    }

    public void Delete(int id)
    {
        Todo todo = todoRepository.Delete(id);
        Console.WriteLine(todo);
    }

    public void Update(int id, Todo todo)
    {
        Todo newTodo = todoRepository.Update(id, todo);
        Console.WriteLine("Todo güncellendi");
    }
}
