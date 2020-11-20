using System;
using System.Collections.Generic;
using angular_todolist.Models;
using angular_todolist.Repositories;

namespace angular_todolist.Services
{
  public class TodosService
  {
    private readonly TodosRepository _repo;

    public TodosService(TodosRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Todo> Get()
    {
      return _repo.Get();
    }

    public Todo GetById(int id)
    {
      var data = _repo.GetById(id);
      if (data == null)
      {
        throw new System.Exception("Invalid Id");
      }
      return data;
    }
    public Todo Create(Todo todo)
    {
      return _repo.Create(todo);
    }

    public Todo Update(Todo todo)
    {
      var original = _repo.GetById(id);
      if (original == null)
      {
        throw new System.Exception("Invalid Id");
      }
      todo.title = todo.title != null ? todo.title : original.title;
      return _repo.Update(todo);
    }

    public bool Delete(int id)
    {
      var data = _repo.GetById(id);
      if (data == null)
      {
        throw new System.Exception("Invalid Id");
      }
      _repo.Delete(id);
      return true;
    }

  }
}