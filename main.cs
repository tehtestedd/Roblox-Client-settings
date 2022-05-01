using System;
using System.IO;
using System.Linq;

namespace HighlightFlagOverrideR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Highlight Override";
            Console.WriteLine("Press any key to start");
            Console.ReadLine();

            #region Roblox Paths
            var roblox_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\Versions\\"; // Little braindead but XD
            var directories = Directory.GetDirectories(roblox_path);
            #endregion

            #region Create files 
            Console.WriteLine("Creating needed files...");
            foreach (var fileInfo in directories)
            {
                Directory.CreateDirectory(fileInfo + "\\ClientSettings");
                File.WriteAllText(fileInfo + "\\ClientSettings" + "\\ClientAppSettings.json", "{\"FFlagRenderHighlightPass3\": \"True\"}");
            }
            Console.WriteLine("Finished created (ClientSettings Folder, ClientSettings.json)");
            Console.ReadLine();
            #endregion
        }
    }
}
