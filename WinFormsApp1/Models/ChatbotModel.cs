using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1.Models
{
    public class ChatbotModel
    {
        private readonly string _connectionString;

        public ChatbotModel(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<string> GetContractsDueSoon()
        {
            var contracts = new List<string>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetContractsDueSoon", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("Ngaytra")))
                        {
                            DateTime ngayTra = Convert.ToDateTime(reader["Ngaytra"]);
                            string contractInfo = $"Mã hợp đồng: {reader["Mahopdong"]}, " +
                                                  $"Trạng thái: {reader["Trangthai"]}, " +
                                                  $"Ngày hết hạn: {ngayTra:dd/MM/yyyy}";
                            contracts.Add(contractInfo);
                        }
                    }
                }
            }

            return contracts;
        }
    }
}
