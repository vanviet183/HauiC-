﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string sourcePath = "E:/A Year 2 Sophomore/Preiod 4/.Net/Code/Bai 3/file-mau.txt";
            string targetPath = "E:/A Year 2 Sophomore/Preiod 4/.Net/Code/Bai 3/file-copy.txt";


            // Cách 2: StreamReader và StreamWriter
            StreamReader reader = new StreamReader(sourcePath);
            StreamWriter writer = new StreamWriter(targetPath);

            try
            {
                String fileHoa = reader.ReadToEnd().ToUpper();
                String[] fileArr = fileHoa.Split(' ');

                writer.Write(fileHoa);
                writer.WriteLine("\nSố từ : " + fileArr.Length + "\n");
            }
            catch (Exception ex)
            {
                throw new Exception("Exception: " + ex);
            }

            writer.Close();
            reader.Close();
        }
    }
}
