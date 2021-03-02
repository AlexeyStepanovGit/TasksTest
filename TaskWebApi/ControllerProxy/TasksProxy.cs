using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TasksWeb.Model;


namespace TaskWebApi.ControllerProxy
{
    public sealed class TasksProxy : ITasksProxy
    {
        private readonly TasksStorage _tasks;
        private readonly ILogger<ITasksProxy> _logger;

        public TasksProxy(ILogger<ITasksProxy> logger)
        {
            _tasks = new TasksStorage();
            _tasks.TryAdd(Guid.NewGuid(), new TaskModel() { DisplayName = "rty", Id = Guid.NewGuid(), Priority = 1, Status = TasksWeb.Model.TaskStatus.InProgress }); 

            _logger = logger;
        }

        public Task<Guid> AddTask(TaskModel task)
        {
            var key = Guid.NewGuid();
            if (_tasks.TryAdd(key, task))
            {
                _logger.LogInformation($"New task {key} added.");
                return Task.FromResult(key);
            }

            _logger.LogInformation($"Cannot add new task.");
            return Task.FromResult(Guid.Empty);
        }

        public Task<TaskModel> FindTaskAsync(Guid taskId)
        {
            if (_tasks.TryGetValue(taskId, out var task))
            {
                _logger.LogInformation($"Task {taskId} found.");
                return Task.FromResult(task);
            }

            _logger.LogInformation($"Task {taskId} not found.");
            return null;
        }

        public Task<ICollection<TaskModel>> GetTasksAsync()
        {
            return Task.FromResult(_tasks.Values);
        }

        public void RemoveTask(Guid taskId)
        {
            if (_tasks.TryRemove(taskId, out _))
            {
                _logger.LogInformation($"Task {taskId} removed.");
            }

            _logger.LogInformation($"Cannot remove task {taskId}.");

        }

        public void UpdateTask(Guid taskId, TaskModel task)
        {
            _tasks[taskId] = task;
        }
    }
}
