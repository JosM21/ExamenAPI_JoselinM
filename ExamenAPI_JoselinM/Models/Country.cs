﻿using System;
using System.Collections.Generic;

namespace ExamenAPI_JoselinM.Models
{
    public partial class Country
    {
        public Country()
        {
            Users = new HashSet<User>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
