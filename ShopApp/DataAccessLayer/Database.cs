using ShopApp.Enitites;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer
{
    public class Database : IDisposable
    {
        private string _conntectionString;
        private SqlConnection _sqlConnection;
        public Database(string databaseName)
        {
            _conntectionString = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString; ;
            _sqlConnection = new SqlConnection(_conntectionString);
        }

        public void Dispose()
        {
            _sqlConnection.Close();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                _sqlConnection.Open();
                string query = "SELECT ID, Name, Price FROM Product";
                using (SqlCommand command = new SqlCommand(query, _sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ID = Convert.ToInt32(reader["ID"].ToString()),
                                Name = reader["Name"].ToString(),
                                Price = Convert.ToInt32(reader["Price"].ToString())                              
                            };

                            products.Add(product);
                        }
                    }
                }
            }
            catch (SqlException exp)
            {
                throw exp;
            }

            return products;
        }
        
    }
}
