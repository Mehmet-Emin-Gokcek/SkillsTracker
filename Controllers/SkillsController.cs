using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {



        //At localhost:5001/skills, add text that states the three possible programming languages 
        //someone could be working on. You need to have an h1 with the title “Skills Tracker”, 
        //an h2, and an ol containing three programming languages of your choosing.
        [HttpGet]
        public IActionResult SkillsList()
        {
            string WebContent = "<h1>Skills Tracker</h1><br><br>" +
                                "<h2>Coding skills to learn</h2><br><br>" +
                                "<ul>" +
                                    "<li> Java </li><br>" +
                                    "<li> C# </li><br>" +
                                    "<li> Python </li><br>" +
                                    "<li> Ruby </li>" +
                                "</ul>";

            return Content(WebContent, "text/html");
        }


        [HttpGet("form")]
        public IActionResult SkillsForm()
        {
            string WebContent =  "<form method='post' action='/skills/form'>" +
                                     "<label for'date'>Date:</label> <br>" +
                                    "<input type='date' name='date' id='skill-date' value='mm/dd/yyyy'> <br><br>" +

                                       "<label for='java-select'>Java</label> <br>" +
                                     "<select name='java' id='java-select'> <br>" +
                                       "<option value=''>Please choose a skill</option><br>" +
                                       "<option value='Learning Basics'>Learning Basics</option>" +
                                       "<option value='Making Apps'>Making Apps</option>" +
                                       "<option value='Master Coder'>Master Coder</option>" +
                                    "</select><br><br>" +

                                    "<label for='c#-select'>C#</label> <br>" +
                                    "<select name='csharp' id='csharp-select'> <br>" +
                                        "<option value=''>Please choose a skill</option>" +
                                        "<option value='Learning Basics'>Learning Basics</option>" +
                                        "<option value='Making Apps'>Making Apps</option>" +
                                        "<option value='Master Coder'>Master Coder</option>" +
                                    "</select><br><br>" +

                                    "<label for='python-select'>Python</label> <br>" +
                                    "<select name='python' id='python-select'> <br>" +
                                        "<option value=''>Please choose a skill</option>" +
                                        "<option value='Learning Basics'>Learning Basics</option>" +
                                        "<option value='Making Apps'>Making Apps</option>" +
                                        "<option value='Master Coder'>Master Coder</option>" +
                                    "</select><br><br>" +

                                    "<label for='ruby-select'>Ruby</label> <br>" +
                                    "<select name='ruby' id='ruby-select'> <br>" +
                                        "<option value=''>Please choose a skill</option>" +
                                        "<option value='Learning Basics'>Learning Basics</option>" +
                                        "<option value='Making Apps'>Making Apps</option>" +
                                        "<option value='Master Coder'>Master Coder</option>" +
                                    "</select><br><br>" +
                                    "<input type = 'submit'>" + 
                                "</form>";
            
            return Content(WebContent, "text/html");
        }

        [HttpPost("form")]
        public IActionResult SkillsFormShow(String date, string java, string csharp, string python, string ruby)
        {
            string WebContent = $"<h1>{date}</h1><br><br>" +
                                "<ol>" +
                                    $"<li> Java: {java} </li><br>" +
                                    $"<li> C#: {csharp} </li><br>" +
                                    $"<li> Python: {python} </li><br>" +
                                    $"<li> Ruby: {ruby} </li><br>" +
                                "</ol>";

            return Content(WebContent, "text/html");
        }


    }
}
