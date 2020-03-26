using System;

namespace KostaIS.Models
{
    public class Empoyee
    {
        
        public decimal ID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        public string Position { get; set; }
        public Guid DepartmentID { get; set; }

    }
}
