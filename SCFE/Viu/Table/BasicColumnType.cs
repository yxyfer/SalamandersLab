using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Viu.Components;

namespace Viu.Table
{
    public class BasicColumnType<T> : ColumnType<T>
    {
        private readonly Func<T, ConsoleColor?> _colorGetter;
        private readonly Func<T, string> _infoGetter;

        public BasicColumnType(string title, Func<T, string> toRowString, Func<T, ConsoleColor?> colorGetter = null)
        {
            ColumnTitle = title;
            _infoGetter = toRowString;
            _colorGetter = colorGetter;
        }

        private string ColumnTitle { get; }

        public HorizontalAlignment HAlign { get; set; } = HorizontalAlignment.Left;

        public override Component GetRowInformation(T data, int index, int width, bool isFocused, bool isSelected,
            TableComponent<T> parent)
        {
            // Cache the same component so as to avoid recreating lots of components.
            return new TextComponent
            {
                Text = _infoGetter(data),
                Background = isFocused ? _colorGetter?.Invoke(data) : null,
                Foreground = isFocused ? null : _colorGetter?.Invoke(data),
                HAlign = HAlign
            };
        }

        public override int[] GetPossibleWidths(ICollection<T> data)
        {
            var max1 = data.Max(t => _infoGetter(t).Length);
            return new[] {Math.Max(ColumnTitle.Length, max1)};
        }

        public override int GetMaximumRowHeight(ICollection<T> data)
        {
            return 1;
        }

        public override string GetTitle(TableComponent<T> parent, int width)
        {
            return ColumnTitle;
        }

        public override int GetTotalRowHeight(ObservableCollection<T> data)
        {
            return data.Count;
        }
    }
}