using System;
using TasksWeb.Model;

namespace TaskWebApi.Validation
{
    public static class TaskValidationExtension
    {
        public static bool IsValid(this TaskModel task)
        {
            return !string.IsNullOrWhiteSpace(task.DisplayName);
        }

        public static bool IsValid(this TaskModel task, Guid taskId)
        {
            return task.IsValid() && task.Id == taskId;
        }
    }
}
