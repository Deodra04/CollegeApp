using Microsoft.AspNetCore.Mvc.Filters;

namespace CollegeApp.Filters
{
    public class MyFilter : IActionFilter
    {      
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"filter executed on Action Executed");
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("filter executed on Action Executing");
        }
    }
}
