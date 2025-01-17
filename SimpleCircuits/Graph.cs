﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleCircuits
{
    class Graph
    {
        static string TOP_LINE = "TopLine.txt";
        static string BOTTOM_LINE = "BottomLine.txt"; 
        static string INPUT_LIST = "InputList.txt"; 

        private static string Spaces() => " ";
        private static string Lines() => "|";

        public static void Initialize()
        {
            var fs = new FileStream(TOP_LINE, FileMode.Create);
            var fs2 = new FileStream(BOTTOM_LINE, FileMode.Create);
            var fs3 = new FileStream(INPUT_LIST, FileMode.Create);
            fs.Close();
            fs2.Close();
            fs3.Close();
        }
        public static void AddToInputFile(string inputs)
        {
            var fs = new FileStream(INPUT_LIST, FileMode.Append);
            var sw = new StreamWriter(fs);

            sw.Write(inputs + " ");


            sw.Close();
            fs.Close();
        }
        public static void AddToTLine(bool value)
        {
            var fs = new FileStream(TOP_LINE, FileMode.Append);
            var sw = new StreamWriter(fs);
            if (value)
            {
                sw.Write(Lines());
            }
            else
            {
                sw.Write(Spaces());
            }
            sw.Close();
            fs.Close();
        }
        public static void AddToBLine(bool value)
        {
            var fs = new FileStream(BOTTOM_LINE, FileMode.Append);
            var sw = new StreamWriter(fs);
            if (value)
            {
                sw.Write(Spaces());
            }
            else
            {
                sw.Write(Lines());
            }
            sw.Close();
            fs.Close();
        }
        public static string GetTopLineString()
        {

            var fs = new FileStream(TOP_LINE, FileMode.Open);
            var sr = new StreamReader(fs);

            string contents = sr.ReadToEnd();

            fs.Close();
            sr.Close();

            return contents;
        }
        public static string GetBottomLineString()
        {

            var fs = new FileStream(BOTTOM_LINE, FileMode.Open);
            var sr = new StreamReader(fs);

            string contents = sr.ReadToEnd();

            fs.Close();
            sr.Close();

            return contents;
        }
        private static int GetLineLength()
        {

            var fs = new FileStream(TOP_LINE, FileMode.Open);
            var sr = new StreamReader(fs);

            string contents = sr.ReadToEnd();

            fs.Close();
            sr.Close();

            return contents.Length;
        }
        private static string GetInputListString()
        {

            var fs = new FileStream(INPUT_LIST, FileMode.Open);
            var sr = new StreamReader(fs);

            string contents = sr.ReadToEnd();

            fs.Close();
            sr.Close();

            return contents;
        }
        public static void PrintGraph()
        {
            int lineLength = GetLineLength();

            string topLineContents = GetTopLineString();
            string bottomLineContents = GetBottomLineString();

            Console.WriteLine("     0    1");
            Console.WriteLine("------------------");

            for (int i = 0; i < lineLength; i++)
            {
                Console.WriteLine($"|    {bottomLineContents[i]}    {topLineContents[i]}");
            }
        }
    }
}
