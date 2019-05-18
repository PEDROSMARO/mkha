using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedlib
{
    [Serializable]
  public  class Journalshared
    {
        private int JaId;
        public int JId
        {
            get { return JaId; }
            set { JaId = value; }
        }


        private string Jatitle;
        public string Jtitle
        {
            get { return Jatitle; }
            set { Jatitle = value; }
        }


        private string Jacity;
        public string Jcity
        {
            get { return Jacity; }
            set { Jacity = value; }
        }

        private string Jasub;
        public string Jsub
        {
            get { return Jasub; }
            set { Jasub = value; }
        }

        private int Jaclass;
        public int Jclass
        {
            get { return Jaclass; }
            set { Jaclass = value; }
        }
    }
}
