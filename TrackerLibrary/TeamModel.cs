﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
