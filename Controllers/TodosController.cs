using System.Collections.Generic;
using angular_todolist.Models;
using angular_todolist.Services;
using Microsoft.AspNetCore.Mvc;

namespace angular_todolist.Controllers
{
  [Route("/api/[controller]")]
  [ApiController]
  public class TodosController : ControllerBase
  {
    private readonly TodosService _service;

    public TodosController(TodosService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Todo>> Get()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Todo>> GetById(int id)
    {
      try
      {
        return Ok(_service.GetById(id));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
    [HttpPost]
    public ActionResult<Todo> Create([FromBody] Todo todo)
    {
      try
      {
        return Ok(_service.Create(todo));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Todo> Update([FromBody] Todo todo, int id)
    {
      try
      {
        todo.Id = id;
        return Ok(_service.Update(todo));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<bool> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

  }
}