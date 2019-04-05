<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ColumnChooserAnimation/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ColumnChooserAnimation/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ColumnChooserAnimation/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ColumnChooserAnimation/MainWindow.xaml.vb))
* [MyConverter.cs](./CS/ColumnChooserAnimation/MyConverter.cs) (VB: [MyConverter.vb](./VB/ColumnChooserAnimation/MyConverter.vb))
<!-- default file list end -->
# How to animate the Column Chooser


<p>This example demonstrates how to animate the Column Chooser in the GridControl. To implement animation, a style for the ColumnChooserControl was created. When the Column Chooser appears, it is wrapped in the WindowContentHolder. In this sample, a WindowContentHolder instance is obtained in the converter named MyConverter, and animation is applied to this instance. By default, the Column Chooser appears with Opacity animation. Thus, if you want to implement a custom Opacity animation, apply it after the standard one via the BeginInvoke method.</p>

<br/>


