using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SiqnalRProject.Data;
using SiqnalRProject.Hubs;
using SiqnalRProject.Model;

namespace SiqnalRProject.Service
{
    public class NotificationService
    {
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly AppDbContext _context;

        public NotificationService(IHubContext<NotificationHub> hubContext, AppDbContext context)
        {
            _hubContext = hubContext;
            _context = context;
        }

        public async Task SendNotificationToClients(string message)
        {
            
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", message);
            var notification = new Notification { Message = message };
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Notification>> GetNotificationsAsync()
        {
            return await _context.Notifications.ToListAsync();
        }
    }
}
