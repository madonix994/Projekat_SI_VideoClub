using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {



        public List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();

            SqlConnection dataConnection = new SqlConnection(); // inicijalizacija konekcije ka bazi podataka

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT * FROM Employees"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Employee e = new Employee();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                e.GetSetId_Employee1 = dataReader.GetInt32(0);
                e.GetSetEmployee_Name1 = dataReader.GetString(1);
                e.GetSetEmployee_Surname1 = dataReader.GetString(2);
                e.GetSetEmployee_Username1 = dataReader.GetString(3);
                e.GetSetEmployee_Password1 = dataReader.GetString(4);

                listEmployees.Add(e); // svaki student se na kraju može ubaciti u neku listu
            }

            dataConnection.Close(); 

            return listEmployees;
        }












    }
}
