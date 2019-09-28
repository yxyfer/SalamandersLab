using System.Collections.Generic;
using System.Collections.ObjectModel;
using JetBrains.Annotations;
using Viu.Components;

namespace Viu.Table
{
    public abstract class ColumnType<T>
    {
        public int Priority { get; set; }

        public int GrowPriority { get; set; }

        public int ShrinkPriority { get; set; }

        [NotNull]
        public abstract Component GetRowInformation(T data, int index, int width, bool isFocused, bool isSelected,
            TableComponent<T> parent);

        public abstract int[] GetPossibleWidths(ICollection<T> data);

        public abstract int GetMaximumRowHeight(ICollection<T> data);

        public abstract string GetTitle(TableComponent<T> parent, int width);

        public abstract int GetTotalRowHeight(ObservableCollection<T> data);

        public virtual bool IsVisible(IEnumerable<T> enumerable)
        {
            return true;
        }
    }
}