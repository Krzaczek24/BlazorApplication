﻿using DynamicForms.Database.Models.Base;
using System.Collections.Generic;

namespace DynamicForms.Database.Models
{
    public class DbForm : DbBaseTable
    {
        public virtual DbFormTemplate FormTemplate { get; set; }
        public virtual ICollection<DbFormData> FormData { get; set; }
    }
}
