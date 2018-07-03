using Microsoft.AspNetCore.Mvc;

namespace restaurantdemo.controllers
{
    //about

    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "1+234+567+8910";
        }

        [Route("[action]")]
        public string Address()
        {
            return "United States";
        }
    }
}
