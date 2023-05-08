using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    class DB_Connection
    {
        public static SqlConnection connection = new SqlConnection("Data Source=INDUS-PC\\SQLEXPRESS;Initial Catalog=Voting;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}
