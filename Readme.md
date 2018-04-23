# How to animate the Column Chooser


<p>This example demonstrates how to animate the Column Chooser in the GridControl. To implement animation, a style for the ColumnChooserControl was created. When the Column Chooser appears, it is wrapped in the WindowContentHolder. In this sample, a WindowContentHolder instance is obtained in the converter named MyConverter, and animation is applied to this instance. By default, the Column Chooser appears with Opacity animation. Thus, if you want to implement a custom Opacity animation, apply it after the standard one via the BeginInvoke method.</p>

<br/>


