using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Homework1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string password(string firstName, string lastName, int age)
        {
            int moddedAge = age % 5;
            string newAge = moddedAge.ToString();
            string pass = lastName.Substring(0, 2) + firstName.Substring(firstName.Length - 2, 2) + newAge;

            return pass;
        }

        public int loginId(int age)
        {
            Random r = new Random();

            return age * r.Next(100, 200);
        }
    }
}
