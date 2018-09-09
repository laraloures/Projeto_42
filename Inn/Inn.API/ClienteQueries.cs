using Projeto_42.Ordering.Ordering.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Inn.Inn.API
{
    public class ClienteQueries : Queries<Cliente>
    {
        public string connectionString { get; set; }

        public ClienteQueries()
        {
            connectionString = "Data Source=SqlCe_W3Schools.sdf";
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void insert()
        {
            throw new NotImplementedException();
        }

        public Cliente selectAll()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTES", connection);
                //cmd.Parameters.AddWithValue("@pricePoint", paramValue); -> o @pricePoint fica no sql para mostrar que vai ter um parametro ali
                SqlDataReader reader = cmd.ExecuteReader();
            }
        }

        public void updade()
        {
            throw new NotImplementedException();
        }
    }
}
