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
        
    }
}
