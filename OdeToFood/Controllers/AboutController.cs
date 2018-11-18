using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {

        public string Phone()
        {
            return "123412341241234";
        }
        
        public string Address()
        {
            return "masahosettes 2123";
        }
    }
}
