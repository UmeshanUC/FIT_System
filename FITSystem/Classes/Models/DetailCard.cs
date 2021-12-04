using FITSystem.Classes.Models;

namespace FITSystem.Classes
{
    public class DetailCard : IDetailCard
    {
        public string CardName { get; set; }
        public string Avatar { get; set; }
        public int TotalEmployed { get; set; }
        public int TodayOnWork { get; set; }
        public int TotalOther { get; set; }
    }
}