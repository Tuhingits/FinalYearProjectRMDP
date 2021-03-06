﻿using MemberShip.Entities;
using MemberShip.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Models
{
    public class DonateMedicine
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Quantity { get; set; }
        public string DonarId { get; set; }
        public string OrgMail { get; set; }
        public string ExecutiveMail { get; set; }

    }
}
