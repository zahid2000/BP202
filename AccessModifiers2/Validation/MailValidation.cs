using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation
{
    public class MailValidation
    {
        public bool CheckEmailFormat(string email)
        {
           return Regex.IsMatch(email, @"^([a-zA-Z0-9]+([\._\-]{1})?){1,}[\w]\@{1}([a-zA-Z]+([\.]{1})?){1,}([a-zA-Z])\.[a-zA-Z]+$");
        }
    }
}
