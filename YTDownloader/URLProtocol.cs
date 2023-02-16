using AngleSharp.Text;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTDownloader
{
    internal static class URLProtocol
    {
        public const string PROTOCOL_NAME = "ytdl";

        // https://stackoverflow.com/a/14826068/13040404
        private static string ReplaceLastOccurrence(string source, string find, string replace)
        {
            int place = source.LastIndexOf(find);

            if (place == -1) return source;

            string result = source.Remove(place, find.Length).Insert(place, replace);

            return result;
        }

        public static void RegisterProtocol()
        {
            var key = Registry.ClassesRoot.OpenSubKey(PROTOCOL_NAME);

            if (key == null)
            {
                key = Registry.ClassesRoot.CreateSubKey(PROTOCOL_NAME);
                key.SetValue(string.Empty, $"URL:{PROTOCOL_NAME}");
                key.SetValue("URL Protocol", string.Empty);

                key = key.CreateSubKey(@"shell\open\command");
                var executablePath = ReplaceLastOccurrence(Environment.GetCommandLineArgs()[0], ".dll", ".exe");
                key.SetValue(string.Empty, $"\"{executablePath}\" %1");
            }

            key.Close();
        }

        public static string? GetPassedArgument()
        {
            var args = Environment.GetCommandLineArgs();

            return args.Length == 2 && args[1].StartsWith($"{PROTOCOL_NAME}:") && args[1].Length > PROTOCOL_NAME.Length + 1 ?
                args[1].ReplaceFirst($"{PROTOCOL_NAME}:", string.Empty)
                :
                null;
        }
    }
}
