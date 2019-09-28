using System.Collections.Generic;
using System.Collections.Immutable;
using Viu;

namespace SCFE
{
    public class FileChangedEventArgs
    {
        public ImmutableList<File> Files { get; }
        public GraphicsContext Graphics { get; }

        public FileChangedEventArgs(IEnumerable<File> files, GraphicsContext graphics)
        {
            Files = files.ToImmutableList();
            Graphics = graphics;
        }
    }
}