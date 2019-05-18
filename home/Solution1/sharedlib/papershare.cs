using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedlib
{
    [Serializable]
  public  class papershare
    {
        
        private int PaId;
        public int PId
        {
            get { return PaId; }
            set { PaId = value; }
        }


        private string PaTitle;

        public string PTitle
        {
            get { return PaTitle; }
            set { PaTitle = value; }
        }

        private int PaNofauthers;


        public int PNofauthers
        {
            get { return PaNofauthers; }
            set { PaNofauthers = value; }


        }



        private string Paauther;

        public string Pauther
        {
            get { return Paauther; }
            set { Paauther = value; }


        }

        private string PaJTitle;

        public string JTitle
        {
            get { return PaJTitle; }
            set { PaJTitle = value; }

        }


        private int PaYear;

        public int PYear
        {
            get { return PaYear; }
            set { PaYear = value; }


        }


        private int PaVnumber;

        public int PVnumber
        {
            get { return PaVnumber; }
            set { PaVnumber = value; }

        }


        private int PaInumber;

        public int PInumber
        {
            get { return PaInumber; }
            set { PaInumber = value; }

        }

        private int PaPagesN;

        public int PPagesN
        {

            get { return PaPagesN; }
            set { PaPagesN = value; }

        }

        private int PaPagesF;

        public int PPagesF
        {

            get { return PaPagesF; }
            set { PaPagesF = value; }

        }

        private string PaAbstract;

        public string PAbstract
        {
            get { return PaAbstract; }
            set { PaAbstract = value; }

        }


        private string PaKeywords;

        public string PKeywords
        {
            get { return PaKeywords; }
            set { PaKeywords = value; }


        }

        public int Papersherdid
        {
            get { return PId  ; }

        }

 


     
    }
}
