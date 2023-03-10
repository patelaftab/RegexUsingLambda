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
            userRegisterLambda.CheckLastNmae("Patel");
            userRegisterLambda.CheckEmail("abc.xyz@bl.co.in");
            userRegisterLambda.CheckPhoneNumber("91 9113873015");
            userRegisterLambda.CheckPasswordPattern1("aftabpatel");
            userRegisterLambda.CheckPasswordPattern2("Aftabpatel");
            userRegisterLambda.CheckPasswordPattern3("Aftabpatel1");
            userRegisterLambda.CheckPasswordPattern4("Aftabpatel@1");
            Console.ReadLine();
        }
    }
}
