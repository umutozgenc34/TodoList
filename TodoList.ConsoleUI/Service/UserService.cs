

using TodoList.ConsoleUI.Models;
using TodoList.ConsoleUI.Repository;

namespace TodoList.ConsoleUI.Service;

public class UserService
{
    UserRepository userRepository = new UserRepository();
    public void GetAll()
    {
        List<User> users = new List<User>();
        users.ForEach(x => Console.WriteLine(x));
    }

    public void GetById (int id)
    {
        User user = userRepository.GetById(id);
        Console.WriteLine(user);
    }

    public void Add(User user)
    {
        User newUser = userRepository.Add(user);
        Console.WriteLine(newUser);
    }

    public void Delete(int id)
    {
        User user = userRepository.Delete(id);
        Console.WriteLine(user);
    }

    public void Update(int id,User user)
    {
        User newUser = userRepository.Update(id, user);
        Console.WriteLine("User güncellendi");
    }
}
