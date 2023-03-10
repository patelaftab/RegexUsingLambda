using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserREgistrationUsingLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegisterLambda userRegisterLambda = new UserRegisterLambda();
            userRegisterLambda.CheckFirstNmae("Aftab");
            Console.ReadLine();
        }
    }
}
