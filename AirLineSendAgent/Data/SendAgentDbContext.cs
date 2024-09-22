using AirLineSendAgent.Models;
using Microsoft.EntityFrameworkCore;

namespace AirLineSendAgent.Data;

public class SendAgentDbContext : DbContext
{
    public SendAgentDbContext(DbContextOptions<SendAgentDbContext> opt) :base(opt)
    {
            
    }

    public DbSet<WebhookSubscription> WebhookSubscriptions { get; set; }
}