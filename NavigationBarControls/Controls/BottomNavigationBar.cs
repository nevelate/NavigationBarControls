using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationBarControls.Controls
{
    public class BottomNavigationBar : ItemsControl
    {
        public static readonly StyledProperty<double> SpacingProperty =
           AvaloniaProperty.Register<StackPanel, double>(nameof(Spacing));

        /// <summary>
        /// Gets or sets the size of the spacing to place between child controls.
        /// </summary>
        public double Spacing
        {
            get => GetValue(SpacingProperty);
            set => SetValue(SpacingProperty, value);
        }
    }
}
