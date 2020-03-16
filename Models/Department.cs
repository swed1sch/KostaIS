using System;
using System.Collections.Generic;


namespace KostaIS.Models
{
    public class Department
    {
        
        public Guid ID { get; set; }
        public List<Empoyee> Employers { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
