using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

namespace UniForm.Util
{
    public static class FileIO
    {
        public static void Write(string path, string text)
        {
            using (var sw = new StreamWriter(path)) sw.Write(text);
        }

        public static void WriteLines(string path, List<string> lines)
        {
            using (var sw = new StreamWriter(path)) lines.ForEach(line => sw.WriteLine(line));
        }

        public static List<string> ReadLines(string path, Encoding encoding)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(path, encoding))
            {
                while (!reader.EndOfStream)
                {
                    lines.Add(reader.ReadLine());
                }
            }
            return lines;
        }

        public static string Read(string path, Encoding encoding)
        {
            using (var sr = new StreamReader(path, encoding)) return sr.ReadToEnd();
        }
    }
}