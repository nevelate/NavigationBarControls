using System;
using System.Collections.Generic;
using System.Text;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace NavigationBarControls.Controls
{
    public class BottomNavigationBarItem : RadioButton
    {
        public static readonly StyledProperty<object?> IconProperty =
            AvaloniaProperty.Register<SplitView, object?>(nameof(Icon));

        public static readonly StyledProperty<IDataTemplate> IconTemplateProperty =
            AvaloniaProperty.Register<SplitView, IDataTemplate>(nameof(IconTemplate));

        public object? Icon
        {
            get => GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public IDataTemplate IconTemplate
        {
            get => GetValue(IconTemplateProperty);
            set => SetValue(IconTemplateProperty, value);
        }
    }
}
