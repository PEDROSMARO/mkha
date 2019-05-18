using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedlib
{

    [Serializable]
    public class ValidationResult
    {
       
        public ValidationResult(bool ok, string msg)
        {
            Console.WriteLine(" valdetion build ");
            this.Ok = ok;
            this.Msg = msg;



        }
        public bool Ok;
        public string Msg;

    }
}
