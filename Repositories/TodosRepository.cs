using System;
using System.Collections.Generic;
using System.Data;
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
      throw new NotImplementedException();
    }

    public Todo Create(Todo todo)
    {
      throw new NotImplementedException();
    }

    public Todo Update(Todo todo)
    {
      throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}