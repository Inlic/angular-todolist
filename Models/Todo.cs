namespace angular_todolist.Models
{
  public class Todo
  {
    public int UserId { get; set; }
    public int Id { get; set; }
    public string title { get; set; }
    public bool completed { get; set; }
  }
}