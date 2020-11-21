namespace angular_todolist.Models
{
  public class Todo
  {
    public string UserId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }
  }
}