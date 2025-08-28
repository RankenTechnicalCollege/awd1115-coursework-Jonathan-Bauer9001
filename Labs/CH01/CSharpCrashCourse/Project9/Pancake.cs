using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    public class Pancake : ITurnable 
    {
        public string Turn()
        {
            return "Pancake - with flat part of spatula under pancake, rotate over";
        }
      
    }
}
