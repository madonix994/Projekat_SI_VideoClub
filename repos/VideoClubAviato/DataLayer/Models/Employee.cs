using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class Employee
    {
        private int Id_Employee;
        private string Employee_Name;
        private string Employee_Surname;
        private string Employee_Username;
        private string Employee_Password;

        public Employee() { }

        public Employee(int id_Employee, string employee_Name, string employee_Surname, string employee_Username, string employee_Password)
        {
            Id_Employee = id_Employee;
            Employee_Name = employee_Name;
            Employee_Surname = employee_Surname;
            Employee_Username = employee_Username;
            Employee_Password = employee_Password;
        }

        public int GetSetId_Employee1 { get => Id_Employee; set => Id_Employee = value; }
        public string GetSetEmployee_Name1 { get => Employee_Name; set => Employee_Name = value; }
        public string GetSetEmployee_Surname1 { get => Employee_Surname; set => Employee_Surname = value; }
        public string GetSetEmployee_Username1 { get => Employee_Username; set => Employee_Username = value; }
        public string GetSetEmployee_Password1 { get => Employee_Password; set => Employee_Password = value; }
    }
}
