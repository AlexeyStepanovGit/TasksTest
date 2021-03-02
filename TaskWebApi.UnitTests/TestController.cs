using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using TasksWeb.Model;
using TaskWebApi.ControllerProxy;
using TaskWebApi.Controllers;
using Xunit;

namespace TaskWebApi.UnitTests
{
    public class TestController
    {
        private Guid FistTaskId = new Guid("00000000-0000-0000-0000-000000000001");
        private Guid SecondTaskId = new Guid("00000000-0000-0000-0000-000000000002");
        private Guid ThirdTaskId = new Guid("00000000-0000-0000-0000-000000000003");

        [Fact]
        public async void Get_Tasks_ShouldBeNoContent()
        {
            var mockProxy = new Mock<ITasksProxy>();
            mockProxy.Setup(repo => repo.GetTasksAsync())
                .ReturnsAsync(GetEmptyTestTasks());

            var controller = new TasksController(mockProxy.Object);

            var result = await controller.GetTasks();

            Assert.NotNull(result);
            Assert.IsType<ActionResult<List<TaskModel>>>(result);
            Assert.IsType<NoContentResult>(result.Result);

        }

        [Fact]
        public async void Get_Tasks_ShouldBeOk()
        {
            var mockProxy = new Mock<ITasksProxy>();    
            mockProxy.Setup(repo => repo.GetTasksAsync())
                .ReturnsAsync(GetTwoTestTasks());

            var controller = new TasksController(mockProxy.Object);

            var result = await controller.GetTasks();

            Assert.NotNull(result);
            var actionResult = Assert.IsType<ActionResult<List<TaskModel>>> (result);
            var returnValue = Assert.IsType<List<TaskModel>>(actionResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public async void Get_Second_Task_ShouldBeNotFound()
        {
            var mockProxy = new Mock<ITasksProxy>();
            mockProxy.Setup(repo => repo.GetTasksAsync())
                .ReturnsAsync(GetTwoTestTasks());

            var controller = new TasksController(mockProxy.Object);

            var result = await controller.GetTask(SecondTaskId);

            Assert.NotNull(result);
            var actionResult = Assert.IsType<ActionResult<TaskModel>>(result);
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(actionResult.Result);
            Assert.Equal(SecondTaskId, notFoundResult.Value);
        }

        private ICollection<TaskModel> GetEmptyTestTasks() => new List<TaskModel>();
    

        private ICollection<TaskModel> GetTwoTestTasks()
        {
            var tasks = new List<TaskModel>();
            tasks.Add(new TaskModel()
            {

                Id = FistTaskId,
                DisplayName = "Test task 1",
                Priority = 1,
                Status = TaskStatus.InProgress
            });

            tasks.Add(new TaskModel()
            {

                Id = SecondTaskId,
                DisplayName = "Test task 2",
                Priority = 2,
                Status = TaskStatus.NotStarted
            });


            return tasks;
        }
    }
}
