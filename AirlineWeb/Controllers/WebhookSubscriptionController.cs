using AirlineWeb.Data;
using AirlineWeb.Dtos;
using AirlineWeb.Models;
using AirlineWeb.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirlineWeb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WebhookSubscriptionController(AirlineDbContext context, IMapper mapper) : ControllerBase
{
    [HttpGet("{secret}", Name = "get-subscription-by-secret")]
    public async Task<ActionResult<WebhookSubscriptionReadDto>> GetSubscriptionBySecret(string secret)
    {
        var subscription =
            await context.WebhookSubscriptions.FirstOrDefaultAsync(x =>
                x.Secret == secret);
        if (subscription is null)
            return NotFound();

        var webhookSubscriptionReadDto = mapper.Map<WebhookSubscriptionReadDto>(subscription);
        return (webhookSubscriptionReadDto);
    }

    [HttpPost]
    public async Task<ActionResult<WebhookSubscriptionReadDto>> CreateSubscription(
        [FromBody] WebhookSubscriptionCreateDto webhookSubscriptionDto)
    {
        var subscription =
            await context.WebhookSubscriptions.FirstOrDefaultAsync(x =>
                x.WebhookType == webhookSubscriptionDto.WebhookType);
        if (subscription is null)
        {
            subscription = mapper.Map<WebhookSubscription>(webhookSubscriptionDto);
            subscription.Secret = Guid.NewGuid().ToString();
            subscription.WebhookPublisher = AirlineWebConsts.WebhookPublisher;
            await context.WebhookSubscriptions.AddAsync(subscription);
            await context.SaveChangesAsync();

            var webhookSubscriptionReadDto = mapper.Map<WebhookSubscriptionReadDto>(subscription);
            return Ok(webhookSubscriptionReadDto);
        }
        else
        {
            return NoContent();
        }
    }
}