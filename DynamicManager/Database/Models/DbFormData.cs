using DynamicManager.Database.Models.Base;
using System;

namespace DynamicManager.Database.Models
{
    public class DbFormData : DbBaseTable
    {
        public virtual int? IntValue { get; set; }
        public virtual string StringValue { get; set; }
        public virtual double? DecimalValue { get; set; }
        public virtual DateTime? DateTimeValue { get; set; }
        public virtual DbFormField FormField { get; set; }
        public virtual DbForm Form { get; set; }
    }
}
