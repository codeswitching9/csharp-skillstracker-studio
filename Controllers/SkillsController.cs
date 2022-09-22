using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker2.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html = @"<h1>Skills Tracker</h1>
            <h2>
                <ol>
                    <li>C#</li>
                    <li>JavaScript</li>
                    <li>Python</li>
                </ol>
            </h2>";
            return Content(html, "text/html");
        }


        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string html = @"<form method='post'>
        <h2>Date:
        <br />
        <input type='date' name='Date'>
        </h2>

        <h2>C#: </h2>
        <select name = 'cskills'>
            <option value='learning basics'>Learning Basics</option>
            <option value='making apps'>Making Apps</option>
            <option value='master coder'>Master Coder</option>
            </select>
        
        <br />
        <h2>JavaScript: </h2> 
        <select name = 'jsskills'>
            <option value='learning basics'>Learning Basics</option>
            <option value='making apps'>Making Apps</option>
            <option value='master coder'>Master Coder</option>
            </select>

        <br/>
        <h2>Python: </h2>
        <select name = 'pskills'>
            <option value='learning basics'>Learning Basics</option>
            <option value='making apps'>Making Apps</option>
            <option value='master coder'>Master Coder</option>
            </select>
        <br>
        <input type='submit' value='Submit'>
        </form>";

            return Content(html, "text/html");
        }

        /*[HttpPost]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            return Content("<h1>"+ date + cskills + )
        }*/
    }
}
