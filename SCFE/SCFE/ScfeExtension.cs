using System;
using System.Collections.Generic;
using Viu;
using Viu.Table;

namespace SCFE
{
    public interface IScfeExtension
    {
        IEnumerable<ColumnType<File>> GetColumns();
        
        Dictionary<string, Action<object, ActionEventArgs>> GetActions();

        IEnumerable<FileOption> GetCurrDirOptions();

        IEnumerable<FileOption> GetFilesOptions();

    }
}