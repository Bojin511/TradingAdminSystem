using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Utils
{
    public class UserValidator
    {
        public static int getUserByUsername(string Username, string Password, XDocument xdoc)
        {

            var query = from usr in xdoc.Descendants("USER")
                        where 
                        usr.Element("ROLE").Value == "System Administrator"
                        && usr.Element("USERNAME").Value == Username
                        && usr.Element("PASSWORD").Value == Password
                        select usr;
            return query.Count();
        }
    }
}
