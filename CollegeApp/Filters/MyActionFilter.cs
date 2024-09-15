using Microsoft.AspNetCore.Mvc.Filters;

namespace CollegeApp.Filters
{
    public class MyActionFilterAttribute : Attribute ,IActionFilter
    {
        private readonly string _name;
        public MyActionFilterAttribute(string name)
        {
            _name = name;
        }
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"filter {_name} executed on Action Executed");
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"filter {_name} executed on Action Executing");
        }
    }
}
