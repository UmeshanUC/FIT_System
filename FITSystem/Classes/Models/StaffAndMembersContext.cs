using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITSystem.Classes
{
    public class StaffAndMembersContext
    {
        public DetailCard MedicalOfficersCard { get; set; }
        public DetailCard TrainersCard { get; set; }
        public DetailCard MembersCard { get; set; }
        public DetailCard OtherStaffCard { get; set; }

    }
}
