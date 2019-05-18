using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcf
{
   
    [ServiceContract]
    public interface IAuthServ
    {
        [OperationContract]
        List<Paper> Getpapers(string auther);

     
       

      
    }


 
    }

