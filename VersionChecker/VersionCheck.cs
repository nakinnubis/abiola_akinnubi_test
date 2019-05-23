using System;
using System.Linq;
namespace VersionChecker
{
    public static class VersionCheck
    {
        /// <summary>
        /// This library accepts the string of software version to compare
        /// checks for null in both string by ensuring no empty string is sent 
        /// splits the string based on the dot(.) seperator
        /// trim empty tailing string by check for isnull or empty
        /// parse or converts the number to integer
        /// return arrays of integer
        /// the handles a scenerior where a user may enter 1.2.5. for v1 and 1.2.4.9 for v2 
        /// in such case it appends 0 to the end of the array before computing
        /// then a while loop to keep checking 
        /// if new version is greater than than the older version it returns -1
        /// if old is greater than new it returns 1
        /// if both matches the it returns 0
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>integer</returns>
        public static int versionChecker(string v1, string v2)
        {
            if (!string.IsNullOrEmpty(v1) && !string.IsNullOrEmpty(v2))
            {
                var versionold = v1.Split('.').Where(j => !string.IsNullOrEmpty(j)).Select(c => int.Parse(c)).ToArray();
                var versionnew = v2.Split('.').Where(j => !string.IsNullOrEmpty(j)).Select(c => int.Parse(c)).ToArray();
                if (versionold.Length < versionnew.Length)
                {
                    var versionupdate = versionold.ToList();
                    versionupdate.Add(0);
                    versionold = versionupdate.ToArray();
                }
                else if (versionnew.Length < versionold.Length)
                {
                    var versionupdate = versionnew.ToList();
                    versionupdate.Add(0);
                    versionnew = versionupdate.ToArray();
                }

                int i = 0;

                while (i < versionold.Length)
                {
                    // Version 2 is greater than version 1 
                    if (versionnew[i] > versionold[i])
                    {
                        return -1;
                    }
                    // Version 1 is greater than version 2 
                    if (versionold[i] > versionnew[i])
                    {
                        return 1;
                    }
                    i += 1;
                }
                return 0;
            }
            return -0;
        }
    }
}
