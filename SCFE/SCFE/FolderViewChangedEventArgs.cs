using JetBrains.Annotations;
using Viu;

namespace SCFE
{
    public class FolderViewChangedEventArgs
    {
        public bool FolderChanged { get; }
        
        [CanBeNull]
        public File OldFolder { get; }
        
        [NotNull]
        public File NewFolder { get; }
        
        [CanBeNull]
        public GraphicsContext Graphics { get; }

        public FolderViewChangedEventArgs(bool folderChanged, File oldFolder, File newFolder, GraphicsContext graphics)
        {
            FolderChanged = folderChanged;
            OldFolder = oldFolder;
            NewFolder = newFolder;
            Graphics = graphics;
        }
    }
}