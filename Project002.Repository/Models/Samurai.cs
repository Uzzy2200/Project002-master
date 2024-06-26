﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Project002.Repository.Models
{   /// <summary>
/// 1) Create Models
/// 2) Install Packages 
/// 3) Create DatabaseContext class
/// 4) Program.cs add our Database service and connection string
/// 5) Go to console => add-migration name
/// 6) Go to console => database-update
/// 7) Dependency injection activation
/// 8) Done
/// 
/// /// /// </summary>
    public class Samurai
    {
        //Entity Framework works with PK...... Id or ClassName+Id
        public int SamuraiId { get; set; }
        public string SamuraiName { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }
        [JsonIgnore]
        public Clan? Clan { get; set; } // Navigation property
        [JsonIgnore]
        public Rank? Rank { get; set; }
        [JsonIgnore]
        public List<War>? War { get; set; }
        [JsonIgnore]
        public List<Armour>? Armour { get; set; }
        [JsonIgnore]
        public List<Clothing>? Clothing { get; set; }
        [JsonIgnore]
        public List<Horse>? Horse { get; set; }
        [JsonIgnore]
        public List<Weapon>? Weapon { get; set; }




    }
}

