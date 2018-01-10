﻿using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{


    public class BusinessEmployee
    {
        private IEmployeeRepository employeeRepository;

        public BusinessEmployee(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;

        }

        public Employee Login()
        {
            List<Employee> lista = this.employeeRepository.GetAllEmployees();

            Employee e = new Employee();

            e = lista.First();
            return e;
        }

        

    }
}
