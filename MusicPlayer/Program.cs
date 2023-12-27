using SpotifyAPI.Web;

namespace MusicPlayer
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            string email = SqlDatabase.CheckLoggedin("LoggedinTable");
            if(email != null) 
            {
                SqlDatabase.DeleteData("LoggedinTable", email);
                Application.Run(new MainForm(email));
            }
            else
            {
                Application.Run(new logInForm ());
            }
            
        }
    }
}
