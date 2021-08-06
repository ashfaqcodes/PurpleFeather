using System;
using Cosmos.Compiler.Builder;

namespace CosmosBoot1
{
    class Program
    {
        #region Cosmos Builder logic
        // Most users wont touch this. This will call the Cosmos Build tool
        [STAThread]
        static void Main(string[] args)
        {
            BuildUI.Run();
        }
        #endregion

        // Main entry point of the kernel
        public static void Init()
        {
            var xBoot = new Cosmos.Sys.Boot();
            xBoot.Execute();
            Console.WriteLine("Welcome to PurpleFeather! Type 'help' for commands");  // A welcome message after booting
            while (true)

                while (true)
                {

                    string command = Console.ReadLine();  // making the OS to read the input given by the user

                    switch (command)
                    {
                        // command for shutting down the OS
                        case "shutdown":
                            {
                                Cosmos.Sys.Deboot.ShutDown();  
                                break;

                            }
                        // 'help' is for showing commands
                        case "help":
                            {

                                Console.WriteLine("hello - Simple OS command");

                                Console.WriteLine("about - Know about OS ");
                                
                                Console.WriteLine("reboot - Restart your device ");

                                Console.WriteLine("shutdown - turn off your device ");

                                break;

                            }
                        // info about the OS
                        case "about":
                            {

                                Console.WriteLine("PurpleFeather 0.1");

                                Console.WriteLine("Made by: ashfaqcodes");

                                break;

                            }
                        // command for rebooting the OS
                        case "reboot":
                            {

                                Cosmos.Sys.Deboot.Reboot();

                                break;

                            }
                        // a simple command for greeting OS
                        case "hello":
                            {

                                Console.WriteLine("Hello and Thank You for using my OS!");

                                break;

                            }
                        // output of the error when given wrong input by the user
                        default:
                            {
                                Console.WriteLine("No such command, type 'help' for commands");

                                command = null; break;
                            }
                    }

                }

        }
    }
}
