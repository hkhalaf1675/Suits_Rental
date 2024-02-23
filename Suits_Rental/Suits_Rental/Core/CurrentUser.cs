namespace Suits_Rental.Core
{
    public class CurrentUser
    {
        static string txtusername;
        static string txtPassword;
        static string dateIn;
        static string name;
        static string role;


        public static string Name { get => name; set => name = value; }
        public static string Txtusername { get => txtusername; set => txtusername = value; }
        public static string TxtPassword { get => txtPassword; set => txtPassword = value; }
        public static string DateIn { get => dateIn; set => dateIn = value; }
        public static string Role { get => role; set => role = value; }
    }
}
