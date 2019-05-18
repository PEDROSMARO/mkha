using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Collections;


namespace WcfPaperDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AutherService : IAutherService
    {





        /// <summary>
        /// //////
        /// </summary>
        /// <param name="auther"></param>
        /// <returns></returns>
        public int countpaper(string authername)
        {
            List<Paper> AllPAPer = new List<Paper>();
            AllPAPer = Getpapers(authername);
            return AllPAPer.Count;
          

        }


  

        public List<Paper> Getpapers(string auther)
        {


            var db = new PaperindexDataClassDataContext();

            return (from pap in db.Papers
                    where pap.Authers.Contains(auther)
                    select pap).ToList();
            

        }

        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="authername"></param>
        /// <returns></returns>


        public int scorepapersbyyear(string authername)
        {
          
            List <Paper> AllPAPer = new List<Paper>();
            AllPAPer = Getpapers(authername);
            return scoreyear(AllPAPer);
          
        }


        public int scoreyear(Paper cur)
        {
            int dis = 2017 - cur.Yearofpub;
            return dis;

        }

        public int scoreyear(List <Paper> cur)
        {
            int summay = 0;
            int fff = 0;
            
            foreach (Paper pap in cur)
            {
                fff = scoreyear(pap);
                summay = summay + fff;
            }
           
            int sub = summay - 10;
            if (sub < 0)
            {
                sub = 0;
            }
            return sub;
        }



        /// <summary>
        /// ////////////
        /// </summary>
        /// <param name="authername"></param>
        /// <returns></returns>
        public int scorepapersbyorder(string authername)
        {
           

            List<Paper> AllPAPer = new List<Paper>();
            AllPAPer = Getpapers(authername);
            return scoreorder(AllPAPer, authername);

        }



            public int scoreorder(Paper cur ,string authername)
        {
            int dis = 0;

            int ord = getauth(authername,cur);
            if (ord == 1)
            {
                dis = 10;
            }
            if (ord == 2)
            {
                dis = 7;
            }

            if (ord == 3)
            {
                dis = 5;
            }

            if (ord == 4)
            {
                dis = 2;
            }

            return dis;

        }



            public int getauth(string eee, Paper Ma)
            {

                string Autherline = Ma.Authers;
                int i = 1;
                int orda = 1;
                string[] words = Autherline.Split(',');
                foreach (string word in words)
                {
                    if (word == eee)
                    {
                        orda = i;
                    }

                    i++;
                }

                return orda;

            }



            public int scoreorder(List<Paper> cur, string authername)
            {
                int summay = 0;
                int fff = 0;

                foreach (Paper pap in cur)
                {
                    fff = scoreorder(pap, authername);
                    summay = summay + fff;
                }


                return summay;
            }



        /// <summary>
        /// //////////
        /// </summary>
        /// <param name="authername"></param>
        /// <returns></returns>

            public int scorepapersbyjournalclass(string authername)
            {

                List<Paper> AllPAPer = new List<Paper>();
                AllPAPer = Getpapers(authername);
                return scorejournalclass(AllPAPer);

            }


            public journal retive(Paper sssss)
            {
                var db = new PaperindexDataClassDataContext();

                return (from pap in db.journals where pap.journalTitle == sssss.jouTitle select pap).SingleOrDefault();


            }


            public int scorejournalclass(Paper cur )
            {
                int dis;
                journal higu = new journal();
                higu = retive(cur);
                dis = scorejclass(higu);
                return dis;

            }

            public int scorejournalclass(List<Paper> cur)
            {
                int summay = 0;
                int fff = 0;

                foreach (Paper pap in cur)
                {
                    fff = scorejournalclass(pap);
                    summay = summay + fff;
                }


                return summay;
            }



            public int scorejclass(journal tem)
            {
                int dis = 0;

                int s = tem.jouclass;
               
                if (s == 1)
                {
                    dis = 10;
                }
                if (s == 2)
                {
                    dis = 7;
                }

                if (s == 3)
                {
                    dis = 5;
                }

                if (s == 4)
                {
                    dis = 2;
                }

                return dis;

            }





  





        









    }


}
