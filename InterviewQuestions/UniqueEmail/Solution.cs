using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace InterviewQuestions.UniqueEmail
{
    public class Solution
    {
        public int NumberofUniqueEmailAddresses(string[] emails)
        {

            emails = LowerCaseArray(emails);
            var filteredEmails = new List<string>();


            
            for(int i = 0; i < emails.Length; i++)
            {
                var email = emails[i];
                Regex rgx = new Regex(@"^[a-z0-0+.]*@[a-z0-9.]*$");
                if (rgx.IsMatch(email))
                {
                    var atIndex = email.IndexOf('@');
                    var plusIdex = email.IndexOf('+');

                    var local = email.Substring(0, atIndex);
                    var domain = email.Substring(atIndex+1);

                    if(plusIdex>-1)
                    {
                        local = local.Substring(0, plusIdex);
                    }

                    local = local.Replace(".", "");

                    filteredEmails.Add(local + "@" + domain);
                }
            }

            return filteredEmails.Distinct().Count();

        }

        private string[] RemoveNonConformingEmails(string[] emails)
        {
            List<int> indexsToKeep = new List<int>();
            Regex rgx = new Regex(@"^[a-z0-0+.]*@[a-z0-9.]*$");

            for (int i = 0; i < emails.Length; i++)
            {
                if(rgx.IsMatch(emails[i]))
                {
                    indexsToKeep.Add(i);
                }
            }

            var filteredEmails = new string[indexsToKeep.Count];

            int x = 0;

            foreach (var index in indexsToKeep)
            {
                filteredEmails[x] = emails[index];
            }

            return filteredEmails;
        }

        private string[] LowerCaseArray(string[] emails)
        {
            for(int i = 0; i < emails.Length; i++)
            {
                emails[i] = emails[i].ToLower();
            }

            return emails;
        }


    }
}
