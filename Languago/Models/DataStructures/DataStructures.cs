using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Text;

namespace Languago.Models.DataStructures
{
    public class UserApprovedArgs : EventArgs
    {
        public long UserID { get; }
        public UserApprovedArgs(long userID)
        {
            this.UserID = userID;
        }
    }
    public class User
    {
        public Int64 UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
    public class Session
    {
        public long SessionID { get; set; }
        public short WordLowerBoundary { get; set; }
        public short WordUpperBoundary { get; set; }
        public DateTime Date { get; set; }
        public DateTime LastVisit { get; set; }
        public Boolean Completed { get; set; }
        public long UserID_Users { get; set; }
    }
    public class Word
    {
        public int WordID { get; set; }
        public string French { get; set; }
        public string English { get; set; }
        public string Grammar { get; set; }
        public string Example { get; set; }
        public Word() { }
        public Word(int id, string French, string English, string Grammar, 
            string Example)
        {
            this.WordID = id;
            this.French = French;
            this.English = English;
            this.Grammar = Grammar;
            this.Example = Example;
        }
    }


}
