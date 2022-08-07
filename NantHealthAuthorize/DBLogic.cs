using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCr = BCrypt.Net;
using Npgsql;
using NantHealthAuthorize.Models;

namespace NantHealthAuthorize
{
    internal class DBLogic : IDBLogic
    {
        string connectionString = "Host=openmediavault.local:5432;Username=postgres;Password=Br1Fud&pophocr8d&zlswinu*l2ra;Database=HumanResources";
        public bool authenticate(string username, string password)
        {
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            var sql = "SELECT password FROM \"UserAuthentication\" WHERE username = @username";
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("username", username);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();
            var passwordHash = "";
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    passwordHash = rdr.GetString(0);
                }
                return BCr.BCrypt.Verify(password, passwordHash);
            }
            else {
                return false;
            }
        }
        public User? GetUser(string? username) {
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            var sql = "SELECT id,username,password FROM \"UserAuthentication\" WHERE username = @username";
            using var cmd = new NpgsqlCommand(sql, con);
            if(username != null)
                cmd.Parameters.AddWithValue("username", username.ToLower());
            using NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {      
                    User user = new User();
                    user.id = rdr.GetGuid(0);
                    user.username = rdr.GetString(1);
                    user.password = rdr.GetString(2);
                    return user;
                }
            }
            return null;
        }


    }
}
