using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using zombie_hospital_suggustion_backend.Models;

namespace zombie_hospital_suggustion_backend
{
    public class SqliteDataAccess
    {

        // insert data into database
        public static void InsertUserData(UserData userData)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./ZombieHospitalRecommandDB.db";
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var insertCommand = connection.CreateCommand();
                    
                    insertCommand.CommandText = "INSERT INTO Illnessess(Name, Illness) VALUES ($Name, $Illness)";
                    insertCommand.Parameters.AddWithValue("$Name", userData.name);
                    insertCommand.Parameters.AddWithValue("$Illness", userData.illness);

                    insertCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
        }
    }
}
