using System.IO;

namespace WindowsFormsUniversity
{
    class Authorization
    {
        public static string User;

        public static bool RightAuthorize(string login, string password)
        {
            using (StreamReader reader = new StreamReader(User+".txt"))
            {
                string log, pass;
                while ((log = reader.ReadLine()) != null)
                {
                    pass = reader.ReadLine();
                    if (log == login && pass == password)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
