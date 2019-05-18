using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sharedlib
{
  public  interface Ipaperservice
    {
     
      int addpaper(papershare P);
    
      void deletepaper(int PapId);

      void modifaypaper(papershare modfipaper);
   
      papershare retrivepaper(int PapId);

      papershare[] retrivepaper(string PapTitle);
   

   

      ValidationResult validate(papershare P);

      

    }
}
