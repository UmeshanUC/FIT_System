using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Classes.Models
{
    interface IDetailCard
    {
        string CardName { get; set; }
        string Avatar { get; set; }
        int TotalEmployed { get; set; }
        int TodayOnWork { get; set; }
        int Other { get; set; }
    }
}
