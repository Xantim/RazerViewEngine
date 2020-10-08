using Microsoft.AspNetCore.Mvc;
namespace AS_RazorFun
{
    public class HomeController : Controller
    {
        //Requests
        //localhost:5000/
        [Route("")]
        [HttpGet] //or HttpPost
        public string Index()
        {
            return "Hello from Controller";
        }

        //localhost:5000/hello
        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi Again!";
        }

        //localhost:5000/users/???
        // [Route("users/{username}/{location}")]
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            if(location == "chicago")
                return $"Hello {username} from {location}. Go Bears!";
            return $"Hello {username} from {location}";
        }


        [HttpGet("users/greeting")]
        public ViewResult HiThere()
        {
            return View();
        }
    }
}