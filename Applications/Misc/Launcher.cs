using System.Diagnostics;

namespace Applications.Misc
{
    public class Launcher
    {
        public static void Launch(string path, bool asAdmin = false)
        {
            var p = new Process
            {
                StartInfo = { FileName = path, Verb = asAdmin ? @"runas" : string.Empty },

            };
            p.Start();
        }
    }
}