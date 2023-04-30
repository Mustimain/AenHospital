using System.Data.SqlClient;

namespace AenHospital.Database
{
    public interface IEfDbContext
    {
        SqlConnection Connection { get; }
        string server_dbname { get; set; }
        string server_name { get; set; }
        string server_pass { get; set; }
        string server_user { get; set; }

        string GetConnectionString();
    }
}