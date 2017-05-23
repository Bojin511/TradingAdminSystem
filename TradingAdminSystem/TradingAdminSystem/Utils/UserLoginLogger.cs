using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Utils
{
    public class UserLoginLogger
    {
        private static void logAttempt(String username, String attempt)
        {
            string loginLogFile = "../../loginLog.xml";
            XDocument xdoc = XDocument.Load(@loginLogFile);

            XElement xLog = new XElement("LOGIN",
                        new XElement("USERNAME", username),
                        new XElement("ATTEMPT", attempt));

            xdoc.Element("LOGINS").Add(xLog);
            xdoc.Save(@loginLogFile);
        }

        public static void logSuccess(String username)
        {
            logAttempt(username, "Success");
        }

        public static void logFailed(String username)
        {
            logAttempt(username, "Failed");
        }
    }
}
