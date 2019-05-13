using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSignalR.Hubs
{
    public class MoveViewHub : Hub
    {
        public async Task MoveViewFromServer(string id, string sensor, string value)
        {
            Console.WriteLine("Receive:  ID -> |" + id + "|  Sensor: |" + sensor +"| Value: |" + value +"|");
            //double dX = 0.6f;
            //float dY = 0.0f;
            //string tS = "teeeest";

            await Clients.Others.SendAsync("ReceiveNewPositions", id, sensor, value);
            //await Clients.Others.SendAsync("ReceiveNewPositions",dX);
        }

    }
}
