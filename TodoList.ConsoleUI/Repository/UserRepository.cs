
using TodoList.ConsoleUI.Models;

namespace TodoList.ConsoleUI.Repository;

public sealed class UserRepository : BaseRepository, IUserRepository
{
    public User Add(User item)
    {
        Users().Add(item);
        return item;
    }

    public User? Delete(int id)
    {
        User user = GetById(id);
        Users().Remove(user);
        return user;
    }

    public List<User> GetAll()
    {
        return Users();
    }

    public User? GetById(int id)
    {
        User user = Users().SingleOrDefault(x => x.Id == id);
        return user;
    }

    public User? Update(int id,User item)
    {
        User user = Users().FirstOrDefault(x => x.Id == id);
        Users().Remove(user);
        Users().Add(item);
        return item;

    }
}
