using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QBankingSystem.Models.Transfers
{
    public abstract class Transfer : ITransfer
    {
        public abstract TransferResult ExecuteTransfer(string connectionString, string insertQuery, SqlParameter[] parameters);

        protected void ExecuteSqlCommand(string connectionString, string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
