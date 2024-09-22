using Microsoft.AspNetCore.Mvc;
using TravelAgentWeb.Data;
using TravelAgentWeb.Dtos;

namespace TravelAgentWeb.Controllers;
[Route("api/[controller]")]
[ApiController]
public class NotificationsController(TravelAgentDbContext context) : ControllerBase
{
    [HttpPost]
    public ActionResult FlightChanged(FlightDetailUpdateDto flightDetailUpdateDto)
    {
        Console.WriteLine($"Webhook Receieved from: {flightDetailUpdateDto.Publisher}");

        var secretModel = context.SubscriptionSecrets.FirstOrDefault(s => 
            s.Publisher == flightDetailUpdateDto.Publisher && 
            s.Secret == flightDetailUpdateDto.Secret);
 
        if (secretModel == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Secret - Ignore Webwook");
            Console.ResetColor();
            return Ok();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valid Webhook!");
            Console.WriteLine($"Old Price {flightDetailUpdateDto.OldPrice}, New Price {flightDetailUpdateDto.NewPrice}");
            Console.ResetColor();
            return Ok();
        }
    }
        

}