using System.Diagnostics;

namespace MVC01.CustomMiddlewares
{
    public class RequestTimmingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimmingMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var watch = Stopwatch.StartNew();

            // next middleware
            await _next(context);
            watch.Stop();
            Console.WriteLine($"[[{context.Request.Path}]] :: {watch.ElapsedMilliseconds} ms");
        }

    }
}
