using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Register_DAO:Base
    {
        public List<Register> Db_Get_All_Register()
        {
            string query = "SELECT *" +
                            "FROM Register";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Register> ReadTable(DataTable dataTable)
        {
            List<Register> registered = new List<Register>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Register registration = new Register()
                {
                    Name = (String)(dr["Name"].ToString()),
                    Email = (String)(dr["Email_Address"].ToString()),
                    Password = (String)(dr["Password"].ToString()),
                };
                registered.Add(registration);
            }
            return registered;
        }
    }
}
