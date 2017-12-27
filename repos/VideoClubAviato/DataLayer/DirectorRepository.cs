using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DirectorRepository
    {

        public List<Director> SelectAllDirectors()
        {
            List<Director> lista = new List<Director>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT * FROM Directors";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Director d = new Director();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                d.GetSetId_Director1 = dataReader.GetInt32(0);
                d.GetSetDirector_Name1 = dataReader.GetString(1);
                d.GetSetDirector_Surname1 = dataReader.GetString(2);
                d.GetSetDirector_Date_Of_Birth1 = dataReader.GetDateTime(3);
                d.GetSetDirector_Oscar1 = dataReader.GetBoolean(4);

                lista.Add(d); // svaki student se na kraju može ubaciti u neku listu
            }

            dataConnection.Close();
            return lista;
        }

    }
}
