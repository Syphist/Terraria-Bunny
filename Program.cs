using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program may be a few lines, but it is created with transparency in mind as an executable will be distributed.
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Terraria"); //Opens the Registry Key for Terraria
            key.SetValue("Bunny", "1"); //Creates the proper String value
            key.Close(); //Closes the registry key
            Console.WriteLine("You should now have a Bunny in Terraria. Press Enter to close the window."); //Some human interaction stuff
            Console.ReadLine();
        }
    }
}
