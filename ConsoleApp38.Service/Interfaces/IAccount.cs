using ConsoleApp38.Service.Constantlar;
using ConsoleApp38.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38.Service.Interfaces
{
    public interface IAccount
    {
        public void AccountRoleAndLoginChecker(string email,string password,Roles role);
       
    }
}
