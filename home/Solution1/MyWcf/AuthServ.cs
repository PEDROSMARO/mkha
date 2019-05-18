using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AuthServ : IAuthServ
    {

        public List<Paper> Getpapers(string auther)
        {

            var db = new PaperindexDataClassDataContext();

            return (from pap in db.Papers where pap.Authers == auther select pap).ToList();
        }
    }
}
