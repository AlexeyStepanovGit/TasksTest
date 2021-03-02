using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using TaskWebApi.ControllerProxy;
using TaskWebApi.Validation;
using System.Linq;
using TasksWeb.Model;

namespace TaskWebApi.Controllers
{
    [ApiController]
    [Route("/api/v1/tasks")]
    public class TasksController : ControllerBase
    {
        private readonly ITasksProxy _tasksProxy;

        public TasksController(ITasksProxy tasksProxy)
        {
            _tasksProxy = tasksProxy;
        }

        [HttpGet]
        [ProducesResponseType(204)]
        [Description("Get all tasks")]
        public async Task<ActionResult<List<TaskModel>>> GetTasks()
        {
            var tasks = await _tasksProxy.GetTasksAsync();
            if (tasks.Count == 0)
            {
                return NoContent();
            }
            return tasks.ToList();
        }

        [HttpGet]
        [ProducesResponseType(404)]
        [Route("{taskId}")]
        [Description("Get task by ID")]
        public async Task<ActionResult<TaskModel>> GetTask([FromRoute] Guid taskId)
        {
            var task = await _tasksProxy.FindTaskAsync(taskId);
            if (task == null)
            {
                return NotFound(taskId);
            }

            return task;
        }

        [HttpPost]
        [ProducesResponseType(400)]
        [Route("/api/v1/tasks/add")]
        [Description("Add task")]
        public async Task<IActionResult> AddTask(TaskModel task)
        {
            if (!task.IsValid())
                return BadRequest(task);

            await _tasksProxy.AddTask(task);

            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Route("/api/v1/tasks/{taskUid}/actions/update")]
        [Description("Uppdate task by ID")]
        public async Task<IActionResult> UpdateTask(Guid taskId, TaskModel task)
        {
            if (!task.IsValid(taskId))
                return BadRequest(task);

            var oldTask = await _tasksProxy.FindTaskAsync(taskId);
            if (oldTask == null)
            {
                return NotFound();
            }

            _tasksProxy.UpdateTask(taskId, task);

       
            return Ok();
        }

        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Route("/api/v1/tasks/{taskUid}/actions/remove")]
        [Description("Remove task by ID")]
        public async Task<IActionResult> RemoveTask([FromRoute] Guid taskId)
        {
            var task = await _tasksProxy.FindTaskAsync(taskId);
            if (task == null)
            {
                return NotFound();
            }

            if (task.Status != TasksWeb.Model.TaskStatus.Completed)
                return BadRequest();

            _tasksProxy.RemoveTask(taskId);
            
            return Ok();
        }
    }
}
