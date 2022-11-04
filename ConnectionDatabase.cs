using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recall
{
    public class conection_database
    {
        public async Task<NpgsqlConnection> GetConnection ()
        {
            var connString = "";
            await using var conn = new NpgsqlConnection(connString);
            
            return conn;

        }
    }
}
