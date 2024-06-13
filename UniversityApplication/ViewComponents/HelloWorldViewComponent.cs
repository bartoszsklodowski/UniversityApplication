using Microsoft.AspNetCore.Mvc;
using UniversityApplication.Models;

namespace UniversityApplication.ViewComponents
{
    [ViewComponent(Name = "HelloWorld")]
    public class HelloWorldViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            Greetings greetings = new Greetings();
            greetings.Name = name;
            greetings.GreetingsText = "Hello: " + name;
            return View(greetings);
        }
        
    }
}
