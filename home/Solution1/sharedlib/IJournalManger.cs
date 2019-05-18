using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedlib
{
    public interface IJournalManger
    {

        #region Main Methods

        int save(Journalshared current);


        void delete(int id);

        void modifaypaper(Journalshared current);

     
        Journalshared getById(int id);





        #endregion
    }
}
