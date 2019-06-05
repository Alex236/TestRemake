using System;
namespace TestRemakeServer.DbModels
{
    public class ClockProfile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FaceColor { get; set; }
        public string HandsColor { get; set; }
        public string Timezone { get; set; }
    }
}
