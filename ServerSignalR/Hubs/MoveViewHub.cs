using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSignalR.Hubs
{
    public class MoveViewHub: Hub
    {

        public async Task MoveViewFromServer(String message)
        {
            Console.WriteLine(message);
            await Clients.All.SendAsync("RecieveNewMessage", message);

        }


    }
}
