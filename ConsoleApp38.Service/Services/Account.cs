using ConsoleApp38.Service.Constantlar;
using ConsoleApp38.Service.Helpers;
using ConsoleApp38.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38.Service.Services
{
    public class Account : IAccount
    {
       
        public void AccountRoleAndLoginChecker(string email, string password, Roles role)
        {
            if(email == "demo@mode.eduz.az"&&password=="lorem12345"&&role==Roles.SuperAdmin) {

                Console.WriteLine(ErrorDetector.AcceptedMessage);
            }
            else
            {
                Console.WriteLine(ErrorDetector.LoginError);
            }
        }
    }
}
