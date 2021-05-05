using System;
using System.Collections.Generic;
using System.Text;

namespace TweetApp.Dal.Models
{
    public class ChangePassword : UserData
    {
        public string newPassword { get; set; }
    }
}
