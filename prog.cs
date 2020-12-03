using System;
using System.IO.Compression;


namespace GZipTest
{
    class Program
    {
        static GZipper zipper; 
        static int Main(string[] args)
        {
        
            if (args.Length != 3)
            {
                ShowInfo();
                Console.Read();

                return -1;
            }

            CompressionMode mode = CompressionMode.Compress; //init
            try
            {
                
                Validation.StringReadValidation(args);

                switch (args[0].ToLower())
                {
                    case "compress":
                        mode = CompressionMode.Compress;
                        zipper = new Compressor(args[1], args[2]);
                        break;
                    case "decompress":
                        mode = CompressionMode.Decompress;
                        zipper = new Decompressor(args[1], args[2]);
                        break;
                }
                zipper.Process(mode); //all magic here!
            
                Console.WriteLine("Done!");
                
                Console.Read();
                return 0; 

            }
