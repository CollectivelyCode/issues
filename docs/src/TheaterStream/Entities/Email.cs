using System;
using System.Runtime.CompilerServices;

namespace TheatreStream.Entities
{
    /// <summary>
    /// An email class for for the user class
    /// </summary>
    public abstract class Email
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="domain">The domain of the email</param>
        /// <param name="user">The part before "@" in the email</param>
        protected Email(string domain, string user)
        {
            this.Domain = domain;
            this.User = user;
            if (domain == "cpsk12.org" || domain == "stu.cpsk12.org")
            {
                this.IsSchoolEmail = true;
            }
        }
        public string Domain;
        public string User;

        public bool IsSchoolEmail;

    }
}