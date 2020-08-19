using Languago.Models.DataStructures;
using Languago.Models.orm;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;

namespace Languago.Models
{
    class AccountModel
    {
        public long UserID { get; }
        LanguagoContext db;
        public AccountModel(long UserID, LanguagoContext db)
        {
            this.UserID = UserID;
            this.db = db;
        }

        /* Gets ammount of words from certain session */
        public short getAmmountOfWordsFromSession(short numDays)
        {
            short num = 0;
            short reviseNum = 0;

            DateTime ReviseDateTime = DateTime.Now.AddDays(-numDays);
            var ReviseSession = db.Sessions
                                        .Where(s => s.UserID_Users == this.UserID
                                        && s.Date == ReviseDateTime.Date);
            foreach(Session s in ReviseSession)
            {
                num++;
                if(s.Date == ReviseDateTime.Date)
                {
                    reviseNum = Convert.ToInt16(s.WordUpperBoundary - s.WordLowerBoundary + 1);
                }
            }
            if (num == 1) return reviseNum;
            else if (num == 0) return 0;
            else return -1;
        }


        /* Check for newest word added to session */
        public short CheckLatestWord()
        {
            var Sessions = db.Sessions.Where(s => s.UserID_Users == this.UserID);
            short max = 0;
            foreach (Session s in Sessions)
            {
                if (s.WordUpperBoundary >= max) max = s.WordUpperBoundary;
            }
            return max;
        }


        /* Check if it's possible to add new session, and then if it its
         * returns number of words to start 
           otherwise returns -1 */
        public short ReturnLowerWordValue()
        {

            //Check if there is already one session for the date
            var Sessions = db.Sessions
                                .Where(s => s.UserID_Users == this.UserID
                                && s.Date == DateTime.Now.Date);
            foreach(Session s in Sessions)
            {
                // ACHTUNG //*******
                //it is imposbile to add new session
                //this day because there is already one there
                return -1;
            }
            return Convert.ToInt16(CheckLatestWord() + 1);
        }
        public bool AddNewSessionToDb(short num_of_words)
        {
            if (num_of_words < 1 || getAmmountOfWordsFromSession(0) > 0) return false;
            Session newSession;
            newSession = new Session();
            newSession.Date = DateTime.Now;
            newSession.LastVisit = DateTime.Now;
            newSession.UserID_Users = this.UserID;
            newSession.Completed = false;
            newSession.WordLowerBoundary = this.ReturnLowerWordValue();
            newSession.WordUpperBoundary = Convert.ToInt16(newSession.WordLowerBoundary + num_of_words - 1);
            db.Add(newSession);
            db.SaveChanges();
            return true;
        }
    }
}
