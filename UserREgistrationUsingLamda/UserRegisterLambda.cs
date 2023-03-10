using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserREgistrationUsingLamda
{
    public class UserRegisterLambda
    {
        List<ModelUserClass> modelClasses = new List<ModelUserClass>();
        public UserRegisterLambda()
        {
            ModelUserClass modelUserClass = new ModelUserClass();
            modelClasses.Add(modelUserClass);
        }
        public void CheckFirstNmae(string firstname)
        {
            if (modelClasses.Any(x => x.firstName.IsMatch(firstname)))
            {
                Console.WriteLine("Pattern For First Name Is Valid");
            }
            else
            {
                Console.WriteLine("Not a VAlid Pattern");
            }
        }
        public void CheckLastNmae(string lastname)
        {
            if (modelClasses.Any(x => x.lastName.IsMatch(lastname)))
            {
                Console.WriteLine("Pattern For Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Not a VAlid Pattern");
            }
        }
        public void CheckEmail(string email)
        {
            if (modelClasses.Any(x => x.Email.IsMatch(email)))
            {
                Console.WriteLine("Regex Pattern For Email is Valid");
            }
            else
            {
                Console.WriteLine("Not a Valid Pattern");
            }
        }
       
    }
}
