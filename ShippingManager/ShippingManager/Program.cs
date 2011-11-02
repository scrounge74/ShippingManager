using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ShippingManager
{
    static class Program
    {
        const string FileName = @"shippingSystem.bin";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ShippingSystem sm;
            Stream TestFileStream;

            if (File.Exists(FileName))
            {
                TestFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                sm = (ShippingSystem)deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();
                Console.WriteLine("Loaded hey string: "+sm.hey);
            }
            else
            {
                TestFileStream = File.Create(FileName);
                sm = new ShippingSystem();
                sm.hey = "Hello world?";
                Console.WriteLine("wrote to sm");
            }

            TestFileStream = File.OpenWrite(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, sm);
            TestFileStream.Close();

            Console.Read();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
        }
    }
}
