namespace ResumeNET.Helper
{
    public enum LogType
    {
        Text = 0,
        Json = 1,
        Xml = 2
    }

    public static class LogHelper
    {
        public static bool Write(LogType logType)
        {
            return true;
        }

        public static bool Read(LogType logType)
        {
            return true;
        }
    }
}