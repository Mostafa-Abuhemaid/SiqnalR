using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SiqnalRProject.Hubs;
using SiqnalRProject.Service;

namespace SiqnalRProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationService _notificationService;
        public NotificationController(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] string message)
        {
            await _notificationService.SendNotificationToClients ( message);
            return Ok("sent successfully");
        }
        [HttpGet("GatAllNotifications")]
        public async Task<IActionResult>GetAllNotifications()
        {
            var Not=await _notificationService.GetNotificationsAsync();
            return Ok(Not);
        }

    }
}
