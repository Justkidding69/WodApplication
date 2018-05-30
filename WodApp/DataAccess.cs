using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace WodApp
{
    public class DataAccess
    {
        public List<Random> GetRandoms(string ExerciseEquipment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WodDB")))
            {
                var output = connection.Query<Random>($"select * from Exercise where ExerciseEquipment = '{ ExerciseEquipment } '").ToList();
                return output;
            }
        }
    }
}
