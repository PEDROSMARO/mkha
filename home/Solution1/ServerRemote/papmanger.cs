using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharedlib;
using System.Data;
using System.Collections;

namespace ServerRemote
{
 public   class papmanger : MarshalByRefObject , Ipaperservice 
    {


     //  طريقة التحقق من ورقة
     public ValidationResult validate(papershare P)
     {
         using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
         {
             journal J = db.journals.SingleOrDefault(ob => ob.journalTitle == P.JTitle);
             

              if ((P.JTitle.Length == 0) && (J == null))
             {
                 return new ValidationResult(false, "Paper Journal Tilte is Missing Or Not Nested");

             }

             if ((P.PTitle == null) && (P.PTitle.Length == 0))
             {
                 return new ValidationResult(false, "Paper Tilte is Missing");

             }

             if ((P.PKeywords == null) && (P.PKeywords.Length == 0))
             {
                 return new ValidationResult(false, "Keywords is Missing");

             }
             if ((P.PAbstract == null) && (P.PAbstract.Length == 0))
             {
                 return new ValidationResult(false, "Abstract is Missing");

             }

             if ((P.Pauther == null) && (P.Pauther.Length == 0))
             {
                 return new ValidationResult(false, "Authers is Missing");

             }

        



             if ((P.JTitle == null) && (P.JTitle.Length == 0))
             {
                 return new ValidationResult(false, "Journal Tilte is Missing");

             }

             if (P.PYear > 2016)
             {

                 return new ValidationResult(false, "Year of Paper more than this Year");


             }

             if (P.PYear < 1940)
             {

                 return new ValidationResult(false, "Year of Paper old than 1940");


             }

         

        




             if (P.PVnumber <= 0)
             {

                 return new ValidationResult(false, "Volume Number must be positive");


             }

             if (P.PInumber <= 0)
             {

                 return new ValidationResult(false, "Issue Number must be positive");


             }



          


             if (P.PPagesF <= P.PPagesN)
             {
                 return new ValidationResult(false, "The Last page of paper must be greater than Start page ");

             }

             int s = P.PPagesF - P.PPagesN;
             if (s >= 45)
             {
                 return new ValidationResult(false, "The Last page of paper must be greater than Start page less 45 P ");

             }


             return new ValidationResult(true, " Validation Succeeded");

         }

     }

     //        طريقة اضافة ورقة

        public int addpaper(papershare P)

        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
               
             
         
                Paper papr = new Paper
                {
                    papTitle= P.PTitle,
                    @abstract = P.PAbstract,
                    jouTitle = P.JTitle,
                    Keywords = P.PKeywords,
                    volumenumber = P.PVnumber,
                    issunumber = P.PInumber,
                    Yearofpub = P.PYear,
                    Authers = P.Pauther,
                    FirstPagePaper = P.PPagesN,
                   LastpagePaper = P.PPagesF,
                    NumoFAuther = P.PNofauthers
                };
                db.Papers.InsertOnSubmit(papr);
                db.SubmitChanges();
                Console.WriteLine(" ADD PAPER IS EXECUTE ......" + DateTime.Now);
                return papr.paperId;
            }


        }



     //     طريقة حذف ورقة 
        public void deletepaper(int PapId)
        {

            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                Paper papr = db.Papers.SingleOrDefault(x => x.paperId == PapId);
                db.Papers.DeleteOnSubmit(papr);
                db.SubmitChanges();

                Console.WriteLine("Delete PAPER IS EXECUTE ......" + DateTime.Now);

            }
            
        }



     // طريقة تعديل ورقة 

        public void modifaypaper(papershare modfipaper)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                Paper papr = db.Papers.SingleOrDefault(x => x.paperId == modfipaper.PId);

                papr.@abstract = modfipaper.PAbstract;
                papr.Authers = modfipaper.Pauther;
                papr.FirstPagePaper = modfipaper.PPagesN;
                papr.LastpagePaper = modfipaper.PPagesF;
                papr.issunumber = modfipaper.PInumber;
                papr.jouTitle = modfipaper.JTitle;
                papr.Keywords = modfipaper.PKeywords;
                papr.NumoFAuther = modfipaper.PNofauthers;
                papr.papTitle = modfipaper.PTitle;
                papr.volumenumber = modfipaper.PVnumber;
                papr.Yearofpub = modfipaper.PYear;


                db.SubmitChanges();

                Console.WriteLine("Modifay PAPER IS EXECUTE ......" + DateTime.Now);

            }
        }


     // طريقة استرداد ورقة عن طريق العنوان 

        public papershare[] retrivepaper(string PapTitle)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                try
                {
                    return ConvertTopapersharedList(db.Papers.Where(ob => ob.papTitle == PapTitle).ToList());
                }
                catch (Exception)
                {

                    List<papershare> temp = new List<papershare>();
                    return temp.ToArray();
                }
            }
            
        }

        public static papershare[] ConvertTopapersharedList(List<Paper> current)
        {

            List<papershare> temp = new List<papershare>();
            if (current != null)
            {
                foreach (Paper item in current)
                {
                    temp.Add(ConvertTopapershared(item));

                }
            }
            return temp.ToArray();
        }


        public static papershare ConvertTopapershared(Paper current)
        {

            papershare temp = new papershare();
            if (current != null)
            {
                
                    temp.PId = current.paperId;
                    temp.JTitle = current.jouTitle;
                    temp.PAbstract = current.@abstract;
                    temp.Pauther = current.Authers;
                    temp.PInumber = current.issunumber;
                    temp.PKeywords = current.Keywords;
                    temp.PNofauthers = current.NumoFAuther;
                    temp.PPagesF = current.LastpagePaper;
                    temp.PPagesN = current.FirstPagePaper;
                    temp.PTitle = current.papTitle;
                    temp.PVnumber = current.volumenumber;
                    temp.PYear = current.Yearofpub;
                    Console.WriteLine("Retrive PAPER IS EXECUTE ......" + DateTime.Now);
                }
                          
            return temp;

        }

     //          طريقة استرداد ورقة عن طريق الايدي
        public papershare retrivepaper(int PapId)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                Paper papr = db.Papers.SingleOrDefault(x => x.paperId == PapId);

                  papershare ps = new papershare();


                  if (papr != null)
                  {
                      ps.PId = papr.paperId;
                      ps.JTitle = papr.jouTitle;
                      ps.PAbstract = papr.@abstract;
                      ps.Pauther = papr.Authers;
                      ps.PInumber = papr.issunumber;
                      ps.PKeywords = papr.Keywords;
                      ps.PNofauthers = papr.NumoFAuther;
                      ps.PPagesF = papr.LastpagePaper;
                      ps.PPagesN = papr.FirstPagePaper;
                      ps.PTitle = papr.papTitle;
                      ps.PVnumber = papr.volumenumber;
                      ps.PYear = papr.Yearofpub;
                      Console.WriteLine("Retrive PAPER IS EXECUTE ......" + DateTime.Now);
                  }
                  else
                  {

                      ps.JTitle = "No Paper";
                      Console.WriteLine("No paper......");
                  }
               

                return ps;
            }
        }

      

   
        public papershare[] getallpaper(bool nested)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                try
                {
                    return ConvertTopapershared(db.Papers.ToList(),nested);
                }
                catch (Exception)
                {

                    List<papershare> temp = new List<papershare>();
                    return temp.ToArray();
                }


            }

        }

  

        public static papershare ConvertTopapershared(Paper current, bool nested)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                papershare temp = new papershare();
                if (current != null)
                {
                    temp.PId = current.paperId;
                    temp.JTitle = current.jouTitle;
                    temp.PAbstract = current.@abstract;
                    temp.Pauther = current.Authers;
                    temp.PInumber = current.issunumber;
                    temp.PKeywords = current.Keywords;
                    temp.PNofauthers = current.NumoFAuther;
                    temp.PPagesF = current.LastpagePaper;
                    temp.PPagesN = current.FirstPagePaper;
                    temp.PTitle = current.papTitle;
                    temp.PVnumber = current.volumenumber;
                    temp.PYear = current.Yearofpub;
                }
                return temp;
            }
        }


     // تحويل مجموعة من الاوراق الى list
        public static  papershare[] ConvertTopapershared(List<Paper> current, bool nested)
        {
            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                List<papershare> temp = new List<papershare>();
                if (current != null)
                {
                    foreach (Paper item in current)
                    {
                        temp.Add(ConvertTopapershared(item, nested));

                    }
                }
                return temp.ToArray();
            }
        }




        public List<Paper> Getpapers(int papid)
        {
            var db = new PaperindexDataClassDataContext();
            return (from pap in db.Papers where pap.paperId == papid select pap).ToList();
           



        }






  




        public papershare GetpaperbyID(int ID)
        {

            using (PaperindexDataClassDataContext db = new PaperindexDataClassDataContext())
            {
                try
                {
                    return ConvertTopaperShared(db.Papers.Where(x => x.paperId == ID).First());
                }

                catch ( Exception)
                {
                    papershare temp = new papershare();
                    return temp;
                }
          

            }



        }


        public static papershare ConvertTopaperShared(Paper current)
        {

            papershare temp = new papershare();
            if (current != null)
            {
                temp.JTitle = current.jouTitle;
                temp.PAbstract = current.@abstract;
                temp.Pauther = current.Authers;
                temp.PId = current.paperId;
                temp.PInumber = current.issunumber;
                temp.PKeywords = current.Keywords;
                temp.PNofauthers = current.NumoFAuther;
                temp.PPagesF = current.LastpagePaper;
                temp.PPagesN = current.FirstPagePaper;
                temp.PTitle = current.papTitle;
                temp.PVnumber = current.volumenumber;
                temp.PYear = current.Yearofpub;
             
            }
            return temp;

        }







       



      
    }
}
