using Code2.Data;

using Code2.Models;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace Code2.Controllers

{

    [ApiController]

    [Route("[controller]")]

    public class TodoController : ControllerBase

    {

        private readonly AppDbContext _db;

        
        public TodoController(AppDbContext db)

        {

            _db = db;

        }

        
        [HttpGet]

        [HttpGet]

        public async Task<ActionResult<List<TodoItem>>> GetAll()

        {

            return Ok(await _db.TodoItems.ToListAsync());

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<TodoItem>> GetById(int id)

        {

            var task = await _db.TodoItems.FindAsync(id);

            if (task == null) return NotFound();

            return Ok(task);

        }

        [HttpPost]

        public async Task<ActionResult<TodoItem>> Create(TodoItem newTask)

        {

            newTask.CreatedAt = DateTime.UtcNow;

            _db.TodoItems.Add(newTask);

            await _db.SaveChangesAsync(); 
            return CreatedAtAction(nameof(GetById), new { id = newTask.Id }, newTask);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Update(int id, TodoItem updatedTask)

        {

            var task = await _db.TodoItems.FindAsync(id);

            if (task == null) return NotFound();

            task.Title = updatedTask.Title;

            task.IsCompleted = updatedTask.IsCompleted;

            await _db.SaveChangesAsync(); 
            return NoContent();

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)

        {

            var task = await _db.TodoItems.FindAsync(id);

            if (task == null) return NotFound();

            _db.TodoItems.Remove(task);

            await _db.SaveChangesAsync(); 
            return NoContent();

        }

    }

}

