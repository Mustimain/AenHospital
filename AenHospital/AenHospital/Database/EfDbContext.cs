using AenHospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;

namespace AenHospital.Database
{
    public class EfDbContext : IEfDbContext
    {

        public EfDbContext()
        {
        }

        public string server_name { get; set; }
        public string server_user { get; set; }
        public string server_pass { get; set; }
        public string server_dbname { get; set; }

        private SqlConnection sqlConnection;

        public string GetConnectionString()
        {
            if (string.IsNullOrEmpty(server_name) || string.IsNullOrEmpty(server_dbname) || string.IsNullOrEmpty(server_user) || string.IsNullOrEmpty(server_pass))
            {
                return "error";
            }

            string serverString = $"Server={server_name}; Database={server_dbname};User Id={server_user};Password = {server_pass};";

            return serverString;
        }


        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(GetConnectionString());
            }
        }


    }
}
