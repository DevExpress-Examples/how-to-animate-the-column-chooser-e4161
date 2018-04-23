Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Data
Imports System.Globalization
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports System.Windows.Media.Animation

Namespace ColumnChooserAnimation
	Public Class MyConverter
		Implements IValueConverter
		Public Delegate Sub StartAnimationEventDelegate(ByVal wch As WindowContentHolder)
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Dim wch As WindowContentHolder = LayoutHelper.FindParentObject(Of WindowContentHolder)(CType(value, DependencyObject))
			Application.Current.Dispatcher.BeginInvoke(New StartAnimationEventDelegate(AddressOf Animate), wch)
			AddHandler wch.IsVisibleChanged, AddressOf wch_IsVisibleChanged
			Return wch.Background
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return value
		End Function

		Private Sub wch_IsVisibleChanged(ByVal sender As Object, ByVal e As DependencyPropertyChangedEventArgs)
			Application.Current.Dispatcher.BeginInvoke(New StartAnimationEventDelegate(AddressOf Animate), CType(sender, WindowContentHolder))
		End Sub

		Private Sub Animate(ByVal wch As WindowContentHolder)
			Dim da As New DoubleAnimation(0, 250, New Duration(TimeSpan.FromMilliseconds(350)))
			da.FillBehavior = FillBehavior.Stop
			wch.BeginAnimation(WindowContentHolder.HeightProperty, da)
			wch.BeginAnimation(WindowContentHolder.OpacityProperty, New DoubleAnimation(0, 1.0, New Duration(TimeSpan.FromMilliseconds(350))))
		End Sub
	End Class
End Namespace
