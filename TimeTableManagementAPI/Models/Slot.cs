﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTableManagementAPI.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public TimeSpan Start_Time { get; set; }
        public TimeSpan End_Time { get; set; }
        public string Period_No { get; set; }
        public int Time_Table_Id { get; set; }
        public int Resource_Id { get; set; }
        public int Teacher_Id { get; set; }
        public int Subject_Id { get; set; }
    }
}
