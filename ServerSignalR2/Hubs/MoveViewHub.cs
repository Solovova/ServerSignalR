using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSignalR.Hubs
{
    public class MoveViewHub : Hub
    {
        public async Task SensorIndicatorChangeValueFromSensor(string strJSON)
        {
            Console.WriteLine("Change value from sensor:  " + strJSON);
            await Clients.Others.SendAsync("SensorIndicatorChangeValueToApp", strJSON);
        }

        public async Task RequestStartSensorDataFromApp(string strJSON)
        {
            Console.WriteLine("Request from app:  " + strJSON);
            await Clients.Others.SendAsync("RequestStartSensorDataToSensor", strJSON);
        }

        public async Task AnswerStartSensorDataFromSensor(string strJSON)
        {
            Console.WriteLine("Ansver from sensor:  " + strJSON);
            await Clients.Others.SendAsync("AnswerStartSensorDataToApp", strJSON);
        }

    }
}
