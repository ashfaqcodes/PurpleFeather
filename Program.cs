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
            Console.WriteLine("Welcome to PurpleFeather! Type 'help' for commands");
            while (true)

                while (true)
                {

                    string command = Console.ReadLine();

                    switch (command)
                    {

                        case "shutdown":
                            {
                                Cosmos.Sys.Deboot.ShutDown();

                                break;

                            }

                        case "help":
                            {

                                Console.WriteLine("hello - Simple OS command");

                                Console.WriteLine("about - Know about OS ");
                                
                                Console.WriteLine("reboot - Restart your device ");

                                Console.WriteLine("shutdown - turn off your device ");

                                break;

                            }

                        case "about":
                            {

                                Console.WriteLine("PurpleFeather 0.1");

                                Console.WriteLine("Made by: ashfaqcodes");

                                break;

                            }

                        case "reboot":
                            {

                                Cosmos.Sys.Deboot.Reboot();

                                break;

                            }

                        case "hello":
                            {

                                Console.WriteLine("Hello and Thank You for using my OS!");

                                break;

                            }

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