using Languago.Models.DataStructures;
using Languago.Models.orm;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators;
using SpeechLib;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace Languago.Models
{
    public class SessionModel
    {
        /* 
         
        3.How to check if word is correct
        4.How to add pronunciation check
        5.how to add sound check
        */
        public Session CurrSession { get; set; }
        public Word CurrWord { get; set; }
        LanguagoContext db;
        ushort wordID;
        public long UserID { get; set; }
        public Word[] dictionary { get; set; }

        public SessionModel(long UserID, LanguagoContext db, int numDays)
        {
            this.UserID = UserID;
            //Updates lastVisit in the db, and gets session
            this.db = db;
            var Session = db.Sessions
                            .Single(s => s.Date == (DateTime.Now.Date.AddDays(-numDays))
                            && s.UserID_Users == UserID 
                            && s.Completed == false);
            Session.LastVisit = DateTime.Now.Date;
            CurrSession = Session;
            db.Sessions.Update(Session);
            db.SaveChanges();
            /* Populates */
            wordID = Convert.ToUInt16(CurrSession.WordLowerBoundary);
            GetWordFromDb(0);
            GetWordsFormDb();
        }
        public Word GetWordFromDb(short num)
        {
            /* Populate Session */

            wordID = Convert.ToUInt16(wordID + num);
            if (wordID > CurrSession.WordUpperBoundary || wordID < CurrSession.WordLowerBoundary)
            {
                wordID = Convert.ToUInt16(wordID - num);
            }
            this.CurrWord = db.Words.FirstOrDefault(item => item.WordID == wordID);
            return this.CurrWord;
        }
        public void GetWordsFormDb()
        {
            int numOfWords = CurrSession.WordUpperBoundary - CurrSession.WordLowerBoundary + 1;
            dictionary = new Word[numOfWords];
            var Session = db.Words.Where(item => item.WordID <= CurrSession.WordUpperBoundary &&
                                        item.WordID >= CurrSession.WordLowerBoundary);
            int array_counter = 0;
            foreach(Word w in Session)
            {
                dictionary[array_counter] = w;
                array_counter++;
            }
        }
    }
}
