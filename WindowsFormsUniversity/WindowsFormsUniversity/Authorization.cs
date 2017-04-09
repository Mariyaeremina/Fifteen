using System;
using System.IO;

namespace WindowsFormsUniversity
{
    class Authorization
    {
        public static string User;

        public static void Authorize(string login, string password)
        {
            using (StreamReader reader = new StreamReader(User+".txt"))
            {
                string log, pass;
                while ((log = reader.ReadLine()) != null)
                {
                    pass = reader.ReadLine();
                    if (log == login && pass == password)
                    {
                        return;
                    }
                }
                throw new Exception("User is not found");
            }
        }
    }
}
