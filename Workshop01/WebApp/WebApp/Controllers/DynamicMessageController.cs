using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DynamicMessageController : ControllerBase
    {
        [HttpGet]
        public DynamicMessage Get()
        {
            var rdmval = new Random().Next(1, 5);
            DynamicMessage workshop01message = new();
            string msg = "";
            switch (rdmval)
            {

                case 1:
                    workshop01message.message = "Logic will get you from A to B. Imagination will take you everywhere.";
                    break;
                case 2:
                    workshop01message.message = "There are 10 kinds of people. Those who know binary and those who don't.";
                    break;
                case 3:
                    workshop01message.message = "There are two ways of constructing a software design. One way is to make it so simple that there are obviously no " +
                        "deficiencies and the other is to make it so complicated that there are no obvious deficiencies.";
                    break;
                case 4:
                    workshop01message.message = "It's not that I'm so smart, it's just that I stay with problems longer.";
                    break;
                case 5:
                    workshop01message.message = "It is pitch dark. You are likely to be eaten by a grue.";
                    break;
            }


            return workshop01message;
        }
    }
}
