using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserREgistrationUsingLamda
{
    public class ModelUserClass
    {
        public Regex firstName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex lastName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex Email = new Regex(@"^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$");
        public Regex PhoneNumber = new Regex(@"[0-9]{1,2}[ ][0-9]{10}");
        
    }
}
