﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
    public class Admin 
    {
        [Key]
        public int ID { get; set; }
        public string Admin_Name { get; set; }

        public string Password { get; set; }

    }
}
