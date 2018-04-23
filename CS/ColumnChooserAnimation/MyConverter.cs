using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;
using System.Windows.Media.Animation;

namespace ColumnChooserAnimation
{
    public class MyConverter : IValueConverter
    {
        public delegate void StartAnimationEventDelegate(WindowContentHolder wch);
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            WindowContentHolder wch = LayoutHelper.FindParentObject<WindowContentHolder>((DependencyObject)value);
            Application.Current.Dispatcher.BeginInvoke(new StartAnimationEventDelegate(Animate), wch);
            wch.IsVisibleChanged += new DependencyPropertyChangedEventHandler(wch_IsVisibleChanged);
            return wch.Background;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        void wch_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(new StartAnimationEventDelegate(Animate), (WindowContentHolder)sender);
        }

        void Animate(WindowContentHolder wch)
        {
            DoubleAnimation da = new DoubleAnimation(0, 250, new Duration(TimeSpan.FromMilliseconds(350)));
            da.FillBehavior = FillBehavior.Stop;
            wch.BeginAnimation(WindowContentHolder.HeightProperty, da);
            wch.BeginAnimation(WindowContentHolder.OpacityProperty, new DoubleAnimation(0, 1.0, new Duration(TimeSpan.FromMilliseconds(350))));
        }
    }
}
