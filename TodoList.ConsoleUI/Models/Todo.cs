
namespace TodoList.ConsoleUI.Models;

public sealed class Todo : Entity<int>
{
    public Todo()
    {
        
    }
    public Todo(int id, string title , string description , DateTime createdDate, string startDate, string endDate, string priority, bool isCompleted , int userId)
    {
        Id = id;
        Title = title;
        Description = description;
        CreatedDate = createdDate;
        StartDate = startDate;
        EndDate = endDate;
        Priority = priority;
        IsCompleted = isCompleted;
        UserId = userId;
        
    }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Priority { get; set; }
    public bool IsCompleted { get; set; }
    public int UserId { get; set; }

    public override string ToString()
    {
        return $"Id : {Id} Title : {Title} Description : {Description} CreatedDate : {CreatedDate} StartDate : {StartDate} EndDate : {EndDate}" +
            $"Priority : {Priority} IsCompleted : {IsCompleted} UserId : {UserId}";
    }
}
