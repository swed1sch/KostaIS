﻿
using System.Linq;

namespace KostaIS.Models
{
    public interface IEmploye
    {
        void AddEmploye(Empoyee employe);
        void DeleteEmploye(Empoyee employe);
        IQueryable<Empoyee> Employers { get; }
    }
}
