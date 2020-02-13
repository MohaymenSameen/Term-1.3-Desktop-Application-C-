using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Register_Service
    {
        Register_DAO register_db = new Register_DAO();

        public List<Register> GetRegisters()
        {
            try
            {
                List<Register> register = register_db.Db_Get_All_Register();
                return register;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
