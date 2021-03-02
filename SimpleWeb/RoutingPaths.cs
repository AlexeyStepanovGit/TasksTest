using System;

namespace SimpleWeb
{
    // TODO: remove static
    public static class RoutingPaths
    {
        private const string BaseUrl = "https://127.0.0.1:4443";
        private const string Version = "v1";
        private static readonly string BaseUrlVersion = $"{BaseUrl}/{Version}";

        public static class Actions
        {
            public static Uri Get => new Uri($"{BaseUrlVersion}/tasks");
            public static Uri GetById(Guid taskId) => new Uri($"{BaseUrlVersion}/tasks/{taskId}");
         
            public static Uri Add(Guid organizationId) => new Uri($"{BaseUrlVersion}/tasks/add");
        }
    }
}
