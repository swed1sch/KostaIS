﻿using System;
using System.Linq;

namespace KostaIS.Models
{
    public interface IDepartment
    {
        IQueryable<Department> Departments { get; }
        void DeleteDepartment(Department department);
        void AddDepartment(Department department);
        Department GetDepartment(Guid key);
        void UpdateDepartment(Department department);
    }
}
