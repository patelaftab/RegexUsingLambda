﻿using System;
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
            userRegisterLambda.CheckEmail("91 9113873015");
            Console.ReadLine();
        }
    }
}
