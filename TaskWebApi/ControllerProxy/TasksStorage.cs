using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using TasksWeb.Model;

namespace TaskWebApi.ControllerProxy
{
    public class TasksStorage
    {
        private readonly ConcurrentDictionary<Guid, TaskModel> _tasks;

        public TasksStorage()
        {
            _tasks = new ConcurrentDictionary<Guid, TaskModel>();
          
        }

        public bool TryAdd(Guid key, TaskModel task)
        {
            return _tasks.TryAdd(key, task);
        }

        public bool TryRemove(Guid taskId, out TaskModel task)
        {
            var result = _tasks.TryRemove(taskId, out var tsk);
            task = tsk;
            return result;
        }

        public bool TryGetValue(Guid taskId, out TaskModel task)
        {
            var result =  _tasks.TryGetValue(taskId, out var tsk);
            task = tsk;
            return result;
        }

        public ICollection<TaskModel> Values
        {
            get { return _tasks.Values; }
                
        }

        public TaskModel this[Guid key]
        {
            get => _tasks[key];
            set => _tasks[key] = value;
        }
    }
}
