using CodeOrginizer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOrginizer.Entities
{
    public class Job
    {
        public string CompanyName { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }

    }
}
