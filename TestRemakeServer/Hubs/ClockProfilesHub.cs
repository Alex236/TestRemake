using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Linq;


namespace TestRemakeServer.Hubs
{
    public class ClockProfilesHub : Hub
    {
        ClockProilesContext clockProilesContext;

        public ClockProfilesHub(ClockProilesContext clockProilesContext)
        {
            this.clockProilesContext = clockProilesContext;
        }

        public async Task GetAllProfiles()
        {
            await Clients.All.SendAsync("Response", JsonConvert.SerializeObject(clockProilesContext.ClockProiles.ToList()));
        }
    }
}
