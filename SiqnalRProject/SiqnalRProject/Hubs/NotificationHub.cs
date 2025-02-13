using Microsoft.AspNetCore.SignalR;

namespace SiqnalRProject.Hubs
{
    public class NotificationHub :Hub
    {
        public async Task SendNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }
    }
}
