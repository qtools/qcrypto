using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qcrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = "";

            if (args.Length == 0 || args[0] == "--help" || args[0] == "-h" || args[0] == "?" || args[0] == "/?")
            {
                ShowHelp();
                return;
            }

            // Generation Function
            if (args[0].ToLower() == "--generate")
            {
                if (args[1].ToLower() != "--type") 
                {
                    Console.WriteLine("\r\nMissing Argument: '--type'");
                    Console.WriteLine("'--type' must be immediately after '--generate'\r\n");
                    return;
                }

                if (args[2].ToLower() == "key")
                {
                    return;
                }
                else if (args[2].ToLower() == "rng")
                {
                    if (args[3].ToLower() == "--length")
                    {
                        try
                        {
                            var b = new byte[Convert.ToInt32(args[4])];
                            var rng = new Random();
                            rng.NextBytes(b);
                            output = System.Text.Encoding.Default.GetString(b);
                            Console.WriteLine("Random Data: " + output);
                            return;
                        }
                        catch
                        {
                            Console.WriteLine("\r\nInvalid --length parameter\r\n");
                            return;
                        }
                        //args[4] == 4096
                        //args[5] == --output
                        //else display random data
                    }
                }
                else
                {
                    Console.WriteLine("\r\nInvalid argument for --type");
                    Console.WriteLine("'--type should have an argument like 'key' or 'rng'\r\n");
                    return;
                }

                
            }

            // Encryption Function
            if (args[0] == "--encrypt")
            {

            }

            // Decryption Function
            if (args[0] == "--decrypt")
            {

            }

            // Hashing Function
            if (args[0] == "--hash")
            {

            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("Help");
        }
    }
}
