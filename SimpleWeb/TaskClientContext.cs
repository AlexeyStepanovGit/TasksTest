using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TasksWeb.Model;

namespace SimpleWeb
{
    public class TaskClientContext
    {

        public async Task<IEnumerable<TaskModel>> GetTasks()
        {
            using (var client = new TasksClient())
            {
                var streamTask = client.GetStreamAsync(RoutingPaths.Actions.Get);
                var tasks = await JsonSerializer.DeserializeAsync<List<TaskModel>>(await streamTask);

                return tasks;

            }
        }
    }
}
