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
                Console.WriteLine("It is A Valid Pattern");
            }
            else
            {
                Console.WriteLine("Not a VAlid Pattern");
            }
        }
    }
}
