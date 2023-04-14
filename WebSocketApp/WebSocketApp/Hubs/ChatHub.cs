using Microsoft.AspNetCore.SignalR;

namespace WebSocketApp.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendAllMessageAsync(string user,string message)
        {
          await  Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendGroupMessageAsync(string user,string group, string message)
        {
            await Clients.Group(group).SendAsync("GroupMessage", user, message);
        }
        public async Task AddGroupAsync(string group)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, group);
        }
        public async Task RemoveGroupAsync(string group)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, group);

        }
    }
}
