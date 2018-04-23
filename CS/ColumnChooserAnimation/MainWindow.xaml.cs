using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;
using System.Windows.Media.Animation;

namespace ColumnChooserAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Col1");
            dt.Columns.Add("Col2");
            DataRow dr;
            for (int i = 0; i < 5; i++)
            {
                dr = dt.NewRow();
                dr[0] = "cell_1_" + (i + 1).ToString();
                dr[1] = "cell_2_" + (i + 1).ToString();
                dt.Rows.Add(dr);
            }
            gridControl1.ItemsSource = dt;
        }
    }
}
