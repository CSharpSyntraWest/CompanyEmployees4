﻿using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class EmployeeRepository:RepositoryBase<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Employee> GetAllEmployees(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(e => e.Age).ToList();
        }
    }
}
