using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Comment
    {
        private string userName { get; set; }
        private string userEmail { get; set; }
        private string comment {get; set;}

        public Comment(string userName, string userEmail, string comment)
        {
            this.userName = userName;
            this.userEmail = userEmail;
            this.comment = comment;
        }

        public string getUserName()
        { return this.userName; }

        public string getUserEmail()
        { return this.userEmail; }

        public string getComment()
        { return this.comment; }
    }
}