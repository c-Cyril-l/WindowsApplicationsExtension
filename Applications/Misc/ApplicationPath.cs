using System;
using System.IO;

namespace Applications.Misc
{
    public class ApplicationPath
    {

        #region System Apps

        /// <summary>
        /// Resource Monitor Path.
        /// </summary>
        public static string ResourceMonitor => @"C:\Windows\System32\resmon.exe";

        /// <summary>
        /// Task Manager Path.
        /// </summary>
        public static string TaskManager => @"C:\Windows\System32\Taskmgr.exe";

        /// <summary>
        /// Registry Editor Path.
        /// </summary>
        public static string RegistryEditor => @"C:\Windows\regedit.exe";

        /// <summary>
        /// Command Prompt Path.
        /// </summary>
        public static string CommandPrompt => @"C:\Windows\System32\cmd.exe";

        /// <summary>
        /// Control Panel Path.
        /// </summary>
        public static string ControlPanel => @"C:\Windows\System32\control.exe";

        /// <summary>
        /// System Information Path.
        /// </summary>
        public static string SystemInformation => @"C:\Windows\System32\msinfo32.exe";

        #endregion

        #region Misc Apps

        /// <summary>
        /// Calculator Path.
        /// </summary>
        public static string Calculator => @"C:\Windows\System32\calc.exe";

        /// <summary>
        /// Character Map Path.
        /// </summary>
        public static string CharacterMap => @"C:\Windows\System32\charmap.exe";

        /// <summary>
        /// Microsoft Paint Path.
        /// </summary>
        public static string MicrosoftPaint => @"C:\Windows\System32\mspaint.exe";

        /// <summary>
        /// Notepad Path.
        /// </summary>
        public static string Notepad => @"C:\Windows\System32\notepad.exe";

        /// <summary>
        /// Osk Path.
        /// Credits : https://stackoverflow.com/a/60432756/12352466 .
        /// </summary>
        public static string ScreenKeyboard()
        {
            var path64 = Path.Combine(Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "winsxs"), "amd64_microsoft-windows-osk_*")[0], "osk.exe");
            const string path32 = @"C:\windows\system32\osk.exe";
            return Environment.Is64BitOperatingSystem ? path64 : path32;

        }

        /// <summary>
        /// Snipping Tool Path.
        /// </summary>
        public static string SnippingTool => @"C:\Windows\sysnative\SnippingTool.exe";


        #endregion

    }
}