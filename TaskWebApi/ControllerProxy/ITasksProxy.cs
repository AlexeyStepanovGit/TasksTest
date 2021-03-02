using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TasksWeb.Model;

namespace TaskWebApi.ControllerProxy
{

    public interface ITasksProxy
    {
        Task<TaskModel> FindTaskAsync(Guid taskId);
        Task<ICollection<TaskModel>> GetTasksAsync();
        void UpdateTask(Guid taskUid, TaskModel task);
        Task<Guid> AddTask(TaskModel task);
        void RemoveTask(Guid taskId);

    }

   
}
