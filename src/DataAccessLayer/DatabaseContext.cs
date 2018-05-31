using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Entities;
using DataAccessLayer.StoredProcedures;

namespace DataAccessLayer
{
    public class DatabaseContext
    {
        private const string ConnectionName = "DatabaseConnection";

        public List<Product> GetProducts(string warehouse = null, string category = null)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
            using (var sqlConnection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(StoredProceduresNames.GetProducts, sqlConnection)
                                     {
                                         CommandType = CommandType.StoredProcedure
                                     })
            {
                sqlConnection.Open();

                command.Parameters.Add("@Warehouse", SqlDbType.VarChar);
                command.Parameters["@Warehouse"].Value = warehouse;
                command.Parameters.Add("@Category", SqlDbType.VarChar);
                command.Parameters["@Category"].Value = category;

                using (var reader = command.ExecuteReader())
                {
                    var products = new List<Product>();
                    while (reader.Read())
                    {
                        var product = new Product()
                                          {
                                              Id =  Guid.Parse(reader[0].ToString()),
                                              Name = reader[1].ToString(),
                                              ProductCategory = new Category()
                                                                    {
                                                                        Id = Guid.Parse(reader[2].ToString()), 
                                                                        Name = reader[3].ToString()
                                                                        
                                                                    },
                                              Stocks = new List<Stock>() { new Stock()
                                                                               {
                                                                                   Price = float.Parse(reader[4].ToString()),
                                                                                   Quantity = int.Parse(reader[5].ToString())
                                                                               } }
                                          };
                        products.Add(product);
                    }
                    return products;
                }
            }// dispose will close the connection
                
        }
    }
}
