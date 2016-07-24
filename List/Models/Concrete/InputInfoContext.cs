using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using List.Models.Entities;

namespace List.Models.Concrete {
    public class InputInfoContext : DbContext {
        public DbSet<InputInfo> InputInfoes { get; set; }
    }
}