using System;

namespace SCFE
{
    public abstract class FileColorScheme
    {
        public abstract ConsoleColor? GetColorForFile(File file);
    }

    public class DiscriminateDirectoriesAndHiddenScheme : FileColorScheme
    {
        public override ConsoleColor? GetColorForFile(File file)
        {
            if (file.IsHidden()) return file.IsFolder() ? ConsoleColor.DarkYellow : ConsoleColor.DarkGray;
            return file.IsFolder() ? ConsoleColor.Green : (ConsoleColor?) null;
        }
    }
}