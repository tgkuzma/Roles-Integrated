﻿using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Role> Roles { get; set; }
    }
}
