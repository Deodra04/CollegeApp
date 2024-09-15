using Microsoft.AspNetCore.Mvc.Filters;

namespace CollegeApp.Filters
{
    public class MyAsyncActionFilter : Attribute, IAsyncActionFilter
    {
        private readonly string _name;
        public MyAsyncActionFilter(string name)
        {
            _name = name;
        }
      
         public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Async Filter : Before Execution");
            await next();
            Console.WriteLine($"Async Filter : After Execution");
        }
    }
}
