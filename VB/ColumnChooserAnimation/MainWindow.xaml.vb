Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Data
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports System.Windows.Media.Animation

Namespace ColumnChooserAnimation
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Dim dt As New DataTable()
			dt.Columns.Add("Col1")
			dt.Columns.Add("Col2")
			Dim dr As DataRow
			For i As Integer = 0 To 4
				dr = dt.NewRow()
				dr(0) = "cell_1_" & (i + 1).ToString()
				dr(1) = "cell_2_" & (i + 1).ToString()
				dt.Rows.Add(dr)
			Next i
			gridControl1.ItemsSource = dt
		End Sub
	End Class
End Namespace
