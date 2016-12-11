using Microsoft.Win32;

namespace TerrariaBunny
{
    ///<Summary>This program may be a few lines, but it is created with transparency in mind as an executable will be distributed.</Summary>
    private static class UserInterface 
    {
        private static void Main(string[] args)
        {
            using( var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Terraria") ) //Opens the Registry Key for Terraria
                key.SetValue("Bunny", "1"); //Creates the proper String value
            Console.WriteLine("You should now have a Bunny in Terraria. Press Enter to close the window."); //Some human interaction stuff
            Console.ReadLine();
        }
    }
}
