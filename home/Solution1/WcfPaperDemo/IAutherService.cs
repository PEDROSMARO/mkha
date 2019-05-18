using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WcfPaperDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAutherService
    {
        

       
      
// منجيب كل الورقات
        [OperationContract]
        List<Paper> Getpapers(string auther);
       
        
        // منحسب السكور للمؤلف

        [OperationContract]
         int scorepapersbyyear(string auther);

        [OperationContract]
       int scorepapersbyorder(string authername);
        [OperationContract]
        int scorepapersbyjournalclass(string authername);

        [OperationContract]
        int countpaper(string authername);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfPaperDemo.ContractType".
    [DataContract]
    public class CompositeType
    {


        [DataMember]
        public string auther { get; set; }

         [DataMember]
        public int score1 { get; set; }
      
    }

}
