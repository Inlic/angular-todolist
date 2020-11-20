using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using angular_todolist.Models;
using Dapper;

namespace angular_todolist.Repositories
{
  public class TodosRepository
  {
    private readonly IDbConnection _db;

    public TodosRepository(IDbConnection db)
    {
      _db = db;
    }
    public IEnumerable<Todo> Get()
    {
      return _db.Query<Todo>(@"
      SELECT * FROM todos
      ");
    }

    public Todo GetById(int id)
    {
      return _db.Query<Todo>(@"
      SELECT * FROM todos WHERE id = @id", new { id }).FirstOrDefault();
    }

    public Todo Create(Todo todo)
    {
      int id = _db.ExecuteScalar<int>(@"
      INSERT INTO todos(title, completed)
      VALUES(@Title, @Completed); SELECT LAST_INSERT_ID();", todo);
      todo.Id = id;
      return todo;
    }

    public Todo Update(Todo todo)
    {
      _db.Execute(@"
        UPDATE todos
        SET
        title = @Title,
        completed = @Completed
        WHERE id = @Id;", todo);
      return todo;
    }

    public bool Delete(int id)
    {
      int success = _db.Execute(@"
      DELETE FROM todos WHERE id = @id
      ", new { id });
      return success > 0;
    }
  }
}