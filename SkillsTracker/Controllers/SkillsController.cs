using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills/")] //put forward slashes on both sides.
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1><h2>Coding skills to learn</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
        [HttpGet("form")] //make sure not to write /form or that re-writes the path you want (/skills/form -> /form). 
        public IActionResult RenderSkillsForm()
        {
            string html =
                "<form method='post' action='form'>" +
                    "<p><label>Date: <input type='date' name='date'></label></p>" +
                    "<p><label>C#: <select name='csharp'>" +
                        "<option value='Learning'>Learning</option>" +
                        "<option value='Familiar'>Familiar</option>" +
                        "<option value='Experienced'>Experienced</option>" +
                    "</select></label></p>" +
                    "<p><label>JavaScript: <select name='js'>" +
                        "<option value='Learning'>Learning</option>" +
                        "<option value='Familiar'>Familiar</option>" +
                        "<option value='Experienced'>Experienced</option>" +
                    "</select></label></p>" +
                    "<p><label>Python: <select name='python'>" +
                        "<option value='Learning'>Learning</option>" +
                        "<option value='Familiar'>Familiar</option>" +
                        "<option value='Experienced'>Experienced</option>" +
                    "</select></label></p>" +
                    "<input type='submit' value='Go!'>" +
                    "</form>";
            return Content(html, "text/html");
        }
        [HttpPost("form")]
        public IActionResult ProcessSkillsForm(string date, string csharp, string js, string python)
        {
            string html =
                $"<h1>{date}</h1>" +
                $"<p> 1. C#: {csharp}</p>" +
                $"<p> 2. JavaScript: {js}</p>" +
                $"<p> 3. Python: {python}</p>";
            return Content(html, "text/html");
        }
    }
}
