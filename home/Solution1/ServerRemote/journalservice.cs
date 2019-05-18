using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharedlib;

namespace ServerRemote
{
    class journalservice : MarshalByRefObject , IJournalManger
    {
        public void delete(int id)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                journal jou = db.journals.SingleOrDefault(x => x.jouID == id);
                db.journals.DeleteOnSubmit(jou);
                db.SubmitChanges();

                Console.WriteLine("Delete Journal IS EXECUTE ......" + DateTime.Now);

            }
        }

    

    


        public Journalshared getById(int id)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                journal jou = db.journals.SingleOrDefault(x => x.jouID == id);

                Journalshared ps = new Journalshared();


                    ps.Jtitle = jou.journalTitle;
                    ps.Jcity = jou.joucity;
                    ps.Jclass = jou.jouclass;
                    ps.Jsub = jou.jousubject;


                    Console.WriteLine("Retrive Journal IS EXECUTE ......" + DateTime.Now);
                   return ps;
                
                   
             }


               
           
        }



        public int save(Journalshared current)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                journal jou = new journal
                {
                    journalTitle = current.Jtitle,
                   jouclass = current.Jclass,
                    joucity = current.Jcity,
                    jousubject = current.Jsub
                 
                };
                db.journals.InsertOnSubmit(jou);
                db.SubmitChanges();
                Console.WriteLine(" ADD Journal IS EXECUTE ......" + DateTime.Now);
                return jou.jouID;
            }
        }


        public void modifaypaper(Journalshared current)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                journal jou = db.journals.SingleOrDefault(x => x.jouID == current.JId);

                jou.joucity = current.Jcity;
                jou.journalTitle = current.Jtitle;
                jou.jousubject = current.Jsub;
                jou.jouclass = current.Jclass;


                db.SubmitChanges();

                Console.WriteLine("Modifay Journal IS EXECUTE ......" + DateTime.Now);

            }
        }

     
    }
}
